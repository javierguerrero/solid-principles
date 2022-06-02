/*
El código anterior funciona muy bien, sin embargo, ¿qué pasará cuando queramos registra actividades
hacia un archivo o hacia el log de Windows? Tendremos que cambiar todas las referencias que
hacemos de ConsoleLogger. 
 */
namespace DIP_Violation
{
    public class ProductService
    {
        readonly ConsoleLogger Logger;
        public ProductService(ConsoleLogger logger) => Logger = logger;

        public void Create(Product product)
        {
            // Lógica para crear el producto
            // ....
            // Escribir al log...
            var Activity = new Activity
            {
                Message = $"Producto agregado {product.Id}",
                Module = nameof(Create)
            };
            Logger.Write(Activity);
        }
    }
}
