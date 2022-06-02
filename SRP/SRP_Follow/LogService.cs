using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Follow
{
    public class LogService
    {
        public void Write(Activity activity)
        {
            // Código para registrar la actividad
            Console.WriteLine("{0}, {1}, {2}",
            activity.CreatedDate, activity.Module, activity.Message);
        }
    }
}
