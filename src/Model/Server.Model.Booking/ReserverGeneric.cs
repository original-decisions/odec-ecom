using System;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Booking
{
    //TODO:Refactor this class
    /// <summary>
    /// Обобщенный класс - резерватор(бронирующий)
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    /// <typeparam name="TRoom">Тип комнаты</typeparam>
    public class ReserverGeneric<TKey, TRoom>:Glossary<TKey>
    {
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public ReserverGeneric()
        {
            StartReservationDate = DateTime.Now.AddDays(30);
            EndReservationDate = DateTime.Now.AddDays(44);
        }
        /// <summary>
        /// Имя
        /// </summary>
        [StringLength(500)]
        public override string Name { get; set; }
        /// <summary>
        /// Идентификтор комнаты
        /// </summary>
        [Required]
        public TKey RoomId { get; set; }
        /// <summary>
        /// Комната
        /// </summary>
        public TRoom Room { get; set; }
        /// <summary>
        /// Контактный телефон
        /// </summary>
        [Required]
        [StringLength(20)]
        public string ContactPhone { get; set; }
        /// <summary>
        /// Начало брони
        /// </summary>
        public DateTime StartReservationDate { get; set; }
        /// <summary>
        /// Конец брони
        /// </summary>
        public DateTime EndReservationDate { get; set; }
    }
}