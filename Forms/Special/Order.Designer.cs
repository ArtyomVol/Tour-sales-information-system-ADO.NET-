
namespace WindowsFormsApp1
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.travelAgencyDataSet = new WindowsFormsApp1.TravelAgencyDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.hotelsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.HotelsTableAdapter();
            this.salesTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.SalesTableAdapter();
            this.toursTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.ToursTableAdapter();
            this.travelAgentsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TravelAgentsTableAdapter();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelAgentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.HotelsTableAdapter = this.hotelsTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.ToursTableAdapter = this.toursTableAdapter;
            this.tableAdapterManager.TravelAgentsTableAdapter = this.travelAgentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // travelAgentsTableAdapter
            // 
            this.travelAgentsTableAdapter.ClearBeforeFill = true;
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            this.toursBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // travelAgentsBindingSource
            // 
            this.travelAgentsBindingSource.DataMember = "TravelAgents";
            this.travelAgentsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.OrderInfo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(635, 330);
            this.reportViewer1.TabIndex = 0;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 336);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private TravelAgencyDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TravelAgencyDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private TravelAgencyDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private TravelAgencyDataSetTableAdapters.TravelAgentsTableAdapter travelAgentsTableAdapter;
        private System.Windows.Forms.BindingSource travelAgentsBindingSource;
        private TravelAgencyDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}