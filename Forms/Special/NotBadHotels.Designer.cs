
namespace WindowsFormsApp1
{
    partial class NotBadHotels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotBadHotels));
            this.travelAgencyDataSet = new WindowsFormsApp1.TravelAgencyDataSet();
            this.notBadHotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notBadHotelsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.NotBadHotelsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.notBadHotelsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBadHotelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBadHotelsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notBadHotelsBindingSource
            // 
            this.notBadHotelsBindingSource.DataMember = "NotBadHotels";
            this.notBadHotelsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // notBadHotelsTableAdapter
            // 
            this.notBadHotelsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.HotelsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.ToursTableAdapter = null;
            this.tableAdapterManager.TravelAgentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notBadHotelsDataGridView
            // 
            this.notBadHotelsDataGridView.AllowUserToAddRows = false;
            this.notBadHotelsDataGridView.AllowUserToDeleteRows = false;
            this.notBadHotelsDataGridView.AutoGenerateColumns = false;
            this.notBadHotelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notBadHotelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.notBadHotelsDataGridView.DataSource = this.notBadHotelsBindingSource;
            this.notBadHotelsDataGridView.Location = new System.Drawing.Point(12, 40);
            this.notBadHotelsDataGridView.Name = "notBadHotelsDataGridView";
            this.notBadHotelsDataGridView.ReadOnly = true;
            this.notBadHotelsDataGridView.Size = new System.Drawing.Size(410, 220);
            this.notBadHotelsDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Отели с 3 и более звёздами";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.FillWeight = 150F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Название";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 40;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn2.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StarsRate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Звёзды";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // NotBadHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notBadHotelsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotBadHotels";
            this.Text = "Неплохие отели";
            this.Load += new System.EventHandler(this.NotBadHotels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBadHotelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBadHotelsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource notBadHotelsBindingSource;
        private TravelAgencyDataSetTableAdapters.NotBadHotelsTableAdapter notBadHotelsTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView notBadHotelsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}