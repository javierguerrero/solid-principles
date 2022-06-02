using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Violation
{
    public interface IRepository<T>
    {
        void Create(T Entity);
        T RetrieveById(int id);
        IEnumerable<T> RetrieveAll();
        void Update(T Entity);
        void Delete(int id);
    }
}
