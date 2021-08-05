using Cognex.VisionPro;
using Cognex.VisionPro.FGGigE;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Cognex.VisionPro.ImageFile;
using System.IO;
using DEMO.LIB;
using System.Diagnostics;
using System.Threading;
using HslCommunication.Profinet.Melsec;
using HslCommunication;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.FGGigE.Implementation.Internal;

namespace DEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        //防止切换界面闪烁  
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        Datarecord datarecord = new Datarecord();
        private void Form1_Load(object sender, EventArgs e)
        {
            #region 加载所有的模板            
            InitcomboBox();
            #endregion

            #region PLC连接
            PLC_ConnectSet();
            #endregion

            #region PLC线程运行
            PLC_Connection();
            HeartBreak();
            #endregion

            #region 相机线程运行
            Camera_1_Connection();
            #endregion

            #region 检查磁盘空间
            label2.Text = GetDriverInfo();
            #endregion

            #region 按钮使能关闭
            YC_Switch.Enabled = false;
            #endregion
        }

        #region 自动选择模板
        //文件路径
        private string ToolBlock_path_1;
        private string ToolBlock_path_2;
        string[] dirs;
        private string FG(string str)
        {
            string[] vs = str.Split('\\');
            return vs[vs.Length - 1];
        }
        private void InitcomboBox()
        {
            dirs = Directory.GetDirectories(Application.StartupPath + @"\VPP");
            for (int i = 0; i < dirs.Length; i++)
            {
                comboBox1.Items.Add(FG(dirs[i]));
            }
        }
        private CogToolBlock Block_1;
        private CogToolBlock Block_2;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolBlock_path_1 = @dirs[comboBox1.SelectedIndex] + "\\Toolblock_1.VPP";
            ToolBlock_path_2 = @dirs[comboBox1.SelectedIndex] + "\\Toolblock_2.VPP";
        }
        #endregion
                
        #region 相机成像

        #region 相机1取像
        ICogAcqFifo macqfifo1;//定义相机对象类型
        CogImage8Grey Camera_1_Image;//定义照片类型（这里是黑白的）
        //相机1取像
        public CogImage8Grey Camera_1_GetImage()
        {
            int trigNum;
            CogFrameGrabberGigEs mf2 = new CogFrameGrabberGigEs();//获取已连接相机列表
            //此处应该返回一张提示图片，指导操作者检查硬件连接
            if (mf2.Count < 1)
            {
                string image_path = Application.StartupPath + @"\ModelTool\error.bmp";
                img = new Bitmap(@image_path);
                Camera_1_Image = new CogImage8Grey(img);
                cogRecordDisplay1.Image = Camera_1_Image;
                MessageBox.Show("没有找到相机设备！");
                return Camera_1_Image;
            }
            else
            {
                ICogFrameGrabber mber = mf2[0];//取相机列表中的第1个相机           
                macqfifo1 = mber.CreateAcqFifo(mber.AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);//创建相机对象
                                                                                                                                   //相机运行参数  曝光 对比度
                macqfifo1.OwnedExposureParams.Exposure = 505.95;//曝光
                macqfifo1.OwnedBrightnessParams.Brightness = 0.048;//亮度
                macqfifo1.OwnedContrastParams.Contrast = 0.0;//对比
                //           
                Camera_1_Image = (CogImage8Grey)macqfifo1.Acquire(out trigNum);//使用相机对象的acquire方法拍照                
                                                                               //save图片
                CogImageFileBMP m_imageBMP = new CogImageFileBMP();
                m_imageBMP.Open(Application.StartupPath + @".\ImageRecord\Base\" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bmp", CogImageFileModeConstants.Write);
                m_imageBMP.Append(Camera_1_Image);
                m_imageBMP.Close();
                //
                return Camera_1_Image;
            }           
        }
        #endregion

        #endregion

        #region 有无检测       
        //检测 toolblock
        Bitmap img;//读入的普通图像
        public List<bool> Result_bool = new List<bool>(21);
        private void PMA_2_Function()
        {
            #region 检测硬盘空间
            label2.BeginInvoke((MethodInvoker)delegate
            {
                label2.Text = GetDriverInfo();
            });           
            #endregion

            #region 状态显示
            bool stationg1 = false;
            #endregion            
            List<bool> vs_bool = new List<bool>();

            bool Detection = false;
            cogRecordDisplay1.InteractiveGraphics.Clear();
            cogRecordDisplay1.StaticGraphics.Clear();
            Camera_1_GetImage();            
            Block_1.Inputs[0].Value = Camera_1_Image;
            Block_1.Run();
            if (Block_1.RunStatus.Result == CogToolResultConstants.Accept)
            {
                int COUNT_VALUE = (int)Block_1.Outputs[0].Value;

                ICogRecord tmpRecord;
                tmpRecord = Block_1.CreateLastRunRecord();
                tmpRecord = tmpRecord.SubRecords[1];//0  原图  1 FIX图
                cogRecordDisplay1.Record = tmpRecord;
                cogRecordDisplay1.BackColor = Color.FromArgb(52, 61, 76);
                for (int i=1;i< COUNT_VALUE+1;i++)
                {
                    int COUNT_X = ((4 * i) - 3) + COUNT_VALUE;
                    int COUNT_Y = ((4 * i) - 2) + COUNT_VALUE;
                    int W = ((4 * i) - 1) + COUNT_VALUE;
                    int H = 4 * i + COUNT_VALUE;
                    //
                    double X = (double)Block_1.Outputs[COUNT_X].Value;
                    double Y = (double)Block_1.Outputs[COUNT_Y].Value;
                    double WIDTH = (double)Block_1.Outputs[W].Value;
                    double HIGHT = (double)Block_1.Outputs[H].Value;
                    if ((int)Block_1.Outputs[i].Value>0)
                    {
                        stationg1 = false;
                        ShowOKBlob(X, Y, WIDTH, HIGHT, cogRecordDisplay1);
                        datarecord.ALL_DATA_RecordWriteFile(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "定位销齐全");
                    }
                    else
                    {
                        stationg1 = true;
                        vs_bool.Add(Detection);
                        Result_bool.Add(Detection);
                        ShowNGBlob(X, Y, WIDTH, HIGHT, cogRecordDisplay1);
                        datarecord.ALL_DATA_RecordWriteFile(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "定位销缺失");
                    }
                }                                                        
                cogRecordDisplay1.Fit(true);
            }
            else
            {
                datarecord.ALL_DATA_RecordWriteFile(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "功能运行失败");
                cogRecordDisplay1.Image = Camera_1_Image;
                cogRecordDisplay1.BackColor = Color.FromArgb(52, 61, 76);
                cogRecordDisplay1.Fit(true);
                vs_bool.Add(Detection);
                Result_bool.Add(Detection);
            }            
            DWStationChange(vs_bool, cogRecordDisplay1);
            #region 保存运行结果
            Image isasaveimage;
            isasaveimage = cogRecordDisplay1.CreateContentBitmap(CogDisplayContentBitmapConstants.Display, null, 2);
            isasaveimage.Save(Application.StartupPath + @".\ImageRecord\" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bmp");
            #endregion
        }
        //检测固定位置涂抹是否溢出
        private void PMA_3_Function()
        {
            #region 检测硬盘空间
            label2.BeginInvoke((MethodInvoker)delegate
            {
                label2.Text = GetDriverInfo();
            });
            #endregion

            #region 状态显示
            bool stationg1 = false;
            #endregion            
            List<bool> vs_bool = new List<bool>();
            bool Detection = false;
            cogRecordDisplay2.InteractiveGraphics.Clear();
            cogRecordDisplay2.StaticGraphics.Clear();
            Camera_1_GetImage();           
            Block_2.Inputs[0].Value = Camera_1_Image;
            Block_2.Run();
            if (Block_2.RunStatus.Result == CogToolResultConstants.Accept)
            {
                int COUNT_VALUE = (int)Block_2.Outputs[0].Value;
                ICogRecord tmpRecord;
                tmpRecord = Block_2.CreateLastRunRecord();
                tmpRecord = tmpRecord.SubRecords[1];//0  原图  1 FIX图
                cogRecordDisplay2.Record = tmpRecord;
                cogRecordDisplay2.BackColor = Color.FromArgb(52, 61, 76);
                for (int i = 1; i < COUNT_VALUE + 1; i++)
                {
                    int COUNT_X = ((4 * i) - 3) + COUNT_VALUE;
                    int COUNT_Y = ((4 * i) - 2) + COUNT_VALUE;
                    int W = ((4 * i) - 1) + COUNT_VALUE;
                    int H = 4 * i + COUNT_VALUE;
                    //
                    double X = (double)Block_2.Outputs[COUNT_X].Value;
                    double Y = (double)Block_2.Outputs[COUNT_Y].Value;
                    double WIDTH = (double)Block_2.Outputs[W].Value;
                    double HIGHT = (double)Block_2.Outputs[H].Value;
                    if ((int)Block_2.Outputs[i].Value >0)
                    {
                        stationg1 = false;
                        ShowOKBlob(X, Y, WIDTH, HIGHT, cogRecordDisplay2);
                        datarecord.ALL_DATA_RecordWriteFile(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "涂抹均匀");
                    }
                    else
                    {
                        stationg1 = true;
                        vs_bool.Add(Detection);
                        Result_bool.Add(Detection);
                        ShowNGBlob(X, Y, WIDTH, HIGHT, cogRecordDisplay2);
                        datarecord.ALL_DATA_RecordWriteFile(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "涂抹溢出");
                    }
                }
                cogRecordDisplay2.Fit(true);
            }
            else
            {
                datarecord.ALL_DATA_RecordWriteFile(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "功能运行失败");
                cogRecordDisplay2.Image = Camera_1_Image;
                cogRecordDisplay2.BackColor = Color.FromArgb(52, 61, 76);
                cogRecordDisplay2.Fit(true);
                vs_bool.Add(Detection);
                Result_bool.Add(Detection);
            }
            DWStationChange(vs_bool, cogRecordDisplay2);

            #region 保存运行结果
            Image isasaveimage;
            isasaveimage = cogRecordDisplay1.CreateContentBitmap(CogDisplayContentBitmapConstants.Display, null, 2);
            isasaveimage.Save(Application.StartupPath + @".\ImageRecord\" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bmp");
            #endregion
        }

        //OK和NG状态显示及PLC信号交互 M851 true 表示OK false 表示NG
        private void DWStationChange(List<bool> station, CogRecordDisplay cogRecordDisplay)
        {
            if (station.Count > 0)
            {
                //创建文字标签
                CogGraphicLabel label = new CogGraphicLabel();
                label.Color = CogColorConstants.Red;
                label.X = 1000;
                label.Y = 600;
                label.Text = "NG";
                label.Font = new Font("arial", 70);
                label.SelectedSpaceName = "#";
                //添加到图像中
                cogRecordDisplay.StaticGraphics.Add(label, "Labels");
                ShowMesIncre_1(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"), 3500, 500, true, cogRecordDisplay);
            }
            else
            {
                //创建文字标签
                CogGraphicLabel label = new CogGraphicLabel();
                label.Color = CogColorConstants.Green;
                label.X = 1000;
                label.Y = 600;
                label.Text = "OK";
                label.Font = new Font("arial", 70);
                label.SelectedSpaceName = "#";
                //添加到图像中
                cogRecordDisplay.StaticGraphics.Add(label, "Labels");
                ShowMesIncre_1(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"), 3500, 500, false, cogRecordDisplay);
            }
        }
        //结果综合判定
        private void ResultPD(List<bool> station)
        {
            if (station.Count > 0)
            {
                melsec_net.Write("M851", new bool[] { false });                
                //边框颜色响应
                panel1.BackColor = Color.Red;
                panel4.BackColor = Color.Red;
                panel5.BackColor = Color.Red;
            }
            else
            {
                melsec_net.Write("M851", new bool[] { true });               
                //边框颜色响应
                panel1.BackColor = Color.FromArgb(36, 232, 166);
                panel4.BackColor = Color.FromArgb(36, 232, 166);
                panel5.BackColor = Color.FromArgb(36, 232, 166);
            }
        }
        #endregion

        #region 屏幕信息显示

        #region 屏幕1
        private void ShowMesIncre_1(string str,int x,int y,bool station, CogRecordDisplay cogRecordDisplay)
        {
            //创建文字标签
            CogGraphicLabel label = new CogGraphicLabel();
            if (station) 
            { 
                label.Color = CogColorConstants.Red; 
            }
            else
            {
                label.Color = CogColorConstants.Green;
            }
            label.X = x;
            label.Y = y;
            label.Text = str;
            label.Font = new Font("arial", 20);            
            label.Alignment = CogGraphicLabelAlignmentConstants.BottomLeft;
            label.SelectedSpaceName = "#";
            //添加到图像中
            cogRecordDisplay.StaticGraphics.Add(label, "Labels");
        }
        private void ShowNGBlob(double x, double y, double width, double height, CogRecordDisplay cogRecordDisplay)
        {
            //创建矩形
            CogRectangle mRectangle = new CogRectangle();
            mRectangle.X = x;
            mRectangle.Y = y;
            mRectangle.Width = width;
            mRectangle.Height = height;
            mRectangle.Color = CogColorConstants.Red;
            mRectangle.SelectedSpaceName = "aBLOB_Fixture";
            //添加到图像中
            cogRecordDisplay.StaticGraphics.Add(mRectangle, "mRectangle");
        }
        private void ShowOKBlob(double x, double y, double width, double height, CogRecordDisplay cogRecordDisplay)
        {
            //创建矩形
            CogRectangle mRectangle = new CogRectangle();
            mRectangle.X = x;
            mRectangle.Y = y;
            mRectangle.Width = width;
            mRectangle.Height = height;
            mRectangle.Color = CogColorConstants.Green;
            mRectangle.SelectedSpaceName = "aBLOB_Fixture";
            //添加到图像中
            cogRecordDisplay.StaticGraphics.Add(mRectangle, "mRectangle");
        }
        #endregion
        #endregion

        #region 心跳运行信号
        // 使能状态监测
        bool CAMERA_RUN = false;        
        #endregion

        #region 自动运行线程

        #region PLC
        bool M800 = false; //触发相机拍照检测
        bool M801 = false;
        bool M802 = false;

        private MelsecMcNet melsec_net = null;
        private void PLC_ConnectSet()
        {
            melsec_net = new MelsecMcNet("192.168.0.20", 6000);            
            melsec_net.ConnectTimeOut = 2000; // 网络连接的超时时间
            melsec_net.NetworkNumber = 0x00;  // 网络号
            melsec_net.NetworkStationNumber = 0x00; // 网络站号
            melsec_net.ConnectClose();
            melsec_net.ConnectServer();
        }
        private Thread PLC_thread = null;              // 后台读取的线程   
        private void PLC_Connection()
        {
            PLC_thread = new Thread(PLC_ThreadReadServer);
            PLC_thread.IsBackground = true;
            PLC_thread.Start();
        }
        private void PLC_ThreadReadServer()
        {
            melsec_net.Write("M800", new bool[] { false });
            while (true)
            {
                // M800-M802读取显示                               
                OperateResult<bool[]> read_Bool = melsec_net.ReadBool("M800", 3);
                if (read_Bool.IsSuccess)
                {
                    // 成功读取，True代表通，False代表不通
                    M800 = read_Bool.Content[0];
                    M801 = read_Bool.Content[1];
                    M802 = read_Bool.Content[2];
                }
                Thread.Sleep(50);
            }
        }
        //心跳 M805
        private Thread HeartBreak2PLC_thread = null;
        private void HeartBreak()
        {
            HeartBreak2PLC_thread = new Thread(HeartBreakServer);
            HeartBreak2PLC_thread.IsBackground = true;
            HeartBreak2PLC_thread.Start();            
        }
        private void HeartBreakServer()
        {
            while (true)
            {
                if (CAMERA_RUN)
                {
                    melsec_net.Write("M805", new bool[] { true });
                }
                Thread.Sleep(500);
                melsec_net.Write("M805", new bool[] { false });
                Thread.Sleep(500);
            }
        }
        #endregion

        #region 相机1自动运行
        //相机1检测独立线程
        private Thread Camera_1_thread = null;   
        private void Camera_1_Connection()
        {
            Camera_1_thread = new Thread(Camera_1_ThreadReadServer);
            Camera_1_thread.IsBackground = true;
            Camera_1_thread.Start();
        }
        private void Camera_1_ThreadReadServer()
        {
            while (true)
            {
                if (CAMERA_RUN && M800)
                {
                    Result_bool.Clear();//清空结果判定的队列，等待新的结果
                    PMA_2_Function();
                    if (YC_Switch.Checked)
                    {
                        PMA_3_Function();
                    }
                    ResultPD(Result_bool);
                    melsec_net.Write("M800", new bool[] { false });
                    melsec_net.Write("M852", new bool[] { true });
                }
                Thread.Sleep(100);
            }
        }
        #endregion

        #endregion

        #region 主按钮功能区
        private void MoveSidePanel(Control c)
        {
            SidePanel.Height = c.Height;
            SidePanel.Top = c.Top;
        }
        //数据记录
        private void btnTrainSet_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnTrainSet);
            string v_OpenFolderPath = Application.StartupPath + @".\ImageRecord\DATA\";
            string srcFile = Application.StartupPath + @".\ALL_DATA_Record_file.txt";
            System.IO.File.Delete(Application.StartupPath + @".\ImageRecord\DATA\ALL_DATA_Record_file.txt");//删除上次的配置
            Process.Start("explorer.exe", v_OpenFolderPath);
            DirectoryInfo destDirectory = new DirectoryInfo(v_OpenFolderPath);
            string fileName = Path.GetFileName(srcFile);           
            File.Copy(srcFile, destDirectory.FullName + @"\" + fileName, true);
        }        
        //历史图像
        private void button2_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button2);
            string v_OpenFolderPath = Application.StartupPath + @".\ImageRecord\";
            Process.Start("explorer.exe", v_OpenFolderPath);
        }
        //加载模板
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "准备检测";
            label1.BackColor = Color.Yellow;
            //check状态更新
            YC_Switch.Checked = false;
            label5.Text = "溢出检测关闭";
            //
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择要执行的模板");
            }
            else
            {
                #region 心跳包开始+状态显示
                Block_1 = CogSerializer.LoadObjectFromFile(@ToolBlock_path_1) as CogToolBlock;                               
                CAMERA_RUN = true;
                label1.Text = "开始检测";
                label1.BackColor = Color.LimeGreen;
                YC_Switch.Enabled = true;
                #endregion
            }
        }
        //退出
        private void button3_Click(object sender, EventArgs e)
        {
            //关闭相机连接，防止程序报错
            CogFrameGrabberGigEs cameras = new CogFrameGrabberGigEs();
            try
            {
                foreach (CogFrameGrabberGigE item in cameras)
                {
                    item.Disconnect(false);
                }
            }
            catch (Exception ex)
            {
                datarecord.ALL_DATA_RecordWriteFile(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+ex.Message);
            }
            Process.GetCurrentProcess().Kill();
        }
        //修改模板参数
        private void button4_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button4);
            userControl21.Visible = true;
            userControl11.Visible = false;
        }
        //参数设定
        private void btnDataRecord_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnDataRecord);
            userControl11.Visible = true;
            userControl21.Visible = false;
        }
        //是否开启溢出检测
        private void YC_Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {                
                MessageBox.Show("请选择要执行的模板");
            }
            else
            {
                if (YC_Switch.Checked)
                {
                    label5.Text = "溢出检测开启";
                    Block_2 = CogSerializer.LoadObjectFromFile(@ToolBlock_path_2) as CogToolBlock;
                }
                else
                {
                    label5.Text = "溢出检测关闭";
                    cogRecordDisplay2.InteractiveGraphics.Clear();
                    cogRecordDisplay2.StaticGraphics.Clear();
                    cogRecordDisplay2.Image = null;
                }
            }            
        }
        #endregion

        #region 辅助功能
        //获取磁盘使用情况     
        public string GetDriverInfo()
        {
            string result = "";
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                //判断是否是固定磁盘
                if (drive.DriveType == DriveType.Fixed)
                {
                    if (drive.Name == "D:\\")
                    {
                        long free = drive.TotalFreeSpace /(1024 * 1024 * 1024);
                        if (free>10)
                        {
                            result = drive.Name + " 剩余空间=" + free.ToString() + " G";
                        }
                        else
                        {
                            result = drive.Name + " 剩余空间不足：" + free.ToString() + " G ！！！";
                        }
                    }                        
                    
                }
            }
            return result;
        }
        #endregion       
    }
}
