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

        // Событие при загрузке формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Заполняем таблицы данными из базы данных
            this.discountsTableAdapter.Fill(this.beauty_saloonDataSet.discounts);
            this.sharesTableAdapter.Fill(this.beauty_saloonDataSet.shares);
            this.recordsTableAdapter.Fill(this.beauty_saloonDataSet.records);
            this.clientsTableAdapter.Fill(this.beauty_saloonDataSet.clients);
            this.servicesTableAdapter.Fill(this.beauty_saloonDataSet.services);
            this.employeesTableAdapter.Fill(this.beauty_saloonDataSet.employees);
            // Привязываем режимы из Enums.CRUDMode к элементам для смены режима на страницах формы
            this.Employees_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
            this.Services_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
            this.Clients_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
            this.Records_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
            this.Shares_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
            this.Discounts_mode.DataSource = Enum.GetValues(typeof(CRUDMode));
        }

        // Нажатие кнопки на странице клиентов
        private void Clients_button_Click(object sender, EventArgs e)
        {
            try
            {
                // В зависимости от текущего установленного режима выбирается действие
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
            // Если возникла ошибка - вывести её в окошке
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            // Очистка полей страницы в форме
            Clients_Update();
        }
        // Смена режима на странице клиентов
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
        
        // Нажатие кнопки на странице записей
        private void Records_accept_button_Click(object sender, EventArgs e)
        {
            try
            {
                // В зависимости от текущего установленного режима выбирается действие
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
            // Если возникла ошибка - вывести её в окошке
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            // Очистка полей страницы в форме
            Records_Update();
        }
        // Смена режима на странице записей
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
        
        // Нажатие кнопки на странице акций
        private void Shares_accept_button_Click(object sender, EventArgs e)
        {
            try
            {
                // В зависимости от текущего установленного режима выбирается действие
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
            // Если возникла ошибка - вывести её в окошке
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            // Очистка полей страницы в форме
            Shares_Update();
        }
        // Смена режима на странице акций
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
        
        // Нажатие кнопки на странице скидок
        private void Discounts_accept_button_Click(object sender, EventArgs e)
        {
            try
            {
                // В зависимости от текущего установленного режима выбирается действие
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
            // Если возникла ошибка - вывести её в окошке
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            // Очистка полей страницы в форме
            Discounts_Update();
        }
        // Смена режима на странице скидок
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
        
        // Нажатие кнопки на странице услуг
        private void Services_accept_button_Click(object sender, EventArgs e)
        {
            try
            {
                // В зависимости от текущего установленного режима выбирается действие
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
            // Если возникла ошибка - вывести её в окошке
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            // Очистка полей страницы в форме
            Services_Update();
        }
        // Смена режима на странице услуг
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
        
        // Нажатие кнопки на странице сотрудников
        private void Employees_accept_button_Click(object sender, EventArgs e)
        {
            try
            {
                // В зависимости от текущего установленного режима выбирается действие
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
            // Если возникла ошибка - вывести её в окошке
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Во время опрации возникла ошибка:\n", ex.ToString()));
            }
            // Очистка полей страницы в форме
            Employees_Update();
        }
        // Смена режима на странице сотрудников
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
    }
}