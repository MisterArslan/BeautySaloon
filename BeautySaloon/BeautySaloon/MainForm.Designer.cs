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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Employees = new System.Windows.Forms.TabPage();
            this.Employees_dataGridView = new System.Windows.Forms.DataGridView();
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
            this.Services_dataGridView = new System.Windows.Forms.DataGridView();
            this.Services_comment = new System.Windows.Forms.TextBox();
            this.Services_price = new System.Windows.Forms.TextBox();
            this.Services_name = new System.Windows.Forms.TextBox();
            this.Services_comment_label = new System.Windows.Forms.Label();
            this.Services_price_label = new System.Windows.Forms.Label();
            this.Services_name_label = new System.Windows.Forms.Label();
            this.Clients = new System.Windows.Forms.TabPage();
            this.Clients_dataGridView = new System.Windows.Forms.DataGridView();
            this.Clients_phonenumber = new System.Windows.Forms.TextBox();
            this.Clients_name = new System.Windows.Forms.TextBox();
            this.Clients_surname = new System.Windows.Forms.TextBox();
            this.Clients_phonenumber_label = new System.Windows.Forms.Label();
            this.Clients_name_label = new System.Windows.Forms.Label();
            this.Clients_surname_label = new System.Windows.Forms.Label();
            this.Records = new System.Windows.Forms.TabPage();
            this.Records_dataGridView = new System.Windows.Forms.DataGridView();
            this.Records_comment = new System.Windows.Forms.TextBox();
            this.Records_time = new System.Windows.Forms.TextBox();
            this.Records_date = new System.Windows.Forms.TextBox();
            this.Records_serviceID = new System.Windows.Forms.TextBox();
            this.Records_employeeID = new System.Windows.Forms.TextBox();
            this.Records_clientID = new System.Windows.Forms.TextBox();
            this.Records_comment_label = new System.Windows.Forms.Label();
            this.Records_time_label = new System.Windows.Forms.Label();
            this.Records_date_label = new System.Windows.Forms.Label();
            this.Records_serviceid_label = new System.Windows.Forms.Label();
            this.Records_employeeID_label = new System.Windows.Forms.Label();
            this.Records_clientID_label = new System.Windows.Forms.Label();
            this.Shares = new System.Windows.Forms.TabPage();
            this.Discounts = new System.Windows.Forms.TabPage();
            this.Shares_dataGridView = new System.Windows.Forms.DataGridView();
            this.Shares_expirationdate = new System.Windows.Forms.TextBox();
            this.Shares_startdate = new System.Windows.Forms.TextBox();
            this.Shares_name = new System.Windows.Forms.TextBox();
            this.Shares_expirationdate_label = new System.Windows.Forms.Label();
            this.Shares_startdate_label = new System.Windows.Forms.Label();
            this.Shares_name_label = new System.Windows.Forms.Label();
            this.Discounts_dataGridView = new System.Windows.Forms.DataGridView();
            this.Discounts_value = new System.Windows.Forms.TextBox();
            this.Discounts_serviceID = new System.Windows.Forms.TextBox();
            this.Discounts_shareID = new System.Windows.Forms.TextBox();
            this.Discounts_value_label = new System.Windows.Forms.Label();
            this.Discounts_serviceID_label = new System.Windows.Forms.Label();
            this.Discounts_shareID_label = new System.Windows.Forms.Label();
            this.Employees_accept_button = new System.Windows.Forms.Button();
            this.Services_accept_button = new System.Windows.Forms.Button();
            this.Clients_accept_button = new System.Windows.Forms.Button();
            this.Records_accept_button = new System.Windows.Forms.Button();
            this.Shares_accept_button = new System.Windows.Forms.Button();
            this.Discounts_accept_button = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.Employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employees_dataGridView)).BeginInit();
            this.Services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services_dataGridView)).BeginInit();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clients_dataGridView)).BeginInit();
            this.Records.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Records_dataGridView)).BeginInit();
            this.Shares.SuspendLayout();
            this.Discounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shares_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discounts_dataGridView)).BeginInit();
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
            // Employees_dataGridView
            // 
            this.Employees_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employees_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Employees_dataGridView.Name = "Employees_dataGridView";
            this.Employees_dataGridView.RowTemplate.Height = 24;
            this.Employees_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Employees_dataGridView.TabIndex = 15;
            // 
            // Employees_startdate
            // 
            this.Employees_startdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_startdate.Location = new System.Drawing.Point(633, 220);
            this.Employees_startdate.Name = "Employees_startdate";
            this.Employees_startdate.Size = new System.Drawing.Size(332, 22);
            this.Employees_startdate.TabIndex = 14;
            // 
            // Employees_specialization
            // 
            this.Employees_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_specialization.Location = new System.Drawing.Point(633, 184);
            this.Employees_specialization.Name = "Employees_specialization";
            this.Employees_specialization.Size = new System.Drawing.Size(332, 27);
            this.Employees_specialization.TabIndex = 12;
            // 
            // Employees_address
            // 
            this.Employees_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_address.Location = new System.Drawing.Point(633, 149);
            this.Employees_address.Name = "Employees_address";
            this.Employees_address.Size = new System.Drawing.Size(332, 27);
            this.Employees_address.TabIndex = 11;
            // 
            // Employees_number
            // 
            this.Employees_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_number.Location = new System.Drawing.Point(633, 114);
            this.Employees_number.Name = "Employees_number";
            this.Employees_number.Size = new System.Drawing.Size(332, 27);
            this.Employees_number.TabIndex = 10;
            // 
            // Employees_lastname
            // 
            this.Employees_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_lastname.Location = new System.Drawing.Point(633, 79);
            this.Employees_lastname.Name = "Employees_lastname";
            this.Employees_lastname.Size = new System.Drawing.Size(332, 27);
            this.Employees_lastname.TabIndex = 9;
            // 
            // Employees_name
            // 
            this.Employees_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_name.Location = new System.Drawing.Point(633, 44);
            this.Employees_name.Name = "Employees_name";
            this.Employees_name.Size = new System.Drawing.Size(332, 27);
            this.Employees_name.TabIndex = 8;
            // 
            // Employees_surname
            // 
            this.Employees_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_surname.Location = new System.Drawing.Point(633, 9);
            this.Employees_surname.Name = "Employees_surname";
            this.Employees_surname.Size = new System.Drawing.Size(332, 27);
            this.Employees_surname.TabIndex = 7;
            // 
            // Employees_startdate_label
            // 
            this.Employees_startdate_label.AutoSize = true;
            this.Employees_startdate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_startdate_label.Location = new System.Drawing.Point(443, 222);
            this.Employees_startdate_label.Name = "Employees_startdate_label";
            this.Employees_startdate_label.Size = new System.Drawing.Size(184, 20);
            this.Employees_startdate_label.TabIndex = 6;
            this.Employees_startdate_label.Text = "Дата начала работы";
            // 
            // Employees_specialization_label
            // 
            this.Employees_specialization_label.AutoSize = true;
            this.Employees_specialization_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_specialization_label.Location = new System.Drawing.Point(487, 187);
            this.Employees_specialization_label.Name = "Employees_specialization_label";
            this.Employees_specialization_label.Size = new System.Drawing.Size(140, 20);
            this.Employees_specialization_label.TabIndex = 5;
            this.Employees_specialization_label.Text = "Специализация";
            // 
            // Employees_address_label
            // 
            this.Employees_address_label.AutoSize = true;
            this.Employees_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_address_label.Location = new System.Drawing.Point(565, 152);
            this.Employees_address_label.Name = "Employees_address_label";
            this.Employees_address_label.Size = new System.Drawing.Size(62, 20);
            this.Employees_address_label.TabIndex = 4;
            this.Employees_address_label.Text = "Адрес";
            // 
            // Employees_number_label
            // 
            this.Employees_number_label.AutoSize = true;
            this.Employees_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_number_label.Location = new System.Drawing.Point(472, 117);
            this.Employees_number_label.Name = "Employees_number_label";
            this.Employees_number_label.Size = new System.Drawing.Size(155, 20);
            this.Employees_number_label.TabIndex = 3;
            this.Employees_number_label.Text = "Номер телефона";
            // 
            // Employees_lastname_label
            // 
            this.Employees_lastname_label.AutoSize = true;
            this.Employees_lastname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_lastname_label.Location = new System.Drawing.Point(536, 82);
            this.Employees_lastname_label.Name = "Employees_lastname_label";
            this.Employees_lastname_label.Size = new System.Drawing.Size(91, 20);
            this.Employees_lastname_label.TabIndex = 2;
            this.Employees_lastname_label.Text = "Отчество";
            // 
            // Employees_name_label
            // 
            this.Employees_name_label.AutoSize = true;
            this.Employees_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_name_label.Location = new System.Drawing.Point(585, 47);
            this.Employees_name_label.Name = "Employees_name_label";
            this.Employees_name_label.Size = new System.Drawing.Size(42, 20);
            this.Employees_name_label.TabIndex = 1;
            this.Employees_name_label.Text = "Имя";
            // 
            // Employees_surname_label
            // 
            this.Employees_surname_label.AutoSize = true;
            this.Employees_surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_surname_label.Location = new System.Drawing.Point(540, 12);
            this.Employees_surname_label.Name = "Employees_surname_label";
            this.Employees_surname_label.Size = new System.Drawing.Size(87, 20);
            this.Employees_surname_label.TabIndex = 0;
            this.Employees_surname_label.Text = "Фамилия";
            // 
            // Services
            // 
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
            // Services_dataGridView
            // 
            this.Services_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Services_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Services_dataGridView.Name = "Services_dataGridView";
            this.Services_dataGridView.RowTemplate.Height = 24;
            this.Services_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Services_dataGridView.TabIndex = 16;
            // 
            // Services_comment
            // 
            this.Services_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_comment.Location = new System.Drawing.Point(628, 79);
            this.Services_comment.Multiline = true;
            this.Services_comment.Name = "Services_comment";
            this.Services_comment.Size = new System.Drawing.Size(338, 129);
            this.Services_comment.TabIndex = 15;
            // 
            // Services_price
            // 
            this.Services_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_price.Location = new System.Drawing.Point(628, 44);
            this.Services_price.Name = "Services_price";
            this.Services_price.Size = new System.Drawing.Size(338, 27);
            this.Services_price.TabIndex = 14;
            // 
            // Services_name
            // 
            this.Services_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_name.Location = new System.Drawing.Point(628, 9);
            this.Services_name.Name = "Services_name";
            this.Services_name.Size = new System.Drawing.Size(338, 27);
            this.Services_name.TabIndex = 13;
            // 
            // Services_comment_label
            // 
            this.Services_comment_label.AutoSize = true;
            this.Services_comment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_comment_label.Location = new System.Drawing.Point(498, 82);
            this.Services_comment_label.Name = "Services_comment_label";
            this.Services_comment_label.Size = new System.Drawing.Size(124, 20);
            this.Services_comment_label.TabIndex = 12;
            this.Services_comment_label.Text = "Комментарий";
            // 
            // Services_price_label
            // 
            this.Services_price_label.AutoSize = true;
            this.Services_price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_price_label.Location = new System.Drawing.Point(570, 47);
            this.Services_price_label.Name = "Services_price_label";
            this.Services_price_label.Size = new System.Drawing.Size(52, 20);
            this.Services_price_label.TabIndex = 11;
            this.Services_price_label.Text = "Цена";
            // 
            // Services_name_label
            // 
            this.Services_name_label.AutoSize = true;
            this.Services_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_name_label.Location = new System.Drawing.Point(488, 12);
            this.Services_name_label.Name = "Services_name_label";
            this.Services_name_label.Size = new System.Drawing.Size(134, 20);
            this.Services_name_label.TabIndex = 10;
            this.Services_name_label.Text = "Наименование";
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.Clients_accept_button);
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
            // Clients_dataGridView
            // 
            this.Clients_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clients_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Clients_dataGridView.Name = "Clients_dataGridView";
            this.Clients_dataGridView.RowTemplate.Height = 24;
            this.Clients_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Clients_dataGridView.TabIndex = 23;
            // 
            // Clients_phonenumber
            // 
            this.Clients_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_phonenumber.Location = new System.Drawing.Point(628, 79);
            this.Clients_phonenumber.Multiline = true;
            this.Clients_phonenumber.Name = "Clients_phonenumber";
            this.Clients_phonenumber.Size = new System.Drawing.Size(338, 27);
            this.Clients_phonenumber.TabIndex = 22;
            // 
            // Clients_name
            // 
            this.Clients_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_name.Location = new System.Drawing.Point(628, 44);
            this.Clients_name.Name = "Clients_name";
            this.Clients_name.Size = new System.Drawing.Size(338, 27);
            this.Clients_name.TabIndex = 21;
            // 
            // Clients_surname
            // 
            this.Clients_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_surname.Location = new System.Drawing.Point(628, 9);
            this.Clients_surname.Name = "Clients_surname";
            this.Clients_surname.Size = new System.Drawing.Size(338, 27);
            this.Clients_surname.TabIndex = 20;
            // 
            // Clients_phonenumber_label
            // 
            this.Clients_phonenumber_label.AutoSize = true;
            this.Clients_phonenumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_phonenumber_label.Location = new System.Drawing.Point(467, 82);
            this.Clients_phonenumber_label.Name = "Clients_phonenumber_label";
            this.Clients_phonenumber_label.Size = new System.Drawing.Size(155, 20);
            this.Clients_phonenumber_label.TabIndex = 19;
            this.Clients_phonenumber_label.Text = "Номер телефона";
            // 
            // Clients_name_label
            // 
            this.Clients_name_label.AutoSize = true;
            this.Clients_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_name_label.Location = new System.Drawing.Point(580, 47);
            this.Clients_name_label.Name = "Clients_name_label";
            this.Clients_name_label.Size = new System.Drawing.Size(42, 20);
            this.Clients_name_label.TabIndex = 18;
            this.Clients_name_label.Text = "Имя";
            // 
            // Clients_surname_label
            // 
            this.Clients_surname_label.AutoSize = true;
            this.Clients_surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_surname_label.Location = new System.Drawing.Point(535, 12);
            this.Clients_surname_label.Name = "Clients_surname_label";
            this.Clients_surname_label.Size = new System.Drawing.Size(87, 20);
            this.Clients_surname_label.TabIndex = 17;
            this.Clients_surname_label.Text = "Фамилия";
            // 
            // Records
            // 
            this.Records.Controls.Add(this.Records_accept_button);
            this.Records.Controls.Add(this.Records_dataGridView);
            this.Records.Controls.Add(this.Records_comment);
            this.Records.Controls.Add(this.Records_time);
            this.Records.Controls.Add(this.Records_date);
            this.Records.Controls.Add(this.Records_serviceID);
            this.Records.Controls.Add(this.Records_employeeID);
            this.Records.Controls.Add(this.Records_clientID);
            this.Records.Controls.Add(this.Records_comment_label);
            this.Records.Controls.Add(this.Records_time_label);
            this.Records.Controls.Add(this.Records_date_label);
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
            // Records_dataGridView
            // 
            this.Records_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Records_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Records_dataGridView.Name = "Records_dataGridView";
            this.Records_dataGridView.RowTemplate.Height = 24;
            this.Records_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Records_dataGridView.TabIndex = 30;
            // 
            // Records_comment
            // 
            this.Records_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_comment.Location = new System.Drawing.Point(633, 184);
            this.Records_comment.Multiline = true;
            this.Records_comment.Name = "Records_comment";
            this.Records_comment.Size = new System.Drawing.Size(332, 94);
            this.Records_comment.TabIndex = 28;
            // 
            // Records_time
            // 
            this.Records_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_time.Location = new System.Drawing.Point(633, 149);
            this.Records_time.Name = "Records_time";
            this.Records_time.Size = new System.Drawing.Size(332, 27);
            this.Records_time.TabIndex = 27;
            // 
            // Records_date
            // 
            this.Records_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_date.Location = new System.Drawing.Point(633, 114);
            this.Records_date.Name = "Records_date";
            this.Records_date.Size = new System.Drawing.Size(332, 27);
            this.Records_date.TabIndex = 26;
            // 
            // Records_serviceID
            // 
            this.Records_serviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_serviceID.Location = new System.Drawing.Point(633, 79);
            this.Records_serviceID.Name = "Records_serviceID";
            this.Records_serviceID.Size = new System.Drawing.Size(332, 27);
            this.Records_serviceID.TabIndex = 25;
            // 
            // Records_employeeID
            // 
            this.Records_employeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_employeeID.Location = new System.Drawing.Point(633, 44);
            this.Records_employeeID.Name = "Records_employeeID";
            this.Records_employeeID.Size = new System.Drawing.Size(332, 27);
            this.Records_employeeID.TabIndex = 24;
            // 
            // Records_clientID
            // 
            this.Records_clientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_clientID.Location = new System.Drawing.Point(633, 9);
            this.Records_clientID.Name = "Records_clientID";
            this.Records_clientID.Size = new System.Drawing.Size(332, 27);
            this.Records_clientID.TabIndex = 23;
            // 
            // Records_comment_label
            // 
            this.Records_comment_label.AutoSize = true;
            this.Records_comment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_comment_label.Location = new System.Drawing.Point(503, 187);
            this.Records_comment_label.Name = "Records_comment_label";
            this.Records_comment_label.Size = new System.Drawing.Size(124, 20);
            this.Records_comment_label.TabIndex = 21;
            this.Records_comment_label.Text = "Комментарий";
            // 
            // Records_time_label
            // 
            this.Records_time_label.AutoSize = true;
            this.Records_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_time_label.Location = new System.Drawing.Point(564, 152);
            this.Records_time_label.Name = "Records_time_label";
            this.Records_time_label.Size = new System.Drawing.Size(63, 20);
            this.Records_time_label.TabIndex = 20;
            this.Records_time_label.Text = "Время";
            // 
            // Records_date_label
            // 
            this.Records_date_label.AutoSize = true;
            this.Records_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_date_label.Location = new System.Drawing.Point(575, 117);
            this.Records_date_label.Name = "Records_date_label";
            this.Records_date_label.Size = new System.Drawing.Size(52, 20);
            this.Records_date_label.TabIndex = 19;
            this.Records_date_label.Text = "Дата";
            // 
            // Records_serviceid_label
            // 
            this.Records_serviceid_label.AutoSize = true;
            this.Records_serviceid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_serviceid_label.Location = new System.Drawing.Point(527, 82);
            this.Records_serviceid_label.Name = "Records_serviceid_label";
            this.Records_serviceid_label.Size = new System.Drawing.Size(100, 20);
            this.Records_serviceid_label.TabIndex = 18;
            this.Records_serviceid_label.Text = "Код услуги";
            // 
            // Records_employeeID_label
            // 
            this.Records_employeeID_label.AutoSize = true;
            this.Records_employeeID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_employeeID_label.Location = new System.Drawing.Point(482, 47);
            this.Records_employeeID_label.Name = "Records_employeeID_label";
            this.Records_employeeID_label.Size = new System.Drawing.Size(145, 20);
            this.Records_employeeID_label.TabIndex = 17;
            this.Records_employeeID_label.Text = "Код сотрудника";
            // 
            // Records_clientID_label
            // 
            this.Records_clientID_label.AutoSize = true;
            this.Records_clientID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_clientID_label.Location = new System.Drawing.Point(511, 12);
            this.Records_clientID_label.Name = "Records_clientID_label";
            this.Records_clientID_label.Size = new System.Drawing.Size(116, 20);
            this.Records_clientID_label.TabIndex = 16;
            this.Records_clientID_label.Text = "Код клиента";
            // 
            // Shares
            // 
            this.Shares.Controls.Add(this.Shares_accept_button);
            this.Shares.Controls.Add(this.Shares_dataGridView);
            this.Shares.Controls.Add(this.Shares_expirationdate);
            this.Shares.Controls.Add(this.Shares_startdate);
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
            // Discounts
            // 
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
            // Shares_dataGridView
            // 
            this.Shares_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shares_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Shares_dataGridView.Name = "Shares_dataGridView";
            this.Shares_dataGridView.RowTemplate.Height = 24;
            this.Shares_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Shares_dataGridView.TabIndex = 30;
            // 
            // Shares_expirationdate
            // 
            this.Shares_expirationdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_expirationdate.Location = new System.Drawing.Point(628, 79);
            this.Shares_expirationdate.Multiline = true;
            this.Shares_expirationdate.Name = "Shares_expirationdate";
            this.Shares_expirationdate.Size = new System.Drawing.Size(338, 27);
            this.Shares_expirationdate.TabIndex = 29;
            // 
            // Shares_startdate
            // 
            this.Shares_startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_startdate.Location = new System.Drawing.Point(628, 44);
            this.Shares_startdate.Name = "Shares_startdate";
            this.Shares_startdate.Size = new System.Drawing.Size(338, 27);
            this.Shares_startdate.TabIndex = 28;
            // 
            // Shares_name
            // 
            this.Shares_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_name.Location = new System.Drawing.Point(628, 9);
            this.Shares_name.Name = "Shares_name";
            this.Shares_name.Size = new System.Drawing.Size(338, 27);
            this.Shares_name.TabIndex = 27;
            // 
            // Shares_expirationdate_label
            // 
            this.Shares_expirationdate_label.AutoSize = true;
            this.Shares_expirationdate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_expirationdate_label.Location = new System.Drawing.Point(476, 82);
            this.Shares_expirationdate_label.Name = "Shares_expirationdate_label";
            this.Shares_expirationdate_label.Size = new System.Drawing.Size(146, 20);
            this.Shares_expirationdate_label.TabIndex = 26;
            this.Shares_expirationdate_label.Text = "Дата истечения";
            // 
            // Shares_startdate_label
            // 
            this.Shares_startdate_label.AutoSize = true;
            this.Shares_startdate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_startdate_label.Location = new System.Drawing.Point(505, 47);
            this.Shares_startdate_label.Name = "Shares_startdate_label";
            this.Shares_startdate_label.Size = new System.Drawing.Size(117, 20);
            this.Shares_startdate_label.TabIndex = 25;
            this.Shares_startdate_label.Text = "Дата начала";
            // 
            // Shares_name_label
            // 
            this.Shares_name_label.AutoSize = true;
            this.Shares_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_name_label.Location = new System.Drawing.Point(488, 12);
            this.Shares_name_label.Name = "Shares_name_label";
            this.Shares_name_label.Size = new System.Drawing.Size(134, 20);
            this.Shares_name_label.TabIndex = 24;
            this.Shares_name_label.Text = "Наименование";
            // 
            // Discounts_dataGridView
            // 
            this.Discounts_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Discounts_dataGridView.Location = new System.Drawing.Point(6, 371);
            this.Discounts_dataGridView.Name = "Discounts_dataGridView";
            this.Discounts_dataGridView.RowTemplate.Height = 24;
            this.Discounts_dataGridView.Size = new System.Drawing.Size(960, 346);
            this.Discounts_dataGridView.TabIndex = 37;
            // 
            // Discounts_value
            // 
            this.Discounts_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_value.Location = new System.Drawing.Point(628, 79);
            this.Discounts_value.Multiline = true;
            this.Discounts_value.Name = "Discounts_value";
            this.Discounts_value.Size = new System.Drawing.Size(338, 27);
            this.Discounts_value.TabIndex = 36;
            // 
            // Discounts_serviceID
            // 
            this.Discounts_serviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_serviceID.Location = new System.Drawing.Point(628, 44);
            this.Discounts_serviceID.Name = "Discounts_serviceID";
            this.Discounts_serviceID.Size = new System.Drawing.Size(338, 27);
            this.Discounts_serviceID.TabIndex = 35;
            // 
            // Discounts_shareID
            // 
            this.Discounts_shareID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_shareID.Location = new System.Drawing.Point(628, 9);
            this.Discounts_shareID.Name = "Discounts_shareID";
            this.Discounts_shareID.Size = new System.Drawing.Size(338, 27);
            this.Discounts_shareID.TabIndex = 34;
            // 
            // Discounts_value_label
            // 
            this.Discounts_value_label.AutoSize = true;
            this.Discounts_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_value_label.Location = new System.Drawing.Point(467, 82);
            this.Discounts_value_label.Name = "Discounts_value_label";
            this.Discounts_value_label.Size = new System.Drawing.Size(155, 20);
            this.Discounts_value_label.TabIndex = 33;
            this.Discounts_value_label.Text = "Величина скидки";
            // 
            // Discounts_serviceID_label
            // 
            this.Discounts_serviceID_label.AutoSize = true;
            this.Discounts_serviceID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_serviceID_label.Location = new System.Drawing.Point(522, 47);
            this.Discounts_serviceID_label.Name = "Discounts_serviceID_label";
            this.Discounts_serviceID_label.Size = new System.Drawing.Size(100, 20);
            this.Discounts_serviceID_label.TabIndex = 32;
            this.Discounts_serviceID_label.Text = "Код услуги";
            // 
            // Discounts_shareID_label
            // 
            this.Discounts_shareID_label.AutoSize = true;
            this.Discounts_shareID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_shareID_label.Location = new System.Drawing.Point(526, 12);
            this.Discounts_shareID_label.Name = "Discounts_shareID_label";
            this.Discounts_shareID_label.Size = new System.Drawing.Size(96, 20);
            this.Discounts_shareID_label.TabIndex = 31;
            this.Discounts_shareID_label.Text = "Код акции";
            // 
            // Employees_accept_button
            // 
            this.Employees_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employees_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Employees_accept_button.Name = "Employees_accept_button";
            this.Employees_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Employees_accept_button.TabIndex = 16;
            this.Employees_accept_button.Text = "Принять";
            this.Employees_accept_button.UseVisualStyleBackColor = true;
            // 
            // Services_accept_button
            // 
            this.Services_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Services_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Services_accept_button.Name = "Services_accept_button";
            this.Services_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Services_accept_button.TabIndex = 17;
            this.Services_accept_button.Text = "Принять";
            this.Services_accept_button.UseVisualStyleBackColor = true;
            // 
            // Clients_accept_button
            // 
            this.Clients_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clients_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Clients_accept_button.Name = "Clients_accept_button";
            this.Clients_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Clients_accept_button.TabIndex = 24;
            this.Clients_accept_button.Text = "Принять";
            this.Clients_accept_button.UseVisualStyleBackColor = true;
            // 
            // Records_accept_button
            // 
            this.Records_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Records_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Records_accept_button.Name = "Records_accept_button";
            this.Records_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Records_accept_button.TabIndex = 31;
            this.Records_accept_button.Text = "Принять";
            this.Records_accept_button.UseVisualStyleBackColor = true;
            // 
            // Shares_accept_button
            // 
            this.Shares_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shares_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shares_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Shares_accept_button.Name = "Shares_accept_button";
            this.Shares_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Shares_accept_button.TabIndex = 31;
            this.Shares_accept_button.Text = "Принять";
            this.Shares_accept_button.UseVisualStyleBackColor = true;
            // 
            // Discounts_accept_button
            // 
            this.Discounts_accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Discounts_accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discounts_accept_button.Location = new System.Drawing.Point(766, 315);
            this.Discounts_accept_button.Name = "Discounts_accept_button";
            this.Discounts_accept_button.Size = new System.Drawing.Size(200, 50);
            this.Discounts_accept_button.TabIndex = 38;
            this.Discounts_accept_button.Text = "Принять";
            this.Discounts_accept_button.UseVisualStyleBackColor = true;
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
            this.Text = "СУБД \"Салон красоты\"";
            this.TabControl.ResumeLayout(false);
            this.Employees.ResumeLayout(false);
            this.Employees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employees_dataGridView)).EndInit();
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services_dataGridView)).EndInit();
            this.Clients.ResumeLayout(false);
            this.Clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clients_dataGridView)).EndInit();
            this.Records.ResumeLayout(false);
            this.Records.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Records_dataGridView)).EndInit();
            this.Shares.ResumeLayout(false);
            this.Shares.PerformLayout();
            this.Discounts.ResumeLayout(false);
            this.Discounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shares_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discounts_dataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox Records_time;
        private System.Windows.Forms.TextBox Records_date;
        private System.Windows.Forms.TextBox Records_serviceID;
        private System.Windows.Forms.TextBox Records_employeeID;
        private System.Windows.Forms.TextBox Records_clientID;
        private System.Windows.Forms.Label Records_comment_label;
        private System.Windows.Forms.Label Records_time_label;
        private System.Windows.Forms.Label Records_date_label;
        private System.Windows.Forms.Label Records_serviceid_label;
        private System.Windows.Forms.Label Records_employeeID_label;
        private System.Windows.Forms.Label Records_clientID_label;
        private System.Windows.Forms.DataGridView Shares_dataGridView;
        private System.Windows.Forms.TextBox Shares_expirationdate;
        private System.Windows.Forms.TextBox Shares_startdate;
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
        private System.Windows.Forms.Button Clients_accept_button;
        private System.Windows.Forms.Button Records_accept_button;
        private System.Windows.Forms.Button Shares_accept_button;
        private System.Windows.Forms.Button Discounts_accept_button;
    }
}