namespace WindowsFormsControlLibrary1
{
    partial class UserControl2
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cogToolBlockEdit = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.panelHeader.Controls.Add(this.button3);
            this.panelHeader.Controls.Add(this.button2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1760, 45);
            this.panelHeader.TabIndex = 107;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 99;
            this.button3.Text = "加载图像";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1633, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 97;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cogToolBlockEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 925);
            this.panel1.TabIndex = 108;
            // 
            // cogToolBlockEdit
            // 
            this.cogToolBlockEdit.AllowDrop = true;
            this.cogToolBlockEdit.ContextMenuCustomizer = null;
            this.cogToolBlockEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogToolBlockEdit.Location = new System.Drawing.Point(0, 0);
            this.cogToolBlockEdit.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogToolBlockEdit.Name = "cogToolBlockEdit";
            this.cogToolBlockEdit.ShowNodeToolTips = true;
            this.cogToolBlockEdit.Size = new System.Drawing.Size(1760, 925);
            this.cogToolBlockEdit.SuspendElectricRuns = false;
            this.cogToolBlockEdit.TabIndex = 2;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1760, 970);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.panelHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogToolBlockEdit;
    }
}
