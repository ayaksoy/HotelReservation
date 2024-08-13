using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Model.Enum;

namespace HotelReservation.Dto
{
    public class RoomTypeDto
    {
        public EnumType Name { get; set; }
        public double PricePerNight { get; set; }
        public int MaxOccupancy { get; set; }
        public int Size { get; set; }
        public List<string>? Images { get; set; }
    }
}