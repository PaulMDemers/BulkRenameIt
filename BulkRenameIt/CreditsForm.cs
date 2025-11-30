using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkRenameIt
{
    public partial class CreditsForm : Form
    {
        public CreditsForm()
        {
            InitializeComponent();
        }

        private void siteLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://pauldemers.com",
                UseShellExecute = true
            });
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
