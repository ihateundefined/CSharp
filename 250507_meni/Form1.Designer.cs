﻿namespace _250507_meni
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
            this.components = new System.ComponentModel.Container();
            this.lblResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(392, 297);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(104, 30);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "결과 출력";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNew,
            this.toolStripSeparator1,
            this.ToolStripOpen,
            this.ToolStripSave,
            this.toolStripSeparator2,
            this.ToolStripExit});
            this.파일ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // ToolStripNew
            // 
            this.ToolStripNew.Name = "ToolStripNew";
            this.ToolStripNew.Size = new System.Drawing.Size(180, 24);
            this.ToolStripNew.Text = "새 창";
            this.ToolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
            // 
            // ToolStripExit
            // 
            this.ToolStripExit.Name = "ToolStripExit";
            this.ToolStripExit.Size = new System.Drawing.Size(180, 24);
            this.ToolStripExit.Text = "종료";
            this.ToolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripCopy,
            this.ToolStripPaste,
            this.ToolStripCut});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 76);
            // 
            // ToolStripCopy
            // 
            this.ToolStripCopy.Name = "ToolStripCopy";
            this.ToolStripCopy.Size = new System.Drawing.Size(138, 24);
            this.ToolStripCopy.Text = "복사";
            this.ToolStripCopy.Click += new System.EventHandler(this.ToolStripCopy_Click);
            // 
            // ToolStripPaste
            // 
            this.ToolStripPaste.Name = "ToolStripPaste";
            this.ToolStripPaste.Size = new System.Drawing.Size(138, 24);
            this.ToolStripPaste.Text = "붙여넣기";
            this.ToolStripPaste.Click += new System.EventHandler(this.ToolStripPaste_Click);
            // 
            // ToolStripCut
            // 
            this.ToolStripCut.Name = "ToolStripCut";
            this.ToolStripCut.Size = new System.Drawing.Size(138, 24);
            this.ToolStripCut.Text = "잘라내기";
            this.ToolStripCut.Click += new System.EventHandler(this.ToolStripCut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripSave
            // 
            this.ToolStripSave.Name = "ToolStripSave";
            this.ToolStripSave.Size = new System.Drawing.Size(180, 24);
            this.ToolStripSave.Text = "저장";
            this.ToolStripSave.Click += new System.EventHandler(this.ToolStripSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripOpen
            // 
            this.ToolStripOpen.Name = "ToolStripOpen";
            this.ToolStripOpen.Size = new System.Drawing.Size(180, 24);
            this.ToolStripOpen.Text = "열기";
            this.ToolStripOpen.Click += new System.EventHandler(this.ToolStripOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCopy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripPaste;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOpen;
    }
}

