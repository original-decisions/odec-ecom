using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Basket.Generic
{
    public class BasketGeneric<TUserId, TUser, TGoodId,TGood>
    {
        [Key, Column(Order = 1)]
        public TUserId UserId { get; set; }
        public TUser User { get; set; }

        [Key, Column(Order = 0)]
        public TGoodId GoodId { get; set; }

        
        public TGood Good { get; set; }

        [Required]
        public DateTime DateUpdated { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        [DefaultValue(1)]
        public int GoodCount { get; set; }

    }
}
