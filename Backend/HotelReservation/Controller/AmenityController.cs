using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Data;
using HotelReservation.Dto;
using HotelReservation.Model;
using HotelReservation.Service;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AmenityController(AmenityService service) : ControllerBase
    {
        private readonly AmenityService service = service;

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
            return CreatedAtAction(nameof(GetAmenityByIdAsync), new { id = amenity.Id }, amenity);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Amenity>> UpdateAmenityById(int id, AmenityDto amenity)
        {
            var amenityToUpdate = await service.UpdateAmenityById(id, amenity);
            if (amenityToUpdate == null)
                return NotFound();
            return Ok(amenityToUpdate);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteById(int id)
        {
            var amenity = await service.GetAmenityByIdAsync(id);
            if (amenity == null)
                return NotFound();
            service.DeleteAmenityById(id);
            return NoContent();

        }
    }
}