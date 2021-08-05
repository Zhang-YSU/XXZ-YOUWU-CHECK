namespace DEMO
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.YC_Switch = new HZH_Controls.Controls.UCSwitch();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDataRecord = new System.Windows.Forms.Button();
            this.btnTrainSet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cogRecordDisplay2 = new Cognex.VisionPro.CogRecordDisplay();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userControl11 = new WindowsFormsControlLibrary1.UserControl1();
            this.userControl21 = new WindowsFormsControlLibrary1.UserControl2();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).BeginInit();
            this.SuspendLayout();
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(148, 61);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(880, 970);
            this.cogRecordDisplay1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(928, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "准备检测";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelHeader.Controls.Add(this.label5);
            this.panelHeader.Controls.Add(this.YC_Switch);
            this.panelHeader.Controls.Add(this.button3);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Controls.Add(this.comboBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1920, 55);
            this.panelHeader.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.label5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(415, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 107;
            this.label5.Text = "溢出检测关闭";
            // 
            // YC_Switch
            // 
            this.YC_Switch.BackColor = System.Drawing.Color.Transparent;
            this.YC_Switch.Checked = false;
            this.YC_Switch.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.YC_Switch.FalseTextColr = System.Drawing.Color.White;
            this.YC_Switch.Location = new System.Drawing.Point(315, 11);
            this.YC_Switch.Name = "YC_Switch";
            this.YC_Switch.Size = new System.Drawing.Size(83, 31);
            this.YC_Switch.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.YC_Switch.TabIndex = 111;
            this.YC_Switch.Texts = null;
            this.YC_Switch.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.YC_Switch.TrueTextColr = System.Drawing.Color.White;
            this.YC_Switch.CheckedChanged += new System.EventHandler(this.YC_Switch_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(1811, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 33);
            this.button3.TabIndex = 109;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(185, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 108;
            this.button1.Text = "加载模板";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 32);
            this.comboBox1.TabIndex = 107;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnDataRecord);
            this.panel2.Controls.Add(this.btnTrainSet);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 1025);
            this.panel2.TabIndex = 95;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(6, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 31);
            this.button4.TabIndex = 15;
            this.button4.Text = "修改模板";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "历史图像";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDataRecord
            // 
            this.btnDataRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.btnDataRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDataRecord.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDataRecord.ForeColor = System.Drawing.Color.White;
            this.btnDataRecord.Location = new System.Drawing.Point(6, 80);
            this.btnDataRecord.Name = "btnDataRecord";
            this.btnDataRecord.Size = new System.Drawing.Size(133, 31);
            this.btnDataRecord.TabIndex = 12;
            this.btnDataRecord.Text = "参数设定";
            this.btnDataRecord.UseVisualStyleBackColor = false;
            this.btnDataRecord.Click += new System.EventHandler(this.btnDataRecord_Click);
            // 
            // btnTrainSet
            // 
            this.btnTrainSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.btnTrainSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrainSet.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTrainSet.ForeColor = System.Drawing.Color.White;
            this.btnTrainSet.Location = new System.Drawing.Point(6, 26);
            this.btnTrainSet.Name = "btnTrainSet";
            this.btnTrainSet.Size = new System.Drawing.Size(133, 31);
            this.btnTrainSet.TabIndex = 10;
            this.btnTrainSet.Text = "数据记录";
            this.btnTrainSet.UseVisualStyleBackColor = false;
            this.btnTrainSet.Click += new System.EventHandler(this.btnTrainSet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 10);
            this.panel1.TabIndex = 3;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 26);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(6, 32);
            this.SidePanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel4.Location = new System.Drawing.Point(139, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 980);
            this.panel4.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(142, 1037);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1778, 43);
            this.panel3.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Violet;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "硬盘空间";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(803, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "视觉检测平台";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel5.Location = new System.Drawing.Point(139, 1033);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1781, 11);
            this.panel5.TabIndex = 103;
            // 
            // cogRecordDisplay2
            // 
            this.cogRecordDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay2.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay2.Location = new System.Drawing.Point(1034, 61);
            this.cogRecordDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay2.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay2.Name = "cogRecordDisplay2";
            this.cogRecordDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay2.OcxState")));
            this.cogRecordDisplay2.Size = new System.Drawing.Size(880, 970);
            this.cogRecordDisplay2.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(523, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 105;
            this.label3.Text = "定位销检测";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(1409, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 106;
            this.label4.Text = "溢出检测";
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.userControl11.Location = new System.Drawing.Point(155, 61);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1759, 971);
            this.userControl11.TabIndex = 108;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.userControl21.Location = new System.Drawing.Point(155, 61);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1760, 970);
            this.userControl21.TabIndex = 109;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cogRecordDisplay2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.cogRecordDisplay1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDataRecord;
        private System.Windows.Forms.Button btnTrainSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private HZH_Controls.Controls.UCSwitch YC_Switch;
        private WindowsFormsControlLibrary1.UserControl1 userControl11;
        private System.Windows.Forms.Button button4;
        private WindowsFormsControlLibrary1.UserControl2 userControl21;
    }
}

