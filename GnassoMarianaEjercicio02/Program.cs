using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnassoMarianaEjercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.Title = "Ejercicio02";
                    double Lado1, Lado2, Lado3;
                    Console.WriteLine("Ingresar la medida del primer lado:");
                    Lado1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresar la medida del segundo lado:");
                    Lado2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresar la medida del tercer lado:");
                    Lado3 = Convert.ToDouble(Console.ReadLine());

                    if (Lado1 > 0 && Lado2 > 0 && Lado3 > 0)
                    {
                        if (Lado1 + Lado2 > Lado3 && Lado1 + Lado2 > Lado2 && Lado2 + Lado3 > Lado1)
                        {
                            if (Lado1 == Lado2 && Lado2 == Lado3 && Lado3 == Lado1)
                            {
                                Console.WriteLine("El triangulo es Equilatero");
                            }
                            else
                            {
                                if (Lado1 != Lado2 && Lado2 != Lado3 && Lado3 != Lado1)
                                {
                                    Console.WriteLine("El triangulo es Escaleno.");
                                }
                                else
                                {
                                    if (Lado1 == Lado2 || Lado2 == Lado3 || Lado3 == Lado1)
                                    {
                                        Console.WriteLine("El triangulo es Isosceles.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Los lados ingresados no forman un triangulo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Los lados deben ser mayores a cero.");
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Los valores deben ingresarse en formato numerico.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

			Console.ReadLine();
				
		}
	}

	
  
}

