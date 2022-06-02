namespace ISP_Violation
{
    public class ProductRepository : IRepository<Product>
    {
        public void Create(Product Entity)
        {
            // Código de la implementación
        }

        public Product RetrieveById(int id)
        {
            Product Result = default;
            // Código de la implementación
            return Result; ;
        }

        public IEnumerable<Product> RetrieveAll()
        {
            List<Product> Result = default;
            // Código de la implementación
            return Result;
        }

        public void Update(Product Entity)
        {
            // Código de la implementación
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}