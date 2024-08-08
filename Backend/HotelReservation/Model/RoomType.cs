using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class RoomType
    {
        public int Id { get; set; }
        public Type? Name { get; set; }
        public double PricePerNight { get; set; }
        public int Beds { get; set; }
        public int MaxOccupancy { get; set; }
        public List<string>? Images { get; set; }
        public List<Room>? Rooms { get; set; }
        public List<Amenity>? Amenities { get; set; }
    }
}