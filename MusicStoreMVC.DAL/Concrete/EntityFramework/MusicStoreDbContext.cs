using MusicStoreMVC.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreMVC.DAL.Concrete.EntityFramework
{
    class MusicStoreDbContext : DbContext
    {
        public MusicStoreDbContext() : base("server=.;Database=MusicStoreDb;UID=sa;PWD=123;")
        {

        }

        public DbSet<Album> Albums { get; set; }
    }
}
