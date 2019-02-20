using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Services.Models.Generic.UnifiedKey
{
    public class ServiceGeneric<TKey, TServiceType, TServiceReview> : Glossary<TKey>
    {

        [StringLength(200)]
        public override string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string SerialNumber { get; set; }

        [Required]
        public TKey ServiceTypeId { get; set; }

        public virtual TServiceType ServiceType { get; set; }

        [Required]
        public decimal LowerCost { get; set; }
        
        [Required]
        public decimal UpperCost { get; set; }

        [Required]
        [DefaultValue("")]
        [MaxLength(1536)]
        public string Description { get; set; }


        public virtual ICollection<TServiceReview> ServiceReviews { get; set; }
    //    public virtual ICollection<ServiceType> ServiceTypes { get; set; }

    }
}