using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class RoomType
    {
        int Id { get; set; }
        string? Name { get; set; }
        List<Room>? Rooms { get; set; }
        List<string>? Amenities { get; set; }
    }
}