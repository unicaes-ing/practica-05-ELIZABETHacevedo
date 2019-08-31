using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Double descuento;

            fecha();

            eje2(ent());
            
            Console.WriteLine("el factorial es {0}",eje3(ent()));
            eje5(ent("numero telefonico:"), ent("numero telefonico:"), ent("numero telefonico:"), ent("numero telefonico:"));
            descuento = ent("ingrese descuento -1 si no lo hay(datos enteros)");
            if (descuento != -1)
            {
                Console.WriteLine(   eje55(descuento));
            }
            else
            {
                Console.WriteLine( eje55());
            }
            Console.ReadKey();
        }



        static void fecha()
        { 
            DateTime ff = new DateTime();
           string v = "31/12/2019";
            ff = DateTime.Parse(v);
            Console.WriteLine(ff);
           
            Console.WriteLine(Math.Truncate((ff-(DateTime.Now)).TotalDays));
          
            
         
            
           // Console.WriteLine(DateTime.Compare(ff,DateTime.Now));
        }



        static void eje2(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine("es positivo");
            } else if(num1<0){
                Console.WriteLine("es negativo");
            }
            else
            {
                Console.WriteLine("es cero");
            }
        }

        static int ent(string str="ingrese un entero")
        {
            int num ;
            
            do
            {
                Console.WriteLine(str);
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    return num;
                }
            } while (true);
        }



        static int eje3(int num)
        {
            int a = num;
            for (int i = 1; i < a; i++)
            {
                num = num * i;
            }
            return num;
        }



        static void eje5(int num,int num2,int num3,int num4)
        {
            int algo;
            Random r = new Random();
            algo = r.Next(1,5);
            switch (algo)
            {
                case 1:
                    Console.WriteLine("felicidades numero: {0} usted ha ganado",num);
                    break;
                case 2:
                    Console.WriteLine("felicidades numero: {0} usted ha ganado",num2);
                    break;
                case 3:
                    Console.WriteLine("felicidades numero: {0} usted ha ganado",num3);
                    break;
                default:
                    Console.WriteLine("felicidades numero: {0} usted ha ganado",num4);
                    break;
                    break;
            }


        }


        static double eje55(double descuento=0){
            double precio=0,des;
            precio = pedirDecimal(precio,"ingrese el precio a pagar:") ;
            des = precio * (descuento*0.01);
            precio = precio - des;
            return precio;
        }

        static double pedirDecimal(double num, string a= "ingrese un numero")
        {
            do
            {
                Console.WriteLine(a);
                if (double.TryParse(Console.ReadLine(),out num))
                {
                    return num;
                }
            } while (true);
        }



    }
}
