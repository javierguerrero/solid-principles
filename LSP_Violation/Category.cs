using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Violation
{
    public class Category : Entity
    {
        public override void Create()
        {
            // Código de la implementación
        }
        // Esta clase no implementa esta funcionalidad
        public override void Update()
        {
            throw new NotImplementedException();
        }
        // Esta clase no implmenta esta funcionalidad
        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
