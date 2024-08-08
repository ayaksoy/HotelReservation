using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
        public int NumberOfGuests { get; set; }  // Rezervasyondaki toplam konuk sayısı
        public string? GuestName { get; set; }
        public string? GuestEmail { get; set; }
    }
}