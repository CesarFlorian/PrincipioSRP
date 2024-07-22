using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrincipioSRP
{
    public class ImprimirCorreo : EnviarCorreo
    {

       public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre:{nombre}");
            Console.WriteLine($"Nombre:{edad}");
            Console.WriteLine($"Nombre:{direccion}");
            Console.WriteLine($"Nombre:{correo}");
        }
    }
}
