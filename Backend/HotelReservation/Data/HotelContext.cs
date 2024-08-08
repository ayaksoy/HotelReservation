using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Data
{
    public class HotelContext : DbContext
    {
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
        }
    }
}