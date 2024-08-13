using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Data;
using HotelReservation.Dto;
using HotelReservation.Model;

namespace HotelReservation.Service
{
    public class RoomTypeService(HotelContext db)
    {
        private readonly HotelContext db = db;
        public List<RoomType> GetRoomTypes()
        {
            return db.RoomTypes.ToList();
        }

        public RoomType GetRoomType(int id)
        {
            return db.RoomTypes.FirstOrDefault(rt => rt.Id == id);
        }

        public RoomType CreateRoomType(RoomTypeDto roomType)
        {
            var newRoomType = new RoomType
            {
                Name = roomType.Name,
                PricePerNight = roomType.PricePerNight,
                Size = roomType.Size,
                Images = roomType.Images,
                MaxOccupancy = roomType.MaxOccupancy
            };
            db.RoomTypes.Add(newRoomType);
            db.SaveChanges();
            return newRoomType;
        }

        public RoomType UpdateRoomType(int id, RoomTypeDto roomType)
        {
            var roomTypeToUpdate = db.RoomTypes.FirstOrDefault(rt => rt.Id == id);
            if (roomTypeToUpdate == null)
                return null;
            roomTypeToUpdate.Name = roomType.Name;
            roomTypeToUpdate.PricePerNight = roomType.PricePerNight;
            roomTypeToUpdate.Size = roomType.Size;
            roomTypeToUpdate.Images = roomType.Images;
            roomTypeToUpdate.MaxOccupancy = roomType.MaxOccupancy;
            db.RoomTypes.Update(roomTypeToUpdate);
            db.SaveChanges();
            return roomTypeToUpdate;
        }

        public void DeleteRoomType(int id)
        {
            var roomType = db.RoomTypes.FirstOrDefault(rt => rt.Id == id);
            db.RoomTypes.Remove(roomType);
            db.SaveChanges();
        }
    }
}