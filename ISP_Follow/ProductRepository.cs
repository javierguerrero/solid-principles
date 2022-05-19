using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Follow
{
    public class ProductRepository : IReadable<Product>, IWriteable<Product>, IDeleteable
    {
        public void Create(Product Entity)
        {
            // Código de la implementación
        }

        public void Delete(int id)
        {
            // Código de la implementación
        }

        public IEnumerable<Product> RetrieveAll()
        {
            List<Product> Result = default;
            // Código de la implementación
            return Result;
        }

        public Product RetrieveById(int id)
        {
            Product Result = default;
            // Código de la implementación
            return Result;
        }

        public void Update(Product Entity)
        {
            // Código de la implementación
        }
    }
}
