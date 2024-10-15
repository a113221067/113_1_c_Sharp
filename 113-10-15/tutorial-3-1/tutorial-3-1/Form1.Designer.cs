namespace tutorial_3_1
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
            label4 = new Label();
            txtDayofweek = new TextBox();
            txtDate = new TextBox();
            txtMonth = new TextBox();
            txtYear = new TextBox();
            lblShow = new Label();
            btnShowday = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16F);
            label1.Location = new Point(123, 43);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16F);
            label2.Location = new Point(145, 125);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16F);
            label3.Location = new Point(145, 220);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 16F);
            label4.Location = new Point(145, 309);
            label4.Name = "label4";
            label4.Size = new Size(56, 28);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtDayofweek
            // 
            txtDayofweek.Font = new Font("Microsoft JhengHei UI", 16F);
            txtDayofweek.Location = new Point(230, 36);
            txtDayofweek.Name = "txtDayofweek";
            txtDayofweek.Size = new Size(152, 35);
            txtDayofweek.TabIndex = 4;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Microsoft JhengHei UI", 16F);
            txtDate.Location = new Point(230, 118);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(152, 35);
            txtDate.TabIndex = 5;
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Microsoft JhengHei UI", 16F);
            txtMonth.Location = new Point(230, 213);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(152, 35);
            txtMonth.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Microsoft JhengHei UI", 16F);
            txtYear.Location = new Point(230, 306);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(152, 35);
            txtYear.TabIndex = 7;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 10F);
            lblShow.Location = new Point(145, 360);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(309, 72);
            lblShow.TabIndex = 8;
            lblShow.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnShowday
            // 
            btnShowday.Location = new Point(75, 474);
            btnShowday.Name = "btnShowday";
            btnShowday.Size = new Size(104, 56);
            btnShowday.TabIndex = 9;
            btnShowday.Text = "顯示完整日期";
            btnShowday.UseVisualStyleBackColor = true;
            btnShowday.Click += btnShowday_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(248, 474);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 56);
            btnClear.TabIndex = 10;
            btnClear.Text = "清空內容";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(418, 474);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 56);
            btnExit.TabIndex = 11;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 607);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnShowday);
            Controls.Add(lblShow);
            Controls.Add(txtYear);
            Controls.Add(txtMonth);
            Controls.Add(txtDate);
            Controls.Add(txtDayofweek);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox txtDayofweek;
        private TextBox txtDate;
        private TextBox txtMonth;
        private TextBox txtYear;
        private Label lblShow;
        private Button btnShowday;
        private Button btnClear;
        private Button btnExit;
    }
}
