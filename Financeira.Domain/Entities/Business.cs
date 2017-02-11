using System;
using Financeira.Domain.Enum;

namespace Financeira.Domain.Entities
{
    public class Business : EntityBase
    {
        public float Value { get; set; }

        public String Category { get; set; }

        public EnumBusiness Type { get; set; }

        public DateTime? Date { get; set; }

        public String Observation { get; set; }
    }
}
