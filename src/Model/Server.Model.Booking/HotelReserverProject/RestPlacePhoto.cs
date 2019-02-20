using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using odec.Framework.Generic.WithUnifiedId;

namespace odec.Server.Model.Booking.HotelReserverProject
{
    /// <summary>
    /// серверный объект - фото места отдыха
    /// </summary>
    public class RestPlacePhoto :Image<Int32,Navigation>
    {
        /// <summary>
        /// название места
        /// </summary>
        [StringLength(100)]
        public override string Name { get; set; }

        /// <summary>
        /// описание места
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public string Description { get; set; }
        
       
    }

}
