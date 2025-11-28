using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace ApartmentRentalAdmin
{
    public static class DatabaseHelper
    {
        private static string dataFile = "apartments.xml";
        private static List<Apartment> apartments = new List<Apartment>();
        private static int nextId = 1;

        public static void InitializeDatabase()
        {
            LoadData();

            // Добавляем тестовые данные если база пустая
            if (!apartments.Any())
            {
                AddSampleData();
            }
        }

        private static void AddSampleData()
        {
            apartments.Add(new Apartment
            {
                Id = nextId++,
                Address = "ул. Ленина, д. 10, кв. 25",
                Rooms = 2,
                Area = 45.5m,
                Price = 25000,
                Description = "Уютная двухкомнатная квартира в центре города",
                IsAvailable = true,
                LandlordName = "Иванов Иван",
                LandlordPhone = "+7-900-123-45-67",
                AddedDate = DateTime.Now
            });

            apartments.Add(new Apartment
            {
                Id = nextId++,
                Address = "пр. Мира, д. 15, кв. 12",
                Rooms = 1,
                Area = 35.0m,
                Price = 18000,
                Description = "Компактная однокомнатная квартира",
                IsAvailable = true,
                LandlordName = "Петрова Мария",
                LandlordPhone = "+7-900-987-65-43",
                AddedDate = DateTime.Now
            });

            apartments.Add(new Apartment
            {
                Id = nextId++,
                Address = "ул. Садовая, д. 5, кв. 78",
                Rooms = 3,
                Area = 65.0m,
                Price = 35000,
                Description = "Просторная трехкомнатная квартира",
                IsAvailable = false,
                LandlordName = "Сидоров Алексей",
                LandlordPhone = "+7-900-555-44-33",
                AddedDate = DateTime.Now
            });

            SaveData();
        }

        public static List<Apartment> GetAllApartments()
        {
            return apartments.OrderByDescending(a => a.AddedDate).ToList();
        }

        public static void AddApartment(Apartment apartment)
        {
            apartment.Id = nextId++;
            apartment.AddedDate = DateTime.Now;
            apartments.Add(apartment);
            SaveData();
        }

        public static void UpdateApartment(Apartment apartment)
        {
            var existing = apartments.FirstOrDefault(a => a.Id == apartment.Id);
            if (existing != null)
            {
                existing.Address = apartment.Address;
                existing.Rooms = apartment.Rooms;
                existing.Area = apartment.Area;
                existing.Price = apartment.Price;
                existing.Description = apartment.Description;
                existing.IsAvailable = apartment.IsAvailable;
                existing.LandlordName = apartment.LandlordName;
                existing.LandlordPhone = apartment.LandlordPhone;
                SaveData();
            }
        }

        public static void DeleteApartment(int id)
        {
            var apartment = apartments.FirstOrDefault(a => a.Id == id);
            if (apartment != null)
            {
                apartments.Remove(apartment);
                SaveData();
            }
        }

        // ВЫЧИСЛИТЕЛЬНЫЕ ФУНКЦИИ
        public static decimal CalculateOptimalPrice(Apartment apartment)
        {
            var similar = apartments.Where(a => a.Rooms == apartment.Rooms).ToList();
            if (!similar.Any()) return apartment.Price;

            decimal avgPrice = similar.Average(a => a.Price);
            decimal pricePerSqm = similar.Average(a => a.Area > 0 ? a.Price / a.Area : 0);

            // Расчет оптимальной цены на основе средней цены за м²
            return apartment.Area * pricePerSqm;
        }

        public static decimal CalculateMonthlyRevenue()
        {
            return apartments.Where(a => !a.IsAvailable).Sum(a => a.Price);
        }

        public static decimal CalculateAnnualRevenue()
        {
            return CalculateMonthlyRevenue() * 12;
        }

        public static (int total, int available, int rented) GetStatistics()
        {
            int total = apartments.Count;
            int available = apartments.Count(a => a.IsAvailable);
            int rented = total - available;
            return (total, available, rented);
        }

        public static List<Apartment> FindUndervaluedApartments()
        {
            return apartments.Where(a => a.IsAvailable)
                           .Where(a => a.Price < CalculateOptimalPrice(a) * 0.9m)
                           .ToList();
        }

        private static void LoadData()
        {
            try
            {
                if (File.Exists(dataFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Apartment>));
                    using (FileStream stream = new FileStream(dataFile, FileMode.Open))
                    {
                        apartments = (List<Apartment>)serializer.Deserialize(stream);
                        nextId = apartments.Count > 0 ? apartments.Max(a => a.Id) + 1 : 1;
                    }
                }
            }
            catch (Exception)
            {
                apartments = new List<Apartment>();
                nextId = 1;
            }
        }

        private static void SaveData()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Apartment>));
                using (FileStream stream = new FileStream(dataFile, FileMode.Create))
                {
                    serializer.Serialize(stream, apartments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка");
            }
        }
    }
}