using MusicStoreMVC.Core.DAL.EntityFramework;
using MusicStoreMVC.DAL.Abstract;
using MusicStoreMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreMVC.DAL.Concrete.EntityFramework
{
    public class OrderRepository : EFRepositoryBase<Order, MusicStoreDbContext>, IOrderDAL
    {
    }
}
