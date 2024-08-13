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
    public class ReservationController(ReservationService service) : ControllerBase
    {
        private readonly ReservationService service = service;

        [HttpGet]
        public async Task<ActionResult<List<Reservation>>> GetAllReservations()
        {
            var reservations = await service.GetReservations();
            return Ok(reservations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservation(int id)
        {
            var reservation = await service.GetReservation(id);
            if (reservation == null)
                return NotFound();
            return Ok(reservation);
        }

        [HttpPost]
        public async Task<ActionResult<Reservation>> CreateReservation(ReservationDto reservation)
        {
            var newReservation = await service.CreateReservation(reservation);
            return Ok(newReservation);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Reservation>> UpdateReservation(int id, ReservationDto reservation)
        {
            var reservationToUpdate = await service.UpdateReservation(id, reservation);
            if (reservationToUpdate == null)
                return NotFound();
            return Ok(reservationToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteReservation(int id)
        {
            await service.DeleteReservation(id);
            return Ok();
        }


    }
}