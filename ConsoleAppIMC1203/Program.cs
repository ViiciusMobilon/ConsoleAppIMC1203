using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIMC1203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso");
            int ps = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu Sua altura ideal");
            double Al = double.Parse(Console.ReadLine());

            double imc =  ps/(Al * Al) ;


            if (imc <= 16.9)
            {
                Console.WriteLine("você é muito abaixo do peso e seu IMC é:" + imc);
                Console.ReadKey();
            }

            if (imc <= 18.4)
            {
                Console.WriteLine("você é abaixo do peso e seu IMC é:" + imc);
                Console.ReadKey();
            }

            else if (imc <= 24.9)
            {
                Console.WriteLine("você é Nomal e seu IMC é:" + imc);
                Console.ReadKey();
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("você é obesidade I e seu IMC é:"+ imc);
                Console.ReadKey();
            }
            else if (imc <= 39.9)
            {
                Console.WriteLine("você tem obesidadade II e sue IMC é:"+ imc);
                Console.ReadKey();
            }
            else if (imc <= 40)
            {

                Console.WriteLine("Você tem obesidade III e seu IMC é:"+ imc);
                Console.ReadKey();
            }
            else 
            { Console.WriteLine("^Você digitou uma informaçâo errada" );
                Console.ReadKey();
             }

        }




    }
}

