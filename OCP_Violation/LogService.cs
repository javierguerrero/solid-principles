/*
El código anterior rompe el principio de Abierto/Cerrado ya que si queremos agregar en un futuro la
capacidad de registrar actividades al log de Windows tendremos que agregar un case adicional con su
método respectivo.
 */

namespace OCP_Violation
{
    public class LogService
    {
        public void Write(Activity activity, string target)
        {
            switch (target)
            {
                case "console":
                    WriteToConsole(activity);

                    break;
                case "file":
                    WriteToFile(activity);

                    break;

            }
        }

        void WriteToConsole(Activity activity)
        {
            // Código para escribir a consola
        }

        void WriteToFile(Activity activity)
        {
            // Código para escribir a archivo
        }
    }
}