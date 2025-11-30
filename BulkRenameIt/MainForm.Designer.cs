namespace BulkRenameIt
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox3 = new GroupBox();
            incExtBox = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            appBox = new TextBox();
            preBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            endNUD = new NumericUpDown();
            begNUD = new NumericUpDown();
            processBtn = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addFilesToolStripMenuItem = new ToolStripMenuItem();
            addDirectoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            clearAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            processToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            originalFilesLV = new ListView();
            columnHeader1 = new ColumnHeader();
            renameLV = new ListView();
            columnHeader2 = new ColumnHeader();
            removeFileStrip = new ContextMenuStrip(components);
            removeFileToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            titleCaseRadio = new RadioButton();
            toUpperRadio = new RadioButton();
            toLowerRadio = new RadioButton();
            noneCapRadio = new RadioButton();
            hidePathCB = new CheckBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)endNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)begNUD).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            removeFileStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(incExtBox);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(appBox);
            groupBox3.Controls.Add(preBox);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(endNUD);
            groupBox3.Controls.Add(begNUD);
            groupBox3.Location = new Point(14, 414);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(548, 140);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Trim Operations";
            // 
            // incExtBox
            // 
            incExtBox.AutoSize = true;
            incExtBox.Location = new Point(107, 112);
            incExtBox.Margin = new Padding(4, 3, 4, 3);
            incExtBox.Name = "incExtBox";
            incExtBox.Size = new Size(118, 19);
            incExtBox.TabIndex = 8;
            incExtBox.Text = "Include extension";
            incExtBox.UseVisualStyleBackColor = true;
            incExtBox.CheckedChanged += incExtBox_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 85);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 7;
            label4.Text = "Append:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Prepend:";
            // 
            // appBox
            // 
            appBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            appBox.Location = new Point(107, 82);
            appBox.Margin = new Padding(4, 3, 4, 3);
            appBox.Name = "appBox";
            appBox.Size = new Size(433, 23);
            appBox.TabIndex = 5;
            appBox.TextChanged += appBox_TextChanged;
            // 
            // preBox
            // 
            preBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            preBox.Location = new Point(107, 52);
            preBox.Margin = new Padding(4, 3, 4, 3);
            preBox.Name = "preBox";
            preBox.Size = new Size(433, 23);
            preBox.TabIndex = 4;
            preBox.TextChanged += preBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Trim Ending:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "Trim Beginning:";
            // 
            // endNUD
            // 
            endNUD.Location = new Point(401, 22);
            endNUD.Margin = new Padding(4, 3, 4, 3);
            endNUD.Name = "endNUD";
            endNUD.Size = new Size(140, 23);
            endNUD.TabIndex = 1;
            endNUD.ValueChanged += endNUD_ValueChanged;
            // 
            // begNUD
            // 
            begNUD.Location = new Point(107, 22);
            begNUD.Margin = new Padding(4, 3, 4, 3);
            begNUD.Name = "begNUD";
            begNUD.Size = new Size(140, 23);
            begNUD.TabIndex = 0;
            begNUD.ValueChanged += begNUD_ValueChanged;
            // 
            // processBtn
            // 
            processBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            processBtn.Location = new Point(474, 617);
            processBtn.Margin = new Padding(4, 3, 4, 3);
            processBtn.Name = "processBtn";
            processBtn.Size = new Size(88, 27);
            processBtn.TabIndex = 9;
            processBtn.Text = "Process";
            processBtn.UseVisualStyleBackColor = true;
            processBtn.Click += processBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, processToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(576, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addFilesToolStripMenuItem, addDirectoryToolStripMenuItem, toolStripMenuItem1, clearAllToolStripMenuItem, toolStripMenuItem2, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // addFilesToolStripMenuItem
            // 
            addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            addFilesToolStripMenuItem.Size = new Size(147, 22);
            addFilesToolStripMenuItem.Text = "Add Files";
            addFilesToolStripMenuItem.Click += addFilesToolStripMenuItem_Click;
            // 
            // addDirectoryToolStripMenuItem
            // 
            addDirectoryToolStripMenuItem.Name = "addDirectoryToolStripMenuItem";
            addDirectoryToolStripMenuItem.Size = new Size(147, 22);
            addDirectoryToolStripMenuItem.Text = "Add Directory";
            addDirectoryToolStripMenuItem.Click += addDirectoryToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(144, 6);
            // 
            // clearAllToolStripMenuItem
            // 
            clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            clearAllToolStripMenuItem.Size = new Size(147, 22);
            clearAllToolStripMenuItem.Text = "Clear All";
            clearAllToolStripMenuItem.Click += clearAllToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(144, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(147, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // processToolStripMenuItem
            // 
            processToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem });
            processToolStripMenuItem.Name = "processToolStripMenuItem";
            processToolStripMenuItem.Size = new Size(59, 20);
            processToolStripMenuItem.Text = "Process";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(98, 22);
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(14, 31);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(originalFilesLV);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(renameLV);
            splitContainer1.Size = new Size(548, 352);
            splitContainer1.SplitterDistance = 274;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 4;
            // 
            // originalFilesLV
            // 
            originalFilesLV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            originalFilesLV.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            originalFilesLV.Location = new Point(4, 3);
            originalFilesLV.Margin = new Padding(4, 3, 4, 3);
            originalFilesLV.Name = "originalFilesLV";
            originalFilesLV.Size = new Size(266, 345);
            originalFilesLV.TabIndex = 0;
            originalFilesLV.UseCompatibleStateImageBehavior = false;
            originalFilesLV.View = View.Details;
            originalFilesLV.MouseClick += originalFilesLV_MouseClick;
            originalFilesLV.Resize += originalFilesLV_Resize;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "File";
            columnHeader1.Width = 220;
            // 
            // renameLV
            // 
            renameLV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            renameLV.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            renameLV.Location = new Point(4, 3);
            renameLV.Margin = new Padding(4, 3, 4, 3);
            renameLV.Name = "renameLV";
            renameLV.Size = new Size(249, 345);
            renameLV.TabIndex = 0;
            renameLV.UseCompatibleStateImageBehavior = false;
            renameLV.View = View.Details;
            renameLV.Resize += renameLV_Resize;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "File";
            columnHeader2.Width = 220;
            // 
            // removeFileStrip
            // 
            removeFileStrip.Items.AddRange(new ToolStripItem[] { removeFileToolStripMenuItem });
            removeFileStrip.Name = "removeFileStrip";
            removeFileStrip.Size = new Size(139, 26);
            // 
            // removeFileToolStripMenuItem
            // 
            removeFileToolStripMenuItem.Name = "removeFileToolStripMenuItem";
            removeFileToolStripMenuItem.Size = new Size(138, 22);
            removeFileToolStripMenuItem.Text = "Remove File";
            removeFileToolStripMenuItem.Click += removeFileToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(titleCaseRadio);
            groupBox1.Controls.Add(toUpperRadio);
            groupBox1.Controls.Add(toLowerRadio);
            groupBox1.Controls.Add(noneCapRadio);
            groupBox1.Location = new Point(14, 560);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 51);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Capitalization";
            // 
            // titleCaseRadio
            // 
            titleCaseRadio.AutoSize = true;
            titleCaseRadio.Location = new Point(253, 22);
            titleCaseRadio.Name = "titleCaseRadio";
            titleCaseRadio.Size = new Size(76, 19);
            titleCaseRadio.TabIndex = 3;
            titleCaseRadio.TabStop = true;
            titleCaseRadio.Text = "Title Case";
            titleCaseRadio.UseVisualStyleBackColor = true;
            titleCaseRadio.CheckedChanged += titleCaseRadio_CheckedChanged;
            // 
            // toUpperRadio
            // 
            toUpperRadio.AutoSize = true;
            toUpperRadio.Location = new Point(174, 22);
            toUpperRadio.Name = "toUpperRadio";
            toUpperRadio.Size = new Size(73, 19);
            toUpperRadio.TabIndex = 2;
            toUpperRadio.TabStop = true;
            toUpperRadio.Text = "To Upper";
            toUpperRadio.UseVisualStyleBackColor = true;
            toUpperRadio.CheckedChanged += toUpperRadio_CheckedChanged;
            // 
            // toLowerRadio
            // 
            toLowerRadio.AutoSize = true;
            toLowerRadio.Location = new Point(98, 22);
            toLowerRadio.Name = "toLowerRadio";
            toLowerRadio.Size = new Size(70, 19);
            toLowerRadio.TabIndex = 1;
            toLowerRadio.TabStop = true;
            toLowerRadio.Text = "To lower";
            toLowerRadio.UseVisualStyleBackColor = true;
            toLowerRadio.CheckedChanged += toLowerRadio_CheckedChanged;
            // 
            // noneCapRadio
            // 
            noneCapRadio.AutoSize = true;
            noneCapRadio.Checked = true;
            noneCapRadio.Location = new Point(7, 22);
            noneCapRadio.Name = "noneCapRadio";
            noneCapRadio.Size = new Size(85, 19);
            noneCapRadio.TabIndex = 0;
            noneCapRadio.TabStop = true;
            noneCapRadio.Text = "No Change";
            noneCapRadio.UseVisualStyleBackColor = true;
            noneCapRadio.CheckedChanged += noneCapRadio_CheckedChanged;
            // 
            // hidePathCB
            // 
            hidePathCB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hidePathCB.AutoSize = true;
            hidePathCB.Location = new Point(14, 389);
            hidePathCB.Name = "hidePathCB";
            hidePathCB.Size = new Size(83, 19);
            hidePathCB.TabIndex = 11;
            hidePathCB.Text = "Hide Paths";
            hidePathCB.UseVisualStyleBackColor = true;
            hidePathCB.CheckedChanged += hidePathCB_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 656);
            Controls.Add(hidePathCB);
            Controls.Add(groupBox1);
            Controls.Add(processBtn);
            Controls.Add(splitContainer1);
            Controls.Add(groupBox3);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BulkRenameIt";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)endNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)begNUD).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            removeFileStrip.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDirectoryToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView originalFilesLV;
        private System.Windows.Forms.ListView renameLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.CheckBox incExtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox appBox;
        private System.Windows.Forms.TextBox preBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown endNUD;
        private System.Windows.Forms.NumericUpDown begNUD;
        private System.Windows.Forms.ContextMenuStrip removeFileStrip;
        private System.Windows.Forms.ToolStripMenuItem removeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox groupBox1;
        private RadioButton toUpperRadio;
        private RadioButton toLowerRadio;
        private RadioButton noneCapRadio;
        private RadioButton titleCaseRadio;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem quitToolStripMenuItem;
        private CheckBox hidePathCB;
    }
}

