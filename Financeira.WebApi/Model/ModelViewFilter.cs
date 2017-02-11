using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financeira.WebApi.Model
{
    public class ModelViewFilter
    {
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        public bool IsGroup { get; set; }
    }
}
