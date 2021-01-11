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
            // TODO: This line of code loads data into the 'data.Datas' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'data.Datas' table. You can move, or remove it, as needed.
            //this.datasTableAdapter.Fill(this.data.Datas);
            // TODO: This line of code loads data into the 'Data.Datas' table. You can move, or remove it, as needed.
            Data.DatasDataTable companyData = new Data.DatasDataTable();
            //Data.DatasDataTable ProfitablityData = new Data.DatasDataTable();
            this.datasTableAdapter.FillCompany(companyData);

            //this.datasTableAdapter.Fill(this.data.Datas);

            this.cmbCompanies.DataSource = companyData;
            this.cmbCompanies.DisplayMember = "Company";
            this.cmbCompanies.ValueMember = "Company";

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

        private void cmbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbCompanies.SelectedValue==null)
            {
                this.datasTableAdapter.Fill(this.data.Datas, null);
                this.rptMain.RefreshReport();


            }
            else
            {
                this.datasTableAdapter.Fill(this.data.Datas, cmbCompanies.SelectedValue.ToString());
                this.rptMain.RefreshReport();

            }


        }
    }
}
