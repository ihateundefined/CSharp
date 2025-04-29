namespace 기본컨트롤
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
            this.ckbA = new System.Windows.Forms.CheckBox();
            this.ckbB = new System.Windows.Forms.CheckBox();
            this.ckbC = new System.Windows.Forms.CheckBox();
            this.ckbD = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.radioAgree = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioDisAgree = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRequire = new System.Windows.Forms.TextBox();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbA
            // 
            this.ckbA.AutoSize = true;
            this.ckbA.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbA.Location = new System.Drawing.Point(28, 95);
            this.ckbA.Name = "ckbA";
            this.ckbA.Size = new System.Drawing.Size(109, 25);
            this.ckbA.TabIndex = 0;
            this.ckbA.Text = "아메리카노";
            this.ckbA.UseVisualStyleBackColor = true;
            // 
            // ckbB
            // 
            this.ckbB.AutoSize = true;
            this.ckbB.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbB.Location = new System.Drawing.Point(174, 95);
            this.ckbB.Name = "ckbB";
            this.ckbB.Size = new System.Drawing.Size(93, 25);
            this.ckbB.TabIndex = 1;
            this.ckbB.Text = "카페라떼";
            this.ckbB.UseVisualStyleBackColor = true;
            // 
            // ckbC
            // 
            this.ckbC.AutoSize = true;
            this.ckbC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbC.Location = new System.Drawing.Point(327, 95);
            this.ckbC.Name = "ckbC";
            this.ckbC.Size = new System.Drawing.Size(93, 25);
            this.ckbC.TabIndex = 2;
            this.ckbC.Text = "카페모카";
            this.ckbC.UseVisualStyleBackColor = true;
            // 
            // ckbD
            // 
            this.ckbD.AutoSize = true;
            this.ckbD.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbD.Location = new System.Drawing.Point(487, 95);
            this.ckbD.Name = "ckbD";
            this.ckbD.Size = new System.Drawing.Size(77, 25);
            this.ckbD.TabIndex = 3;
            this.ckbD.Text = "밀크티";
            this.ckbD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "주문하세요";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder.Location = new System.Drawing.Point(434, 25);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(130, 46);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "주문";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(21, 141);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(125, 37);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "주문결과";
            // 
            // radioAgree
            // 
            this.radioAgree.AutoSize = true;
            this.radioAgree.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioAgree.Location = new System.Drawing.Point(22, 20);
            this.radioAgree.Name = "radioAgree";
            this.radioAgree.Size = new System.Drawing.Size(68, 29);
            this.radioAgree.TabIndex = 7;
            this.radioAgree.TabStop = true;
            this.radioAgree.Text = "동의";
            this.radioAgree.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(23, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "이벤트에 응모하려면 개인정보 동의해주세요";
            // 
            // radioDisAgree
            // 
            this.radioDisAgree.AutoSize = true;
            this.radioDisAgree.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioDisAgree.Location = new System.Drawing.Point(145, 20);
            this.radioDisAgree.Name = "radioDisAgree";
            this.radioDisAgree.Size = new System.Drawing.Size(87, 29);
            this.radioDisAgree.TabIndex = 9;
            this.radioDisAgree.TabStop = true;
            this.radioDisAgree.Text = "비동의";
            this.radioDisAgree.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDisAgree);
            this.groupBox1.Controls.Add(this.radioAgree);
            this.groupBox1.Location = new System.Drawing.Point(70, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 61);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보동의";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEnter.Location = new System.Drawing.Point(434, 474);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(130, 46);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "응모";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(27, 622);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "주문시 요구사항";
            // 
            // txtRequire
            // 
            this.txtRequire.Location = new System.Drawing.Point(32, 666);
            this.txtRequire.Multiline = true;
            this.txtRequire.Name = "txtRequire";
            this.txtRequire.Size = new System.Drawing.Size(370, 121);
            this.txtRequire.TabIndex = 13;
            // 
            // btnReceipt
            // 
            this.btnReceipt.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReceipt.Location = new System.Drawing.Point(434, 666);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(130, 46);
            this.btnReceipt.TabIndex = 14;
            this.btnReceipt.Text = "접수";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(27, 835);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "결제 방법";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(246, 835);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "결제 정보";
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Items.AddRange(new object[] {
            "실물 카드",
            "무통장 입금",
            "네이버 페이",
            "카카오 페이",
            "삼성 페이",
            "지역 화폐",
            "외상"});
            this.cbPay.Location = new System.Drawing.Point(25, 868);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(121, 20);
            this.cbPay.TabIndex = 17;
            this.cbPay.SelectedIndexChanged += new System.EventHandler(this.cbPay_SelectedIndexChanged);
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.ItemHeight = 12;
            this.lbArea.Items.AddRange(new object[] {
            "일시불",
            "3개월 할부",
            "6개월 할부"});
            this.lbArea.Location = new System.Drawing.Point(251, 868);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(120, 88);
            this.lbArea.TabIndex = 18;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPay.Location = new System.Drawing.Point(434, 848);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(130, 46);
            this.btnPay.TabIndex = 19;
            this.btnPay.Text = "결제";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 1061);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.txtRequire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbD);
            this.Controls.Add(this.ckbC);
            this.Controls.Add(this.ckbB);
            this.Controls.Add(this.ckbA);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbA;
        private System.Windows.Forms.CheckBox ckbB;
        private System.Windows.Forms.CheckBox ckbC;
        private System.Windows.Forms.CheckBox ckbD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton radioAgree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioDisAgree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRequire;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.Button btnPay;
    }
}

