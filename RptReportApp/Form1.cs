using System;
using System.Collections;
using System.Windows.Forms;

namespace RptReportApp
{

    class HardDrive
    {
        private string model = null;
        private string type = null;
        private string serialNo = null;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList hardDriveDetails = new ArrayList();

        private string identifier(string wmiClass, string wmiProperty)
        //Return a hardware identifier
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }

        private bool ValidHD()
        {
            string SerialNo = identifier("Win32_DiskDrive", "SerialNumber");

            //0100_0000_0000_0000_8CE3_8E04_0070_69A9. Test
            //588ZCE71T
            if (SerialNo.Trim() == "588ZCE71T")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            if (ValidHD() != true)
            {
                MessageBox.Show("Sorry, this machine is not licensed!!!");
                Environment.Exit(0);
            }


            this.datasTableAdapter.Fill(this.data.Datas, DateTime.Now.AddDays(-60), DateTime.Now);
            this.rptOverview.RefreshReport();
            Data.DatasDataTable companyData = new Data.DatasDataTable();
            Data.DatasDataTable hospitalData = new Data.DatasDataTable();
            this.datasTableAdapter.FillCompany(companyData);
            this.datasTableAdapter.FillHospital(hospitalData);


            //this.datasTableAdapter.Fill(this.data.Datas);

            this.cmbCompanies.DataSource = companyData;
            this.cmbCompanies.DisplayMember = "Company";
            this.cmbCompanies.ValueMember = "Company";

            this.cmbHospital.DataSource = hospitalData;
            this.cmbHospital.DisplayMember = "Hospital";
            this.cmbHospital.ValueMember = "Hospital";

            this.rptMain.RefreshReport();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpload frm = new frmUpload();
            frm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.datasTableAdapter.Delete();
            Environment.Exit(0);
        }

        private void cmbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.datasTableAdapter.ClearBeforeFill = true;
            this.datasTableAdapter.FillByCompanyDetails(this.data.Datas, dteCompanyFrom.Value, dteCompanyTo.Value, cmbCompanies.SelectedValue.ToString());
            this.rptMain.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadOverview_Click(object sender, EventArgs e)
        {
            this.datasTableAdapter.ClearBeforeFill = true;
            this.datasTableAdapter.Fill(this.data.Datas, dteFromDateOverview.Value, dteToDateOverview.Value);
            this.rptOverview.RefreshReport();
        }

        private void btnLoadEnrollee_Click(object sender, EventArgs e)
        {
            this.datasTableAdapter.ClearBeforeFill = true;

            this.datasTableAdapter.FillByEnrolleeNumber(this.data.Datas, dteFromEnrollee.Value, dteToEnrollee.Value, txtEnrolleeNumber.Text);
            this.rptEnrollee.RefreshReport();

        }

        private void btnLoadProvider_Click(object sender, EventArgs e)
        {
            this.datasTableAdapter.ClearBeforeFill = true;
            this.datasTableAdapter.FillByHospital(this.data.Datas, dteFromProvider.Value, dteToProvider.Value, cmbHospital.SelectedValue.ToString());
            this.rptProvider.RefreshReport();
        }
    }
}
