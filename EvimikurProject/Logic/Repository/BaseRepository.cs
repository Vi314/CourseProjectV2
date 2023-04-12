using DataAccess;
using Entity.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly Context _context;
        private DbSet<T> _entity;

        public BaseRepository(Context context) 
        {
            this._context = context;
            _entity = context.Set<T>();
        }

        public string Create(T thing)
        {
            try
            {
                _entity.Add(thing);
                _context.SaveChanges();
                return "Created";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                GetById(id).State = EntityState.Deleted;
                _context.SaveChanges();
                return "Deleted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(T Thing)
        {
            try
            {
                _entity.Entry(Thing).State = EntityState.Modified;
                _context.SaveChanges();
                return "Updated";
            }
            catch (Exception ex)
            {

                return ex.Message;

            }
        }

        public T GetById(int id)
        {
            try
            {
                return _entity.Find(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public IEnumerable<T> GetAll()
        {
            return _entity.ToList();
        }
    }
}
