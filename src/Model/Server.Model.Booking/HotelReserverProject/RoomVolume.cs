using System;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Booking.HotelReserverProject
{
    public class RoomVolume:Glossary<Int32>
    {
        [StringLength(30)]
        public override string Name { get; set; }
    }
}
