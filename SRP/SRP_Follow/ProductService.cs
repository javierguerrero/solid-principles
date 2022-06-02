using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Follow
{
    public class ProductService
    {
        private readonly LogService LogService;
        public ProductService(LogService logService) => LogService = logService;

        public void Create(Product product)
        {
            // Código para crear el producto
            // .....
            //
            // Registrar la actividad
            var Activity = new Activity
            {
                Message = $"Producto agregado {product.Id}",
                Module = nameof(Create)
            };
            LogService.Write(Activity);
        }
    }
}
