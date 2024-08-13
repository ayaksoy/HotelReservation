using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Data;
using HotelReservation.Dto;
using HotelReservation.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Service
{
    public class ReservationService(HotelContext db)
    {
        private readonly HotelContext db = db;

        public async Task<List<Reservation>> GetReservations()
        {
            return await db.Reservations.ToListAsync();
        }

        public async Task<Reservation> GetReservation(int id)
        {
            return await db.Reservations.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<Reservation> CreateReservation(ReservationDto reservation)
        {
            var newReservation = new Reservation
            {
                RoomId = reservation.RoomId,
                CheckInDate = reservation.CheckInDate,
                CheckOutDate = reservation.CheckOutDate,
                NumberOfGuests = reservation.NumberOfGuests,
                GuestFirstName = reservation.GuestFirstName,
                GuestLastName = reservation.GuestLastName,
                GuestPhone = reservation.GuestPhone,
                GuestEmail = reservation.GuestEmail,
                Request = reservation.Request
            };
            db.Reservations.Add(newReservation);
            await db.SaveChangesAsync();
            return newReservation;
        }

        public async Task<Reservation> UpdateReservation(int id, ReservationDto reservation)
        {
            var reservationToUpdate = await db.Reservations.FirstOrDefaultAsync(r => r.Id == id);
            if (reservationToUpdate == null)
                return null;
            reservationToUpdate.RoomId = reservation.RoomId;
            reservationToUpdate.CheckInDate = reservation.CheckInDate;
            reservationToUpdate.CheckOutDate = reservation.CheckOutDate;
            reservationToUpdate.NumberOfGuests = reservation.NumberOfGuests;
            reservationToUpdate.GuestFirstName = reservation.GuestFirstName;
            reservationToUpdate.GuestLastName = reservation.GuestLastName;
            reservationToUpdate.GuestPhone = reservation.GuestPhone;
            reservationToUpdate.GuestEmail = reservation.GuestEmail;
            reservationToUpdate.Request = reservation.Request;
            db.Reservations.Update(reservationToUpdate);
            await db.SaveChangesAsync();
            return reservationToUpdate;
        }
        public async Task DeleteReservation(int id)
        {
            var reservation = await db.Reservations.FirstOrDefaultAsync(r => r.Id == id);
            db.Reservations.Remove(reservation);
            await db.SaveChangesAsync();
        }
    }
}