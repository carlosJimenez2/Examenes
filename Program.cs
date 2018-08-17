using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            double Numero1 = 0;
            string Numero1String = "";
            double Numero2 = 0;
            string Numero2String = "";


            Console.WriteLine("Introduce el primer numero");
            Numero1String = Console.ReadLine();
            Numero1 = Convert.ToDouble(Numero1String);

            Console.WriteLine("Introduce el segundo numero");
            Numero2String = Console.ReadLine();
            Numero2 = Convert.ToDouble(Numero2String);

            Suma s = new Suma();
            s.setNumero1(Numero1);
            s.setNumero2(Numero2);

            Console.WriteLine("La suma es = {0}", s.getSuma());
            

            Divicion d = new Divicion();
            d.setNumero1(Numero1);
            d.setNumero2(Numero2);

            Console.WriteLine("La divicion es = {0}", d.getDivicion());
            Console.ReadKey();

        }
    }
}
