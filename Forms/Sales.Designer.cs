
namespace WindowsFormsApp1
{
    partial class Sales
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
            System.Windows.Forms.Label saleDateLabel;
            System.Windows.Forms.Label tourIdLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label lastNameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.travelAgencyDataSet = new WindowsFormsApp1.TravelAgencyDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.SalesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.salesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.getOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsOfEnterpriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxesViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonInformation = new System.Windows.Forms.ToolStripDropDownButton();
            this.salesPerMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitPerMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesMoreThenAverageCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesWithNotStartedToursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonLists = new System.Windows.Forms.ToolStripDropDownButton();
            this.toursListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.travelaAgentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TravelAgentPassportNumber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.travelAgentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientPassportNumber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordsWorkPanel = new System.Windows.Forms.Panel();
            this.buttonRejectChanges = new System.Windows.Forms.Button();
            this.buttonSaveToBD = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.recordTransactionPanel = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.textBoxesPanel = new System.Windows.Forms.Panel();
            this.TravelAgentComboBox = new System.Windows.Forms.ComboBox();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.TourComboBox = new System.Windows.Forms.ComboBox();
            this.saleDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toursTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.ToursTableAdapter();
            this.hotelsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.HotelsTableAdapter();
            this.clientsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.ClientsTableAdapter();
            this.travelAgentsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TravelAgentsTableAdapter();
            saleDateLabel = new System.Windows.Forms.Label();
            tourIdLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingNavigator)).BeginInit();
            this.salesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.recordsWorkPanel.SuspendLayout();
            this.recordTransactionPanel.SuspendLayout();
            this.textBoxesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saleDateLabel
            // 
            saleDateLabel.AutoSize = true;
            saleDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            saleDateLabel.Location = new System.Drawing.Point(186, 49);
            saleDateLabel.Name = "saleDateLabel";
            saleDateLabel.Size = new System.Drawing.Size(120, 17);
            saleDateLabel.TabIndex = 0;
            saleDateLabel.Text = "Дата продажи:";
            // 
            // tourIdLabel
            // 
            tourIdLabel.AutoSize = true;
            tourIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tourIdLabel.Location = new System.Drawing.Point(182, 75);
            tourIdLabel.Name = "tourIdLabel";
            tourIdLabel.Size = new System.Drawing.Size(124, 17);
            tourIdLabel.TabIndex = 2;
            tourIdLabel.Text = "Название тура:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(104, 129);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(202, 17);
            lastNameLabel.TabIndex = 13;
            lastNameLabel.Text = "Номер паспорта клиента:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel1.Location = new System.Drawing.Point(90, 102);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(216, 17);
            lastNameLabel1.TabIndex = 19;
            lastNameLabel1.Text = "Номер паспорта турагента:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(261, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Продажи";
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.HotelsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.ToursTableAdapter = null;
            this.tableAdapterManager.TravelAgentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesBindingNavigator
            // 
            this.salesBindingNavigator.AddNewItem = null;
            this.salesBindingNavigator.BindingSource = this.salesBindingSource;
            this.salesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salesBindingNavigator.DeleteItem = null;
            this.salesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile,
            this.toolStripDropDownButtonView,
            this.toolStripDropDownButtonInformation,
            this.toolStripDropDownButtonLists,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.salesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.salesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salesBindingNavigator.Name = "salesBindingNavigator";
            this.salesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salesBindingNavigator.Size = new System.Drawing.Size(581, 25);
            this.salesBindingNavigator.TabIndex = 2;
            this.salesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // toolStripDropDownButtonFile
            // 
            this.toolStripDropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getOrderToolStripMenuItem,
            this.resultsOfEnterpriseToolStripMenuItem});
            this.toolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile.Name = "toolStripDropDownButtonFile";
            this.toolStripDropDownButtonFile.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButtonFile.Text = "Файл";
            // 
            // getOrderToolStripMenuItem
            // 
            this.getOrderToolStripMenuItem.Name = "getOrderToolStripMenuItem";
            this.getOrderToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.getOrderToolStripMenuItem.Text = "Получить заказ";
            this.getOrderToolStripMenuItem.Click += new System.EventHandler(this.getOrderToolStripMenuItem_Click);
            // 
            // resultsOfEnterpriseToolStripMenuItem
            // 
            this.resultsOfEnterpriseToolStripMenuItem.Name = "resultsOfEnterpriseToolStripMenuItem";
            this.resultsOfEnterpriseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.resultsOfEnterpriseToolStripMenuItem.Text = "Итоги работы предприятия";
            this.resultsOfEnterpriseToolStripMenuItem.Click += new System.EventHandler(this.resultsOfEnterpriseToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonView
            // 
            this.toolStripDropDownButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableViewToolStripMenuItem,
            this.textBoxesViewToolStripMenuItem});
            this.toolStripDropDownButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonView.Name = "toolStripDropDownButtonView";
            this.toolStripDropDownButtonView.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButtonView.Text = "Вид";
            // 
            // tableViewToolStripMenuItem
            // 
            this.tableViewToolStripMenuItem.Checked = true;
            this.tableViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableViewToolStripMenuItem.Name = "tableViewToolStripMenuItem";
            this.tableViewToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.tableViewToolStripMenuItem.Text = "Таблица";
            this.tableViewToolStripMenuItem.Click += new System.EventHandler(this.tableViewToolStripMenuItem_Click);
            // 
            // textBoxesViewToolStripMenuItem
            // 
            this.textBoxesViewToolStripMenuItem.Name = "textBoxesViewToolStripMenuItem";
            this.textBoxesViewToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.textBoxesViewToolStripMenuItem.Text = "Поля";
            this.textBoxesViewToolStripMenuItem.Click += new System.EventHandler(this.textBoxesViewToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonInformation
            // 
            this.toolStripDropDownButtonInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesPerMonthToolStripMenuItem,
            this.profitPerMonthToolStripMenuItem,
            this.salesMoreThenAverageCostToolStripMenuItem,
            this.salesWithNotStartedToursToolStripMenuItem});
            this.toolStripDropDownButtonInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonInformation.Name = "toolStripDropDownButtonInformation";
            this.toolStripDropDownButtonInformation.Size = new System.Drawing.Size(94, 22);
            this.toolStripDropDownButtonInformation.Text = "Информация";
            // 
            // salesPerMonthToolStripMenuItem
            // 
            this.salesPerMonthToolStripMenuItem.Name = "salesPerMonthToolStripMenuItem";
            this.salesPerMonthToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.salesPerMonthToolStripMenuItem.Text = "Продажи за месяц";
            this.salesPerMonthToolStripMenuItem.Click += new System.EventHandler(this.salesPerMonthToolStripMenuItem_Click);
            // 
            // profitPerMonthToolStripMenuItem
            // 
            this.profitPerMonthToolStripMenuItem.Name = "profitPerMonthToolStripMenuItem";
            this.profitPerMonthToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.profitPerMonthToolStripMenuItem.Text = "Доход за месяц";
            this.profitPerMonthToolStripMenuItem.Click += new System.EventHandler(this.profitPerMonthToolStripMenuItem_Click);
            // 
            // salesMoreThenAverageCostToolStripMenuItem
            // 
            this.salesMoreThenAverageCostToolStripMenuItem.Name = "salesMoreThenAverageCostToolStripMenuItem";
            this.salesMoreThenAverageCostToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.salesMoreThenAverageCostToolStripMenuItem.Text = "Продажи выше средней стоимости";
            this.salesMoreThenAverageCostToolStripMenuItem.Click += new System.EventHandler(this.salesMoreThenAverageCostToolStripMenuItem_Click);
            // 
            // salesWithNotStartedToursToolStripMenuItem
            // 
            this.salesWithNotStartedToursToolStripMenuItem.Name = "salesWithNotStartedToursToolStripMenuItem";
            this.salesWithNotStartedToursToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.salesWithNotStartedToursToolStripMenuItem.Text = "Продажи, туры которых не начались";
            this.salesWithNotStartedToursToolStripMenuItem.Click += new System.EventHandler(this.salesWithNotStartedToursToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonLists
            // 
            this.toolStripDropDownButtonLists.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonLists.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toursListToolStripMenuItem,
            this.clientsListToolStripMenuItem,
            this.travelaAgentsListToolStripMenuItem});
            this.toolStripDropDownButtonLists.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonLists.Name = "toolStripDropDownButtonLists";
            this.toolStripDropDownButtonLists.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButtonLists.Text = "Списки";
            // 
            // toursListToolStripMenuItem
            // 
            this.toursListToolStripMenuItem.Name = "toursListToolStripMenuItem";
            this.toursListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.toursListToolStripMenuItem.Text = "Список туров";
            this.toursListToolStripMenuItem.Click += new System.EventHandler(this.toursListToolStripMenuItem_Click);
            // 
            // clientsListToolStripMenuItem
            // 
            this.clientsListToolStripMenuItem.Name = "clientsListToolStripMenuItem";
            this.clientsListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.clientsListToolStripMenuItem.Text = "Список клиентов";
            this.clientsListToolStripMenuItem.Click += new System.EventHandler(this.clientsListToolStripMenuItem_Click);
            // 
            // travelaAgentsListToolStripMenuItem
            // 
            this.travelaAgentsListToolStripMenuItem.Name = "travelaAgentsListToolStripMenuItem";
            this.travelaAgentsListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.travelaAgentsListToolStripMenuItem.Text = "Список турагентов";
            this.travelaAgentsListToolStripMenuItem.Click += new System.EventHandler(this.travelaAgentsListToolStripMenuItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AllowUserToDeleteRows = false;
            this.salesDataGridView.AutoGenerateColumns = false;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.TourName,
            this.TravelAgentPassportNumber,
            this.ClientPassportNumber});
            this.salesDataGridView.DataSource = this.salesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesDataGridView.Location = new System.Drawing.Point(11, 51);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.Size = new System.Drawing.Size(561, 210);
            this.salesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SaleDate";
            this.dataGridViewTextBoxColumn2.FillWeight = 110F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата продажи";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // TourName
            // 
            this.TourName.DataPropertyName = "TourId";
            this.TourName.DataSource = this.toursBindingSource;
            this.TourName.DisplayMember = "Name";
            this.TourName.FillWeight = 120F;
            this.TourName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TourName.HeaderText = "Название тура";
            this.TourName.Name = "TourName";
            this.TourName.ValueMember = "TourId";
            this.TourName.Width = 120;
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            this.toursBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // TravelAgentPassportNumber
            // 
            this.TravelAgentPassportNumber.DataPropertyName = "TravelAgentId";
            this.TravelAgentPassportNumber.DataSource = this.travelAgentsBindingSource;
            this.TravelAgentPassportNumber.DisplayMember = "PassportID";
            this.TravelAgentPassportNumber.FillWeight = 135F;
            this.TravelAgentPassportNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TravelAgentPassportNumber.HeaderText = "№ паспорта турагента";
            this.TravelAgentPassportNumber.Name = "TravelAgentPassportNumber";
            this.TravelAgentPassportNumber.ValueMember = "TravelAgentId";
            this.TravelAgentPassportNumber.Width = 135;
            // 
            // travelAgentsBindingSource
            // 
            this.travelAgentsBindingSource.DataMember = "TravelAgents";
            this.travelAgentsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // ClientPassportNumber
            // 
            this.ClientPassportNumber.DataPropertyName = "ClientId";
            this.ClientPassportNumber.DataSource = this.clientsBindingSource;
            this.ClientPassportNumber.DisplayMember = "PassportID";
            this.ClientPassportNumber.DropDownWidth = 10;
            this.ClientPassportNumber.FillWeight = 135F;
            this.ClientPassportNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientPassportNumber.HeaderText = "№ паспорта клиента";
            this.ClientPassportNumber.Name = "ClientPassportNumber";
            this.ClientPassportNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientPassportNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClientPassportNumber.ValueMember = "ClientId";
            this.ClientPassportNumber.Width = 135;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // recordsWorkPanel
            // 
            this.recordsWorkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recordsWorkPanel.Controls.Add(this.buttonRejectChanges);
            this.recordsWorkPanel.Controls.Add(this.buttonSaveToBD);
            this.recordsWorkPanel.Controls.Add(this.buttonAddRecord);
            this.recordsWorkPanel.Controls.Add(this.label3);
            this.recordsWorkPanel.Controls.Add(this.buttonDeleteRecord);
            this.recordsWorkPanel.Location = new System.Drawing.Point(208, 267);
            this.recordsWorkPanel.Name = "recordsWorkPanel";
            this.recordsWorkPanel.Size = new System.Drawing.Size(293, 78);
            this.recordsWorkPanel.TabIndex = 19;
            // 
            // buttonRejectChanges
            // 
            this.buttonRejectChanges.Location = new System.Drawing.Point(77, 49);
            this.buttonRejectChanges.Name = "buttonRejectChanges";
            this.buttonRejectChanges.Size = new System.Drawing.Size(125, 23);
            this.buttonRejectChanges.TabIndex = 11;
            this.buttonRejectChanges.Text = "О&тменить изменения";
            this.buttonRejectChanges.UseVisualStyleBackColor = true;
            this.buttonRejectChanges.Click += new System.EventHandler(this.buttonRejectChanges_Click);
            // 
            // buttonSaveToBD
            // 
            this.buttonSaveToBD.Location = new System.Drawing.Point(188, 23);
            this.buttonSaveToBD.Name = "buttonSaveToBD";
            this.buttonSaveToBD.Size = new System.Drawing.Size(96, 23);
            this.buttonSaveToBD.TabIndex = 9;
            this.buttonSaveToBD.Text = "Сохранить в БД";
            this.buttonSaveToBD.UseVisualStyleBackColor = true;
            this.buttonSaveToBD.Click += new System.EventHandler(this.buttonSaveToBD_Click);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(97, 23);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(85, 23);
            this.buttonAddRecord.TabIndex = 8;
            this.buttonAddRecord.Text = "Удалить";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Работа с записям";
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.Location = new System.Drawing.Point(6, 23);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(85, 23);
            this.buttonDeleteRecord.TabIndex = 6;
            this.buttonDeleteRecord.Text = "Добавить";
            this.buttonDeleteRecord.UseVisualStyleBackColor = true;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // recordTransactionPanel
            // 
            this.recordTransactionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recordTransactionPanel.Controls.Add(this.buttonNext);
            this.recordTransactionPanel.Controls.Add(this.buttonPrevious);
            this.recordTransactionPanel.Controls.Add(this.buttonLast);
            this.recordTransactionPanel.Controls.Add(this.label2);
            this.recordTransactionPanel.Controls.Add(this.buttonFirst);
            this.recordTransactionPanel.Location = new System.Drawing.Point(12, 267);
            this.recordTransactionPanel.Name = "recordTransactionPanel";
            this.recordTransactionPanel.Size = new System.Drawing.Size(190, 78);
            this.recordTransactionPanel.TabIndex = 18;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(97, 49);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(85, 23);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Следующая";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(6, 49);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(85, 23);
            this.buttonPrevious.TabIndex = 9;
            this.buttonPrevious.Text = "Предыдущая";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(97, 20);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(85, 23);
            this.buttonLast.TabIndex = 8;
            this.buttonLast.Text = "Последняя";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Переход по записям";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(6, 20);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(85, 23);
            this.buttonFirst.TabIndex = 6;
            this.buttonFirst.Text = "Первая";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // textBoxesPanel
            // 
            this.textBoxesPanel.Controls.Add(this.TravelAgentComboBox);
            this.textBoxesPanel.Controls.Add(this.ClientComboBox);
            this.textBoxesPanel.Controls.Add(this.TourComboBox);
            this.textBoxesPanel.Controls.Add(lastNameLabel1);
            this.textBoxesPanel.Controls.Add(lastNameLabel);
            this.textBoxesPanel.Controls.Add(tourIdLabel);
            this.textBoxesPanel.Controls.Add(saleDateLabel);
            this.textBoxesPanel.Controls.Add(this.saleDateDateTimePicker);
            this.textBoxesPanel.Location = new System.Drawing.Point(11, 51);
            this.textBoxesPanel.Name = "textBoxesPanel";
            this.textBoxesPanel.Size = new System.Drawing.Size(561, 210);
            this.textBoxesPanel.TabIndex = 21;
            this.textBoxesPanel.Visible = false;
            // 
            // TravelAgentComboBox
            // 
            this.TravelAgentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TravelAgentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TravelAgentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "TravelAgentId", true));
            this.TravelAgentComboBox.DataSource = this.travelAgentsBindingSource;
            this.TravelAgentComboBox.DisplayMember = "PassportID";
            this.TravelAgentComboBox.FormattingEnabled = true;
            this.TravelAgentComboBox.Location = new System.Drawing.Point(310, 100);
            this.TravelAgentComboBox.Name = "TravelAgentComboBox";
            this.TravelAgentComboBox.Size = new System.Drawing.Size(130, 21);
            this.TravelAgentComboBox.TabIndex = 31;
            this.TravelAgentComboBox.ValueMember = "TravelAgentId";
            this.TravelAgentComboBox.Leave += new System.EventHandler(this.TravelAgentComboBox_Leave);
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClientComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "ClientId", true));
            this.ClientComboBox.DataSource = this.clientsBindingSource;
            this.ClientComboBox.DisplayMember = "PassportID";
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(310, 127);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(131, 21);
            this.ClientComboBox.TabIndex = 30;
            this.ClientComboBox.ValueMember = "ClientId";
            this.ClientComboBox.Leave += new System.EventHandler(this.ClientComboBox_Leave);
            // 
            // TourComboBox
            // 
            this.TourComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TourComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TourComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "TourId", true));
            this.TourComboBox.DataSource = this.toursBindingSource;
            this.TourComboBox.DisplayMember = "Name";
            this.TourComboBox.FormattingEnabled = true;
            this.TourComboBox.Location = new System.Drawing.Point(310, 73);
            this.TourComboBox.Name = "TourComboBox";
            this.TourComboBox.Size = new System.Drawing.Size(131, 21);
            this.TourComboBox.TabIndex = 29;
            this.TourComboBox.ValueMember = "TourId";
            this.TourComboBox.Leave += new System.EventHandler(this.TourComboBox_Leave);
            // 
            // saleDateDateTimePicker
            // 
            this.saleDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesBindingSource, "SaleDate", true));
            this.saleDateDateTimePicker.Location = new System.Drawing.Point(310, 47);
            this.saleDateDateTimePicker.Name = "saleDateDateTimePicker";
            this.saleDateDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.saleDateDateTimePicker.TabIndex = 1;
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // travelAgentsTableAdapter
            // 
            this.travelAgentsTableAdapter.ClearBeforeFill = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 351);
            this.Controls.Add(this.recordsWorkPanel);
            this.Controls.Add(this.recordTransactionPanel);
            this.Controls.Add(this.salesBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesDataGridView);
            this.Controls.Add(this.textBoxesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales";
            this.Text = "Продажи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sales_FormClosing);
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingNavigator)).EndInit();
            this.salesBindingNavigator.ResumeLayout(false);
            this.salesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.recordsWorkPanel.ResumeLayout(false);
            this.recordsWorkPanel.PerformLayout();
            this.recordTransactionPanel.ResumeLayout(false);
            this.recordTransactionPanel.PerformLayout();
            this.textBoxesPanel.ResumeLayout(false);
            this.textBoxesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private TravelAgencyDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator salesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Panel recordsWorkPanel;
        private System.Windows.Forms.Button buttonSaveToBD;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.Panel recordTransactionPanel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonRejectChanges;
        private System.Windows.Forms.Panel textBoxesPanel;
        public System.Windows.Forms.DateTimePicker saleDateDateTimePicker;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private TravelAgencyDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private TravelAgencyDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private TravelAgencyDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource travelAgentsBindingSource;
        private TravelAgencyDataSetTableAdapters.TravelAgentsTableAdapter travelAgentsTableAdapter;
        public System.Windows.Forms.ComboBox TourComboBox;
        public System.Windows.Forms.ComboBox TravelAgentComboBox;
        public System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonView;
        private System.Windows.Forms.ToolStripMenuItem tableViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBoxesViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem getOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonInformation;
        private System.Windows.Forms.ToolStripMenuItem salesPerMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profitPerMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesMoreThenAverageCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesWithNotStartedToursToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonLists;
        private System.Windows.Forms.ToolStripMenuItem toursListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem travelaAgentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsOfEnterpriseToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn TourName;
        private System.Windows.Forms.DataGridViewComboBoxColumn TravelAgentPassportNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn ClientPassportNumber;
    }
}