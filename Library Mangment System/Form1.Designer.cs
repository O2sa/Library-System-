namespace Library_Mangment_System
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label bookIDLabel;
            System.Windows.Forms.Label bookTitleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label rRPLabel;
            System.Windows.Forms.Label sellingPriceLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label postCodeLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label dateBorrowedLabel;
            System.Windows.Forms.Label dateReturnedLabel;
            System.Windows.Forms.Label dateDueBackLabel;
            System.Windows.Forms.Label currentDateLabel;
            System.Windows.Forms.Label lateReturnFineLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.libraryDataSet = new Library_Mangment_System.LibraryDataSet();
            this.libraryBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryBookTableAdapter = new Library_Mangment_System.LibraryDataSetTableAdapters.LibraryBookTableAdapter();
            this.tableAdapterManager = new Library_Mangment_System.LibraryDataSetTableAdapters.TableAdapterManager();
            this.libraryBookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.libraryBookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.rRPTextBox = new System.Windows.Forms.TextBox();
            this.sellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.postCodeTextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.dateBorrowedTextBox = new System.Windows.Forms.TextBox();
            this.dateReturnedTextBox = new System.Windows.Forms.TextBox();
            this.dateDueBackTextBox = new System.Windows.Forms.TextBox();
            this.currentDateTextBox = new System.Windows.Forms.TextBox();
            this.lateReturnFineTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datereturned = new System.Windows.Forms.Button();
            this.borrowed = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateOverDue = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.TextBox();
            this.libraryBookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclose = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            bookIDLabel = new System.Windows.Forms.Label();
            bookTitleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            rRPLabel = new System.Windows.Forms.Label();
            sellingPriceLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            postCodeLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            dateBorrowedLabel = new System.Windows.Forms.Label();
            dateReturnedLabel = new System.Windows.Forms.Label();
            dateDueBackLabel = new System.Windows.Forms.Label();
            currentDateLabel = new System.Windows.Forms.Label();
            lateReturnFineLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBookBindingNavigator)).BeginInit();
            this.libraryBookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(442, 226);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(52, 29);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bookIDLabel.Location = new System.Drawing.Point(442, 292);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new System.Drawing.Size(119, 29);
            bookIDLabel.TabIndex = 3;
            bookIDLabel.Text = "Book ID:";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bookTitleLabel.Location = new System.Drawing.Point(442, 357);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new System.Drawing.Size(142, 29);
            bookTitleLabel.TabIndex = 5;
            bookTitleLabel.Text = "Book Title:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            authorLabel.Location = new System.Drawing.Point(442, 422);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(103, 29);
            authorLabel.TabIndex = 7;
            authorLabel.Text = "Author:";
            // 
            // rRPLabel
            // 
            rRPLabel.AutoSize = true;
            rRPLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rRPLabel.Location = new System.Drawing.Point(442, 484);
            rRPLabel.Name = "rRPLabel";
            rRPLabel.Size = new System.Drawing.Size(72, 29);
            rRPLabel.TabIndex = 9;
            rRPLabel.Text = "RRP:";
            // 
            // sellingPriceLabel
            // 
            sellingPriceLabel.AutoSize = true;
            sellingPriceLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sellingPriceLabel.Location = new System.Drawing.Point(442, 547);
            sellingPriceLabel.Name = "sellingPriceLabel";
            sellingPriceLabel.Size = new System.Drawing.Size(169, 29);
            sellingPriceLabel.TabIndex = 11;
            sellingPriceLabel.Text = "Selling Price:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(4, 292);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(75, 29);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Title:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(-1, 356);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(10);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(152, 29);
            firstNameLabel.TabIndex = 15;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(-1, 422);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(10);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(149, 29);
            lastNameLabel.TabIndex = 17;
            lastNameLabel.Text = "Last Name:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address1Label.Location = new System.Drawing.Point(-1, 487);
            address1Label.Margin = new System.Windows.Forms.Padding(10);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(131, 29);
            address1Label.TabIndex = 19;
            address1Label.Text = "Address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address2Label.Location = new System.Drawing.Point(-1, 552);
            address2Label.Margin = new System.Windows.Forms.Padding(10);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(131, 29);
            address2Label.TabIndex = 21;
            address2Label.Text = "Address2:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postCodeLabel.Location = new System.Drawing.Point(-1, 617);
            postCodeLabel.Margin = new System.Windows.Forms.Padding(10);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(142, 29);
            postCodeLabel.TabIndex = 23;
            postCodeLabel.Text = "Post Code:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dOBLabel.Location = new System.Drawing.Point(-1, 547);
            dOBLabel.Margin = new System.Windows.Forms.Padding(10);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(74, 29);
            dOBLabel.TabIndex = 25;
            dOBLabel.Text = "DOB:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIDLabel.Location = new System.Drawing.Point(-1, 226);
            customerIDLabel.Margin = new System.Windows.Forms.Padding(10);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(174, 29);
            customerIDLabel.TabIndex = 27;
            customerIDLabel.Text = "Customer ID:";
            // 
            // dateBorrowedLabel
            // 
            dateBorrowedLabel.AutoSize = true;
            dateBorrowedLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateBorrowedLabel.Location = new System.Drawing.Point(893, 231);
            dateBorrowedLabel.Name = "dateBorrowedLabel";
            dateBorrowedLabel.Size = new System.Drawing.Size(201, 29);
            dateBorrowedLabel.TabIndex = 29;
            dateBorrowedLabel.Text = "Date Borrowed:";
            // 
            // dateReturnedLabel
            // 
            dateReturnedLabel.AutoSize = true;
            dateReturnedLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateReturnedLabel.Location = new System.Drawing.Point(893, 297);
            dateReturnedLabel.Name = "dateReturnedLabel";
            dateReturnedLabel.Size = new System.Drawing.Size(195, 29);
            dateReturnedLabel.TabIndex = 31;
            dateReturnedLabel.Text = "Date Returned:";
            // 
            // dateDueBackLabel
            // 
            dateDueBackLabel.AutoSize = true;
            dateDueBackLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateDueBackLabel.Location = new System.Drawing.Point(893, 361);
            dateDueBackLabel.Name = "dateDueBackLabel";
            dateDueBackLabel.Size = new System.Drawing.Size(196, 29);
            dateDueBackLabel.TabIndex = 33;
            dateDueBackLabel.Text = "Date Due Back:";
            // 
            // currentDateLabel
            // 
            currentDateLabel.AutoSize = true;
            currentDateLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentDateLabel.Location = new System.Drawing.Point(436, 6);
            currentDateLabel.Name = "currentDateLabel";
            currentDateLabel.Size = new System.Drawing.Size(175, 29);
            currentDateLabel.TabIndex = 35;
            currentDateLabel.Text = "Current Date:";
            // 
            // lateReturnFineLabel
            // 
            lateReturnFineLabel.AutoSize = true;
            lateReturnFineLabel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lateReturnFineLabel.Location = new System.Drawing.Point(893, 427);
            lateReturnFineLabel.Name = "lateReturnFineLabel";
            lateReturnFineLabel.Size = new System.Drawing.Size(203, 27);
            lateReturnFineLabel.TabIndex = 37;
            lateReturnFineLabel.Text = "Late Return Fine:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(-1, 677);
            label1.Margin = new System.Windows.Forms.Padding(10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 29);
            label1.TabIndex = 40;
            label1.Text = "DOB:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label2.Location = new System.Drawing.Point(7, 41);
            label2.Margin = new System.Windows.Forms.Padding(10);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(140, 0, 140, 0);
            label2.Size = new System.Drawing.Size(1595, 116);
            label2.TabIndex = 41;
            label2.Text = "Library Mangment System";
            label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            label5.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(4, 161);
            label5.Margin = new System.Windows.Forms.Padding(10);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(371, 53);
            label5.TabIndex = 44;
            label5.Text = "Library Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            label3.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(889, 161);
            label3.Margin = new System.Windows.Forms.Padding(10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(395, 53);
            label3.TabIndex = 51;
            label3.Text = "Library Loan info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            label4.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(438, 161);
            label4.Margin = new System.Windows.Forms.Padding(10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(299, 53);
            label4.TabIndex = 52;
            label4.Text = "Book Details";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(893, 487);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(186, 29);
            label7.TabIndex = 57;
            label7.Text = "Date Over Due";
            label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryBookBindingSource
            // 
            this.libraryBookBindingSource.DataMember = "LibraryBook";
            this.libraryBookBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryBookTableAdapter
            // 
            this.libraryBookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LibraryBookTableAdapter = this.libraryBookTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library_Mangment_System.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // libraryBookBindingNavigator
            // 
            this.libraryBookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.libraryBookBindingNavigator.BindingSource = this.libraryBookBindingSource;
            this.libraryBookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.libraryBookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.libraryBookBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.libraryBookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.libraryBookBindingNavigatorSaveItem});
            this.libraryBookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.libraryBookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.libraryBookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.libraryBookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.libraryBookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.libraryBookBindingNavigator.Name = "libraryBookBindingNavigator";
            this.libraryBookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.libraryBookBindingNavigator.Size = new System.Drawing.Size(1640, 31);
            this.libraryBookBindingNavigator.TabIndex = 0;
            this.libraryBookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // libraryBookBindingNavigatorSaveItem
            // 
            this.libraryBookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.libraryBookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("libraryBookBindingNavigatorSaveItem.Image")));
            this.libraryBookBindingNavigatorSaveItem.Name = "libraryBookBindingNavigatorSaveItem";
            this.libraryBookBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.libraryBookBindingNavigatorSaveItem.Text = "Save Data";
            this.libraryBookBindingNavigatorSaveItem.Click += new System.EventHandler(this.LibraryBookBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(617, 223);
            this.iDTextBox.Multiline = true;
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(250, 45);
            this.iDTextBox.TabIndex = 2;
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "BookID", true));
            this.bookIDTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDTextBox.Location = new System.Drawing.Point(617, 289);
            this.bookIDTextBox.Multiline = true;
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(250, 45);
            this.bookIDTextBox.TabIndex = 4;
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "BookTitle", true));
            this.bookTitleTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleTextBox.Location = new System.Drawing.Point(617, 354);
            this.bookTitleTextBox.Multiline = true;
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(250, 45);
            this.bookTitleTextBox.TabIndex = 6;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "Author", true));
            this.authorTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(617, 419);
            this.authorTextBox.Multiline = true;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(250, 45);
            this.authorTextBox.TabIndex = 8;
            // 
            // rRPTextBox
            // 
            this.rRPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "RRP", true));
            this.rRPTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rRPTextBox.Location = new System.Drawing.Point(617, 481);
            this.rRPTextBox.Multiline = true;
            this.rRPTextBox.Name = "rRPTextBox";
            this.rRPTextBox.Size = new System.Drawing.Size(250, 45);
            this.rRPTextBox.TabIndex = 10;
            // 
            // sellingPriceTextBox
            // 
            this.sellingPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "SellingPrice", true));
            this.sellingPriceTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingPriceTextBox.Location = new System.Drawing.Point(617, 544);
            this.sellingPriceTextBox.Multiline = true;
            this.sellingPriceTextBox.Name = "sellingPriceTextBox";
            this.sellingPriceTextBox.Size = new System.Drawing.Size(250, 45);
            this.sellingPriceTextBox.TabIndex = 12;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(179, 289);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(250, 45);
            this.titleTextBox.TabIndex = 14;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(179, 353);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(250, 45);
            this.firstNameTextBox.TabIndex = 16;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(179, 419);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(250, 45);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "Address1", true));
            this.address1TextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1TextBox.Location = new System.Drawing.Point(179, 484);
            this.address1TextBox.Margin = new System.Windows.Forms.Padding(10);
            this.address1TextBox.Multiline = true;
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(250, 45);
            this.address1TextBox.TabIndex = 20;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "Address2", true));
            this.address2TextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(179, 549);
            this.address2TextBox.Margin = new System.Windows.Forms.Padding(10);
            this.address2TextBox.Multiline = true;
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(250, 45);
            this.address2TextBox.TabIndex = 22;
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "PostCode", true));
            this.postCodeTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodeTextBox.Location = new System.Drawing.Point(179, 614);
            this.postCodeTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.postCodeTextBox.Multiline = true;
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(250, 45);
            this.postCodeTextBox.TabIndex = 24;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.libraryBookBindingSource, "DOB", true));
            this.dOBDateTimePicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(179, 679);
            this.dOBDateTimePicker.Margin = new System.Windows.Forms.Padding(10);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(250, 36);
            this.dOBDateTimePicker.TabIndex = 26;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "CustomerID", true));
            this.customerIDTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(179, 223);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.customerIDTextBox.Multiline = true;
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(250, 45);
            this.customerIDTextBox.TabIndex = 28;
            // 
            // dateBorrowedTextBox
            // 
            this.dateBorrowedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "DateBorrowed", true));
            this.dateBorrowedTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBorrowedTextBox.Location = new System.Drawing.Point(1113, 223);
            this.dateBorrowedTextBox.Multiline = true;
            this.dateBorrowedTextBox.Name = "dateBorrowedTextBox";
            this.dateBorrowedTextBox.Size = new System.Drawing.Size(250, 45);
            this.dateBorrowedTextBox.TabIndex = 30;
            // 
            // dateReturnedTextBox
            // 
            this.dateReturnedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "DateReturned", true));
            this.dateReturnedTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReturnedTextBox.Location = new System.Drawing.Point(1113, 289);
            this.dateReturnedTextBox.Multiline = true;
            this.dateReturnedTextBox.Name = "dateReturnedTextBox";
            this.dateReturnedTextBox.Size = new System.Drawing.Size(250, 45);
            this.dateReturnedTextBox.TabIndex = 32;
            // 
            // dateDueBackTextBox
            // 
            this.dateDueBackTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "DateDueBack", true));
            this.dateDueBackTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDueBackTextBox.Location = new System.Drawing.Point(1113, 353);
            this.dateDueBackTextBox.Multiline = true;
            this.dateDueBackTextBox.Name = "dateDueBackTextBox";
            this.dateDueBackTextBox.Size = new System.Drawing.Size(250, 45);
            this.dateDueBackTextBox.TabIndex = 34;
            // 
            // currentDateTextBox
            // 
            this.currentDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "CurrentDate", true));
            this.currentDateTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateTextBox.Location = new System.Drawing.Point(617, 4);
            this.currentDateTextBox.Multiline = true;
            this.currentDateTextBox.Name = "currentDateTextBox";
            this.currentDateTextBox.Size = new System.Drawing.Size(196, 33);
            this.currentDateTextBox.TabIndex = 36;
            // 
            // lateReturnFineTextBox
            // 
            this.lateReturnFineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "LateReturnFine", true));
            this.lateReturnFineTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateReturnFineTextBox.Location = new System.Drawing.Point(1113, 419);
            this.lateReturnFineTextBox.Multiline = true;
            this.lateReturnFineTextBox.Name = "lateReturnFineTextBox";
            this.lateReturnFineTextBox.Size = new System.Drawing.Size(250, 45);
            this.lateReturnFineTextBox.TabIndex = 38;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.libraryBookBindingSource;
            this.listBox1.DisplayMember = "BookTitle";
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 34;
            this.listBox1.Location = new System.Drawing.Point(1369, 223);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 378);
            this.listBox1.TabIndex = 39;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1135, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 37);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1327, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 46;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // datereturned
            // 
            this.datereturned.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.datereturned.Location = new System.Drawing.Point(1107, 617);
            this.datereturned.Name = "datereturned";
            this.datereturned.Size = new System.Drawing.Size(256, 55);
            this.datereturned.TabIndex = 47;
            this.datereturned.Text = "Date Returned";
            this.datereturned.UseVisualStyleBackColor = true;
            this.datereturned.Click += new System.EventHandler(this.Button2_Click);
            // 
            // borrowed
            // 
            this.borrowed.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowed.Location = new System.Drawing.Point(1107, 544);
            this.borrowed.Name = "borrowed";
            this.borrowed.Size = new System.Drawing.Size(256, 59);
            this.borrowed.TabIndex = 48;
            this.borrowed.Text = "Borrowed";
            this.borrowed.UseVisualStyleBackColor = true;
            this.borrowed.Click += new System.EventHandler(this.Borrowed_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnreset.Location = new System.Drawing.Point(874, 617);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(214, 55);
            this.btnreset.TabIndex = 49;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.Btnreset_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1341, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 53);
            this.label6.TabIndex = 55;
            this.label6.Text = " ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(874, 558);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(203, 36);
            this.numericUpDown1.TabIndex = 56;
            // 
            // dateOverDue
            // 
            this.dateOverDue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "LateReturnFine", true));
            this.dateOverDue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOverDue.Location = new System.Drawing.Point(1113, 479);
            this.dateOverDue.Multiline = true;
            this.dateOverDue.Name = "dateOverDue";
            this.dateOverDue.Size = new System.Drawing.Size(250, 45);
            this.dateOverDue.TabIndex = 58;
            // 
            // btnsearch
            // 
            this.btnsearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBookBindingSource, "DateBorrowed", true));
            this.btnsearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(912, 0);
            this.btnsearch.Multiline = true;
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(212, 37);
            this.btnsearch.TabIndex = 50;
            this.btnsearch.TextChanged += new System.EventHandler(this.Btnsearch_TextChanged);
            // 
            // libraryBookDataGridView
            // 
            this.libraryBookDataGridView.AutoGenerateColumns = false;
            this.libraryBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryBookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.libraryBookDataGridView.DataSource = this.libraryBookBindingSource;
            this.libraryBookDataGridView.Location = new System.Drawing.Point(4, 728);
            this.libraryBookDataGridView.Name = "libraryBookDataGridView";
            this.libraryBookDataGridView.RowTemplate.Height = 29;
            this.libraryBookDataGridView.Size = new System.Drawing.Size(1611, 277);
            this.libraryBookDataGridView.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn2.HeaderText = "BookID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BookTitle";
            this.dataGridViewTextBoxColumn3.HeaderText = "BookTitle";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn4.HeaderText = "Author";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RRP";
            this.dataGridViewTextBoxColumn5.HeaderText = "RRP";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SellingPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "SellingPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn7.HeaderText = "Title";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn8.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn9.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Address1";
            this.dataGridViewTextBoxColumn10.HeaderText = "Address1";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Address2";
            this.dataGridViewTextBoxColumn11.HeaderText = "Address2";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PostCode";
            this.dataGridViewTextBoxColumn12.HeaderText = "PostCode";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn13.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn14.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DateBorrowed";
            this.dataGridViewTextBoxColumn15.HeaderText = "DateBorrowed";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "DateReturned";
            this.dataGridViewTextBoxColumn16.HeaderText = "DateReturned";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "DateDueBack";
            this.dataGridViewTextBoxColumn17.HeaderText = "DateDueBack";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "CurrentDate";
            this.dataGridViewTextBoxColumn18.HeaderText = "CurrentDate";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "LateReturnFine";
            this.dataGridViewTextBoxColumn19.HeaderText = "LateReturnFine";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnclose.Location = new System.Drawing.Point(1545, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(95, 37);
            this.btnclose.TabIndex = 59;
            this.btnclose.Text = "Exit";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 906);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.libraryBookDataGridView);
            this.Controls.Add(label7);
            this.Controls.Add(this.dateOverDue);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.borrowed);
            this.Controls.Add(this.datereturned);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label5);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(bookIDLabel);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(bookTitleLabel);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(rRPLabel);
            this.Controls.Add(this.rRPTextBox);
            this.Controls.Add(sellingPriceLabel);
            this.Controls.Add(this.sellingPriceTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(postCodeLabel);
            this.Controls.Add(this.postCodeTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.dOBDateTimePicker);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(dateBorrowedLabel);
            this.Controls.Add(this.dateBorrowedTextBox);
            this.Controls.Add(dateReturnedLabel);
            this.Controls.Add(this.dateReturnedTextBox);
            this.Controls.Add(dateDueBackLabel);
            this.Controls.Add(this.dateDueBackTextBox);
            this.Controls.Add(currentDateLabel);
            this.Controls.Add(this.currentDateTextBox);
            this.Controls.Add(lateReturnFineLabel);
            this.Controls.Add(this.lateReturnFineTextBox);
            this.Controls.Add(this.libraryBookBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximumSize = new System.Drawing.Size(1640, 906);
            this.MinimumSize = new System.Drawing.Size(1540, 906);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LIBRARY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBookBindingNavigator)).EndInit();
            this.libraryBookBindingNavigator.ResumeLayout(false);
            this.libraryBookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource libraryBookBindingSource;
        private LibraryDataSetTableAdapters.LibraryBookTableAdapter libraryBookTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator libraryBookBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton libraryBookBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox rRPTextBox;
        private System.Windows.Forms.TextBox sellingPriceTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox postCodeTextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox dateBorrowedTextBox;
        private System.Windows.Forms.TextBox dateReturnedTextBox;
        private System.Windows.Forms.TextBox dateDueBackTextBox;
        private System.Windows.Forms.TextBox currentDateTextBox;
        private System.Windows.Forms.TextBox lateReturnFineTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button datereturned;
        private System.Windows.Forms.Button borrowed;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox dateOverDue;
        private System.Windows.Forms.TextBox btnsearch;
        private System.Windows.Forms.DataGridView libraryBookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.Button btnclose;
    }
}