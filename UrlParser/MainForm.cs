using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrlParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void parseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<string> raw_urls = Program.SplitToLines(txtInput.Text.ToString());
            Program.ParseUrls(raw_urls);
        }
    }
}
