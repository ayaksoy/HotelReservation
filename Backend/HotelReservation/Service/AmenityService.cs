using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Data;
using HotelReservation.Dto;
using HotelReservation.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Service
{
    public class AmenityService(HotelContext db)
    {
        private readonly HotelContext db = db;
        public async Task<IEnumerable<Amenity>> GetAllAmenitiesAsync()
        {
            return await db.Amenities.ToListAsync();
        }
        public async Task<Amenity> GetAmenityByIdAsync(int id)
        {
            var amenity = await db.Amenities.FindAsync(id);
            return amenity;
        }
        public async Task<Amenity> CreateAmenityAsync(AmenityDto amenityDto)
        {
            var amenity = new Amenity
            {
                Name = amenityDto.Name,
                Description = amenityDto.Description,
                Icon = amenityDto.Icon
            };
            db.Amenities.Add(amenity);
            await db.SaveChangesAsync();
            return amenity;
        }
        public async Task<Amenity> UpdateAmenityById(int id, AmenityDto amenity)
        {
            var amenityToUpdate = await db.Amenities.FindAsync(id);
            if (amenityToUpdate == null)
                return null;
            amenityToUpdate.Name = amenity.Name;
            amenityToUpdate.Description = amenity.Description;
            amenityToUpdate.Icon = amenity.Icon;
            db.Amenities.Update(amenityToUpdate);
            db.SaveChanges();
            return amenityToUpdate;
        }

        internal void DeleteAmenityById(int id)
        {
            throw new NotImplementedException();
        }
    }
}