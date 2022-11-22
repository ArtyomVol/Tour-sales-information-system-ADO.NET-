
namespace WindowsFormsApp1
{
    partial class Tours
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
            System.Windows.Forms.Label beginDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tours));
            this.label1 = new System.Windows.Forms.Label();
            this.travelAgencyDataSet = new WindowsFormsApp1.TravelAgencyDataSet();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toursTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.ToursTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.toursBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButtonView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxesViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonInformation = new System.Windows.Forms.ToolStripDropDownButton();
            this.toursByHotelNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unfineshedToursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonLists = new System.Windows.Forms.ToolStripDropDownButton();
            this.hotelsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRejectChanges = new System.Windows.Forms.Button();
            this.buttonSaveToBD = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.HotelsTableAdapter();
            this.textBoxesPanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.beginDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toursDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            beginDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingNavigator)).BeginInit();
            this.toursBindingNavigator.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            this.textBoxesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // beginDateLabel
            // 
            beginDateLabel.AutoSize = true;
            beginDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            beginDateLabel.Location = new System.Drawing.Point(179, 99);
            beginDateLabel.Name = "beginDateLabel";
            beginDateLabel.Size = new System.Drawing.Size(110, 17);
            beginDateLabel.TabIndex = 0;
            beginDateLabel.Text = "Дата начала:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endDateLabel.Location = new System.Drawing.Point(153, 125);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(136, 17);
            endDateLabel.TabIndex = 2;
            endDateLabel.Text = "Дата окончания:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(197, 151);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(92, 17);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Стоимость:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(155, 71);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(134, 17);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Название отеля:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel1.Location = new System.Drawing.Point(165, 46);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(124, 17);
            nameLabel1.TabIndex = 9;
            nameLabel1.Text = "Название тура:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Туры";
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            this.toursBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.HotelsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.ToursTableAdapter = this.toursTableAdapter;
            this.tableAdapterManager.TravelAgentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // toursBindingNavigator
            // 
            this.toursBindingNavigator.AddNewItem = null;
            this.toursBindingNavigator.BindingSource = this.toursBindingSource;
            this.toursBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.toursBindingNavigator.DeleteItem = null;
            this.toursBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toursBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.toursBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.toursBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.toursBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.toursBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.toursBindingNavigator.Name = "toursBindingNavigator";
            this.toursBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.toursBindingNavigator.Size = new System.Drawing.Size(670, 25);
            this.toursBindingNavigator.TabIndex = 3;
            this.toursBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.toursByHotelNameToolStripMenuItem,
            this.unfineshedToursToolStripMenuItem});
            this.toolStripDropDownButtonInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonInformation.Name = "toolStripDropDownButtonInformation";
            this.toolStripDropDownButtonInformation.Size = new System.Drawing.Size(94, 22);
            this.toolStripDropDownButtonInformation.Text = "Информация";
            // 
            // toursByHotelNameToolStripMenuItem
            // 
            this.toursByHotelNameToolStripMenuItem.Name = "toursByHotelNameToolStripMenuItem";
            this.toursByHotelNameToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.toursByHotelNameToolStripMenuItem.Text = "Туры по названию отеля";
            this.toursByHotelNameToolStripMenuItem.Click += new System.EventHandler(this.toursByHotelNameToolStripMenuItem_Click);
            // 
            // unfineshedToursToolStripMenuItem
            // 
            this.unfineshedToursToolStripMenuItem.Name = "unfineshedToursToolStripMenuItem";
            this.unfineshedToursToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.unfineshedToursToolStripMenuItem.Text = "Незавершённые туры";
            this.unfineshedToursToolStripMenuItem.Click += new System.EventHandler(this.unfineshedToursToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonLists
            // 
            this.toolStripDropDownButtonLists.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonLists.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelsListToolStripMenuItem});
            this.toolStripDropDownButtonLists.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonLists.Name = "toolStripDropDownButtonLists";
            this.toolStripDropDownButtonLists.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButtonLists.Text = "Списки";
            // 
            // hotelsListToolStripMenuItem
            // 
            this.hotelsListToolStripMenuItem.Name = "hotelsListToolStripMenuItem";
            this.hotelsListToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hotelsListToolStripMenuItem.Text = "Список отелей";
            this.hotelsListToolStripMenuItem.Click += new System.EventHandler(this.hotelsListToolStripMenuItem_Click);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonRejectChanges);
            this.panel2.Controls.Add(this.buttonSaveToBD);
            this.panel2.Controls.Add(this.buttonAddRecord);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonDeleteRecord);
            this.panel2.Location = new System.Drawing.Point(208, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 78);
            this.panel2.TabIndex = 17;
            // 
            // buttonRejectChanges
            // 
            this.buttonRejectChanges.Location = new System.Drawing.Point(77, 49);
            this.buttonRejectChanges.Name = "buttonRejectChanges";
            this.buttonRejectChanges.Size = new System.Drawing.Size(125, 23);
            this.buttonRejectChanges.TabIndex = 13;
            this.buttonRejectChanges.Text = "Отменить изменения";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Controls.Add(this.buttonLast);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonFirst);
            this.panel1.Location = new System.Drawing.Point(12, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 78);
            this.panel1.TabIndex = 16;
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
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxesPanel
            // 
            this.textBoxesPanel.Controls.Add(nameLabel1);
            this.textBoxesPanel.Controls.Add(this.nameTextBox);
            this.textBoxesPanel.Controls.Add(this.comboBox1);
            this.textBoxesPanel.Controls.Add(nameLabel);
            this.textBoxesPanel.Controls.Add(priceLabel);
            this.textBoxesPanel.Controls.Add(this.priceTextBox);
            this.textBoxesPanel.Controls.Add(endDateLabel);
            this.textBoxesPanel.Controls.Add(this.endDateDateTimePicker);
            this.textBoxesPanel.Controls.Add(beginDateLabel);
            this.textBoxesPanel.Controls.Add(this.beginDateDateTimePicker);
            this.textBoxesPanel.Location = new System.Drawing.Point(12, 52);
            this.textBoxesPanel.Name = "textBoxesPanel";
            this.textBoxesPanel.Size = new System.Drawing.Size(648, 220);
            this.textBoxesPanel.TabIndex = 19;
            this.textBoxesPanel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(294, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(139, 20);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.toursBindingSource, "HotelId", true));
            this.comboBox1.DataSource = this.hotelsBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(294, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "HotelId";
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(294, 149);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(139, 20);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.toursBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(294, 123);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.endDateDateTimePicker.TabIndex = 3;
            // 
            // beginDateDateTimePicker
            // 
            this.beginDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.toursBindingSource, "BeginDate", true));
            this.beginDateDateTimePicker.Location = new System.Drawing.Point(294, 97);
            this.beginDateDateTimePicker.Name = "beginDateDateTimePicker";
            this.beginDateDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.beginDateDateTimePicker.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // toursDataGridView
            // 
            this.toursDataGridView.AllowUserToAddRows = false;
            this.toursDataGridView.AllowUserToDeleteRows = false;
            this.toursDataGridView.AutoGenerateColumns = false;
            this.toursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toursDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.Column1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.toursDataGridView.DataSource = this.toursBindingSource;
            this.toursDataGridView.Location = new System.Drawing.Point(12, 52);
            this.toursDataGridView.Name = "toursDataGridView";
            this.toursDataGridView.Size = new System.Drawing.Size(648, 220);
            this.toursDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.FillWeight = 120F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Название тура";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HotelId";
            this.Column1.DataSource = this.hotelsBindingSource;
            this.Column1.DisplayMember = "Name";
            this.Column1.FillWeight = 120F;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "Название отеля";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "HotelId";
            this.Column1.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BeginDate";
            this.dataGridViewTextBoxColumn3.FillWeight = 110F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата начала";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn4.FillWeight = 120F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата окончания";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Tours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toursBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toursDataGridView);
            this.Controls.Add(this.textBoxesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tours";
            this.Text = "Туры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tours_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tours_FormClosed);
            this.Load += new System.EventHandler(this.Tours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingNavigator)).EndInit();
            this.toursBindingNavigator.ResumeLayout(false);
            this.toursBindingNavigator.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            this.textBoxesPanel.ResumeLayout(false);
            this.textBoxesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private TravelAgencyDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator toursBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSaveToBD;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonRejectChanges;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private TravelAgencyDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private System.Windows.Forms.Panel textBoxesPanel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker beginDateDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView toursDataGridView;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonView;
        private System.Windows.Forms.ToolStripMenuItem tableViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBoxesViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonLists;
        private System.Windows.Forms.ToolStripMenuItem hotelsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonInformation;
        private System.Windows.Forms.ToolStripMenuItem toursByHotelNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unfineshedToursToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}