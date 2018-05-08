using BeautySaloon.Enums;

namespace BeautySaloon
{
    partial class MainForm
    {
        // Смена режима для страницы клиентов в форме
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
        // Смена режима для страницы записей в форме
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
        // Смена режима для страницы акций в форме
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
        // Смена режима для страницы скидок в форме
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
        // Смена режима для страницы услуг в форме
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
        // Смена режима для страницы сотрудников в форме
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