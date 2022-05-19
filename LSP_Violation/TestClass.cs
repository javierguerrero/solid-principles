
/*
El siguiente código que utiliza las clases anteriores, muestra que no obtenemos el mismo
comportamiento al remplazar instancias de clases base por cualquiera de sus clases derivadas. 
 */

namespace LSP_Violation
{
    public class TestClass
    {
        public void Test()
        {
            Entity E = new Product();
            E.Create(); // Funciona correctamente.
            E.Update(); // Funciona correctamente.
            E.Delete(); // Funciona correctamente.

            E = new Category();
            E.Create(); // Funciona correctamente.
            E.Update(); // Lanza una excepción.
            E.Delete(); // Lanza una excepción.
        }
    }
}
