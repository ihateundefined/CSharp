﻿namespace _250508_미니그림판
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
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ToolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripShape = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripLine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripRect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSelectColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBtnLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnGreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBlue = new System.Windows.Forms.ToolStripButton();
            this.menubar.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubar
            // 
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripFile,
            this.ToolStripShape,
            this.ToolStripColor});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(647, 24);
            this.menubar.TabIndex = 0;
            this.menubar.Text = "menuStrip1";
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnLine,
            this.toolStripBtnRect,
            this.toolStripBtnCircle,
            this.toolStripSeparator1,
            this.toolStripBtnBlack,
            this.toolStripBtnRed,
            this.toolStripBtnGreen,
            this.toolStripBtnBlue});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(647, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // ToolStripFile
            // 
            this.ToolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNew,
            this.ToolStripExit});
            this.ToolStripFile.Name = "ToolStripFile";
            this.ToolStripFile.Size = new System.Drawing.Size(43, 20);
            this.ToolStripFile.Text = "파일";
            // 
            // ToolStripShape
            // 
            this.ToolStripShape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLine,
            this.ToolStripRect,
            this.ToolStripCircle});
            this.ToolStripShape.Name = "ToolStripShape";
            this.ToolStripShape.Size = new System.Drawing.Size(43, 20);
            this.ToolStripShape.Text = "도형";
            // 
            // ToolStripColor
            // 
            this.ToolStripColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSelectColor});
            this.ToolStripColor.Name = "ToolStripColor";
            this.ToolStripColor.Size = new System.Drawing.Size(43, 20);
            this.ToolStripColor.Text = "색상";
            // 
            // ToolStripNew
            // 
            this.ToolStripNew.Name = "ToolStripNew";
            this.ToolStripNew.Size = new System.Drawing.Size(180, 22);
            this.ToolStripNew.Text = "새로만들기";
            this.ToolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
            // 
            // ToolStripExit
            // 
            this.ToolStripExit.Name = "ToolStripExit";
            this.ToolStripExit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripExit.Text = "끝내기";
            this.ToolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // ToolStripLine
            // 
            this.ToolStripLine.Name = "ToolStripLine";
            this.ToolStripLine.Size = new System.Drawing.Size(180, 22);
            this.ToolStripLine.Text = "선";
            this.ToolStripLine.Click += new System.EventHandler(this.ToolStripLine_Click);
            // 
            // ToolStripRect
            // 
            this.ToolStripRect.Name = "ToolStripRect";
            this.ToolStripRect.Size = new System.Drawing.Size(180, 22);
            this.ToolStripRect.Text = "사각형";
            this.ToolStripRect.Click += new System.EventHandler(this.ToolStripRect_Click);
            // 
            // ToolStripCircle
            // 
            this.ToolStripCircle.Name = "ToolStripCircle";
            this.ToolStripCircle.Size = new System.Drawing.Size(180, 22);
            this.ToolStripCircle.Text = "원";
            this.ToolStripCircle.Click += new System.EventHandler(this.ToolStripCircle_Click);
            // 
            // toolStripSelectColor
            // 
            this.toolStripSelectColor.Name = "toolStripSelectColor";
            this.toolStripSelectColor.Size = new System.Drawing.Size(180, 22);
            this.toolStripSelectColor.Text = "색상설정";
            this.toolStripSelectColor.Click += new System.EventHandler(this.toolStripSelectColor_Click);
            // 
            // toolStripBtnLine
            // 
            this.toolStripBtnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLine.Image")));
            this.toolStripBtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLine.Name = "toolStripBtnLine";
            this.toolStripBtnLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnLine.Text = "toolStripButton1";
            this.toolStripBtnLine.Click += new System.EventHandler(this.toolStripBtnLine_Click);
            // 
            // toolStripBtnRect
            // 
            this.toolStripBtnRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRect.Image")));
            this.toolStripBtnRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRect.Name = "toolStripBtnRect";
            this.toolStripBtnRect.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnRect.Text = "toolStripButton2";
            this.toolStripBtnRect.Click += new System.EventHandler(this.toolStripBtnRect_Click);
            // 
            // toolStripBtnCircle
            // 
            this.toolStripBtnCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCircle.Image")));
            this.toolStripBtnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCircle.Name = "toolStripBtnCircle";
            this.toolStripBtnCircle.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCircle.Text = "toolStripButton3";
            this.toolStripBtnCircle.Click += new System.EventHandler(this.toolStripBtnCircle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnBlack
            // 
            this.toolStripBtnBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBlack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBlack.Image")));
            this.toolStripBtnBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBlack.Name = "toolStripBtnBlack";
            this.toolStripBtnBlack.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnBlack.Text = "toolStripButton4";
            this.toolStripBtnBlack.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnRed
            // 
            this.toolStripBtnRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRed.Image")));
            this.toolStripBtnRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRed.Name = "toolStripBtnRed";
            this.toolStripBtnRed.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnRed.Text = "toolStripButton5";
            this.toolStripBtnRed.Click += new System.EventHandler(this.toolStripBtnRed_Click);
            // 
            // toolStripBtnGreen
            // 
            this.toolStripBtnGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnGreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnGreen.Image")));
            this.toolStripBtnGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGreen.Name = "toolStripBtnGreen";
            this.toolStripBtnGreen.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnGreen.Text = "toolStripButton6";
            this.toolStripBtnGreen.Click += new System.EventHandler(this.toolStripBtnGreen_Click);
            // 
            // toolStripBtnBlue
            // 
            this.toolStripBtnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBlue.Image")));
            this.toolStripBtnBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBlue.Name = "toolStripBtnBlue";
            this.toolStripBtnBlue.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnBlue.Text = "toolStripButton7";
            this.toolStripBtnBlue.Click += new System.EventHandler(this.toolStripBtnBlue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 556);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.menubar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripShape;
        private System.Windows.Forms.ToolStripMenuItem ToolStripLine;
        private System.Windows.Forms.ToolStripMenuItem ToolStripRect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCircle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripColor;
        private System.Windows.Forms.ToolStripMenuItem toolStripSelectColor;
        private System.Windows.Forms.ToolStripButton toolStripBtnLine;
        private System.Windows.Forms.ToolStripButton toolStripBtnRect;
        private System.Windows.Forms.ToolStripButton toolStripBtnCircle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnBlack;
        private System.Windows.Forms.ToolStripButton toolStripBtnRed;
        private System.Windows.Forms.ToolStripButton toolStripBtnGreen;
        private System.Windows.Forms.ToolStripButton toolStripBtnBlue;
    }
}

