using System.Collections.Generic;

namespace MedicalSolution.Infraestructure.Data
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> Getall();

        T GetById(object Id);

        void Insert(T obj);

        void Update(T obj);

        void Delete(T obj);

        void Save();
    }
}
