using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Room
    {
        
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }  // Odanın türü
        public int Floor { get; set; }  // Odanın bulunduğu kat 
        public List<Reservation>? Reservations { get; set; }  // Oda rezervasyonları
    }
}