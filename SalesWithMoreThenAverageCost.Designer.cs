
namespace WindowsFormsApp1
{
    partial class SalesWithMoreThenAverageCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesWithMoreThenAverageCost));
            this.travelAgencyDataSet = new WindowsFormsApp1.TravelAgencyDataSet();
            this.salesWithMoreThenAverageCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesWithMoreThenAverageCostTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.SalesWithMoreThenAverageCostTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.clientsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.ClientsTableAdapter();
            this.toursTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.ToursTableAdapter();
            this.travelAgentsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TravelAgentsTableAdapter();
            this.salesWithMoreThenAverageCostDataGridView = new System.Windows.Forms.DataGridView();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelAgentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesWithMoreThenAverageCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesWithMoreThenAverageCostDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesWithMoreThenAverageCostBindingSource
            // 
            this.salesWithMoreThenAverageCostBindingSource.DataMember = "SalesWithMoreThenAverageCost";
            this.salesWithMoreThenAverageCostBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // salesWithMoreThenAverageCostTableAdapter
            // 
            this.salesWithMoreThenAverageCostTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.HotelsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.ToursTableAdapter = this.toursTableAdapter;
            this.tableAdapterManager.TravelAgentsTableAdapter = this.travelAgentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // travelAgentsTableAdapter
            // 
            this.travelAgentsTableAdapter.ClearBeforeFill = true;
            // 
            // salesWithMoreThenAverageCostDataGridView
            // 
            this.salesWithMoreThenAverageCostDataGridView.AllowUserToAddRows = false;
            this.salesWithMoreThenAverageCostDataGridView.AllowUserToDeleteRows = false;
            this.salesWithMoreThenAverageCostDataGridView.AutoGenerateColumns = false;
            this.salesWithMoreThenAverageCostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesWithMoreThenAverageCostDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2,
            this.Column3,
            this.dataGridViewTextBoxColumn6});
            this.salesWithMoreThenAverageCostDataGridView.DataSource = this.salesWithMoreThenAverageCostBindingSource;
            this.salesWithMoreThenAverageCostDataGridView.Location = new System.Drawing.Point(12, 39);
            this.salesWithMoreThenAverageCostDataGridView.Name = "salesWithMoreThenAverageCostDataGridView";
            this.salesWithMoreThenAverageCostDataGridView.ReadOnly = true;
            this.salesWithMoreThenAverageCostDataGridView.Size = new System.Drawing.Size(670, 220);
            this.salesWithMoreThenAverageCostDataGridView.TabIndex = 1;
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
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Продажи выше средней выручки за продажи";
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
            // Column3
            // 
            this.Column3.DataPropertyName = "ClientId";
            this.Column3.DataSource = this.clientsBindingSource;
            this.Column3.DisplayMember = "PassportID";
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column3.FillWeight = 140F;
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column3.HeaderText = "№ паспортп клиента";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.ValueMember = "ClientId";
            this.Column3.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // SalesWithMoreThenAverageCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesWithMoreThenAverageCostDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesWithMoreThenAverageCost";
            this.Text = "Продажи выше средней выручки за продажи";
            this.Load += new System.EventHandler(this.SalesWithMoreThenAverageCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesWithMoreThenAverageCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesWithMoreThenAverageCostDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource salesWithMoreThenAverageCostBindingSource;
        private TravelAgencyDataSetTableAdapters.SalesWithMoreThenAverageCostTableAdapter salesWithMoreThenAverageCostTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView salesWithMoreThenAverageCostDataGridView;
        private TravelAgencyDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private TravelAgencyDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private TravelAgencyDataSetTableAdapters.TravelAgentsTableAdapter travelAgentsTableAdapter;
        private System.Windows.Forms.BindingSource travelAgentsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}