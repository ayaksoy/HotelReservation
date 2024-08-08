using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Data;
using HotelReservation.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Service
{
    public class RoomTypeService(HotelContext db)
    {
        private readonly HotelContext db = db;
    
    }
}