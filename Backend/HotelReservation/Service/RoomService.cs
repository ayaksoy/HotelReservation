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
    public class RoomService(HotelContext db, ReservationService reservationService)
    {
        private readonly HotelContext db = db;
        private readonly ReservationService reservationService = reservationService;

        public async Task<List<Room>> GetRooms()
        {
            return await db.Rooms.ToListAsync();
        }

        public async Task<Room> GetRoom(int id)
        {
            return await db.Rooms.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<Room> CreateRoom(RoomDto room)
        {
            var newRoom = new Room
            {
                RoomTypeId = room.RoomTypeId,
                Floor = room.Floor
            };
            db.Rooms.Add(newRoom);
            await db.SaveChangesAsync();
            return newRoom;
        }

        public async Task<Room> UpdateRoom(int id, RoomDto room)
        {
            var roomToUpdate = await db.Rooms.FirstOrDefaultAsync(r => r.Id == id);
            if (roomToUpdate == null)
                return null;
            roomToUpdate.RoomTypeId = room.RoomTypeId;
            roomToUpdate.Floor = room.Floor;
            db.Rooms.Update(roomToUpdate);
            await db.SaveChangesAsync();
            return roomToUpdate;
        }

        public async Task DeleteRoom(int id)
        {
            var room = await db.Rooms.FirstOrDefaultAsync(r => r.Id == id);
            db.Rooms.Remove(room);
            await db.SaveChangesAsync();
        }

        public async Task<List<Room>> GetAvailableRooms(DateTime checkInDate, DateTime checkOutDate, int roomTypeId)
        {
            var reservations = await reservationService.GetReservations();
            var reservedRoomIds = reservations
                .Where(r => r.CheckInDate < checkOutDate && r.CheckOutDate > checkInDate)
                .Select(r => r.RoomId)
                .ToList();
            if (roomTypeId == 0)
            {
                var availableRooms = await db.Rooms
                    .Where(r => !reservedRoomIds.Contains(r.Id))
                    .ToListAsync();
                return availableRooms;
            }
            else
            {
                var availableRooms = await db.Rooms
                    .Where(r => r.RoomTypeId == roomTypeId && !reservedRoomIds.Contains(r.Id))
                    .ToListAsync();
                return availableRooms;
            }
        }

    }
}