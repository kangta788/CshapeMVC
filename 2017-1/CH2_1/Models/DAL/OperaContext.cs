using CH2_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH2_1.DAL
{
    public class OperaContext : DbContext
    {
        public DbSet<Opera> Operas { get; set; }
    }
}
