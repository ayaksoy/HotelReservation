using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Model.Enum;

namespace HotelReservation.Model
{
    public class RoomType
    {
        public int Id { get; set; }
        public EnumType Name { get; set; }
        public double PricePerNight { get; set; }
        public int Size { get; set; }
        public List<string>? Images { get; set; }
        public List<Room>? Rooms { get; set; }
        public List<Amenity>? Amenities { get; set; }
    }
}