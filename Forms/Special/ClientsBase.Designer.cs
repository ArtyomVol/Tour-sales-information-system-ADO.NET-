
namespace WindowsFormsApp1
{
    partial class ClientsBase
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsBase));
            this.ClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TravelAgencyDataSet = new WindowsFormsApp1.TravelAgencyDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelAgencyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsBindingSource
            // 
            this.ClientsBindingSource.DataMember = "Clients";
            this.ClientsBindingSource.DataSource = this.TravelAgencyDataSet;
            // 
            // TravelAgencyDataSet
            // 
            this.TravelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.TravelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClientsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ClientBase.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 32);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(631, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClientsTableAdapter
            // 
            this.ClientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.ClientsTableAdapter;
            this.tableAdapterManager.HotelsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.ToursTableAdapter = null;
            this.tableAdapterManager.TravelAgentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "База клиентов";
            // 
            // ClientsBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsBase";
            this.Text = "База клиентов";
            this.Load += new System.EventHandler(this.ClientsBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelAgencyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientsBindingSource;
        private TravelAgencyDataSet TravelAgencyDataSet;
        private TravelAgencyDataSetTableAdapters.ClientsTableAdapter ClientsTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
    }
}