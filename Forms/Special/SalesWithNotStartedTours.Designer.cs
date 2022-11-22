
namespace WindowsFormsApp1
{
    partial class SalesWithNotStartedTours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesWithNotStartedTours));
            this.travelAgencyDataSet = new WindowsFormsApp1.TravelAgencyDataSet();
            this.getSalesWithNotStartedToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getSalesWithNotStartedToursTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.GetSalesWithNotStartedToursTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.clientsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.ClientsTableAdapter();
            this.hotelsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.HotelsTableAdapter();
            this.toursTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.ToursTableAdapter();
            this.travelAgentsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TravelAgentsTableAdapter();
            this.getSalesWithNotStartedToursDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.travelAgentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesWithNotStartedToursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesWithNotStartedToursDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getSalesWithNotStartedToursBindingSource
            // 
            this.getSalesWithNotStartedToursBindingSource.DataMember = "GetSalesWithNotStartedTours";
            this.getSalesWithNotStartedToursBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // getSalesWithNotStartedToursTableAdapter
            // 
            this.getSalesWithNotStartedToursTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.HotelsTableAdapter = this.hotelsTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.ToursTableAdapter = this.toursTableAdapter;
            this.tableAdapterManager.TravelAgentsTableAdapter = this.travelAgentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // travelAgentsTableAdapter
            // 
            this.travelAgentsTableAdapter.ClearBeforeFill = true;
            // 
            // getSalesWithNotStartedToursDataGridView
            // 
            this.getSalesWithNotStartedToursDataGridView.AllowUserToAddRows = false;
            this.getSalesWithNotStartedToursDataGridView.AllowUserToDeleteRows = false;
            this.getSalesWithNotStartedToursDataGridView.AutoGenerateColumns = false;
            this.getSalesWithNotStartedToursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getSalesWithNotStartedToursDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2,
            this.Column3});
            this.getSalesWithNotStartedToursDataGridView.DataSource = this.getSalesWithNotStartedToursBindingSource;
            this.getSalesWithNotStartedToursDataGridView.Location = new System.Drawing.Point(12, 39);
            this.getSalesWithNotStartedToursDataGridView.Name = "getSalesWithNotStartedToursDataGridView";
            this.getSalesWithNotStartedToursDataGridView.ReadOnly = true;
            this.getSalesWithNotStartedToursDataGridView.Size = new System.Drawing.Size(577, 220);
            this.getSalesWithNotStartedToursDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SaleDate";
            this.dataGridViewTextBoxColumn2.FillWeight = 110F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата продажи";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TourId";
            this.Column1.DataSource = this.toursBindingSource;
            this.Column1.DisplayMember = "Name";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.FillWeight = 110F;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "Название тура";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.ValueMember = "TourId";
            this.Column1.Width = 110;
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            this.toursBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TravelAgentId";
            this.Column2.DataSource = this.travelAgentsBindingSource;
            this.Column2.DisplayMember = "PassportID";
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column2.FillWeight = 150F;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "№ паспорта турагента";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.ValueMember = "TravelAgentId";
            this.Column2.Width = 150;
            // 
            // travelAgentsBindingSource
            // 
            this.travelAgentsBindingSource.DataMember = "TravelAgents";
            this.travelAgentsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ClientId";
            this.Column3.DataSource = this.clientsBindingSource;
            this.Column3.DisplayMember = "PassportID";
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column3.FillWeight = 150F;
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column3.HeaderText = "№ паспорта клиента";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.ValueMember = "ClientId";
            this.Column3.Width = 150;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Продажи, туры которых ещё не начались";
            // 
            // SalesWithNotStartedTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getSalesWithNotStartedToursDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesWithNotStartedTours";
            this.Text = "Продажи, туры которых ещё не начались";
            this.Load += new System.EventHandler(this.SalesWithNotStartedTours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesWithNotStartedToursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesWithNotStartedToursDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource getSalesWithNotStartedToursBindingSource;
        private TravelAgencyDataSetTableAdapters.GetSalesWithNotStartedToursTableAdapter getSalesWithNotStartedToursTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView getSalesWithNotStartedToursDataGridView;
        private TravelAgencyDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private TravelAgencyDataSetTableAdapters.TravelAgentsTableAdapter travelAgentsTableAdapter;
        private System.Windows.Forms.BindingSource travelAgentsBindingSource;
        private TravelAgencyDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private TravelAgencyDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
    }
}