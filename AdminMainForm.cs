using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ApartmentRentalAdmin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();
            LoadApartments();
            UpdateStatistics();

            // Настройка DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadApartments()
        {
            var apartments = DatabaseHelper.GetAllApartments();
            dataGridView1.DataSource = apartments;
        }

        private void UpdateStatistics()
        {
            var stats = DatabaseHelper.GetStatistics();
            lblTotal.Text = $"Всего: {stats.total}";
            lblAvailable.Text = $"Свободно: {stats.available}";
            lblRented.Text = $"Сдано: {stats.rented}";
            lblMonthlyRevenue.Text = $"Месячный доход: {DatabaseHelper.CalculateMonthlyRevenue():C}";
            lblAnnualRevenue.Text = $"Годовой доход: {DatabaseHelper.CalculateAnnualRevenue():C}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Введите адрес квартиры", "Ошибка");
                    return;
                }

                var apartment = new Apartment
                {
                    Address = txtAddress.Text,
                    Rooms = (int)nudRooms.Value,
                    Area = nudArea.Value,
                    Price = nudPrice.Value,
                    Description = txtDescription.Text,
                    IsAvailable = chkAvailable.Checked,
                    LandlordName = txtLandlordName.Text,
                    LandlordPhone = txtLandlordPhone.Text
                };

                DatabaseHelper.AddApartment(apartment);
                LoadApartments();
                UpdateStatistics();
                ClearForm();

                MessageBox.Show("Квартира добавлена!", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите квартиру для редактирования", "Информация");
                return;
            }

            try
            {
                var selectedApartment = dataGridView1.SelectedRows[0].DataBoundItem as Apartment;

                selectedApartment.Address = txtAddress.Text;
                selectedApartment.Rooms = (int)nudRooms.Value;
                selectedApartment.Area = nudArea.Value;
                selectedApartment.Price = nudPrice.Value;
                selectedApartment.Description = txtDescription.Text;
                selectedApartment.IsAvailable = chkAvailable.Checked;
                selectedApartment.LandlordName = txtLandlordName.Text;
                selectedApartment.LandlordPhone = txtLandlordPhone.Text;

                DatabaseHelper.UpdateApartment(selectedApartment);
                LoadApartments();
                UpdateStatistics();

                MessageBox.Show("Квартира обновлена!", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите квартиру для удаления", "Информация");
                return;
            }

            var result = MessageBox.Show("Удалить выбранную квартиру?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var selectedApartment = dataGridView1.SelectedRows[0].DataBoundItem as Apartment;
                DatabaseHelper.DeleteApartment(selectedApartment.Id);
                LoadApartments();
                UpdateStatistics();
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtAddress.Text = "";
            nudRooms.Value = 1;
            nudArea.Value = 30;
            nudPrice.Value = 20000;
            txtDescription.Text = "";
            chkAvailable.Checked = true;
            txtLandlordName.Text = "";
            txtLandlordPhone.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var apartment = dataGridView1.SelectedRows[0].DataBoundItem as Apartment;
                if (apartment != null)
                {
                    txtAddress.Text = apartment.Address;
                    nudRooms.Value = apartment.Rooms;
                    nudArea.Value = apartment.Area;
                    nudPrice.Value = apartment.Price;
                    txtDescription.Text = apartment.Description;
                    chkAvailable.Checked = apartment.IsAvailable;
                    txtLandlordName.Text = apartment.LandlordName;
                    txtLandlordPhone.Text = apartment.LandlordPhone;
                }
            }
        }

        private void btnCalculateOptimal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите квартиру", "Информация");
                return;
            }

            var apartment = dataGridView1.SelectedRows[0].DataBoundItem as Apartment;
            decimal optimalPrice = DatabaseHelper.CalculateOptimalPrice(apartment);

            MessageBox.Show($"Оптимальная цена для этой квартиры: {optimalPrice:C}\n" +
                          $"Текущая цена: {apartment.Price:C}\n" +
                          $"Разница: {optimalPrice - apartment.Price:C}",
                          "Расчет оптимальной цены");
        }

        private void btnFindUndervalued_Click(object sender, EventArgs e)
        {
            var undervalued = DatabaseHelper.FindUndervaluedApartments();
            if (undervalued.Any())
            {
                string result = "Недорогие квартиры (ниже рыночной стоимости):\n\n";
                foreach (var apt in undervalued)
                {
                    decimal optimal = DatabaseHelper.CalculateOptimalPrice(apt);
                    result += $"{apt.Address} - {apt.Price:C} (рекомендуется {optimal:C})\n";
                }
                MessageBox.Show(result, "Результаты анализа");
            }
            else
            {
                MessageBox.Show("Недорогих квартир не найдено", "Информация");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApartments();
            UpdateStatistics();
        }

        private void txtLandlordPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}