namespace Tutorial2_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ptxfront = new PictureBox();
            ptxback = new PictureBox();
            showfront = new Button();
            showback = new Button();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxback).BeginInit();
            SuspendLayout();
            // 
            // ptxfront
            // 
            ptxfront.Image = (Image)resources.GetObject("ptxfront.Image");
            ptxfront.Location = new Point(468, 49);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(219, 162);
            ptxfront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxfront.TabIndex = 0;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            // 
            // ptxback
            // 
            ptxback.Image = (Image)resources.GetObject("ptxback.Image");
            ptxback.Location = new Point(122, 49);
            ptxback.Name = "ptxback";
            ptxback.Size = new Size(219, 162);
            ptxback.SizeMode = PictureBoxSizeMode.Zoom;
            ptxback.TabIndex = 1;
            ptxback.TabStop = false;
            ptxback.Visible = false;
            // 
            // showfront
            // 
            showfront.Location = new Point(497, 277);
            showfront.Name = "showfront";
            showfront.Size = new Size(143, 59);
            showfront.TabIndex = 2;
            showfront.Text = "正面";
            showfront.UseVisualStyleBackColor = true;
            showfront.Click += showfront_Click;
            // 
            // showback
            // 
            showback.Location = new Point(168, 277);
            showback.Name = "showback";
            showback.Size = new Size(143, 59);
            showback.TabIndex = 3;
            showback.Text = "背面";
            showback.UseVisualStyleBackColor = true;
            showback.Click += showback_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Microsoft JhengHei UI", 16F);
            exit.Location = new Point(248, 426);
            exit.Name = "exit";
            exit.Size = new Size(300, 92);
            exit.TabIndex = 4;
            exit.Text = "離開";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 712);
            Controls.Add(exit);
            Controls.Add(showback);
            Controls.Add(showfront);
            Controls.Add(ptxback);
            Controls.Add(ptxfront);
            Font = new Font("Microsoft JhengHei UI", 9F);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxback).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxfront;
        private PictureBox ptxback;
        private Button showfront;
        private Button showback;
        private Button exit;
    }
}
