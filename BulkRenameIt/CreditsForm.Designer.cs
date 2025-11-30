namespace BulkRenameIt
{
    partial class CreditsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            siteLinkLbl = new LinkLabel();
            label2 = new Label();
            closeBtn = new Button();
            label3 = new Label();
            versionLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 25);
            label1.TabIndex = 0;
            label1.Text = "BulkRenameIt";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bulkrenameit;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 160);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // siteLinkLbl
            // 
            siteLinkLbl.AutoSize = true;
            siteLinkLbl.Location = new Point(179, 49);
            siteLinkLbl.Name = "siteLinkLbl";
            siteLinkLbl.Size = new Size(97, 15);
            siteLinkLbl.TabIndex = 2;
            siteLinkLbl.TabStop = true;
            siteLinkLbl.Text = "PaulDemers.com";
            siteLinkLbl.LinkClicked += siteLinkLbl_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 34);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 3;
            label2.Text = "Created By: Paul Demers";
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeBtn.Location = new Point(328, 145);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(76, 23);
            closeBtn.TabIndex = 4;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 138);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 5;
            label3.Text = ".Net 10 Updated 2025\r\nOriginally Developed 2020";
            // 
            // versionLbl
            // 
            versionLbl.AutoSize = true;
            versionLbl.Location = new Point(179, 123);
            versionLbl.Name = "versionLbl";
            versionLbl.Size = new Size(37, 15);
            versionLbl.TabIndex = 6;
            versionLbl.Text = "v1.0.1";
            // 
            // CreditsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 180);
            Controls.Add(versionLbl);
            Controls.Add(label3);
            Controls.Add(closeBtn);
            Controls.Add(label2);
            Controls.Add(siteLinkLbl);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreditsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BulkRenameIt - About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PictureBox pictureBox1;
        private LinkLabel siteLinkLbl;
        private Label label2;
        private Button closeBtn;
        private Label label3;
        private Label versionLbl;
    }
}