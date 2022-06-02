namespace DIP_Follow
{
    public class ProductService
    {
        readonly ILogger Logger;
        public ProductService(ILogger logger) => Logger = logger;

        public void Create(Product product)
        {
            // Lógica para crear el producto...
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