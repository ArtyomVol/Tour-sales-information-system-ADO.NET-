
namespace WindowsFormsApp1
{
    partial class Hotels
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
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label starsRateLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotels));
            this.label1 = new System.Windows.Forms.Label();
            this.travelAgencyDataSet = new WindowsFormsApp1.TravelAgencyDataSet();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelsTableAdapter = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.HotelsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.hotelsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButtonView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxesViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonInformation = new System.Windows.Forms.ToolStripDropDownButton();
            this.notBadHotelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelsFromCountruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hotelsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textBoxesPanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.starsRateTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            countryLabel = new System.Windows.Forms.Label();
            starsRateLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingNavigator)).BeginInit();
            this.hotelsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.textBoxesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            countryLabel.Location = new System.Drawing.Point(163, 91);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(67, 17);
            countryLabel.TabIndex = 0;
            countryLabel.Text = "Страна:";
            // 
            // starsRateLabel
            // 
            starsRateLabel.AutoSize = true;
            starsRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            starsRateLabel.Location = new System.Drawing.Point(162, 117);
            starsRateLabel.Name = "starsRateLabel";
            starsRateLabel.Size = new System.Drawing.Size(68, 17);
            starsRateLabel.TabIndex = 2;
            starsRateLabel.Text = "Звёзды:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(145, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(85, 17);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Название:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(220, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Отели";
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.HotelsTableAdapter = this.hotelsTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.ToursTableAdapter = null;
            this.tableAdapterManager.TravelAgentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hotelsBindingNavigator
            // 
            this.hotelsBindingNavigator.AddNewItem = null;
            this.hotelsBindingNavigator.BindingSource = this.hotelsBindingSource;
            this.hotelsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hotelsBindingNavigator.DeleteItem = null;
            this.hotelsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonView,
            this.toolStripDropDownButtonInformation,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.hotelsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hotelsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hotelsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hotelsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hotelsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hotelsBindingNavigator.Name = "hotelsBindingNavigator";
            this.hotelsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hotelsBindingNavigator.Size = new System.Drawing.Size(502, 25);
            this.hotelsBindingNavigator.TabIndex = 3;
            this.hotelsBindingNavigator.Text = "bindingNavigator1";
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
            this.notBadHotelsToolStripMenuItem,
            this.hotelsFromCountruToolStripMenuItem});
            this.toolStripDropDownButtonInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonInformation.Name = "toolStripDropDownButtonInformation";
            this.toolStripDropDownButtonInformation.Size = new System.Drawing.Size(94, 22);
            this.toolStripDropDownButtonInformation.Text = "Информация";
            // 
            // notBadHotelsToolStripMenuItem
            // 
            this.notBadHotelsToolStripMenuItem.Name = "notBadHotelsToolStripMenuItem";
            this.notBadHotelsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.notBadHotelsToolStripMenuItem.Text = "Неплохие отели";
            this.notBadHotelsToolStripMenuItem.ToolTipText = "Рейтинг не меньше 3";
            this.notBadHotelsToolStripMenuItem.Click += new System.EventHandler(this.notBadHotelsToolStripMenuItem_Click);
            // 
            // hotelsFromCountruToolStripMenuItem
            // 
            this.hotelsFromCountruToolStripMenuItem.Name = "hotelsFromCountruToolStripMenuItem";
            this.hotelsFromCountruToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.hotelsFromCountruToolStripMenuItem.Text = "Отели из страны";
            this.hotelsFromCountruToolStripMenuItem.Click += new System.EventHandler(this.hotelsFromCountruToolStripMenuItem_Click);
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
            // hotelsDataGridView
            // 
            this.hotelsDataGridView.AllowUserToAddRows = false;
            this.hotelsDataGridView.AllowUserToDeleteRows = false;
            this.hotelsDataGridView.AutoGenerateColumns = false;
            this.hotelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.hotelsDataGridView.DataSource = this.hotelsBindingSource;
            this.hotelsDataGridView.Location = new System.Drawing.Point(7, 50);
            this.hotelsDataGridView.Name = "hotelsDataGridView";
            this.hotelsDataGridView.Size = new System.Drawing.Size(488, 220);
            this.hotelsDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.FillWeight = 150F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Название";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 40;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn2.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StarsRate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Звёзды";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonRejectChanges);
            this.panel2.Controls.Add(this.buttonSaveToBD);
            this.panel2.Controls.Add(this.buttonAddRecord);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonDeleteRecord);
            this.panel2.Location = new System.Drawing.Point(202, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 78);
            this.panel2.TabIndex = 15;
            // 
            // buttonRejectChanges
            // 
            this.buttonRejectChanges.Location = new System.Drawing.Point(77, 49);
            this.buttonRejectChanges.Name = "buttonRejectChanges";
            this.buttonRejectChanges.Size = new System.Drawing.Size(125, 23);
            this.buttonRejectChanges.TabIndex = 12;
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
            this.panel1.Location = new System.Drawing.Point(6, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 78);
            this.panel1.TabIndex = 14;
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
            this.textBoxesPanel.Controls.Add(nameLabel);
            this.textBoxesPanel.Controls.Add(this.nameTextBox);
            this.textBoxesPanel.Controls.Add(starsRateLabel);
            this.textBoxesPanel.Controls.Add(this.starsRateTextBox);
            this.textBoxesPanel.Controls.Add(countryLabel);
            this.textBoxesPanel.Controls.Add(this.countryTextBox);
            this.textBoxesPanel.Location = new System.Drawing.Point(6, 50);
            this.textBoxesPanel.Name = "textBoxesPanel";
            this.textBoxesPanel.Size = new System.Drawing.Size(489, 220);
            this.textBoxesPanel.TabIndex = 18;
            this.textBoxesPanel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(245, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // starsRateTextBox
            // 
            this.starsRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "StarsRate", true));
            this.starsRateTextBox.Location = new System.Drawing.Point(245, 115);
            this.starsRateTextBox.Name = "starsRateTextBox";
            this.starsRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.starsRateTextBox.TabIndex = 3;
            this.starsRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.starsRateTextBox_KeyPress);
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(245, 89);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 1;
            this.countryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countryTextBox_KeyPress);
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hotelsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotelsDataGridView);
            this.Controls.Add(this.textBoxesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hotels";
            this.Text = "Отели";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hotels_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hotels_FormClosed);
            this.Load += new System.EventHandler(this.Hotels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingNavigator)).EndInit();
            this.hotelsBindingNavigator.ResumeLayout(false);
            this.hotelsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.textBoxesPanel.ResumeLayout(false);
            this.textBoxesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private TravelAgencyDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hotelsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView hotelsDataGridView;
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
        private System.Windows.Forms.Panel textBoxesPanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox starsRateTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonView;
        private System.Windows.Forms.ToolStripMenuItem tableViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBoxesViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonInformation;
        private System.Windows.Forms.ToolStripMenuItem notBadHotelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelsFromCountruToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}