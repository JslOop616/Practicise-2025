using System;

namespace ApartmentRentalAdmin
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Rooms { get; set; }
        public decimal Area { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public string LandlordName { get; set; }
        public string LandlordPhone { get; set; }
        public DateTime AddedDate { get; set; }
    }
}