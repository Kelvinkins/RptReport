using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RptReportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Data.Datas' table. You can move, or remove it, as needed.
            this.DatasTableAdapter.Fill(this.Data.Datas);

            this.rptMain.RefreshReport();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpload frm = new frmUpload();
            frm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
