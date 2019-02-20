using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Booking
{
    //TODO:Refactor this class
    /// <summary>
    /// Обобщенный класс - тип комнаты
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TRoom"></typeparam>
    /// <typeparam name="TRoomImage"></typeparam>
    public class RoomTypeGeneric<TKey, TRoom, TRoomImage> : Glossary<TKey>
    {
        /// <summary>
        /// Название
        /// </summary>
        [StringLength(50)]
        public override string Name { get; set; }
        /// <summary>
        /// Описание типа комнаты
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(250)]
        public string StaticRoomDescription { get; set; }
        /// <summary>
        /// Комнаты этого типа
        /// </summary>
        public virtual  ICollection<TRoom>  Rooms{ get; set; }
        /// <summary>
        /// Изображение комнат этого типа
        /// </summary>
        public virtual ICollection<TRoomImage> Images{ get; set; }
        /// <summary>
        /// начальная цена
        /// </summary>
        [Required]
        public decimal StartPrice { get; set; }
        /// <summary>
        /// Конечная цена
        /// </summary>
        [Required]
        public decimal EndPrice { get; set; }

    }
}
