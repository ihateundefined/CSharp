namespace ImageViewer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbMenu = new System.Windows.Forms.ToolStrip();
            this.tbBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tbBtnSizeUp = new System.Windows.Forms.ToolStripButton();
            this.tbBtnSizeDown = new System.Windows.Forms.ToolStripButton();
            this.tbBtnRotate = new System.Windows.Forms.ToolStripSplitButton();
            this.tbMenuItem90 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMenuItem180 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMenuItem270 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbBtnOpen,
            this.tbBtnSizeUp,
            this.tbBtnSizeDown,
            this.tbBtnRotate});
            this.tbMenu.Location = new System.Drawing.Point(0, 0);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.Size = new System.Drawing.Size(821, 38);
            this.tbMenu.TabIndex = 0;
            this.tbMenu.Text = "toolStrip1";
            // 
            // tbBtnOpen
            // 
            this.tbBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbBtnOpen.Image")));
            this.tbBtnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBtnOpen.Name = "tbBtnOpen";
            this.tbBtnOpen.Size = new System.Drawing.Size(37, 35);
            this.tbBtnOpen.Text = "열기";
            this.tbBtnOpen.Click += new System.EventHandler(this.TbBtnOpen_Click);
            // 
            // tbBtnSizeUp
            // 
            this.tbBtnSizeUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBtnSizeUp.Image = ((System.Drawing.Image)(resources.GetObject("tbBtnSizeUp.Image")));
            this.tbBtnSizeUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbBtnSizeUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBtnSizeUp.Name = "tbBtnSizeUp";
            this.tbBtnSizeUp.Size = new System.Drawing.Size(34, 35);
            this.tbBtnSizeUp.Text = "확대";
            this.tbBtnSizeUp.Click += new System.EventHandler(this.TbBtnSizeUp_Click);
            // 
            // tbBtnSizeDown
            // 
            this.tbBtnSizeDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBtnSizeDown.Image = ((System.Drawing.Image)(resources.GetObject("tbBtnSizeDown.Image")));
            this.tbBtnSizeDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbBtnSizeDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBtnSizeDown.Name = "tbBtnSizeDown";
            this.tbBtnSizeDown.Size = new System.Drawing.Size(33, 35);
            this.tbBtnSizeDown.Text = "축소";
            this.tbBtnSizeDown.Click += new System.EventHandler(this.TbBtnSizeDown_Click);
            // 
            // tbBtnRotate
            // 
            this.tbBtnRotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBtnRotate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbMenuItem90,
            this.tbMenuItem180,
            this.tbMenuItem270});
            this.tbBtnRotate.Image = ((System.Drawing.Image)(resources.GetObject("tbBtnRotate.Image")));
            this.tbBtnRotate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbBtnRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBtnRotate.Name = "tbBtnRotate";
            this.tbBtnRotate.Size = new System.Drawing.Size(46, 35);
            this.tbBtnRotate.Text = "회전";
            // 
            // tbMenuItem90
            // 
            this.tbMenuItem90.Name = "tbMenuItem90";
            this.tbMenuItem90.Size = new System.Drawing.Size(180, 24);
            this.tbMenuItem90.Text = "90도";
            this.tbMenuItem90.Click += new System.EventHandler(this.TbMenuItem90_Click);
            // 
            // tbMenuItem180
            // 
            this.tbMenuItem180.Name = "tbMenuItem180";
            this.tbMenuItem180.Size = new System.Drawing.Size(180, 24);
            this.tbMenuItem180.Text = "180도";
            this.tbMenuItem180.Click += new System.EventHandler(this.TbMenuItem180_Click);
            // 
            // tbMenuItem270
            // 
            this.tbMenuItem270.Name = "tbMenuItem270";
            this.tbMenuItem270.Size = new System.Drawing.Size(180, 24);
            this.tbMenuItem270.Text = "270도";
            this.tbMenuItem270.Click += new System.EventHandler(this.TbMenuItem270_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 91);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(596, 306);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(821, 864);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbMenu);
            this.Name = "Form1";
            this.Text = "이미지 뷰어";
            this.tbMenu.ResumeLayout(false);
            this.tbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tbMenu;
        private System.Windows.Forms.ToolStripButton tbBtnOpen;
        private System.Windows.Forms.ToolStripButton tbBtnSizeUp;
        private System.Windows.Forms.ToolStripButton tbBtnSizeDown;
        private System.Windows.Forms.ToolStripSplitButton tbBtnRotate;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem tbMenuItem90;
        private System.Windows.Forms.ToolStripMenuItem tbMenuItem180;
        private System.Windows.Forms.ToolStripMenuItem tbMenuItem270;
        private System.Windows.Forms.PictureBox pbImage;
    }
}

