using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Dto;
using HotelReservation.Model;
using HotelReservation.Service;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomTypeController(RoomTypeService service) : ControllerBase
    {
        private readonly RoomTypeService service = service;

        [HttpGet]
        public ActionResult<List<RoomType>> GetAllRoomTypes()
        {
            var roomTypes = service.GetRoomTypes();
            return Ok(roomTypes);
        }

        [HttpGet("{id}")]
        public ActionResult<RoomType> GetRoomType(int id)
        {
            var roomType = service.GetRoomType(id);
            if (roomType == null)
                return NotFound();
            return Ok(roomType);
        }

        [HttpPost]
        public ActionResult<RoomType> CreateRoomTypeAsync(RoomTypeDto roomTypeDto)
        {
            var roomType = service.CreateRoomType(roomTypeDto);
            return Ok(roomType);
        }

        [HttpPut("{id}")]
        public ActionResult<RoomType> UpdateRoomType(int id, RoomTypeDto roomTypeDto)
        {
            var roomTypeToUpdate = service.UpdateRoomType(id, roomTypeDto);
            if (roomTypeToUpdate == null)
                return NotFound();
            return Ok(roomTypeToUpdate);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteRoomType(int id)
        {
            service.DeleteRoomType(id);
            return Ok();
        }
    }
}