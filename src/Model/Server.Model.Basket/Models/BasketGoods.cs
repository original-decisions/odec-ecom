using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.Server.Model.Basket.Generic.UnifiedKey;
using odec.Server.Model.Store.Blob;

namespace odec.Server.Model.Basket
{
    /// <summary>
    /// таблица связи корзины и товара
    /// </summary>
    public class BasketGood :BasketGeneric<int,User.User,Good>
    {
        public BasketGood()
        {
            DateUpdated = DateTime.Now;
        }

        /// <summary>
        /// Цена
        /// </summary>
        [Required]
        [DefaultValue(0)]
        [Column(TypeName="money")]
        public decimal Cost { get; set; }

        /// <summary>
        /// Старая цена
        /// </summary>
        [Required]
        [DefaultValue(0)]
        [Column(TypeName = "money")]
        public decimal OldCost { get; set; }

    }
}
