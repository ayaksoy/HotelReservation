using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Data;
using HotelReservation.Dto;
using HotelReservation.Model;
using HotelReservation.Service;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AmenityController : ControllerBase
    {
        private readonly AmenityService service;

        public AmenityController(AmenityService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amenity>>> GetAllAmenitiesAsync()
        {
            var amenities = await service.GetAllAmenitiesAsync();
            return Ok(amenities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Amenity>> GetAmenityByIdAsync(int id)
        {
            var amenity = await service.GetAmenityByIdAsync(id);
            if (amenity == null)
                return NotFound();
            return Ok(amenity);
        }

        [HttpPost]
        public async Task<ActionResult<Amenity>> CreateAmenityAsync(AmenityDto amenityDto)
        {
            var amenity = await service.CreateAmenityAsync(amenityDto);
            return Ok(amenity);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Amenity>> UpdateAmenityByIdAsync(int id, AmenityDto amenityDto)
        {
            var amenityToUpdate = await service.UpdateAmenityByIdAsync(id, amenityDto);
            if (amenityToUpdate == null)
                return NotFound();
            return Ok(amenityToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteByIdAsync(int id)
        {
            var amenity = await service.GetAmenityByIdAsync(id);
            if (amenity == null)
                return NotFound();

            service.DeleteAmenityByIdAsync(id); // Eğer bu metot async ise await kullanın
            return NoContent();
        }
    }
}
