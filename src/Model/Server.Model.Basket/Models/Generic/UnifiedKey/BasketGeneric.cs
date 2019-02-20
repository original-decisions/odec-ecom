using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Basket.Generic.UnifiedKey
{
    /// <summary>
    /// обобщенный класс корзина пользователя
    /// </summary>
    /// <typeparam name="TKey">Тип Идентификатора</typeparam>
    /// <typeparam name="TUser">ТИп пользователя</typeparam>
    /// <typeparam name="TGood">Тип Товара</typeparam>
    public class BasketGeneric<TKey, TUser,TGood>
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [Key, Column(Order = 1)]
        public TKey UserId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public TUser User { get; set; }
        /// <summary>
        /// Идентификатор товара
        /// </summary>
        [Key, Column(Order = 0)]
        public TKey GoodId { get; set; }
        /// <summary>
        /// Товар
        /// </summary>
        public TGood Good { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        [Required]
        public DateTime DateUpdated { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Кро-во товаров этого типа
        /// </summary>
        [Required]
        [DefaultValue(1)]
        public int GoodCount { get; set; }

    }
}
