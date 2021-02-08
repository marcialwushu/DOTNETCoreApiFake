using IS2B.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS2B.Infra.Persistence.EF
{
    class IS2BContext : DbContext
    {
        public DbSet<JsonLoginRequest> Login { get; set; }

        public IS2BContext()
        {

        }


    }
}
