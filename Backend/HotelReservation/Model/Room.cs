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

        public double PricePerNight { get; set; }

        public int NumberOfBeds { get; set; }

        public int MaxOccupancy { get; set; }

        public int Floor { get; set; }  // Odanın bulunduğu kat 
        public List<string>? Images { get; set; }  // Odanın resimleri
        public bool IsAvailable { get; set; } = true;  // Oda müsait mi?
        public List<Reservation>? Reservations { get; set; }  // Oda rezervasyonları
    }
}