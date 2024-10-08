namespace Textboxdemo
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
            btnconfirm = new Button();
            txtfirstname = new TextBox();
            txtlastname = new TextBox();
            lblshow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(178, 34);
            label1.Name = "label1";
            label1.Size = new Size(152, 35);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F);
            label2.Location = new Point(180, 144);
            label2.Name = "label2";
            label2.Size = new Size(150, 35);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F);
            label3.Location = new Point(178, 251);
            label3.Name = "label3";
            label3.Size = new Size(143, 35);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // btnconfirm
            // 
            btnconfirm.Font = new Font("Microsoft JhengHei UI", 20F);
            btnconfirm.Location = new Point(317, 370);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(169, 68);
            btnconfirm.TabIndex = 3;
            btnconfirm.Text = "confirm";
            btnconfirm.UseVisualStyleBackColor = true;
            btnconfirm.Click += btnconfirm_Click;
            // 
            // txtfirstname
            // 
            txtfirstname.Font = new Font("Microsoft JhengHei UI", 20F);
            txtfirstname.Location = new Point(364, 34);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(192, 41);
            txtfirstname.TabIndex = 4;
            // 
            // txtlastname
            // 
            txtlastname.Font = new Font("Microsoft JhengHei UI", 20F);
            txtlastname.Location = new Point(364, 144);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(192, 41);
            txtlastname.TabIndex = 5;
            // 
            // lblshow
            // 
            lblshow.AutoSize = true;
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 20F);
            lblshow.Location = new Point(351, 251);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(83, 37);
            lblshow.TabIndex = 6;
            lblshow.Text = "show";
            lblshow.Click += lblshow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblshow);
            Controls.Add(txtlastname);
            Controls.Add(txtfirstname);
            Controls.Add(btnconfirm);
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
        private Button btnconfirm;
        private TextBox txtfirstname;
        private TextBox txtlastname;
        private Label lblshow;
    }
}
