using BeautySaloon.Enums;
using System;
using System.Windows.Forms;

namespace BeautySaloon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Заполняем таблицы данными из базы данных
            this.discountsTableAdapter.Fill(this.beauty_saloonDataSet.discounts);
            this.sharesTableAdapter.Fill(this.beauty_saloonDataSet.shares);
            this.recordsTableAdapter.Fill(this.beauty_saloonDataSet.records);
            this.clientsTableAdapter.Fill(this.beauty_saloonDataSet.clients);
            this.servicesTableAdapter.Fill(this.beauty_saloonDataSet.services);
            this.employeesTableAdapter.Fill(this.beauty_saloonDataSet.employees);
            // 
            this.Employees_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
            this.Services_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
            this.Clients_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
            this.Records_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
            this.Shares_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
            this.Discounts_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
        }

        private void Clients_button_Click(object sender, EventArgs e)
        {
            // Добавление в базу данных
            var button = sender as Button;
            try
            {
                switch (Clients_mode.SelectedIndex)
                {
                    case (int)CRUDMode.Добавление:
                        DataAcessObjects.Tables.Clients.Insert(Clients_surname.Text,
                            Clients_name.Text, Clients_phonenumber.Text);
                        MessageBox.Show("Клиент успешно добавлен");
                        break;
                    case (int)CRUDMode.Изменение:
                        DataAcessObjects.Tables.Clients.Update(Convert.ToInt32(Clients_clientID.Text),
                            Clients_surname.Text, Clients_name.Text, Clients_phonenumber.Text);
                        MessageBox.Show("Клиент успешно обновлен");
                        break;
                    case (int)CRUDMode.Удаление:
                        DataAcessObjects.Tables.Clients.Delete(Convert.ToInt32(Clients_clientID.Text));
                        MessageBox.Show("Клиент успешно удален");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            Clients_Update();
        }
        private void Clients_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = sender as ComboBox;
            switch (box.SelectedIndex)
            {
                case 0:
                    Clients_AddMode();
                    break;
                case 1:
                    Clients_ChangeMode();
                    break;
                case 2:
                    Clients_RemoveMode();
                    break;
            }
        }
        private void Clients_Update()
        {
            this.clientsTableAdapter.Fill(this.beauty_saloonDataSet.clients);
            Clients_clientID.Clear();
            Clients_surname.Clear();
            Clients_name.Clear();
            Clients_phonenumber.Clear();
        }
        private void Clients_AddMode()
        {
            Clients_button.Text = ButtonType.Добавить.ToString();
            Clients_clientID.Enabled = false;
            Clients_surname.Enabled = true;
            Clients_name.Enabled = true;
            Clients_phonenumber.Enabled = true;
        }
        private void Clients_ChangeMode()
        {
            Clients_button.Text = ButtonType.Изменить.ToString();
            Clients_clientID.Enabled = true;
            Clients_surname.Enabled = true;
            Clients_name.Enabled = true;
            Clients_phonenumber.Enabled = true;
        }
        private void Clients_RemoveMode()
        {
            Clients_button.Text = ButtonType.Удалить.ToString();
            Clients_clientID.Enabled = true;
            Clients_surname.Enabled = false;
            Clients_name.Enabled = false;
            Clients_phonenumber.Enabled = false;
        }

        private void Records_accept_button_Click(object sender, EventArgs e)
        {
            // Добавление в базу данных
            try
            {
                switch (Records_mode.SelectedIndex)
                {
                    case (int)CRUDMode.Добавление:
                        DataAcessObjects.Tables.Records.Insert(Convert.ToInt32(Records_clientID.Text),
                            Convert.ToInt32(Records_employeeID.Text), Convert.ToInt32(Records_serviceID.Text),
                            Records_datetime.Value, Records_comment.Text);
                        MessageBox.Show("Запись успешно добавлена");
                        break;
                    case (int)CRUDMode.Изменение:
                        DataAcessObjects.Tables.Records.Update(Convert.ToInt32(Records_recordID.Text), 
                            Convert.ToInt32(Records_clientID.Text), Convert.ToInt32(Records_employeeID.Text),
                            Convert.ToInt32(Records_serviceID.Text), Records_datetime.Value, Records_comment.Text);
                        MessageBox.Show("Запись успешно обновлена");
                        break;
                    case (int)CRUDMode.Удаление:
                        DataAcessObjects.Tables.Records.Delete(Convert.ToInt32(Records_recordID.Text));
                        MessageBox.Show("Запись успешно удалена");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            Records_Update();
        }
        private void Records_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = sender as ComboBox;
            switch (box.SelectedIndex)
            {
                case 0:
                    Records_AddMode();
                    break;
                case 1:
                    Records_ChangeMode();
                    break;
                case 2:
                    Records_RemoveMode();
                    break;
            }
        }
        private void Records_Update()
        {
            this.recordsTableAdapter.Fill(this.beauty_saloonDataSet.records);
            Records_recordID.Clear();
            Records_clientID.Clear();
            Records_employeeID.Clear();
            Records_serviceID.Clear();
            Records_datetime.ResetText();
            Records_comment.Clear();
        }
        private void Records_AddMode()
        {
            Records_accept_button.Text = ButtonType.Добавить.ToString();
            Records_recordID.Enabled = false;
            Records_clientID.Enabled = true;
            Records_employeeID.Enabled = true;
            Records_serviceID.Enabled = true;
            Records_datetime.Enabled = true;
            Records_comment.Enabled = true;
        }
        private void Records_ChangeMode()
        {
            Records_accept_button.Text = ButtonType.Изменить.ToString();
            Records_recordID.Enabled = true;
            Records_clientID.Enabled = true;
            Records_employeeID.Enabled = true;
            Records_serviceID.Enabled = true;
            Records_datetime.Enabled = true;
            Records_comment.Enabled = true;
        }
        private void Records_RemoveMode()
        {
            Records_accept_button.Text = ButtonType.Удалить.ToString();
            Records_recordID.Enabled = true;
            Records_clientID.Enabled = false;
            Records_employeeID.Enabled = false;
            Records_serviceID.Enabled = false;
            Records_datetime.Enabled = false;
            Records_comment.Enabled = false;
        }

        private void Shares_accept_button_Click(object sender, EventArgs e)
        {
            // Добавление в базу данных
            try
            {
                switch (Shares_mode.SelectedIndex)
                {
                    case (int)CRUDMode.Добавление:
                        DataAcessObjects.Tables.Shares.Insert(Shares_name.Text,
                            Shares_startdate.Value, Shares_expirationdate.Value);
                        MessageBox.Show("Акция успешно добавлена");
                        break;
                    case (int)CRUDMode.Изменение:
                        DataAcessObjects.Tables.Shares.Update(Convert.ToInt32(Shares_shareID.Text),
                            Shares_name.Text, Shares_startdate.Value, Shares_expirationdate.Value);
                        MessageBox.Show("Акция успешно обновлена");
                        break;
                    case (int)CRUDMode.Удаление:
                        DataAcessObjects.Tables.Shares.Delete(Convert.ToInt32(Shares_shareID.Text));
                        MessageBox.Show("Акция успешно удалена");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            Shares_Update();
        }
        private void Shares_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = sender as ComboBox;
            switch (box.SelectedIndex)
            {
                case 0:
                    Shares_AddMode();
                    break;
                case 1:
                    Shares_ChangeMode();
                    break;
                case 2:
                    Shares_RemoveMode();
                    break;
            }
        }
        private void Shares_Update()
        {
            this.sharesTableAdapter.Fill(this.beauty_saloonDataSet.shares);
            Shares_shareID.Clear();
            Shares_name.Clear();
            Shares_startdate.ResetText();
            Shares_expirationdate.ResetText();
        }
        private void Shares_AddMode()
        {
            Shares_accept_button.Text = ButtonType.Добавить.ToString();
            Shares_shareID.Enabled = false;
            Shares_name.Enabled = true;
            Shares_startdate.Enabled = true;
            Shares_expirationdate.Enabled = true;
        }
        private void Shares_ChangeMode()
        {
            Shares_accept_button.Text = ButtonType.Изменить.ToString();
            Shares_shareID.Enabled = true;
            Shares_name.Enabled = true;
            Shares_startdate.Enabled = true;
            Shares_expirationdate.Enabled = true;
        }
        private void Shares_RemoveMode()
        {
            Shares_accept_button.Text = ButtonType.Удалить.ToString();
            Shares_shareID.Enabled = true;
            Shares_name.Enabled = false;
            Shares_startdate.Enabled = false;
            Shares_expirationdate.Enabled = false;
        }

        private void Discounts_accept_button_Click(object sender, EventArgs e)
        {
            // Добавление в базу данных
            try
            {
                switch (Discounts_mode.SelectedIndex)
                {
                    case (int)CRUDMode.Добавление:
                        DataAcessObjects.Tables.Discounts.Insert(Convert.ToInt32(Discounts_shareID.Text),
                            Convert.ToInt32(Discounts_serviceID.Text), Convert.ToInt32(Discounts_value.Text));
                        MessageBox.Show("Скидка успешно добавлена");
                        break;
                    case (int)CRUDMode.Изменение:
                        DataAcessObjects.Tables.Discounts.Update(Convert.ToInt32(Discounts_discountID.Text),
                            Convert.ToInt32(Discounts_shareID.Text), Convert.ToInt32(Discounts_serviceID.Text),
                            Convert.ToInt32(Discounts_value.Text));
                        MessageBox.Show("Скидка успешно обновлена");
                        break;
                    case (int)CRUDMode.Удаление:
                        DataAcessObjects.Tables.Discounts.Delete(Convert.ToInt32(Discounts_discountID.Text));
                        MessageBox.Show("Скидка успешно удалена");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            Discounts_Update();
        }
        private void Discounts_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = sender as ComboBox;
            switch (box.SelectedIndex)
            {
                case 0:
                    Discounts_AddMode();
                    break;
                case 1:
                    Discounts_ChangeMode();
                    break;
                case 2:
                    Discounts_RemoveMode();
                    break;
            }
        }
        private void Discounts_Update()
        {
            this.discountsTableAdapter.Fill(this.beauty_saloonDataSet.discounts);
            Discounts_discountID.Clear();
            Discounts_shareID.Clear();
            Discounts_serviceID.Clear();
            Discounts_value.Clear();
        }
        private void Discounts_AddMode()
        {
            Discounts_accept_button.Text = ButtonType.Добавить.ToString();
            Discounts_discountID.Enabled = false;
            Discounts_shareID.Enabled = true;
            Discounts_serviceID.Enabled = true;
            Discounts_value.Enabled = true;
        }
        private void Discounts_ChangeMode()
        {
            Discounts_accept_button.Text = ButtonType.Изменить.ToString();
            Discounts_discountID.Enabled = true;
            Discounts_shareID.Enabled = true;
            Discounts_serviceID.Enabled = true;
            Discounts_value.Enabled = true;
        }
        private void Discounts_RemoveMode()
        {
            Discounts_accept_button.Text = ButtonType.Удалить.ToString();
            Discounts_discountID.Enabled = true;
            Discounts_shareID.Enabled = false;
            Discounts_serviceID.Enabled = false;
            Discounts_value.Enabled = false;
        }

        private void Services_accept_button_Click(object sender, EventArgs e)
        {
            // Добавление в базу данных
            try
            {
                switch (Services_mode.SelectedIndex)
                {
                    case (int)CRUDMode.Добавление:
                        DataAcessObjects.Tables.Services.Insert(Services_name.Text,
                            Convert.ToInt32(Services_price.Text), Services_comment.Text);
                        MessageBox.Show("Услуга успешно добавлена");
                        break;
                    case (int)CRUDMode.Изменение:
                        DataAcessObjects.Tables.Services.Update(Convert.ToInt32(Services_serviceID.Text),
                            Services_name.Text, Convert.ToInt32(Services_price.Text), Services_comment.Text);
                        MessageBox.Show("Услуга успешно обновлена");
                        break;
                    case (int)CRUDMode.Удаление:
                        DataAcessObjects.Tables.Services.Delete(Convert.ToInt32(Services_serviceID.Text));
                        MessageBox.Show("Услуга успешно удалена");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            Services_Update();
        }
        private void Services_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = sender as ComboBox;
            switch (box.SelectedIndex)
            {
                case 0:
                    Services_AddMode();
                    break;
                case 1:
                    Services_ChangeMode();
                    break;
                case 2:
                    Services_RemoveMode();
                    break;
            }
        }
        private void Services_Update()
        {
            this.servicesTableAdapter.Fill(this.beauty_saloonDataSet.services);
            Services_serviceID.Clear();
            Services_name.Clear();
            Services_price.Clear();
            Services_comment.Clear();
        }
        private void Services_AddMode()
        {
            Services_accept_button.Text = ButtonType.Добавить.ToString();
            Services_serviceID.Enabled = false;
            Services_name.Enabled = true;
            Services_price.Enabled = true;
            Services_comment.Enabled = true;
        }
        private void Services_ChangeMode()
        {
            Services_accept_button.Text = ButtonType.Изменить.ToString();
            Services_serviceID.Enabled = true;
            Services_name.Enabled = true;
            Services_price.Enabled = true;
            Services_comment.Enabled = true;
        }
        private void Services_RemoveMode()
        {
            Services_accept_button.Text = ButtonType.Удалить.ToString();
            Services_serviceID.Enabled = true;
            Services_name.Enabled = false;
            Services_price.Enabled = false;
            Services_comment.Enabled = false;
        }

        private void Employees_accept_button_Click(object sender, EventArgs e)
        {
            // Добавление в базу данных
            try
            {
                switch (Employees_mode.SelectedIndex)
                {
                    case (int)CRUDMode.Добавление:
                        DataAcessObjects.Tables.Employees.Insert(Employees_surname.Text,
                            Employees_name.Text, Employees_lastname.Text, Employees_number.Text,
                            Employees_address.Text, Employees_specialization.Text, Employees_startdate.Value);
                        MessageBox.Show("Сотрудник успешно добавлен");
                        break;
                    case (int)CRUDMode.Изменение:
                        DataAcessObjects.Tables.Employees.Update(Convert.ToInt32(Employees_employeeID.Text), 
                            Employees_surname.Text, Employees_name.Text, Employees_lastname.Text, Employees_number.Text,
                            Employees_address.Text, Employees_specialization.Text, Employees_startdate.Value);
                        MessageBox.Show("Сотрудник успешно обновлен");
                        break;
                    case (int)CRUDMode.Удаление:
                        DataAcessObjects.Tables.Employees.Delete(Convert.ToInt32(Employees_employeeID.Text));
                        MessageBox.Show("Сотрудник успешно удален");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            Employees_Update();
        }
        private void Employees_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = sender as ComboBox;
            switch (box.SelectedIndex)
            {
                case 0:
                    Employees_AddMode();
                    break;
                case 1:
                    Employees_ChangeMode();
                    break;
                case 2:
                    Employees_RemoveMode();
                    break;
            }
        }
        private void Employees_Update()
        {
            this.employeesTableAdapter.Fill(this.beauty_saloonDataSet.employees);
            Employees_employeeID.Clear();
            Employees_surname.Clear();
            Employees_name.Clear();
            Employees_lastname.Clear();
            Employees_number.Clear();
            Employees_address.Clear();
            Employees_specialization.Clear();
            Employees_startdate.ResetText();
        }
        private void Employees_AddMode()
        {
            Employees_accept_button.Text = ButtonType.Добавить.ToString();
            Employees_employeeID.Enabled = false;
            Employees_surname.Enabled = true;
            Employees_name.Enabled = true;
            Employees_lastname.Enabled = true;
            Employees_number.Enabled = true;
            Employees_address.Enabled = true;
            Employees_specialization.Enabled = true;
            Employees_startdate.Enabled = true;
        }
        private void Employees_ChangeMode()
        {
            Employees_accept_button.Text = ButtonType.Изменить.ToString();
            Employees_employeeID.Enabled = true;
            Employees_surname.Enabled = true;
            Employees_name.Enabled = true;
            Employees_lastname.Enabled = true;
            Employees_number.Enabled = true;
            Employees_address.Enabled = true;
            Employees_specialization.Enabled = true;
            Employees_startdate.Enabled = true;
        }
        private void Employees_RemoveMode()
        {
            Employees_accept_button.Text = ButtonType.Удалить.ToString();
            Employees_employeeID.Enabled = true;
            Employees_surname.Enabled = false;
            Employees_name.Enabled = false;
            Employees_lastname.Enabled = false;
            Employees_number.Enabled = false;
            Employees_address.Enabled = false;
            Employees_specialization.Enabled = false;
            Employees_startdate.Enabled = false;
        }
    }
}