using MusicStoreMVC.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreMVC.Core.DAL
{
    public interface IRepository<TEntity>
        where TEntity:BaseEntity //Bu Interface'i implement edecek class Entity tipinde olmaz zorunda.
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> filter); //Get metodu içine lambda yazabilecek bir parametre oluşturmuş olduk
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

        /* ---CRUD---
         * Create
         * Read
         * Update
         * Delete */
    }
}
