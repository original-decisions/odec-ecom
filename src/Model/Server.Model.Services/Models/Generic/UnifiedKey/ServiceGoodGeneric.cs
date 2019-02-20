using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Services.Models.Generic.UnifiedKey
{
    public class ServiceGoodGeneric<TKey, TGood, TService>
    {
        [Key, Column(Order = 1)]
        public TKey GoodId { get; set; }

        public TGood Good { get; set; }

        [Key,Column(Order = 0)]
        public TKey ServiceId { get; set; }
        public TService Service { get; set; }
    }
}
