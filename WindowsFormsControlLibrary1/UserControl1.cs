using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.FGGigE;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        #region 相机1取像
        ICogAcqFifo macqfifo1;//定义相机对象类型
        CogImage8Grey Camera_1_Image;//定义照片类型（这里是黑白的）
        Bitmap img;//读入的普通图像
        //相机1取像
        public CogImage8Grey Camera_1_GetImage()
        {
            //
            int trigNum;
            CogFrameGrabberGigEs mf2 = new CogFrameGrabberGigEs();//获取已连接相机列表
            if (mf2.Count > 0)
            {
                ICogFrameGrabber mber = mf2[0];//取相机列表中的第1个相机           
                macqfifo1 = mber.CreateAcqFifo(mber.AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);//创建相机对象
                macqfifo1.OwnedExposureParams.Exposure = 505.95;//曝光
                macqfifo1.OwnedBrightnessParams.Brightness = 0.048;//亮度
                macqfifo1.OwnedContrastParams.Contrast = 0.0;//对比
                Camera_1_Image = (CogImage8Grey)macqfifo1.Acquire(out trigNum);//使用相机对象的acquire方法拍照                
                return Camera_1_Image;
            }
            else
            {
                string image_path = Application.StartupPath + @"\ModelTool\error.bmp";
                img = new Bitmap(@image_path);
                Camera_1_Image = new CogImage8Grey(img);
                return Camera_1_Image;
            }
        }
        #endregion
        public string BD_path = Application.StartupPath + @"\ModelTool\T2\ToolBlock.vpp";
        private void InitcogTool()
        {
            CogToolBlock Block = CogSerializer.LoadObjectFromFile(@BD_path) as CogToolBlock;
            cogToolBlockEdit.Subject = Block;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cogToolBlockEdit.Enabled = false;
            InitcogTool();            
            cogToolBlockEdit.Subject.Inputs[0].Value = Camera_1_GetImage();
            cogToolBlockEdit.Enabled = true;
            button3.Enabled = true;
            //InitcogTool(InputImage);            
        }

        private void ToolSet_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            cogToolBlockEdit.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cogToolBlockEdit.Enabled = false;
            cogToolBlockEdit.Subject = null;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cogToolBlockEdit.Subject.Inputs[0].Value = Camera_1_GetImage();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BD_path = Application.StartupPath + @"\ModelTool\T2\ToolBlock.vpp";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BD_path = Application.StartupPath + @"\ModelTool\T3\ToolBlock.vpp";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BD_path = Application.StartupPath + @"\ModelTool\T4\ToolBlock.vpp";
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            BD_path = Application.StartupPath + @"\ModelTool\T1\ToolBlock.vpp";
        }
    }
}
