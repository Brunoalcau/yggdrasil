using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Financeira.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeira.Infra.Mapper
{
    public class BusinessMap
    {
        public BusinessMap(EntityTypeBuilder<Business> entityBuilder)
        {
            
        }
    }
}
