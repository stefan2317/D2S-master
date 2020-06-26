using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D2S.Models;
using Microsoft.EntityFrameworkCore;

namespace D2S.DataBase
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {

        }

        public DbSet<EmpClass> chat { get; set; }
        public DbSet<Mensagem> mensagens{ get; set; }
        public DbSet<FazerEncomenda> encomendas { get; set; }

        public DbSet<Cliente> clientes { get; set; }
    }
}
