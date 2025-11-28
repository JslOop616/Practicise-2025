using System;
using System.Linq;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class TenantMainForm : Form
    {
        public TenantMainForm()
        {
            InitializeComponent();
        }

        private void TenantMainForm_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();
            LoadAvailableApartments();

            dataGridViewApartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewApartments.ReadOnly = true;
            dataGridViewApartments.AllowUserToAddRows = false;

            tabControl1.SelectedIndex = 0;
        }

        private void LoadAvailableApartments()
        {
            var apartments = DatabaseHelper.GetAvailableApartments();
            dataGridViewApartments.DataSource = apartments;
            lblApartmentCount.Text = $"Найдено квартир: {apartments.Count}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string address = txtSearchAddress.Text;
                int? minRooms = string.IsNullOrEmpty(txtMinRooms.Text) ? null : (int?)int.Parse(txtMinRooms.Text);
                int? maxRooms = string.IsNullOrEmpty(txtMaxRooms.Text) ? null : (int?)int.Parse(txtMaxRooms.Text);
                decimal? maxPrice = string.IsNullOrEmpty(txtMaxPrice.Text) ? null : (decimal?)decimal.Parse(txtMaxPrice.Text);

                var apartments = DatabaseHelper.SearchApartments(address, minRooms, maxRooms, maxPrice);
                dataGridViewApartments.DataSource = apartments;
                lblApartmentCount.Text = $"Найдено квартир: {apartments.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка");
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchAddress.Text = "";
            txtMinRooms.Text = "";
            txtMaxRooms.Text = "";
            txtMaxPrice.Text = "";
            LoadAvailableApartments();
        }

        private void btnSubmitApplication_Click(object sender, EventArgs e)
        {
            if (dataGridViewApartments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите квартиру для подачи заявки", "Информация");
                return;
            }

            var selectedApartment = dataGridViewApartments.SelectedRows[0].DataBoundItem as Apartment;

            if (string.IsNullOrEmpty(txtTenantName.Text) || string.IsNullOrEmpty(txtTenantPhone.Text))
            {
                MessageBox.Show("Заполните ваши контактные данные", "Ошибка");
                return;
            }

            try
            {
                var application = new RentalApplication
                {
                    ApartmentId = selectedApartment.Id,
                    TenantName = txtTenantName.Text,
                    TenantPhone = txtTenantPhone.Text,
                    TenantEmail = txtTenantEmail.Text,
                    DesiredMoveInDate = dtpMoveInDate.Value,
                    RentalPeriodMonths = (int)numRentalPeriod.Value,
                    Comments = txtApplicationComments.Text
                };

                DatabaseHelper.SubmitApplication(application);

                MessageBox.Show("Заявка на аренду успешно подана!", "Успех");
                ClearApplicationForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подачи заявки: {ex.Message}", "Ошибка");
            }
        }

        private void ClearApplicationForm()
        {
            txtTenantName.Text = "";
            txtTenantPhone.Text = "";
            txtTenantEmail.Text = "";
            txtApplicationComments.Text = "";
            dtpMoveInDate.Value = DateTime.Now.AddDays(1);
            numRentalPeriod.Value = 12;
        }

        private void btnLoadMyApplications_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchPhone.Text))
            {
                MessageBox.Show("Введите ваш телефон для поиска заявок", "Информация");
                return;
            }

            var applications = DatabaseHelper.GetUserApplications(txtSearchPhone.Text);
            dataGridViewApplications.DataSource = applications;
            lblApplicationCount.Text = $"Найдено заявок: {applications.Count}";
        }

        private void dataGridViewApartments_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewApartments.SelectedRows.Count > 0)
            {
                var apartment = dataGridViewApartments.SelectedRows[0].DataBoundItem as Apartment;
                if (apartment != null)
                {
                    lblSelectedApartment.Text = $"Выбрана: {apartment.Address} - {apartment.Price:C}/мес";
                }
            }
        }

        private void txtMinRooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}