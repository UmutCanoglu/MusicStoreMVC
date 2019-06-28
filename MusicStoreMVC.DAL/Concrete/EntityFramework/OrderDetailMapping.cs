using MusicStoreMVC.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreMVC.DAL.Concrete.EntityFramework
{
    class OrderDetailMapping : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMapping()
        {
            HasKey(a => new { a.OrderID, a.AlbumID });
        }
    }
}
