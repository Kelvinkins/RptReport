namespace RptReportApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCompanies = new System.Windows.Forms.ComboBox();
            this.rptMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadOverview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rptOverview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.dteFromDateOverview = new System.Windows.Forms.DateTimePicker();
            this.dteToDateOverview = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dteCompanyFrom = new System.Windows.Forms.DateTimePicker();
            this.dteCompanyTo = new System.Windows.Forms.DateTimePicker();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dteFromEnrollee = new System.Windows.Forms.DateTimePicker();
            this.dteToEnrollee = new System.Windows.Forms.DateTimePicker();
            this.btnLoadEnrollee = new System.Windows.Forms.Button();
            this.rptEnrollee = new Microsoft.Reporting.WinForms.ReportViewer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dteFromProvider = new System.Windows.Forms.DateTimePicker();
            this.dteToProvider = new System.Windows.Forms.DateTimePicker();
            this.btnLoadProvider = new System.Windows.Forms.Button();
            this.rptProvider = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtEnrolleeNumber = new System.Windows.Forms.TextBox();
            this.datasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new RptReportApp.Data();
            this.datasTableAdapter = new RptReportApp.DataTableAdapters.DatasTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 526);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1059, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1059, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profitability By Company";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1059, 497);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profitability By Enrollee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1059, 497);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Profitability By Provider";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rptMain);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 491);
            this.splitContainer1.SplitterDistance = 87;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbCompanies, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dteCompanyFrom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dteCompanyTo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(459, 58);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(185, 33);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);


            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCompanies
            // 
            this.cmbCompanies.FormattingEnabled = true;
            this.cmbCompanies.Location = new System.Drawing.Point(119, 2);
            this.cmbCompanies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCompanies.Name = "cmbCompanies";
            this.cmbCompanies.Size = new System.Drawing.Size(334, 24);
            this.cmbCompanies.TabIndex = 0;
            // 
            // rptMain
            // 
            this.rptMain.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "ProfitDataSet";
            reportDataSource2.Value = this.datasBindingSource;
            this.rptMain.LocalReport.DataSources.Add(reportDataSource2);
            this.rptMain.LocalReport.ReportEmbeddedResource = "RptReportApp.Profitability.rdlc";
            this.rptMain.Location = new System.Drawing.Point(0, 0);
            this.rptMain.Margin = new System.Windows.Forms.Padding(4);
            this.rptMain.Name = "rptMain";
            this.rptMain.Size = new System.Drawing.Size(1053, 399);
            this.rptMain.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rptOverview);
            this.splitContainer2.Size = new System.Drawing.Size(1053, 491);
            this.splitContainer2.SplitterDistance = 56;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 610F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dteFromDateOverview, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dteToDateOverview, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLoadOverview, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1053, 56);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnLoadOverview
            // 
            this.btnLoadOverview.Location = new System.Drawing.Point(446, 30);
            this.btnLoadOverview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadOverview.Name = "btnLoadOverview";
            this.btnLoadOverview.Size = new System.Drawing.Size(185, 28);
            this.btnLoadOverview.TabIndex = 1;
            this.btnLoadOverview.Text = "Load";
            this.btnLoadOverview.UseVisualStyleBackColor = true;
            this.btnLoadOverview.Click += new System.EventHandler(this.btnLoadOverview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Date";
            // 
            // rptOverview
            // 
            this.rptOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProfitDataSet";
            reportDataSource1.Value = this.datasBindingSource;
            this.rptOverview.LocalReport.DataSources.Add(reportDataSource1);
            this.rptOverview.LocalReport.ReportEmbeddedResource = "RptReportApp.Profitability.rdlc";
            this.rptOverview.Location = new System.Drawing.Point(0, 0);
            this.rptOverview.Margin = new System.Windows.Forms.Padding(4);
            this.rptOverview.Name = "rptOverview";
            this.rptOverview.Size = new System.Drawing.Size(1053, 430);
            this.rptOverview.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "To Date";
            // 
            // dteFromDateOverview
            // 
            this.dteFromDateOverview.Location = new System.Drawing.Point(83, 3);
            this.dteFromDateOverview.Name = "dteFromDateOverview";
            this.dteFromDateOverview.Size = new System.Drawing.Size(357, 22);
            this.dteFromDateOverview.TabIndex = 2;
            // 
            // dteToDateOverview
            // 
            this.dteToDateOverview.Location = new System.Drawing.Point(83, 31);
            this.dteToDateOverview.Name = "dteToDateOverview";
            this.dteToDateOverview.Size = new System.Drawing.Size(357, 22);
            this.dteToDateOverview.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "To Date";
            // 
            // dteCompanyFrom
            // 
            this.dteCompanyFrom.Location = new System.Drawing.Point(119, 31);
            this.dteCompanyFrom.Name = "dteCompanyFrom";
            this.dteCompanyFrom.Size = new System.Drawing.Size(334, 22);
            this.dteCompanyFrom.TabIndex = 5;
            // 
            // dteCompanyTo
            // 
            this.dteCompanyTo.Location = new System.Drawing.Point(119, 59);
            this.dteCompanyTo.Name = "dteCompanyTo";
            this.dteCompanyTo.Size = new System.Drawing.Size(334, 22);
            this.dteCompanyTo.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.rptEnrollee);
            this.splitContainer3.Size = new System.Drawing.Size(1059, 497);
            this.splitContainer3.SplitterDistance = 89;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dteFromEnrollee, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dteToEnrollee, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnLoadEnrollee, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtEnrolleeNumber, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1059, 89);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Enrollee No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "From Date";
            // 
            // dteFromEnrollee
            // 
            this.dteFromEnrollee.Location = new System.Drawing.Point(95, 31);
            this.dteFromEnrollee.Name = "dteFromEnrollee";
            this.dteFromEnrollee.Size = new System.Drawing.Size(334, 22);
            this.dteFromEnrollee.TabIndex = 5;
            // 
            // dteToEnrollee
            // 
            this.dteToEnrollee.Location = new System.Drawing.Point(95, 59);
            this.dteToEnrollee.Name = "dteToEnrollee";
            this.dteToEnrollee.Size = new System.Drawing.Size(334, 22);
            this.dteToEnrollee.TabIndex = 6;
            // 
            // btnLoadEnrollee
            // 
            this.btnLoadEnrollee.Location = new System.Drawing.Point(435, 58);
            this.btnLoadEnrollee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadEnrollee.Name = "btnLoadEnrollee";
            this.btnLoadEnrollee.Size = new System.Drawing.Size(185, 33);
            this.btnLoadEnrollee.TabIndex = 1;
            this.btnLoadEnrollee.Text = "Load";
            this.btnLoadEnrollee.UseVisualStyleBackColor = true;
            this.btnLoadEnrollee.Click += new System.EventHandler(this.btnLoadEnrollee_Click);
            // 
            // rptEnrollee
            // 
            this.rptEnrollee.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "ProfitDataSet";
            reportDataSource3.Value = this.datasBindingSource;
            this.rptEnrollee.LocalReport.DataSources.Add(reportDataSource3);
            this.rptEnrollee.LocalReport.ReportEmbeddedResource = "RptReportApp.Profitability.rdlc";
            this.rptEnrollee.Location = new System.Drawing.Point(0, 0);
            this.rptEnrollee.Margin = new System.Windows.Forms.Padding(4);
            this.rptEnrollee.Name = "rptEnrollee";
            this.rptEnrollee.Size = new System.Drawing.Size(1059, 403);
            this.rptEnrollee.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.rptProvider);
            this.splitContainer4.Size = new System.Drawing.Size(1059, 497);
            this.splitContainer4.SplitterDistance = 89;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.cmbHospital, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dteFromProvider, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.dteToProvider, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnLoadProvider, 2, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1059, 89);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "To Date";
            // 
            // cmbHospital
            // 
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Location = new System.Drawing.Point(113, 2);
            this.cmbHospital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(334, 24);
            this.cmbHospital.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Select Provider";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "From Date";
            // 
            // dteFromProvider
            // 
            this.dteFromProvider.Location = new System.Drawing.Point(113, 31);
            this.dteFromProvider.Name = "dteFromProvider";
            this.dteFromProvider.Size = new System.Drawing.Size(334, 22);
            this.dteFromProvider.TabIndex = 5;
            // 
            // dteToProvider
            // 
            this.dteToProvider.Location = new System.Drawing.Point(113, 59);
            this.dteToProvider.Name = "dteToProvider";
            this.dteToProvider.Size = new System.Drawing.Size(334, 22);
            this.dteToProvider.TabIndex = 6;
            // 
            // btnLoadProvider
            // 
            this.btnLoadProvider.Location = new System.Drawing.Point(453, 58);
            this.btnLoadProvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadProvider.Name = "btnLoadProvider";
            this.btnLoadProvider.Size = new System.Drawing.Size(185, 29);
            this.btnLoadProvider.TabIndex = 1;
            this.btnLoadProvider.Text = "Load";
            this.btnLoadProvider.UseVisualStyleBackColor = true;
            this.btnLoadProvider.Click += new System.EventHandler(this.btnLoadProvider_Click);
            // 
            // rptProvider
            // 
            this.rptProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "ProfitDataSet";
            reportDataSource4.Value = this.datasBindingSource;
            this.rptProvider.LocalReport.DataSources.Add(reportDataSource4);
            this.rptProvider.LocalReport.ReportEmbeddedResource = "RptReportApp.Profitability.rdlc";
            this.rptProvider.Location = new System.Drawing.Point(0, 0);
            this.rptProvider.Margin = new System.Windows.Forms.Padding(4);
            this.rptProvider.Name = "rptProvider";
            this.rptProvider.Size = new System.Drawing.Size(1059, 403);
            this.rptProvider.TabIndex = 1;
            // 
            // txtEnrolleeNumber
            // 
            this.txtEnrolleeNumber.Location = new System.Drawing.Point(95, 3);
            this.txtEnrolleeNumber.Name = "txtEnrolleeNumber";
            this.txtEnrolleeNumber.Size = new System.Drawing.Size(334, 22);
            this.txtEnrolleeNumber.TabIndex = 7;
            // 
            // datasBindingSource
            // 
            this.datasBindingSource.DataMember = "Datas";
            this.datasBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datasTableAdapter
            // 
            this.datasTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Rpt Report App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private Data data;
        private System.Windows.Forms.BindingSource datasBindingSource;
        private DataTableAdapters.DatasTableAdapter datasTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dteFromDateOverview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dteToDateOverview;
        private System.Windows.Forms.Button btnLoadOverview;
        private Microsoft.Reporting.WinForms.ReportViewer rptOverview;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cmbCompanies;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rptMain;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dteCompanyFrom;
        private System.Windows.Forms.DateTimePicker dteCompanyTo;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dteFromEnrollee;
        private System.Windows.Forms.DateTimePicker dteToEnrollee;
        private System.Windows.Forms.Button btnLoadEnrollee;
        private Microsoft.Reporting.WinForms.ReportViewer rptEnrollee;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dteFromProvider;
        private System.Windows.Forms.DateTimePicker dteToProvider;
        private System.Windows.Forms.Button btnLoadProvider;
        private Microsoft.Reporting.WinForms.ReportViewer rptProvider;
        private System.Windows.Forms.TextBox txtEnrolleeNumber;
    }
}

