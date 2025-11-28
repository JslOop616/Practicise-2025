using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Rooms { get; set; }
        public double Area { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public string LandlordName { get; set; }
        public string LandlordPhone { get; set; }
        public DateTime AddedDate { get; set; }
    }

    public class RentalApplication
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public string TenantName { get; set; }
        public string TenantPhone { get; set; }
        public string TenantEmail { get; set; }
        public DateTime DesiredMoveInDate { get; set; }
        public int RentalPeriodMonths { get; set; }
        public string Comments { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; } // "Pending", "Approved", "Rejected"
    }

    public static class DatabaseHelper
    {
        private static string apartmentsFile = "apartments.xml";
        private static string applicationsFile = "applications.xml";
        private static List<Apartment> apartments = new List<Apartment>();
        private static List<RentalApplication> applications = new List<RentalApplication>();
        private static int nextApartmentId = 1;
        private static int nextApplicationId = 1;

        public static void InitializeDatabase()
        {
            LoadApartments();
            LoadApplications();
            
            // Добавляем тестовые данные если база пустая
            if (!apartments.Any())
            {
                AddSampleApartments();
            }
        }

        private static void AddSampleApartments()
        {
            apartments.Add(new Apartment
            {
                Id = nextApartmentId++,
                Address = "ул. Ленина, д. 10, кв. 25",
                Rooms = 2,
                Area = 45.5,
                Price = 25000,
                Description = "Уютная двухкомнатная квартира в центре города",
                IsAvailable = true,
                LandlordName = "Иванов Иван",
                LandlordPhone = "+7-900-123-45-67",
                AddedDate = DateTime.Now
            });

            apartments.Add(new Apartment
            {
                Id = nextApartmentId++,
                Address = "пр. Мира, д. 15, кв. 12",
                Rooms = 1,
                Area = 35.0,
                Price = 18000,
                Description = "Компактная однокомнатная квартира с ремонтом",
                IsAvailable = true,
                LandlordName = "Петрова Мария",
                LandlordPhone = "+7-900-987-65-43",
                AddedDate = DateTime.Now
            });

            apartments.Add(new Apartment
            {
                Id = nextApartmentId++,
                Address = "ул. Садовая, д. 5, кв. 78",
                Rooms = 3,
                Area = 65.0,
                Price = 35000,
                Description = "Просторная трехкомнатная квартира с балконом",
                IsAvailable = true,
                LandlordName = "Сидоров Алексей",
                LandlordPhone = "+7-900-555-44-33",
                AddedDate = DateTime.Now
            });

            SaveApartments();
        }

        // Методы для работы с квартирами
        public static List<Apartment> GetAvailableApartments()
        {
            return apartments.Where(a => a.IsAvailable).OrderByDescending(a => a.AddedDate).ToList();
        }

        public static List<Apartment> SearchApartments(string address, int? minRooms, int? maxRooms, decimal? maxPrice)
        {
            var query = apartments.Where(a => a.IsAvailable);

            if (!string.IsNullOrEmpty(address))
                query = query.Where(a => a.Address.ToLower().Contains(address.ToLower()));

            if (minRooms.HasValue)
                query = query.Where(a => a.Rooms >= minRooms.Value);

            if (maxRooms.HasValue)
                query = query.Where(a => a.Rooms <= maxRooms.Value);

            if (maxPrice.HasValue)
                query = query.Where(a => a.Price <= maxPrice.Value);

            return query.OrderBy(a => a.Price).ToList();
        }

        // Методы для работы с заявками
        public static void SubmitApplication(RentalApplication application)
        {
            application.Id = nextApplicationId++;
            application.ApplicationDate = DateTime.Now;
            application.Status = "Pending";
            applications.Add(application);
            SaveApplications();
        }

        public static List<RentalApplication> GetUserApplications(string userPhone)
        {
            return applications.Where(a => a.TenantPhone == userPhone)
                             .OrderByDescending(a => a.ApplicationDate)
                             .ToList();
        }

        // Сохранение и загрузка данных
        private static void LoadApartments()
        {
            try
            {
                if (File.Exists(apartmentsFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Apartment>));
                    using (FileStream stream = new FileStream(apartmentsFile, FileMode.Open))
                    {
                        apartments = (List<Apartment>)serializer.Deserialize(stream);
                        nextApartmentId = apartments.Count > 0 ? apartments.Max(a => a.Id) + 1 : 1;
                    }
                }
            }
            catch (Exception)
            {
                apartments = new List<Apartment>();
                nextApartmentId = 1;
            }
        }

        private static void SaveApartments()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Apartment>));
                using (FileStream stream = new FileStream(apartmentsFile, FileMode.Create))
                {
                    serializer.Serialize(stream, apartments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения квартир: {ex.Message}", "Ошибка");
            }
        }

        private static void LoadApplications()
        {
            try
            {
                if (File.Exists(applicationsFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<RentalApplication>));
                    using (FileStream stream = new FileStream(applicationsFile, FileMode.Open))
                    {
                        applications = (List<RentalApplication>)serializer.Deserialize(stream);
                        nextApplicationId = applications.Count > 0 ? applications.Max(a => a.Id) + 1 : 1;
                    }
                }
            }
            catch (Exception)
            {
                applications = new List<RentalApplication>();
                nextApplicationId = 1;
            }
        }

        private static void SaveApplications()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<RentalApplication>));
                using (FileStream stream = new FileStream(applicationsFile, FileMode.Create))
                {
                    serializer.Serialize(stream, applications);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения заявок: {ex.Message}", "Ошибка");
            }
        }
    }
}