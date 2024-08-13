using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Model;

namespace HotelReservation.Dto
{
    public class RoomDto
    {
        public int RoomTypeId { get; set; }
        public int Floor { get; set; }
    }
}