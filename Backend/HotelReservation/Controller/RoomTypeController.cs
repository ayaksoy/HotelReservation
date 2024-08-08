using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Data;
using HotelReservation.Model;
using HotelReservation.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomTypeController( RoomTypeService service) : ControllerBase
    {
        private readonly RoomTypeService service = service;
    }
}