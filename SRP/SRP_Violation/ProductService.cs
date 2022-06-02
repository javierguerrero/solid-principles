/*
El problema con el código de la clase ProductService es que además de crear productos, que es la
responsabilidad principal por la que fue creada, registra actividades que no son propiamente su
responsabilidad.
*/
namespace SRP_Violation
{
    public class ProductService
    {
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
            WriteLog(Activity);
        }

        public void WriteLog(Activity activity)
        {
            // Código para registrar la actividad
            Console.WriteLine("{0}, {1}, {2}",
            activity.CreatedDate, activity.Module, activity.Message);
        }
    }
}