namespace tutorial_3_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbKM = new TextBox();
            txbLiter = new TextBox();
            lblShow = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(191, 69);
            label1.Name = "label1";
            label1.Size = new Size(96, 35);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F);
            label2.Location = new Point(164, 149);
            label2.Name = "label2";
            label2.Size = new Size(123, 35);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F);
            label3.Location = new Point(126, 239);
            label3.Name = "label3";
            label3.Size = new Size(161, 35);
            label3.TabIndex = 2;
            label3.Text = "公里/每公升";
            // 
            // txbKM
            // 
            txbKM.Font = new Font("Microsoft JhengHei UI", 16F);
            txbKM.Location = new Point(314, 69);
            txbKM.Name = "txbKM";
            txbKM.Size = new Size(226, 35);
            txbKM.TabIndex = 3;
            // 
            // txbLiter
            // 
            txbLiter.Font = new Font("Microsoft JhengHei UI", 16F);
            txbLiter.Location = new Point(314, 153);
            txbLiter.Name = "txbLiter";
            txbLiter.Size = new Size(226, 35);
            txbLiter.TabIndex = 4;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(314, 239);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(241, 43);
            lblShow.TabIndex = 6;
            lblShow.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(148, 354);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(168, 62);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "計算";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(414, 354);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 62);
            btnExit.TabIndex = 8;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblShow);
            Controls.Add(txbLiter);
            Controls.Add(txbKM);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbKM;
        private TextBox txbLiter;
        private Label lblShow;
        private Button btnCalculate;
        private Button btnExit;
    }
}
