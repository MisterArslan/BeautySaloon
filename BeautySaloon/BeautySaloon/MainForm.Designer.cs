namespace BeautySaloon
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Employees = new System.Windows.Forms.TabPage();
            this.Employees_employeeID = new System.Windows.Forms.TextBox();
            this.Employees_employeeID_label = new System.Windows.Forms.Label();
            this.Employees_mode = new System.Windows.Forms.ComboBox();
            this.Employees_mode_label = new System.Windows.Forms.Label();
            this.Employees_accept_button = new System.Windows.Forms.Button();
            this.Employees_dataGridView = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beauty_saloonDataSet = new BeautySaloon.beauty_saloonDataSet();
            this.Employees_startdate = new System.Windows.Forms.DateTimePicker();
            this.Employees_specialization = new System.Windows.Forms.TextBox();
            this.Employees_address = new System.Windows.Forms.TextBox();
            this.Employees_number = new System.Windows.Forms.TextBox();
            this.Employees_lastname = new System.Windows.Forms.TextBox();
            this.Employees_name = new System.Windows.Forms.TextBox();
            this.Employees_surname = new System.Windows.Forms.TextBox();
            this.Employees_startdate_label = new System.Windows.Forms.Label();
            this.Employees_specialization_label = new System.Windows.Forms.Label();
            this.Employees_address_label = new System.Windows.Forms.Label();
            this.Employees_number_label = new System.Windows.Forms.Label();
            this.Employees_lastname_label = new System.Windows.Forms.Label();
            this.Employees_name_label = new System.Windows.Forms.Label();
            this.Employees_surname_label = new System.Windows.Forms.Label();
            this.Services = new System.Windows.Forms.TabPage();
            this.Services_serviceID = new System.Windows.Forms.TextBox();
            this.Services_serviceID_label = new System.Windows.Forms.Label();
            this.Services_mode = new System.Windows.Forms.ComboBox();
            this.Services_mode_label = new System.Windows.Forms.Label();
            this.Services_accept_button = new System.Windows.Forms.Button();
            this.Services_dataGridView = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Services_comment = new System.Windows.Forms.TextBox();
            this.Services_price = new System.Windows.Forms.TextBox();
            this.Services_name = new System.Windows.Forms.TextBox();
            this.Services_comment_label = new System.Windows.Forms.Label();
            this.Services_price_label = new System.Windows.Forms.Label();
            this.Services_name_label = new System.Windows.Forms.Label();
            this.Clients = new System.Windows.Forms.TabPage();
            this.Clients_clientID = new System.Windows.Forms.TextBox();
            this.Clients_clientID_label = new System.Windows.Forms.Label();
            this.Clients_mode = new System.Windows.Forms.ComboBox();
            this.Clients_mode_label = new System.Windows.Forms.Label();
            this.Clients_button = new System.Windows.Forms.Button();
            this.Clients_dataGridView = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Clients_phonenumber = new System.Windows.Forms.TextBox();
            this.Clients_name = new System.Windows.Forms.TextBox();
            this.Clients_surname = new System.Windows.Forms.TextBox();
            this.Clients_phonenumber_label = new System.Windows.Forms.Label();
            this.Clients_name_label = new System.Windows.Forms.Label();
            this.Clients_surname_label = new System.Windows.Forms.Label();
            this.Records = new System.Windows.Forms.TabPage();
            this.Records_recordID = new System.Windows.Forms.TextBox();
            this.Records_recordID_label = new System.Windows.Forms.Label();
            this.Records_mode = new System.Windows.Forms.ComboBox();
            this.Records_mode_label = new System.Windows.Forms.Label();
            this.Records_datetime = new System.Windows.Forms.DateTimePicker();
            this.Records_accept_button = new System.Windows.Forms.Button();
            this.Records_dataGridView = new System.Windows.Forms.DataGridView();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Records_comment = new System.Windows.Forms.TextBox();
            this.Records_serviceID = new System.Windows.Forms.TextBox();
            this.Records_employeeID = new System.Windows.Forms.TextBox();
            this.Records_clientID = new System.Windows.Forms.TextBox();
            this.Records_comment_label = new System.Windows.Forms.Label();
            this.Records_datetime_label = new System.Windows.Forms.Label();
            this.Records_serviceid_label = new System.Windows.Forms.Label();
            this.Records_employeeID_label = new System.Windows.Forms.Label();
            this.Records_clientID_label = new System.Windows.Forms.Label();
            this.Shares = new System.Windows.Forms.TabPage();
            this.Shares_shareID = new System.Windows.Forms.TextBox();
            this.Shares_shareID_label = new System.Windows.Forms.Label();
            this.Shares_mode = new System.Windows.Forms.ComboBox();
            this.Shares_mode_label = new System.Windows.Forms.Label();
            this.Shares_expirationdate = new System.Windows.Forms.DateTimePicker();
            this.Shares_startdate = new System.Windows.Forms.DateTimePicker();
            this.Shares_accept_button = new System.Windows.Forms.Button();
            this.Shares_dataGridView = new System.Windows.Forms.DataGridView();
            this.shareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sharesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Shares_name = new System.Windows.Forms.TextBox();
            this.Shares_expirationdate_label = new System.Windows.Forms.Label();
            this.Shares_startdate_label = new System.Windows.Forms.Label();
            this.Shares_name_label = new System.Windows.Forms.Label();
            this.Discounts = new System.Windows.Forms.TabPage();
            this.Discounts_discountID = new System.Windows.Forms.TextBox();
            this.Discounts_discountID_label = new System.Windows.Forms.Label();
            this.Discounts_mode = new System.Windows.Forms.ComboBox();
            this.Discounts_mode_label = new System.Windows.Forms.Label();
            this.Discounts_accept_button = new System.Windows.Forms.Button();
            this.Discounts_dataGridView = new System.Windows.Forms.DataGridView();
            this.discountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Discounts_value = new System.Windows.Forms.TextBox();
            this.Discounts_serviceID = new System.Windows.Forms.TextBox();
            this.Discounts_shareID = new System.Windows.Forms.TextBox();
            this.Discounts_value_label = new System.Windows.Forms.Label();
            this.Discounts_serviceID_label = new System.Windows.Forms.Label();
            this.Discounts_shareID_label = new System.Windows.Forms.Label();
            this.employeesTableAdapter = new BeautySaloon.beauty_saloonDataSetTableAdapters.employeesTableAdapter();
            this.servicesTableAdapter = new BeautySaloon.beauty_saloonDataSetTableAdapters.servicesTableAdapter();
            this.clientsTableAdapter = new BeautySaloon.beauty_saloonDataSetTableAdapters.clientsTableAdapter();
            this.recordsTableAdapter = new BeautySaloon.beauty_saloonDataSetTableAdapters.recordsTableAdapter();
            this.sharesTableAdapter = new BeautySaloon.beauty_saloonDataSetTableAdapters.sharesTableAdapter();
            this.discountsTableAdapter = new BeautySaloon.beauty_saloonDataSetTableAdapters.discountsTableAdapter();
            this.TabControl.SuspendLayout();
            this.Employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employees_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_saloonDataSet)).BeginInit();
            this.Services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clients_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.Records.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Records_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            this.Shares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shares_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharesBindingSource)).BeginInit();
            this.Discounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discounts_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Employees);
            this.TabControl.Controls.Add(this.Services);
            this.TabControl.Controls.Add(this.Clients);
            this.TabControl.Controls.Add(this.Records);
            this.TabControl.Controls.Add(this.Shares);
            this.TabControl.Controls.Add(this.Discounts);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(982, 753);
            this.TabControl.TabIndex = 0;
            // 
            // Employees
            // 
            this.Employees.Controls.Add(this.Employees_employeeID);
            this.Employees.Controls.Add(this.Employees_employeeID_label);
            this.Employees.Controls.Add(this.Employees_mode);
            this.Employees.Controls.Add(this.Employees_mode_label);
            this.Employees.Controls.Add(this.Employees_accept_button);
            this.Employees.Controls.Add(this.Employees_dataGridView);
            this.Employees.Controls.Add(this.Employees_startdate);
            this.Employees.Controls.Add(this.Employees_specialization);
            this.Employees.Controls.Add(this.Employees_address);
            this.Employees.Controls.Add(this.Employees_number);
            this.Employees.Controls.Add(this.Employees_lastname);
            this.Employees.Controls.Add(this.Employees_name);
            this.Employees.Controls.Add(this.Employees_surname);
            this.Employees.Controls.Add(this.Employees_startdate_label);
            this.Employees.Controls.Add(this.Employees_specialization_label);
            this.Employees.Controls.Add(this.Employees_address_label);
            this.Employees.Controls.Add(this.Employees_number_label);
            this.Employees.Controls.Add(this.Employees_lastname_label);
            this.Employees.Controls.Add(this.Employees_name_label);
            this.Employees.Controls.Add(this.Employees_surname_label);
            this.Employees.Location = new System.Drawing.Point(4, 25);
            this.Employees.Name = "Employees";
            this.Employees.Padding = new System.Windows.Forms.Padding(3);
            this.Employees.Size = new System.Drawing.Size(974, 724);
            this.Employees.TabIndex = 0;
            this.Employees.Text = "Сотрудники";
            this.Employees.UseVisualStyleBackColor = true;
            // 
            // Employees_employeeID
            // 
            this.Employees_employeeID.Enabled = false;
            this.Employees_employeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_employeeID.Location = new System.Drawing.Point(634, 8);
            this.Employees_employeeID.Name = "Employees_employeeID";
            this.Employees_employeeID.Size = new System.Drawing.Size(332, 27);
            this.Employees_employeeID.TabIndex = 1;
            // 
            // Employees_employeeID_label
            // 
            this.Employees_employeeID_label.AutoSize = true;
            this.Employees_employeeID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_employeeID_label.Location = new System.Drawing.Point(482, 11);
            this.Employees_employeeID_label.Name = "Employees_employeeID_label";
            this.Employees_employeeID_label.Size = new System.Drawing.Size(145, 20);
            this.Employees_employeeID_label.TabIndex = 0;
            this.Employees_employeeID_label.Text = "Код сотрудника";
            // 
            // Employees_mode
            // 
            this.Employees_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employees_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_mode.FormattingEnabled = true;
            this.Employees_mode.Location = new System.Drawing.Point(6, 337);
            this.Employees_mode.Name = "Employees_mode";
            this.Employees_mode.Size = new System.Drawing.Size(186, 28);
            this.Employees_mode.TabIndex = 10;
            this.Employees_mode.SelectedIndexChanged += new System.EventHandler(this.Employees_mode_SelectedIndexChanged);
            // 
            // Employees_mode_label
            // 
            this.Employees_mode_label.AutoSize = true;
            this.Employees_mode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_mode_label.Location = new System.Drawing.Point(2, 315);
            this.Employees_mode_label.Name = "Employees_mode_label";
            this.Employees_mode_label.Size = new System.Drawing.Size(64, 20);
            this.Employees_mode_label.TabIndex = 0;
            this.Employees_mode_label.Text = "Режим";
            // 
            // Employees_accept_button
            // 
            this.Employees_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employees_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Employees_accept_button.Name = "Employees_accept_button";
            this.Employees_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Employees_accept_button.TabIndex = 9;
            this.Employees_accept_button.Text = "Добавить";
            this.Employees_accept_button.UseVisualStyleBackColor = true;
            this.Employees_accept_button.Click += new System.EventHandler(this.Employees_accept_button_Click);
            // 
            // Employees_dataGridView
            // 
            this.Employees_dataGridView.AllowUserToAddRows = false;
            this.Employees_dataGridView.AllowUserToDeleteRows = false;
            this.Employees_dataGridView.AutoGenerateColumns = false;
            this.Employees_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employees_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn});
            this.Employees_dataGridView.DataSource = this.employeesBindingSource;
            this.Employees_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Employees_dataGridView.Name = "Employees_dataGridView";
            this.Employees_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Employees_dataGridView.RowTemplate.Height = 24;
            this.Employees_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Employees_dataGridView.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "specialization";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.beauty_saloonDataSet;
            // 
            // beauty_saloonDataSet
            // 
            this.beauty_saloonDataSet.DataSetName = "beauty_saloonDataSet";
            this.beauty_saloonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Employees_startdate
            // 
            this.Employees_startdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_startdate.Location = new System.Drawing.Point(633, 252);
            this.Employees_startdate.Name = "Employees_startdate";
            this.Employees_startdate.Size = new System.Drawing.Size(332, 22);
            this.Employees_startdate.TabIndex = 8;
            // 
            // Employees_specialization
            // 
            this.Employees_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_specialization.Location = new System.Drawing.Point(633, 216);
            this.Employees_specialization.Name = "Employees_specialization";
            this.Employees_specialization.Size = new System.Drawing.Size(332, 27);
            this.Employees_specialization.TabIndex = 7;
            // 
            // Employees_address
            // 
            this.Employees_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_address.Location = new System.Drawing.Point(633, 181);
            this.Employees_address.Name = "Employees_address";
            this.Employees_address.Size = new System.Drawing.Size(332, 27);
            this.Employees_address.TabIndex = 6;
            // 
            // Employees_number
            // 
            this.Employees_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_number.Location = new System.Drawing.Point(633, 146);
            this.Employees_number.Name = "Employees_number";
            this.Employees_number.Size = new System.Drawing.Size(332, 27);
            this.Employees_number.TabIndex = 5;
            // 
            // Employees_lastname
            // 
            this.Employees_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_lastname.Location = new System.Drawing.Point(633, 111);
            this.Employees_lastname.Name = "Employees_lastname";
            this.Employees_lastname.Size = new System.Drawing.Size(332, 27);
            this.Employees_lastname.TabIndex = 4;
            // 
            // Employees_name
            // 
            this.Employees_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_name.Location = new System.Drawing.Point(633, 76);
            this.Employees_name.Name = "Employees_name";
            this.Employees_name.Size = new System.Drawing.Size(332, 27);
            this.Employees_name.TabIndex = 3;
            // 
            // Employees_surname
            // 
            this.Employees_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_surname.Location = new System.Drawing.Point(633, 41);
            this.Employees_surname.Name = "Employees_surname";
            this.Employees_surname.Size = new System.Drawing.Size(332, 27);
            this.Employees_surname.TabIndex = 2;
            // 
            // Employees_startdate_label
            // 
            this.Employees_startdate_label.AutoSize = true;
            this.Employees_startdate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_startdate_label.Location = new System.Drawing.Point(443, 254);
            this.Employees_startdate_label.Name = "Employees_startdate_label";
            this.Employees_startdate_label.Size = new System.Drawing.Size(184, 20);
            this.Employees_startdate_label.TabIndex = 0;
            this.Employees_startdate_label.Text = "Дата начала работы";
            // 
            // Employees_specialization_label
            // 
            this.Employees_specialization_label.AutoSize = true;
            this.Employees_specialization_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_specialization_label.Location = new System.Drawing.Point(487, 219);
            this.Employees_specialization_label.Name = "Employees_specialization_label";
            this.Employees_specialization_label.Size = new System.Drawing.Size(140, 20);
            this.Employees_specialization_label.TabIndex = 0;
            this.Employees_specialization_label.Text = "Специализация";
            // 
            // Employees_address_label
            // 
            this.Employees_address_label.AutoSize = true;
            this.Employees_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_address_label.Location = new System.Drawing.Point(565, 184);
            this.Employees_address_label.Name = "Employees_address_label";
            this.Employees_address_label.Size = new System.Drawing.Size(62, 20);
            this.Employees_address_label.TabIndex = 0;
            this.Employees_address_label.Text = "Адрес";
            // 
            // Employees_number_label
            // 
            this.Employees_number_label.AutoSize = true;
            this.Employees_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_number_label.Location = new System.Drawing.Point(472, 149);
            this.Employees_number_label.Name = "Employees_number_label";
            this.Employees_number_label.Size = new System.Drawing.Size(155, 20);
            this.Employees_number_label.TabIndex = 0;
            this.Employees_number_label.Text = "Номер телефона";
            // 
            // Employees_lastname_label
            // 
            this.Employees_lastname_label.AutoSize = true;
            this.Employees_lastname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_lastname_label.Location = new System.Drawing.Point(536, 114);
            this.Employees_lastname_label.Name = "Employees_lastname_label";
            this.Employees_lastname_label.Size = new System.Drawing.Size(91, 20);
            this.Employees_lastname_label.TabIndex = 0;
            this.Employees_lastname_label.Text = "Отчество";
            // 
            // Employees_name_label
            // 
            this.Employees_name_label.AutoSize = true;
            this.Employees_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_name_label.Location = new System.Drawing.Point(585, 79);
            this.Employees_name_label.Name = "Employees_name_label";
            this.Employees_name_label.Size = new System.Drawing.Size(42, 20);
            this.Employees_name_label.TabIndex = 0;
            this.Employees_name_label.Text = "Имя";
            // 
            // Employees_surname_label
            // 
            this.Employees_surname_label.AutoSize = true;
            this.Employees_surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_surname_label.Location = new System.Drawing.Point(540, 44);
            this.Employees_surname_label.Name = "Employees_surname_label";
            this.Employees_surname_label.Size = new System.Drawing.Size(87, 20);
            this.Employees_surname_label.TabIndex = 0;
            this.Employees_surname_label.Text = "Фамилия";
            // 
            // Services
            // 
            this.Services.Controls.Add(this.Services_serviceID);
            this.Services.Controls.Add(this.Services_serviceID_label);
            this.Services.Controls.Add(this.Services_mode);
            this.Services.Controls.Add(this.Services_mode_label);
            this.Services.Controls.Add(this.Services_accept_button);
            this.Services.Controls.Add(this.Services_dataGridView);
            this.Services.Controls.Add(this.Services_comment);
            this.Services.Controls.Add(this.Services_price);
            this.Services.Controls.Add(this.Services_name);
            this.Services.Controls.Add(this.Services_comment_label);
            this.Services.Controls.Add(this.Services_price_label);
            this.Services.Controls.Add(this.Services_name_label);
            this.Services.Location = new System.Drawing.Point(4, 25);
            this.Services.Name = "Services";
            this.Services.Padding = new System.Windows.Forms.Padding(3);
            this.Services.Size = new System.Drawing.Size(974, 724);
            this.Services.TabIndex = 1;
            this.Services.Text = "Услуги";
            this.Services.UseVisualStyleBackColor = true;
            // 
            // Services_serviceID
            // 
            this.Services_serviceID.Enabled = false;
            this.Services_serviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_serviceID.Location = new System.Drawing.Point(634, 8);
            this.Services_serviceID.Name = "Services_serviceID";
            this.Services_serviceID.Size = new System.Drawing.Size(332, 27);
            this.Services_serviceID.TabIndex = 1;
            // 
            // Services_serviceID_label
            // 
            this.Services_serviceID_label.AutoSize = true;
            this.Services_serviceID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_serviceID_label.Location = new System.Drawing.Point(527, 11);
            this.Services_serviceID_label.Name = "Services_serviceID_label";
            this.Services_serviceID_label.Size = new System.Drawing.Size(100, 20);
            this.Services_serviceID_label.TabIndex = 0;
            this.Services_serviceID_label.Text = "Код услуги";
            // 
            // Services_mode
            // 
            this.Services_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Services_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_mode.FormattingEnabled = true;
            this.Services_mode.Location = new System.Drawing.Point(6, 337);
            this.Services_mode.Name = "Services_mode";
            this.Services_mode.Size = new System.Drawing.Size(186, 28);
            this.Services_mode.TabIndex = 6;
            this.Services_mode.SelectedIndexChanged += new System.EventHandler(this.Services_mode_SelectedIndexChanged);
            // 
            // Services_mode_label
            // 
            this.Services_mode_label.AutoSize = true;
            this.Services_mode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_mode_label.Location = new System.Drawing.Point(2, 315);
            this.Services_mode_label.Name = "Services_mode_label";
            this.Services_mode_label.Size = new System.Drawing.Size(64, 20);
            this.Services_mode_label.TabIndex = 0;
            this.Services_mode_label.Text = "Режим";
            // 
            // Services_accept_button
            // 
            this.Services_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Services_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Services_accept_button.Name = "Services_accept_button";
            this.Services_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Services_accept_button.TabIndex = 5;
            this.Services_accept_button.Text = "Добавить";
            this.Services_accept_button.UseVisualStyleBackColor = true;
            this.Services_accept_button.Click += new System.EventHandler(this.Services_accept_button_Click);
            // 
            // Services_dataGridView
            // 
            this.Services_dataGridView.AllowUserToAddRows = false;
            this.Services_dataGridView.AllowUserToDeleteRows = false;
            this.Services_dataGridView.AutoGenerateColumns = false;
            this.Services_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Services_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.Services_dataGridView.DataSource = this.servicesBindingSource;
            this.Services_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Services_dataGridView.Name = "Services_dataGridView";
            this.Services_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Services_dataGridView.RowTemplate.Height = 24;
            this.Services_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Services_dataGridView.TabIndex = 0;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.beauty_saloonDataSet;
            // 
            // Services_comment
            // 
            this.Services_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_comment.Location = new System.Drawing.Point(634, 111);
            this.Services_comment.Multiline = true;
            this.Services_comment.Name = "Services_comment";
            this.Services_comment.Size = new System.Drawing.Size(332, 129);
            this.Services_comment.TabIndex = 4;
            // 
            // Services_price
            // 
            this.Services_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_price.Location = new System.Drawing.Point(634, 76);
            this.Services_price.Name = "Services_price";
            this.Services_price.Size = new System.Drawing.Size(332, 27);
            this.Services_price.TabIndex = 3;
            // 
            // Services_name
            // 
            this.Services_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_name.Location = new System.Drawing.Point(634, 41);
            this.Services_name.Name = "Services_name";
            this.Services_name.Size = new System.Drawing.Size(332, 27);
            this.Services_name.TabIndex = 2;
            // 
            // Services_comment_label
            // 
            this.Services_comment_label.AutoSize = true;
            this.Services_comment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_comment_label.Location = new System.Drawing.Point(504, 114);
            this.Services_comment_label.Name = "Services_comment_label";
            this.Services_comment_label.Size = new System.Drawing.Size(124, 20);
            this.Services_comment_label.TabIndex = 0;
            this.Services_comment_label.Text = "Комментарий";
            // 
            // Services_price_label
            // 
            this.Services_price_label.AutoSize = true;
            this.Services_price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_price_label.Location = new System.Drawing.Point(575, 79);
            this.Services_price_label.Name = "Services_price_label";
            this.Services_price_label.Size = new System.Drawing.Size(52, 20);
            this.Services_price_label.TabIndex = 0;
            this.Services_price_label.Text = "Цена";
            // 
            // Services_name_label
            // 
            this.Services_name_label.AutoSize = true;
            this.Services_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_name_label.Location = new System.Drawing.Point(493, 44);
            this.Services_name_label.Name = "Services_name_label";
            this.Services_name_label.Size = new System.Drawing.Size(134, 20);
            this.Services_name_label.TabIndex = 0;
            this.Services_name_label.Text = "Наименование";
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.Clients_clientID);
            this.Clients.Controls.Add(this.Clients_clientID_label);
            this.Clients.Controls.Add(this.Clients_mode);
            this.Clients.Controls.Add(this.Clients_mode_label);
            this.Clients.Controls.Add(this.Clients_button);
            this.Clients.Controls.Add(this.Clients_dataGridView);
            this.Clients.Controls.Add(this.Clients_phonenumber);
            this.Clients.Controls.Add(this.Clients_name);
            this.Clients.Controls.Add(this.Clients_surname);
            this.Clients.Controls.Add(this.Clients_phonenumber_label);
            this.Clients.Controls.Add(this.Clients_name_label);
            this.Clients.Controls.Add(this.Clients_surname_label);
            this.Clients.Location = new System.Drawing.Point(4, 25);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(974, 724);
            this.Clients.TabIndex = 2;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // Clients_clientID
            // 
            this.Clients_clientID.Enabled = false;
            this.Clients_clientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_clientID.Location = new System.Drawing.Point(634, 8);
            this.Clients_clientID.Name = "Clients_clientID";
            this.Clients_clientID.Size = new System.Drawing.Size(332, 27);
            this.Clients_clientID.TabIndex = 1;
            // 
            // Clients_clientID_label
            // 
            this.Clients_clientID_label.AutoSize = true;
            this.Clients_clientID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_clientID_label.Location = new System.Drawing.Point(511, 11);
            this.Clients_clientID_label.Name = "Clients_clientID_label";
            this.Clients_clientID_label.Size = new System.Drawing.Size(116, 20);
            this.Clients_clientID_label.TabIndex = 0;
            this.Clients_clientID_label.Text = "Код клиента";
            // 
            // Clients_mode
            // 
            this.Clients_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Clients_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_mode.FormattingEnabled = true;
            this.Clients_mode.Location = new System.Drawing.Point(6, 337);
            this.Clients_mode.Name = "Clients_mode";
            this.Clients_mode.Size = new System.Drawing.Size(186, 28);
            this.Clients_mode.TabIndex = 6;
            this.Clients_mode.SelectedIndexChanged += new System.EventHandler(this.Clients_mode_SelectedIndexChanged);
            // 
            // Clients_mode_label
            // 
            this.Clients_mode_label.AutoSize = true;
            this.Clients_mode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_mode_label.Location = new System.Drawing.Point(2, 315);
            this.Clients_mode_label.Name = "Clients_mode_label";
            this.Clients_mode_label.Size = new System.Drawing.Size(64, 20);
            this.Clients_mode_label.TabIndex = 0;
            this.Clients_mode_label.Text = "Режим";
            // 
            // Clients_button
            // 
            this.Clients_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clients_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_button.Location = new System.Drawing.Point(766, 315);
            this.Clients_button.Name = "Clients_button";
            this.Clients_button.Size = new System.Drawing.Size(200, 50);
            this.Clients_button.TabIndex = 5;
            this.Clients_button.Text = "Добавить";
            this.Clients_button.UseVisualStyleBackColor = true;
            this.Clients_button.Click += new System.EventHandler(this.Clients_button_Click);
            // 
            // Clients_dataGridView
            // 
            this.Clients_dataGridView.AllowUserToAddRows = false;
            this.Clients_dataGridView.AllowUserToDeleteRows = false;
            this.Clients_dataGridView.AutoGenerateColumns = false;
            this.Clients_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clients_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn2,
            this.phonenumberDataGridViewTextBoxColumn1});
            this.Clients_dataGridView.DataSource = this.clientsBindingSource;
            this.Clients_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Clients_dataGridView.Name = "Clients_dataGridView";
            this.Clients_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Clients_dataGridView.RowTemplate.Height = 24;
            this.Clients_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Clients_dataGridView.TabIndex = 0;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "clientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "clientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // phonenumberDataGridViewTextBoxColumn1
            // 
            this.phonenumberDataGridViewTextBoxColumn1.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn1.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn1.Name = "phonenumberDataGridViewTextBoxColumn1";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.beauty_saloonDataSet;
            // 
            // Clients_phonenumber
            // 
            this.Clients_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_phonenumber.Location = new System.Drawing.Point(634, 111);
            this.Clients_phonenumber.Multiline = true;
            this.Clients_phonenumber.Name = "Clients_phonenumber";
            this.Clients_phonenumber.Size = new System.Drawing.Size(332, 27);
            this.Clients_phonenumber.TabIndex = 4;
            // 
            // Clients_name
            // 
            this.Clients_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_name.Location = new System.Drawing.Point(634, 76);
            this.Clients_name.Name = "Clients_name";
            this.Clients_name.Size = new System.Drawing.Size(332, 27);
            this.Clients_name.TabIndex = 3;
            // 
            // Clients_surname
            // 
            this.Clients_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_surname.Location = new System.Drawing.Point(634, 41);
            this.Clients_surname.Name = "Clients_surname";
            this.Clients_surname.Size = new System.Drawing.Size(332, 27);
            this.Clients_surname.TabIndex = 2;
            // 
            // Clients_phonenumber_label
            // 
            this.Clients_phonenumber_label.AutoSize = true;
            this.Clients_phonenumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_phonenumber_label.Location = new System.Drawing.Point(472, 114);
            this.Clients_phonenumber_label.Name = "Clients_phonenumber_label";
            this.Clients_phonenumber_label.Size = new System.Drawing.Size(155, 20);
            this.Clients_phonenumber_label.TabIndex = 0;
            this.Clients_phonenumber_label.Text = "Номер телефона";
            // 
            // Clients_name_label
            // 
            this.Clients_name_label.AutoSize = true;
            this.Clients_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_name_label.Location = new System.Drawing.Point(585, 79);
            this.Clients_name_label.Name = "Clients_name_label";
            this.Clients_name_label.Size = new System.Drawing.Size(42, 20);
            this.Clients_name_label.TabIndex = 0;
            this.Clients_name_label.Text = "Имя";
            // 
            // Clients_surname_label
            // 
            this.Clients_surname_label.AutoSize = true;
            this.Clients_surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_surname_label.Location = new System.Drawing.Point(540, 44);
            this.Clients_surname_label.Name = "Clients_surname_label";
            this.Clients_surname_label.Size = new System.Drawing.Size(87, 20);
            this.Clients_surname_label.TabIndex = 0;
            this.Clients_surname_label.Text = "Фамилия";
            // 
            // Records
            // 
            this.Records.Controls.Add(this.Records_recordID);
            this.Records.Controls.Add(this.Records_recordID_label);
            this.Records.Controls.Add(this.Records_mode);
            this.Records.Controls.Add(this.Records_mode_label);
            this.Records.Controls.Add(this.Records_datetime);
            this.Records.Controls.Add(this.Records_accept_button);
            this.Records.Controls.Add(this.Records_dataGridView);
            this.Records.Controls.Add(this.Records_comment);
            this.Records.Controls.Add(this.Records_serviceID);
            this.Records.Controls.Add(this.Records_employeeID);
            this.Records.Controls.Add(this.Records_clientID);
            this.Records.Controls.Add(this.Records_comment_label);
            this.Records.Controls.Add(this.Records_datetime_label);
            this.Records.Controls.Add(this.Records_serviceid_label);
            this.Records.Controls.Add(this.Records_employeeID_label);
            this.Records.Controls.Add(this.Records_clientID_label);
            this.Records.Location = new System.Drawing.Point(4, 25);
            this.Records.Name = "Records";
            this.Records.Padding = new System.Windows.Forms.Padding(3);
            this.Records.Size = new System.Drawing.Size(974, 724);
            this.Records.TabIndex = 3;
            this.Records.Text = "Записи";
            this.Records.UseVisualStyleBackColor = true;
            // 
            // Records_recordID
            // 
            this.Records_recordID.Enabled = false;
            this.Records_recordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_recordID.Location = new System.Drawing.Point(634, 8);
            this.Records_recordID.Name = "Records_recordID";
            this.Records_recordID.Size = new System.Drawing.Size(332, 27);
            this.Records_recordID.TabIndex = 1;
            // 
            // Records_recordID_label
            // 
            this.Records_recordID_label.AutoSize = true;
            this.Records_recordID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_recordID_label.Location = new System.Drawing.Point(523, 11);
            this.Records_recordID_label.Name = "Records_recordID_label";
            this.Records_recordID_label.Size = new System.Drawing.Size(105, 20);
            this.Records_recordID_label.TabIndex = 0;
            this.Records_recordID_label.Text = "Код записи";
            // 
            // Records_mode
            // 
            this.Records_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Records_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_mode.FormattingEnabled = true;
            this.Records_mode.Location = new System.Drawing.Point(6, 337);
            this.Records_mode.Name = "Records_mode";
            this.Records_mode.Size = new System.Drawing.Size(186, 28);
            this.Records_mode.TabIndex = 8;
            this.Records_mode.SelectedIndexChanged += new System.EventHandler(this.Records_mode_SelectedIndexChanged);
            // 
            // Records_mode_label
            // 
            this.Records_mode_label.AutoSize = true;
            this.Records_mode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_mode_label.Location = new System.Drawing.Point(2, 315);
            this.Records_mode_label.Name = "Records_mode_label";
            this.Records_mode_label.Size = new System.Drawing.Size(64, 20);
            this.Records_mode_label.TabIndex = 0;
            this.Records_mode_label.Text = "Режим";
            // 
            // Records_datetime
            // 
            this.Records_datetime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_datetime.Location = new System.Drawing.Point(634, 147);
            this.Records_datetime.Name = "Records_datetime";
            this.Records_datetime.Size = new System.Drawing.Size(332, 22);
            this.Records_datetime.TabIndex = 5;
            // 
            // Records_accept_button
            // 
            this.Records_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Records_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Records_accept_button.Name = "Records_accept_button";
            this.Records_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Records_accept_button.TabIndex = 7;
            this.Records_accept_button.Text = "Добавить";
            this.Records_accept_button.UseVisualStyleBackColor = true;
            this.Records_accept_button.Click += new System.EventHandler(this.Records_accept_button_Click);
            // 
            // Records_dataGridView
            // 
            this.Records_dataGridView.AllowUserToAddRows = false;
            this.Records_dataGridView.AllowUserToDeleteRows = false;
            this.Records_dataGridView.AutoGenerateColumns = false;
            this.Records_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Records_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIDDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn1,
            this.employeeidDataGridViewTextBoxColumn1,
            this.serviceidDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn1});
            this.Records_dataGridView.DataSource = this.recordsBindingSource;
            this.Records_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Records_dataGridView.Name = "Records_dataGridView";
            this.Records_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Records_dataGridView.RowTemplate.Height = 24;
            this.Records_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Records_dataGridView.TabIndex = 0;
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "recordID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "recordID";
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientidDataGridViewTextBoxColumn1
            // 
            this.clientidDataGridViewTextBoxColumn1.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn1.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn1.Name = "clientidDataGridViewTextBoxColumn1";
            // 
            // employeeidDataGridViewTextBoxColumn1
            // 
            this.employeeidDataGridViewTextBoxColumn1.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn1.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn1.Name = "employeeidDataGridViewTextBoxColumn1";
            // 
            // serviceidDataGridViewTextBoxColumn1
            // 
            this.serviceidDataGridViewTextBoxColumn1.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn1.HeaderText = "service_id";
            this.serviceidDataGridViewTextBoxColumn1.Name = "serviceidDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            // 
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataMember = "records";
            this.recordsBindingSource.DataSource = this.beauty_saloonDataSet;
            // 
            // Records_comment
            // 
            this.Records_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_comment.Location = new System.Drawing.Point(635, 178);
            this.Records_comment.Multiline = true;
            this.Records_comment.Name = "Records_comment";
            this.Records_comment.Size = new System.Drawing.Size(332, 94);
            this.Records_comment.TabIndex = 6;
            // 
            // Records_serviceID
            // 
            this.Records_serviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_serviceID.Location = new System.Drawing.Point(634, 111);
            this.Records_serviceID.Name = "Records_serviceID";
            this.Records_serviceID.Size = new System.Drawing.Size(332, 27);
            this.Records_serviceID.TabIndex = 4;
            // 
            // Records_employeeID
            // 
            this.Records_employeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_employeeID.Location = new System.Drawing.Point(634, 76);
            this.Records_employeeID.Name = "Records_employeeID";
            this.Records_employeeID.Size = new System.Drawing.Size(332, 27);
            this.Records_employeeID.TabIndex = 3;
            // 
            // Records_clientID
            // 
            this.Records_clientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_clientID.Location = new System.Drawing.Point(634, 41);
            this.Records_clientID.Name = "Records_clientID";
            this.Records_clientID.Size = new System.Drawing.Size(332, 27);
            this.Records_clientID.TabIndex = 2;
            // 
            // Records_comment_label
            // 
            this.Records_comment_label.AutoSize = true;
            this.Records_comment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_comment_label.Location = new System.Drawing.Point(505, 181);
            this.Records_comment_label.Name = "Records_comment_label";
            this.Records_comment_label.Size = new System.Drawing.Size(124, 20);
            this.Records_comment_label.TabIndex = 0;
            this.Records_comment_label.Text = "Комментарий";
            // 
            // Records_datetime_label
            // 
            this.Records_datetime_label.AutoSize = true;
            this.Records_datetime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_datetime_label.Location = new System.Drawing.Point(504, 149);
            this.Records_datetime_label.Name = "Records_datetime_label";
            this.Records_datetime_label.Size = new System.Drawing.Size(124, 20);
            this.Records_datetime_label.TabIndex = 0;
            this.Records_datetime_label.Text = "Дата и время";
            // 
            // Records_serviceid_label
            // 
            this.Records_serviceid_label.AutoSize = true;
            this.Records_serviceid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_serviceid_label.Location = new System.Drawing.Point(528, 114);
            this.Records_serviceid_label.Name = "Records_serviceid_label";
            this.Records_serviceid_label.Size = new System.Drawing.Size(100, 20);
            this.Records_serviceid_label.TabIndex = 0;
            this.Records_serviceid_label.Text = "Код услуги";
            // 
            // Records_employeeID_label
            // 
            this.Records_employeeID_label.AutoSize = true;
            this.Records_employeeID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_employeeID_label.Location = new System.Drawing.Point(483, 79);
            this.Records_employeeID_label.Name = "Records_employeeID_label";
            this.Records_employeeID_label.Size = new System.Drawing.Size(145, 20);
            this.Records_employeeID_label.TabIndex = 0;
            this.Records_employeeID_label.Text = "Код сотрудника";
            // 
            // Records_clientID_label
            // 
            this.Records_clientID_label.AutoSize = true;
            this.Records_clientID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_clientID_label.Location = new System.Drawing.Point(512, 44);
            this.Records_clientID_label.Name = "Records_clientID_label";
            this.Records_clientID_label.Size = new System.Drawing.Size(116, 20);
            this.Records_clientID_label.TabIndex = 0;
            this.Records_clientID_label.Text = "Код клиента";
            // 
            // Shares
            // 
            this.Shares.Controls.Add(this.Shares_shareID);
            this.Shares.Controls.Add(this.Shares_shareID_label);
            this.Shares.Controls.Add(this.Shares_mode);
            this.Shares.Controls.Add(this.Shares_mode_label);
            this.Shares.Controls.Add(this.Shares_expirationdate);
            this.Shares.Controls.Add(this.Shares_startdate);
            this.Shares.Controls.Add(this.Shares_accept_button);
            this.Shares.Controls.Add(this.Shares_dataGridView);
            this.Shares.Controls.Add(this.Shares_name);
            this.Shares.Controls.Add(this.Shares_expirationdate_label);
            this.Shares.Controls.Add(this.Shares_startdate_label);
            this.Shares.Controls.Add(this.Shares_name_label);
            this.Shares.Location = new System.Drawing.Point(4, 25);
            this.Shares.Name = "Shares";
            this.Shares.Padding = new System.Windows.Forms.Padding(3);
            this.Shares.Size = new System.Drawing.Size(974, 724);
            this.Shares.TabIndex = 4;
            this.Shares.Text = "Акции";
            this.Shares.UseVisualStyleBackColor = true;
            // 
            // Shares_shareID
            // 
            this.Shares_shareID.Enabled = false;
            this.Shares_shareID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_shareID.Location = new System.Drawing.Point(634, 8);
            this.Shares_shareID.Name = "Shares_shareID";
            this.Shares_shareID.Size = new System.Drawing.Size(332, 27);
            this.Shares_shareID.TabIndex = 1;
            // 
            // Shares_shareID_label
            // 
            this.Shares_shareID_label.AutoSize = true;
            this.Shares_shareID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_shareID_label.Location = new System.Drawing.Point(532, 11);
            this.Shares_shareID_label.Name = "Shares_shareID_label";
            this.Shares_shareID_label.Size = new System.Drawing.Size(96, 20);
            this.Shares_shareID_label.TabIndex = 0;
            this.Shares_shareID_label.Text = "Код акции";
            // 
            // Shares_mode
            // 
            this.Shares_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Shares_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_mode.FormattingEnabled = true;
            this.Shares_mode.Location = new System.Drawing.Point(6, 337);
            this.Shares_mode.Name = "Shares_mode";
            this.Shares_mode.Size = new System.Drawing.Size(186, 28);
            this.Shares_mode.TabIndex = 6;
            this.Shares_mode.SelectedIndexChanged += new System.EventHandler(this.Shares_mode_SelectedIndexChanged);
            // 
            // Shares_mode_label
            // 
            this.Shares_mode_label.AutoSize = true;
            this.Shares_mode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_mode_label.Location = new System.Drawing.Point(2, 315);
            this.Shares_mode_label.Name = "Shares_mode_label";
            this.Shares_mode_label.Size = new System.Drawing.Size(64, 20);
            this.Shares_mode_label.TabIndex = 0;
            this.Shares_mode_label.Text = "Режим";
            // 
            // Shares_expirationdate
            // 
            this.Shares_expirationdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_expirationdate.Location = new System.Drawing.Point(634, 112);
            this.Shares_expirationdate.Name = "Shares_expirationdate";
            this.Shares_expirationdate.Size = new System.Drawing.Size(332, 22);
            this.Shares_expirationdate.TabIndex = 4;
            // 
            // Shares_startdate
            // 
            this.Shares_startdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_startdate.Location = new System.Drawing.Point(634, 77);
            this.Shares_startdate.Name = "Shares_startdate";
            this.Shares_startdate.Size = new System.Drawing.Size(332, 22);
            this.Shares_startdate.TabIndex = 3;
            // 
            // Shares_accept_button
            // 
            this.Shares_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shares_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Shares_accept_button.Name = "Shares_accept_button";
            this.Shares_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Shares_accept_button.TabIndex = 5;
            this.Shares_accept_button.Text = "Добавить";
            this.Shares_accept_button.UseVisualStyleBackColor = true;
            this.Shares_accept_button.Click += new System.EventHandler(this.Shares_accept_button_Click);
            // 
            // Shares_dataGridView
            // 
            this.Shares_dataGridView.AllowUserToAddRows = false;
            this.Shares_dataGridView.AllowUserToDeleteRows = false;
            this.Shares_dataGridView.AutoGenerateColumns = false;
            this.Shares_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shares_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shareIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn3,
            this.startdateDataGridViewTextBoxColumn1,
            this.expirationdateDataGridViewTextBoxColumn});
            this.Shares_dataGridView.DataSource = this.sharesBindingSource;
            this.Shares_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Shares_dataGridView.Name = "Shares_dataGridView";
            this.Shares_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Shares_dataGridView.RowTemplate.Height = 24;
            this.Shares_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Shares_dataGridView.TabIndex = 0;
            // 
            // shareIDDataGridViewTextBoxColumn
            // 
            this.shareIDDataGridViewTextBoxColumn.DataPropertyName = "shareID";
            this.shareIDDataGridViewTextBoxColumn.HeaderText = "shareID";
            this.shareIDDataGridViewTextBoxColumn.Name = "shareIDDataGridViewTextBoxColumn";
            this.shareIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            // 
            // startdateDataGridViewTextBoxColumn1
            // 
            this.startdateDataGridViewTextBoxColumn1.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn1.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn1.Name = "startdateDataGridViewTextBoxColumn1";
            // 
            // expirationdateDataGridViewTextBoxColumn
            // 
            this.expirationdateDataGridViewTextBoxColumn.DataPropertyName = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn.HeaderText = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn.Name = "expirationdateDataGridViewTextBoxColumn";
            // 
            // sharesBindingSource
            // 
            this.sharesBindingSource.DataMember = "shares";
            this.sharesBindingSource.DataSource = this.beauty_saloonDataSet;
            // 
            // Shares_name
            // 
            this.Shares_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_name.Location = new System.Drawing.Point(634, 41);
            this.Shares_name.Name = "Shares_name";
            this.Shares_name.Size = new System.Drawing.Size(332, 27);
            this.Shares_name.TabIndex = 2;
            // 
            // Shares_expirationdate_label
            // 
            this.Shares_expirationdate_label.AutoSize = true;
            this.Shares_expirationdate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_expirationdate_label.Location = new System.Drawing.Point(482, 114);
            this.Shares_expirationdate_label.Name = "Shares_expirationdate_label";
            this.Shares_expirationdate_label.Size = new System.Drawing.Size(146, 20);
            this.Shares_expirationdate_label.TabIndex = 0;
            this.Shares_expirationdate_label.Text = "Дата истечения";
            // 
            // Shares_startdate_label
            // 
            this.Shares_startdate_label.AutoSize = true;
            this.Shares_startdate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_startdate_label.Location = new System.Drawing.Point(511, 79);
            this.Shares_startdate_label.Name = "Shares_startdate_label";
            this.Shares_startdate_label.Size = new System.Drawing.Size(117, 20);
            this.Shares_startdate_label.TabIndex = 0;
            this.Shares_startdate_label.Text = "Дата начала";
            // 
            // Shares_name_label
            // 
            this.Shares_name_label.AutoSize = true;
            this.Shares_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_name_label.Location = new System.Drawing.Point(494, 44);
            this.Shares_name_label.Name = "Shares_name_label";
            this.Shares_name_label.Size = new System.Drawing.Size(134, 20);
            this.Shares_name_label.TabIndex = 0;
            this.Shares_name_label.Text = "Наименование";
            // 
            // Discounts
            // 
            this.Discounts.Controls.Add(this.Discounts_discountID);
            this.Discounts.Controls.Add(this.Discounts_discountID_label);
            this.Discounts.Controls.Add(this.Discounts_mode);
            this.Discounts.Controls.Add(this.Discounts_mode_label);
            this.Discounts.Controls.Add(this.Discounts_accept_button);
            this.Discounts.Controls.Add(this.Discounts_dataGridView);
            this.Discounts.Controls.Add(this.Discounts_value);
            this.Discounts.Controls.Add(this.Discounts_serviceID);
            this.Discounts.Controls.Add(this.Discounts_shareID);
            this.Discounts.Controls.Add(this.Discounts_value_label);
            this.Discounts.Controls.Add(this.Discounts_serviceID_label);
            this.Discounts.Controls.Add(this.Discounts_shareID_label);
            this.Discounts.Location = new System.Drawing.Point(4, 25);
            this.Discounts.Name = "Discounts";
            this.Discounts.Padding = new System.Windows.Forms.Padding(3);
            this.Discounts.Size = new System.Drawing.Size(974, 724);
            this.Discounts.TabIndex = 5;
            this.Discounts.Text = "Скидки";
            this.Discounts.UseVisualStyleBackColor = true;
            // 
            // Discounts_discountID
            // 
            this.Discounts_discountID.Enabled = false;
            this.Discounts_discountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_discountID.Location = new System.Drawing.Point(634, 8);
            this.Discounts_discountID.Name = "Discounts_discountID";
            this.Discounts_discountID.Size = new System.Drawing.Size(332, 27);
            this.Discounts_discountID.TabIndex = 1;
            // 
            // Discounts_discountID_label
            // 
            this.Discounts_discountID_label.AutoSize = true;
            this.Discounts_discountID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_discountID_label.Location = new System.Drawing.Point(522, 11);
            this.Discounts_discountID_label.Name = "Discounts_discountID_label";
            this.Discounts_discountID_label.Size = new System.Drawing.Size(106, 20);
            this.Discounts_discountID_label.TabIndex = 0;
            this.Discounts_discountID_label.Text = "Код скидки";
            // 
            // Discounts_mode
            // 
            this.Discounts_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Discounts_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_mode.FormattingEnabled = true;
            this.Discounts_mode.Location = new System.Drawing.Point(6, 337);
            this.Discounts_mode.Name = "Discounts_mode";
            this.Discounts_mode.Size = new System.Drawing.Size(186, 28);
            this.Discounts_mode.TabIndex = 6;
            this.Discounts_mode.SelectedIndexChanged += new System.EventHandler(this.Discounts_mode_SelectedIndexChanged);
            // 
            // Discounts_mode_label
            // 
            this.Discounts_mode_label.AutoSize = true;
            this.Discounts_mode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_mode_label.Location = new System.Drawing.Point(2, 315);
            this.Discounts_mode_label.Name = "Discounts_mode_label";
            this.Discounts_mode_label.Size = new System.Drawing.Size(64, 20);
            this.Discounts_mode_label.TabIndex = 0;
            this.Discounts_mode_label.Text = "Режим";
            // 
            // Discounts_accept_button
            // 
            this.Discounts_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Discounts_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Discounts_accept_button.Name = "Discounts_accept_button";
            this.Discounts_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Discounts_accept_button.TabIndex = 5;
            this.Discounts_accept_button.Text = "Добавить";
            this.Discounts_accept_button.UseVisualStyleBackColor = true;
            this.Discounts_accept_button.Click += new System.EventHandler(this.Discounts_accept_button_Click);
            // 
            // Discounts_dataGridView
            // 
            this.Discounts_dataGridView.AllowUserToAddRows = false;
            this.Discounts_dataGridView.AllowUserToDeleteRows = false;
            this.Discounts_dataGridView.AutoGenerateColumns = false;
            this.Discounts_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Discounts_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.discountIDDataGridViewTextBoxColumn,
            this.shareidDataGridViewTextBoxColumn1,
            this.serviceidDataGridViewTextBoxColumn2,
            this.valueDataGridViewTextBoxColumn});
            this.Discounts_dataGridView.DataSource = this.discountsBindingSource;
            this.Discounts_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Discounts_dataGridView.Name = "Discounts_dataGridView";
            this.Discounts_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Discounts_dataGridView.RowTemplate.Height = 24;
            this.Discounts_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Discounts_dataGridView.TabIndex = 0;
            // 
            // discountIDDataGridViewTextBoxColumn
            // 
            this.discountIDDataGridViewTextBoxColumn.DataPropertyName = "discountID";
            this.discountIDDataGridViewTextBoxColumn.HeaderText = "discountID";
            this.discountIDDataGridViewTextBoxColumn.Name = "discountIDDataGridViewTextBoxColumn";
            this.discountIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shareidDataGridViewTextBoxColumn1
            // 
            this.shareidDataGridViewTextBoxColumn1.DataPropertyName = "share_id";
            this.shareidDataGridViewTextBoxColumn1.HeaderText = "share_id";
            this.shareidDataGridViewTextBoxColumn1.Name = "shareidDataGridViewTextBoxColumn1";
            // 
            // serviceidDataGridViewTextBoxColumn2
            // 
            this.serviceidDataGridViewTextBoxColumn2.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn2.HeaderText = "service_id";
            this.serviceidDataGridViewTextBoxColumn2.Name = "serviceidDataGridViewTextBoxColumn2";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // discountsBindingSource
            // 
            this.discountsBindingSource.DataMember = "discounts";
            this.discountsBindingSource.DataSource = this.beauty_saloonDataSet;
            // 
            // Discounts_value
            // 
            this.Discounts_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_value.Location = new System.Drawing.Point(634, 111);
            this.Discounts_value.Multiline = true;
            this.Discounts_value.Name = "Discounts_value";
            this.Discounts_value.Size = new System.Drawing.Size(332, 27);
            this.Discounts_value.TabIndex = 4;
            // 
            // Discounts_serviceID
            // 
            this.Discounts_serviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_serviceID.Location = new System.Drawing.Point(634, 76);
            this.Discounts_serviceID.Name = "Discounts_serviceID";
            this.Discounts_serviceID.Size = new System.Drawing.Size(332, 27);
            this.Discounts_serviceID.TabIndex = 3;
            // 
            // Discounts_shareID
            // 
            this.Discounts_shareID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_shareID.Location = new System.Drawing.Point(634, 41);
            this.Discounts_shareID.Name = "Discounts_shareID";
            this.Discounts_shareID.Size = new System.Drawing.Size(332, 27);
            this.Discounts_shareID.TabIndex = 2;
            // 
            // Discounts_value_label
            // 
            this.Discounts_value_label.AutoSize = true;
            this.Discounts_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_value_label.Location = new System.Drawing.Point(473, 114);
            this.Discounts_value_label.Name = "Discounts_value_label";
            this.Discounts_value_label.Size = new System.Drawing.Size(155, 20);
            this.Discounts_value_label.TabIndex = 0;
            this.Discounts_value_label.Text = "Величина скидки";
            // 
            // Discounts_serviceID_label
            // 
            this.Discounts_serviceID_label.AutoSize = true;
            this.Discounts_serviceID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_serviceID_label.Location = new System.Drawing.Point(528, 79);
            this.Discounts_serviceID_label.Name = "Discounts_serviceID_label";
            this.Discounts_serviceID_label.Size = new System.Drawing.Size(100, 20);
            this.Discounts_serviceID_label.TabIndex = 0;
            this.Discounts_serviceID_label.Text = "Код услуги";
            // 
            // Discounts_shareID_label
            // 
            this.Discounts_shareID_label.AutoSize = true;
            this.Discounts_shareID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_shareID_label.Location = new System.Drawing.Point(532, 44);
            this.Discounts_shareID_label.Name = "Discounts_shareID_label";
            this.Discounts_shareID_label.Size = new System.Drawing.Size(96, 20);
            this.Discounts_shareID_label.TabIndex = 0;
            this.Discounts_shareID_label.Text = "Код акции";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // recordsTableAdapter
            // 
            this.recordsTableAdapter.ClearBeforeFill = true;
            // 
            // sharesTableAdapter
            // 
            this.sharesTableAdapter.ClearBeforeFill = true;
            // 
            // discountsTableAdapter
            // 
            this.discountsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД \"Салон красоты\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.Employees.ResumeLayout(false);
            this.Employees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employees_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_saloonDataSet)).EndInit();
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.Clients.ResumeLayout(false);
            this.Clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clients_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.Records.ResumeLayout(false);
            this.Records.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Records_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            this.Shares.ResumeLayout(false);
            this.Shares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shares_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharesBindingSource)).EndInit();
            this.Discounts.ResumeLayout(false);
            this.Discounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discounts_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Services;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.Label Employees_startdate_label;
        private System.Windows.Forms.Label Employees_specialization_label;
        private System.Windows.Forms.Label Employees_address_label;
        private System.Windows.Forms.Label Employees_number_label;
        private System.Windows.Forms.Label Employees_lastname_label;
        private System.Windows.Forms.Label Employees_name_label;
        private System.Windows.Forms.Label Employees_surname_label;
        private System.Windows.Forms.TextBox Employees_specialization;
        private System.Windows.Forms.TextBox Employees_address;
        private System.Windows.Forms.TextBox Employees_number;
        private System.Windows.Forms.TextBox Employees_lastname;
        private System.Windows.Forms.TextBox Employees_name;
        private System.Windows.Forms.TextBox Employees_surname;
        private System.Windows.Forms.DataGridView Employees_dataGridView;
        private System.Windows.Forms.DateTimePicker Employees_startdate;
        private System.Windows.Forms.DataGridView Services_dataGridView;
        private System.Windows.Forms.TextBox Services_comment;
        private System.Windows.Forms.TextBox Services_price;
        private System.Windows.Forms.TextBox Services_name;
        private System.Windows.Forms.Label Services_comment_label;
        private System.Windows.Forms.Label Services_price_label;
        private System.Windows.Forms.Label Services_name_label;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.DataGridView Clients_dataGridView;
        private System.Windows.Forms.TextBox Clients_phonenumber;
        private System.Windows.Forms.TextBox Clients_name;
        private System.Windows.Forms.TextBox Clients_surname;
        private System.Windows.Forms.Label Clients_phonenumber_label;
        private System.Windows.Forms.Label Clients_name_label;
        private System.Windows.Forms.Label Clients_surname_label;
        private System.Windows.Forms.TabPage Records;
        private System.Windows.Forms.TabPage Shares;
        private System.Windows.Forms.TabPage Discounts;
        private System.Windows.Forms.DataGridView Records_dataGridView;
        private System.Windows.Forms.TextBox Records_comment;
        private System.Windows.Forms.TextBox Records_serviceID;
        private System.Windows.Forms.TextBox Records_employeeID;
        private System.Windows.Forms.TextBox Records_clientID;
        private System.Windows.Forms.Label Records_comment_label;
        private System.Windows.Forms.Label Records_datetime_label;
        private System.Windows.Forms.Label Records_serviceid_label;
        private System.Windows.Forms.Label Records_employeeID_label;
        private System.Windows.Forms.Label Records_clientID_label;
        private System.Windows.Forms.DataGridView Shares_dataGridView;
        private System.Windows.Forms.TextBox Shares_name;
        private System.Windows.Forms.Label Shares_expirationdate_label;
        private System.Windows.Forms.Label Shares_startdate_label;
        private System.Windows.Forms.Label Shares_name_label;
        private System.Windows.Forms.DataGridView Discounts_dataGridView;
        private System.Windows.Forms.TextBox Discounts_value;
        private System.Windows.Forms.TextBox Discounts_serviceID;
        private System.Windows.Forms.TextBox Discounts_shareID;
        private System.Windows.Forms.Label Discounts_value_label;
        private System.Windows.Forms.Label Discounts_serviceID_label;
        private System.Windows.Forms.Label Discounts_shareID_label;
        private System.Windows.Forms.Button Employees_accept_button;
        private System.Windows.Forms.Button Services_accept_button;
        private System.Windows.Forms.Button Clients_button;
        private System.Windows.Forms.Button Records_accept_button;
        private System.Windows.Forms.Button Shares_accept_button;
        private System.Windows.Forms.Button Discounts_accept_button;
        private beauty_saloonDataSet beauty_saloonDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private beauty_saloonDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private beauty_saloonDataSetTableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private beauty_saloonDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource recordsBindingSource;
        private beauty_saloonDataSetTableAdapters.recordsTableAdapter recordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource sharesBindingSource;
        private beauty_saloonDataSetTableAdapters.sharesTableAdapter sharesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource discountsBindingSource;
        private beauty_saloonDataSetTableAdapters.discountsTableAdapter discountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker Records_datetime;
        private System.Windows.Forms.DateTimePicker Shares_expirationdate;
        private System.Windows.Forms.DateTimePicker Shares_startdate;
        private System.Windows.Forms.Label Employees_mode_label;
        private System.Windows.Forms.ComboBox Employees_mode;
        private System.Windows.Forms.TextBox Employees_employeeID;
        private System.Windows.Forms.Label Employees_employeeID_label;
        private System.Windows.Forms.ComboBox Services_mode;
        private System.Windows.Forms.Label Services_mode_label;
        private System.Windows.Forms.ComboBox Clients_mode;
        private System.Windows.Forms.Label Clients_mode_label;
        private System.Windows.Forms.ComboBox Records_mode;
        private System.Windows.Forms.Label Records_mode_label;
        private System.Windows.Forms.ComboBox Shares_mode;
        private System.Windows.Forms.Label Shares_mode_label;
        private System.Windows.Forms.ComboBox Discounts_mode;
        private System.Windows.Forms.Label Discounts_mode_label;
        private System.Windows.Forms.TextBox Services_serviceID;
        private System.Windows.Forms.Label Services_serviceID_label;
        private System.Windows.Forms.TextBox Clients_clientID;
        private System.Windows.Forms.Label Clients_clientID_label;
        private System.Windows.Forms.TextBox Records_recordID;
        private System.Windows.Forms.Label Records_recordID_label;
        private System.Windows.Forms.TextBox Shares_shareID;
        private System.Windows.Forms.Label Shares_shareID_label;
        private System.Windows.Forms.TextBox Discounts_discountID;
        private System.Windows.Forms.Label Discounts_discountID_label;
    }
}