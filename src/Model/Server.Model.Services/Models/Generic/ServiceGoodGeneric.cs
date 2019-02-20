using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Services.Models.Generic
{
    public class ServiceGoodGeneric<TGoodId,TGood,TServiceId,TService>
    {
        [Key, Column(Order = 1)]
        public TGoodId GoodId { get; set; }

        public TGood Good { get; set; }

        [Key,Column(Order = 0)]
        public TServiceId ServiceId { get; set; }
        public TService Service { get; set; }
    }
}
