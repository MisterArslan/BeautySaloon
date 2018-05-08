namespace BeautySaloon
{
    partial class MainForm
    {
        // Методы для очищения полей соответствующих страниц на форме
        private void Clients_Update()
        {
            this.clientsTableAdapter.Fill(this.beauty_saloonDataSet.clients);
            Clients_clientID.Clear();
            Clients_surname.Clear();
            Clients_name.Clear();
            Clients_phonenumber.Clear();
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
        private void Shares_Update()
        {
            this.sharesTableAdapter.Fill(this.beauty_saloonDataSet.shares);
            Shares_shareID.Clear();
            Shares_name.Clear();
            Shares_startdate.ResetText();
            Shares_expirationdate.ResetText();
        }
        private void Discounts_Update()
        {
            this.discountsTableAdapter.Fill(this.beauty_saloonDataSet.discounts);
            Discounts_discountID.Clear();
            Discounts_shareID.Clear();
            Discounts_serviceID.Clear();
            Discounts_value.Clear();
        }
        private void Services_Update()
        {
            this.servicesTableAdapter.Fill(this.beauty_saloonDataSet.services);
            Services_serviceID.Clear();
            Services_name.Clear();
            Services_price.Clear();
            Services_comment.Clear();
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
    }
}