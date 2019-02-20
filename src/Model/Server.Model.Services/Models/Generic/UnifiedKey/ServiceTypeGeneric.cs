using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Services.Models.Generic.UnifiedKey
{
    public class ServiceTypeGeneric<TKey> : Glossary<TKey>
    {
        [StringLength(150)]
        public override string Name { get; set; }

    }
}
