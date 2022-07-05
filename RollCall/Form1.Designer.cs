namespace RollCall
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new Sunny.UI.UIButton();
            this.plStudent = new System.Windows.Forms.Panel();
            this.btnUpper = new Sunny.UI.UIButton();
            this.btnLower = new Sunny.UI.UIButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnReset = new Sunny.UI.UIButton();
            this.btnSetFile = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(773, 59);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始自动点名";
            this.btnStart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // plStudent
            // 
            this.plStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plStudent.AutoScroll = true;
            this.plStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plStudent.Location = new System.Drawing.Point(3, 120);
            this.plStudent.Name = "plStudent";
            this.plStudent.Size = new System.Drawing.Size(959, 412);
            this.plStudent.TabIndex = 2;
            // 
            // btnUpper
            // 
            this.btnUpper.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpper.Location = new System.Drawing.Point(673, 560);
            this.btnUpper.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(125, 44);
            this.btnUpper.Style = Sunny.UI.UIStyle.DarkBlue;
            this.btnUpper.StyleCustomMode = true;
            this.btnUpper.TabIndex = 3;
            this.btnUpper.Text = "上一位";
            this.btnUpper.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnLower
            // 
            this.btnLower.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLower.Location = new System.Drawing.Point(816, 560);
            this.btnLower.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(125, 44);
            this.btnLower.StyleCustomMode = true;
            this.btnLower.TabIndex = 4;
            this.btnLower.Text = "下一位";
            this.btnLower.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnReset
            // 
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnReset.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnReset.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnReset.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnReset.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(522, 560);
            this.btnReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnReset.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnReset.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnReset.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnReset.Size = new System.Drawing.Size(125, 44);
            this.btnReset.Style = Sunny.UI.UIStyle.Colorful;
            this.btnReset.StyleCustomMode = true;
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重复播报";
            this.btnReset.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSetFile
            // 
            this.btnSetFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSetFile.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSetFile.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnSetFile.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetFile.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetFile.Location = new System.Drawing.Point(598, 59);
            this.btnSetFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetFile.Name = "btnSetFile";
            this.btnSetFile.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSetFile.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnSetFile.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetFile.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetFile.Size = new System.Drawing.Size(147, 44);
            this.btnSetFile.Style = Sunny.UI.UIStyle.Red;
            this.btnSetFile.StyleCustomMode = true;
            this.btnSetFile.TabIndex = 6;
            this.btnSetFile.Text = "更换文件";
            this.btnSetFile.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSetFile.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(965, 621);
            this.Controls.Add(this.btnSetFile);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.plStudent);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StyleCustomMode = true;
            this.Text = "点名系统";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 943, 530);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btnStart;
        private Panel plStudent;
        private Sunny.UI.UIButton btnUpper;
        private Sunny.UI.UIButton btnLower;
        private OpenFileDialog ofd;
        private Sunny.UI.UIButton btnReset;
        private Sunny.UI.UIButton btnSetFile;
    }
}