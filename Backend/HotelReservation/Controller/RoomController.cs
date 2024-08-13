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
    public class RoomController(RoomService service) : ControllerBase
    {
        private readonly RoomService service = service;

        [HttpGet]
        public async Task<ActionResult<List<Room>>> GetAllRooms()
        {
            var rooms = await service.GetRooms();
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public ActionResult<Room> GetRoom(int id)
        {
            var room = service.GetRoom(id);
            if (room == null)
                return NotFound();
            return Ok(room);
        }
        [HttpGet("available/{roomTypeId}")]
        public async Task<ActionResult<List<Room>>> GetAvailableRooms(DateTime checkInDate, DateTime checkOutDate, int roomTypeId)
        {
            var availableRooms = await service.GetAvailableRooms(checkInDate, checkOutDate, roomTypeId);
            return Ok(availableRooms);
        }
        [HttpPost]
        public async Task<ActionResult<Room>> CreateRoom(RoomDto roomDto)
        {
            var newRoom = await service.CreateRoom(roomDto);
            return Ok(newRoom);
        }

        [HttpPut("{id}")]
        public ActionResult<Room> UpdateRoom(int id, RoomDto roomDto)
        {
            var roomToUpdate = service.UpdateRoom(id, roomDto);
            if (roomToUpdate == null)
                return NotFound();
            return Ok(roomToUpdate);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteRoom(int id)
        {
            service.DeleteRoom(id);
            return Ok();
        }
    }
}