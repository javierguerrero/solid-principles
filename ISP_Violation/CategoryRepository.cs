/*
¿Qué pasa ahora si queremos implementar un repositorio que solo implemente la funcionalidad de
recuperación de datos? La clase estaría obligada a implementar cada una de las operaciones y lanzar
excepciones en las operaciones no soportadas. 
 */
namespace ISP_Violation
{
    public class CategoryRepository : IRepository<Category>
    {
        public void Create(Category category)
        {
            throw new NotImplementedException();
        }

        public Category RetrieveById(int id)
        {
            Category Result = default;
            // Código de la implementación
            return Result; ;
        }

        public IEnumerable<Category> RetrieveAll()
        {
            List<Category> Result = default;
            // Código de la implementación
            return Result;
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
