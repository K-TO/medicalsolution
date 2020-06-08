using MedicalSolution.Data.Context;
using MedicalSolution.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MedicalSolution.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        #region Props
        private MedicalSolutionContext _context;
        private readonly DbSet<T> table;
        #endregion

        #region Ctor
        public GenericRepository(MedicalSolutionContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        #endregion

        #region Methods
        public void Delete(T obj)
        {
            T exists = table.Find(obj);
            table.Remove(exists);
        }

        public IEnumerable<T> Getall()
        {
            return table.ToList();
        }

        public T GetById(object Id)
        {
            return table.Find(Id);
        }


        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        #endregion
    }
}
