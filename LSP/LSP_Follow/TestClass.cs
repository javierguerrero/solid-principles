using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Follow
{
    public class TestClass
    {
        public void Test()
        {
            ICreateable C = new Product();
            C.Create(); // Funciona correctamente.

            C = new Category();
            C.Create(); // Funciona correctamente.
        }
    }
}
