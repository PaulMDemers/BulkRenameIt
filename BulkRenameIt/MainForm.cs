using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkRenameIt
{
    public partial class MainForm : Form
    {
        List<string> files = new List<string>();
        List<Tuple<string, string>> previewFiles = new List<Tuple<string, string>>();


        public MainForm()
        {
            InitializeComponent();
        }

        void ProcessPreview()
        {
            // Determine selected capitalization
            CapMode selectedCapitalization = CapMode.NONE;

            if (noneCapRadio.Checked)
                selectedCapitalization = CapMode.NONE;
            else if (toLowerRadio.Checked)
                selectedCapitalization = CapMode.TOLOWER;
            else if (toUpperRadio.Checked)
                selectedCapitalization = CapMode.TOUPPER;
            else if (titleCaseRadio.Checked)
                selectedCapitalization = CapMode.TITLE;

            previewFiles.Clear();

            int trimStart = (int)begNUD.Value;
            int trimEnd = (int)endNUD.Value;

            if (trimStart < 0) trimStart = 0;
            if (trimEnd < 0) trimEnd = 0;

            foreach (string f in files)
            {
                string dir = Path.GetDirectoryName(f);

                // When including the extension, operate on full file name.
                // When not, operate on just the name and re-attach extension later.
                string name = incExtBox.Checked
                    ? Path.GetFileName(f)
                    : Path.GetFileNameWithoutExtension(f);

                string extension = incExtBox.Checked
                    ? string.Empty
                    : Path.GetExtension(f);

                // Safe trimming
                if (!string.IsNullOrEmpty(name))
                {
                    int availableLength = name.Length - trimStart - trimEnd;

                    if (availableLength <= 0)
                    {
                        name = string.Empty;
                    }
                    else
                    {
                        name = name.Substring(trimStart, availableLength);
                    }
                }

                // Apply capitalization mode to the trimmed name
                name = ApplyCapitalization(name, selectedCapitalization);

                // Build final filename
                string finalName = preBox.Text + name + appBox.Text + extension;

                previewFiles.Add(new Tuple<string, string>(f, Path.Combine(dir, finalName)));
            }
        }

        // Helper for capitalization
        string ApplyCapitalization(string input, CapMode mode)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            switch (mode)
            {
                case CapMode.TOLOWER:
                    return input.ToLowerInvariant();

                case CapMode.TOUPPER:
                    return input.ToUpperInvariant();

                case CapMode.TITLE:
                    // TextInfo.ToTitleCase works best on lowercase input
                    var textInfo = CultureInfo.CurrentCulture.TextInfo;
                    return textInfo.ToTitleCase(input.ToLower());

                case CapMode.NONE:
                default:
                    return input;
            }
        }

        void RefreshListViews()
        {
            bool hidePaths = hidePathCB.Checked;

            originalFilesLV.Items.Clear();
            foreach (string s in files)
            {
                originalFilesLV.Items.Add(hidePaths ? Path.GetFileName(s) : s);
            }

            renameLV.Items.Clear();
            foreach (Tuple<string, string> s in previewFiles)
            {
                renameLV.Items.Add(hidePaths ? Path.GetFileName(s.Item2) : s.Item2);
            }
        }

        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files.AddRange(ofd.FileNames);

                ProcessPreview();
                RefreshListViews();
            }
        }

        private void addDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                files.AddRange(Directory.GetFiles(fbd.SelectedPath));

                ProcessPreview();
                RefreshListViews();
            }
        }

        private void begNUD_ValueChanged(object sender, EventArgs e)
        {
            ProcessPreview();
            RefreshListViews();
        }

        private void endNUD_ValueChanged(object sender, EventArgs e)
        {
            ProcessPreview();
            RefreshListViews();
        }

        private void preBox_TextChanged(object sender, EventArgs e)
        {
            ProcessPreview();
            RefreshListViews();
        }

        private void appBox_TextChanged(object sender, EventArgs e)
        {
            ProcessPreview();
            RefreshListViews();
        }

        private void incExtBox_CheckedChanged(object sender, EventArgs e)
        {
            ProcessPreview();
            RefreshListViews();
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            StartProcess();
            PostProcess();
        }

        private void originalFilesLV_Resize(object sender, EventArgs e)
        {
            originalFilesLV.Columns[0].Width = originalFilesLV.Width - 7;
        }

        private void renameLV_Resize(object sender, EventArgs e)
        {
            renameLV.Columns[0].Width = renameLV.Width - 7;
        }

        private void removeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalFilesLV.SelectedIndices.Count > 0)
            {
                files.RemoveAt(originalFilesLV.SelectedIndices[0]);

                ProcessPreview();
                RefreshListViews();
            }
        }

        private void originalFilesLV_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                removeFileStrip.Show(Cursor.Position);
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProcess();
            PostProcess();
        }

        void StartProcess()
        {
            foreach (Tuple<string, string> tpl in previewFiles)
            {
                int counter = 0;
                while (true)
                {
                    try
                    {
                        if (counter == 0)
                            File.Move(tpl.Item1, tpl.Item2);
                        else
                        {
                            string dir = Path.GetDirectoryName(tpl.Item2);
                            string filename = Path.GetFileNameWithoutExtension(tpl.Item2);
                            string extension = Path.GetExtension(tpl.Item2);

                            File.Move(tpl.Item1, Path.Combine(dir, filename + " (" + counter.ToString() + ")" + extension));
                        }
                        break;
                    }
                    catch (IOException)
                    {
                        counter++;
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

            MessageBox.Show("Rename complete!");
        }

        void PostProcess()
        {
            List<string> newFiles = [];

            foreach (Tuple<string, string> tpl in previewFiles)
            {
                if (File.Exists(tpl.Item2))  //ensure new filename exists
                    newFiles.Add(tpl.Item2);
                else if (File.Exists(tpl.Item1)) //some reason it didn't rename
                    newFiles.Add(tpl.Item1);
                else { }
            }

            files.Clear();
            files.AddRange(newFiles);

            ResetOptions();
        }

        void ResetOptions()
        {
            begNUD.Value = 0;
            endNUD.Value = 0;
            preBox.Text = "";
            appBox.Text = "";
            noneCapRadio.Checked = true;

            RefreshListViews();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditsForm cf = new CreditsForm();

            cf.ShowDialog();
        }

        private void noneCapRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (noneCapRadio.Checked)
            {
                ProcessPreview();
                RefreshListViews();
            }
        }

        private void toLowerRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (toLowerRadio.Checked)
            {
                ProcessPreview();
                RefreshListViews();
            }
        }

        private void toUpperRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (toUpperRadio.Checked)
            {
                ProcessPreview();
                RefreshListViews();
            }
        }

        private void titleCaseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (titleCaseRadio.Checked)
            {
                ProcessPreview();
                RefreshListViews();
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            files.Clear();
            previewFiles.Clear();
            RefreshListViews();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hidePathCB_CheckedChanged(object sender, EventArgs e)
        {
            RefreshListViews();
        }
    }
}
