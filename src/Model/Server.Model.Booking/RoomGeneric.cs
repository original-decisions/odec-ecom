using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.Framework.Generic;

namespace odec.Server.Model.Booking
{
    //TODO:Refactor this class
    /// <summary>
    /// Обобщенный класс - комната
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    /// <typeparam name="TRoomType">Тип типа комнаты</typeparam>
    /// <typeparam name="TReserver">Тип резерванта</typeparam>
    public class RoomGeneric<TKey, TRoomType, TReserver> : Glossary<TKey>
    {
        /// <summary>
        /// Номер комнаты
        /// </summary>
        [StringLength(250)]
        [Column("Number")]
        public override string Name { get; set; }
        /// <summary>
        /// Идентификатор типа комнаты
        /// </summary>
        [Required]
        public TKey RoomTypeId { get; set; } 
        /// <summary>
        /// тип комнаты
        /// </summary>
        public TRoomType RoomType { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        [Required]
        public decimal Cost { get; set; }
        /// <summary>
        /// Старая цена
        /// </summary>
        [Required]
        public decimal OldCost { get; set; }
        /// <summary>
        /// Список бронировщиков
        /// </summary>
        public virtual ICollection<TReserver> Reservers{ get; set; }
    }
}