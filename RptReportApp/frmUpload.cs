//using RptReportApp.DataTableAdapters;
using ExcelDataReader;
using RptReportApp.DataTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RptReportApp
{


    public partial class frmUpload : Form
    {

        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        string sFileName;
        int iRow, iCol = 2;


        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Excel File to Edit";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFileName = openFileDialog1.FileName;
                lblFile.Text = sFileName;
            }
        }

        public List<DataModel> ReadSettlementTss(string path)
        {
            //Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            List<DataModel> listSettlementData = new List<DataModel>();

            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                   

                    do
                    {
                        while (reader.Read())
                        {
                            // reader.GetDouble(0);
                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    var tssTable = result.Tables[0];
                    
                    //read tss data
                    for (int t = 0; t < tssTable.Rows.Count; t++)
                    {
                        try
                        {
                            DataModel data = new DataModel();
                            data.EnrolleeNumber = tssTable.Rows[t][0].ToString();
                            data.Company = tssTable.Rows[t][1].ToString();
                            data.Hospital = tssTable.Rows[t][2].ToString();
                            data.LastName = tssTable.Rows[t][3].ToString();
                            data.OtherName = tssTable.Rows[t][4].ToString();
                            data.Plan = tssTable.Rows[t][5].ToString();
                            try
                            {
                                data.FeeForService = Convert.ToDecimal(tssTable.Rows[t][6].ToString());

                            }
                            catch (Exception ex)
                            {

                            }
                            try
                            {
                                data.Capitation = Convert.ToDecimal(tssTable.Rows[t][7].ToString());
                            }
                            catch (Exception ex)
                            {

                            }
                            try
                            {
                                data.PremiumPerIndividual = Convert.ToDecimal(tssTable.Rows[t][8].ToString());
                            }
                            catch (Exception ex)
                            {

                            }
                            try
                            {
                                data.CommissionPerIndividualPercentage = Convert.ToInt32(tssTable.Rows[t][9].ToString());
                            }
                            catch (Exception ex)
                            {

                            }
                            data.Address1 = tssTable.Rows[t][10].ToString();
                            data.Address2 = tssTable.Rows[t][11].ToString();
                            data.State = tssTable.Rows[t][12].ToString();
                            data.PhoneNumber = tssTable.Rows[t][13].ToString();
                            data.Gender = tssTable.Rows[t][14].ToString();
                            data.Email = tssTable.Rows[t][15].ToString();
                            data.City = tssTable.Rows[t][16].ToString();
                            data.Region = tssTable.Rows[t][17].ToString();
                            try
                            {
                                var rawDate = tssTable.Rows[t][18].ToString();
                                data.Date = Convert.ToDateTime(rawDate);
                            }
                            catch (Exception ex)
                            {

                            }
                            data.SystemDateTime = DateTime.Now;
                            listSettlementData.Add(data);
                        }
                        catch (Exception ex)
                        {

                        }

                    }

                }
            }
            return listSettlementData;

        }



        // GET DATA FROM EXCEL AND POPULATE COMB0 BOX.
        private int readExcel(string sFile)
        {
            int result = 0;
            List<DataModel> dataModels = new List<DataModel>();
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(sFile);           // WORKBOOK TO OPEN THE EXCEL FILE.
            xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];      // NAME OF THE SHEET.

            for (iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)  // START FROM THE SECOND ROW.
            {
                DataModel data = new DataModel();
                if (xlWorkSheet.Cells[iRow, 1].value != null)
                {
                    data.EnrolleeNumber = xlWorkSheet.Cells[iRow, 1].value.ToString();
                }
                else
                {
                    break;
                }

                if (xlWorkSheet.Cells[iRow, 2].value != null)
                {
                    data.Company = xlWorkSheet.Cells[iRow, 2].value.ToString();
                }

                if (xlWorkSheet.Cells[iRow, 3].value != null)
                {
                    data.Hospital = xlWorkSheet.Cells[iRow, 3].value.ToString();
                }

                if (xlWorkSheet.Cells[iRow, 4].value != null)
                {
                    data.LastName = xlWorkSheet.Cells[iRow, 4].value.ToString();
                }


                if (xlWorkSheet.Cells[iRow, 5].value != null)
                {
                    data.OtherName = xlWorkSheet.Cells[iRow, 5].value.ToString();
                }

                if (xlWorkSheet.Cells[iRow, 6].value != null)
                {
                    data.Plan = xlWorkSheet.Cells[iRow, 6].value.ToString();
                }

                if (xlWorkSheet.Cells[iRow, 7].value != null)
                {
                    data.FeeForService = Convert.ToDecimal(xlWorkSheet.Cells[iRow, 7].value);
                }

                if (xlWorkSheet.Cells[iRow, 8].value != null)
                {
                    data.Capitation = Convert.ToDecimal(xlWorkSheet.Cells[iRow, 8].value);
                }

                if (xlWorkSheet.Cells[iRow, 9].value != null)
                {
                    data.PremiumPerIndividual = Convert.ToDecimal(xlWorkSheet.Cells[iRow, 9].value);
                }
 

                if (xlWorkSheet.Cells[iRow, 10].value != null)
                {
                    data.CommissionPerIndividualPercentage = Convert.ToInt32(xlWorkSheet.Cells[iRow, 10].value);
                }


                if (xlWorkSheet.Cells[iRow, 11].value != null)
                {
                    data.Address1 = xlWorkSheet.Cells[iRow, 11].value.ToString();
                }
   

                if (xlWorkSheet.Cells[iRow, 12].value != null)
                {
                    data.Address2 = xlWorkSheet.Cells[iRow, 12].value.ToString();
                }
    

                if (xlWorkSheet.Cells[iRow, 13].value != null)
                {
                    data.State = xlWorkSheet.Cells[iRow, 13].value.ToString();
                }
       

                if (xlWorkSheet.Cells[iRow, 14].value != null)
                {
                    data.PhoneNumber = xlWorkSheet.Cells[iRow, 14].value.ToString();
                }
      

                if (xlWorkSheet.Cells[iRow, 15].value != null)
                {
                    data.Gender = xlWorkSheet.Cells[iRow, 15].value.ToString();
                }
      

                if (xlWorkSheet.Cells[iRow, 16].value != null)
                {
                    data.Email = xlWorkSheet.Cells[iRow, 16].value.ToString();
                }
          

                if (xlWorkSheet.Cells[iRow, 17].value != null)
                {
                    data.City = xlWorkSheet.Cells[iRow, 17].value.ToString();
                }
         
                if (xlWorkSheet.Cells[iRow, 18].value != null)
                {
                    data.Region = xlWorkSheet.Cells[iRow, 18].value.ToString();
                }
           

                if (xlWorkSheet.Cells[iRow, 19].value != null)
                {
                    try
                    {
                        var rawDate= xlWorkSheet.Cells[iRow, 19].value.ToString();
                        data.Date = Convert.ToDateTime(rawDate);
                    }
                    catch (Exception ex)
                    {

                    }
                }



                data.SystemDateTime = DateTime.Now;
                dataModels.Add(data);
            }

            xlWorkBook.Close();
            xlApp.Quit();

            DatasTableAdapter adapter = new DatasTableAdapter();
            foreach (var d in dataModels)
            {
                var r = adapter.Insert(d.EnrolleeNumber, d.Company, d.Hospital, d.LastName, d.OtherName, d.Plan, d.FeeForService, d.Capitation, d.PremiumPerIndividual, d.CommissionPerIndividualPercentage, d.Date, d.Address1, d.Address2, d.State, d.PhoneNumber, d.Gender, d.Email,d.City,d.Region,d.SystemDateTime);
                if (r > 0)
                {
                    result = result + 1;
                }

            }
            return result;
        }
    
        private void btnUpload_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (sFileName.Trim() != "")
            {

                progr.Visible = true;
               var result = ReadSettlementTss(sFileName);
                DatasTableAdapter adapter = new DatasTableAdapter();
                foreach (var d in result)
                {
                    var r = adapter.Insert(d.EnrolleeNumber, d.Company, d.Hospital, d.LastName, d.OtherName, d.Plan, d.FeeForService, d.Capitation, d.PremiumPerIndividual, d.CommissionPerIndividualPercentage, d.Date, d.Address1, d.Address2, d.State, d.PhoneNumber, d.Gender, d.Email, d.City, d.Region, d.SystemDateTime);
                    if (r > 0)
                    {
                        count = count + 1;
                    }

                }
                progr.Visible = false;
                MessageBox.Show($"Uploaded {count} records successfully\nThe program will close so that the data will propagate. \nPlease open it again when it closes.");
                Environment.Exit(0);
       

            }
        }

        public frmUpload()
        {
            InitializeComponent();
        }
    }
}
