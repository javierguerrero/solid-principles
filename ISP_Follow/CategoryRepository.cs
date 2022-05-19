using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Follow
{
    public class CategoryRepository : IReadable<Category>
    {
        public IEnumerable<Category> RetrieveAll()
        {
            List<Category> Result = default;
            // Código de la implementación
            return Result;
        }

        public Category RetrieveById(int id)
        {
            Category Result = default;
            // Código de la implementación
            return Result;
        }
    }
}
