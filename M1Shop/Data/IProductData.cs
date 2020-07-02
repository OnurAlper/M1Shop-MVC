using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Shop.Data
{
  public interface IEntityData<T>
  {
      IEnumerable<T> GetAll();
      T GetById(int entityId);
      void Insert(T entity);
      T Update(T entity);
      void Delete(int entityId);
      int Comit();
  }


}

