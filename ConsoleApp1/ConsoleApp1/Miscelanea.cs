using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intemto
{
    public class Miscelanea
    {
        public static void Main()
        {
            double numero1 = 0.0;
            double numero2 = 0.0;
            double numero3 = 0.0;
            double numero4 = 0.0;

            Menus.MenuPrincipal();
            String Opciones = null;
            Opciones = Console.ReadLine().ToString();
            Console.Clear();

            switch (Opciones)
            {
                case "1":

                    Menus.MenuOperadores();
                    String s1 = null;
                    s1 = Console.ReadLine().ToString();
                    Console.Clear();

                    Ejercicios operadores = new Ejercicios();
                    switch (s1)
                    {
                        case "1":
                            operadores.AreaTriangulo(numero1, numero2);
                            break;

                        case "2":
                            operadores.SumaNumeros(numero1, numero2);
                            break;

                        case "3":
                            operadores.ElevadoCuadrado(numero1);
                            break;

                        case "4":
                            operadores.ConvertidorEuro(numero1);
                            break;

                        case "5":
                            operadores.PerimetroCuadrado(numero1);
                            break;

                        case "6":
                            operadores.VolumenCilindro(numero1, numero2);
                            break;

                        case "7":
                            operadores.RadioCircunferencia(numero1);
                            break;

                        case "8":
                            operadores.PromedioNumeros(numero1, numero2, numero3);
                            break;
                    }
                    break;


                case "2":

                    Menus.MenuCondicionales();
                    String s2 = null;
                    s2 = Console.ReadLine().ToString();
                    Console.Clear();


                    Ejercicios condicionales = new Ejercicios();
                    switch (s2)
                    {
                        case "1":
                            condicionales.NumeroNP(numero1);
                            break;

                        case "2":
                            condicionales.NumeroMayor(numero1, numero2, numero3);
                            break;

                        case "3":
                            condicionales.NumeroMayoroMenor(numero1, numero2, numero3);
                            break;

                        case "4":
                            condicionales.SumaResta(numero1, numero2);

                            break;

                        case "5":
                            condicionales.CocienteDosNumeors(numero1, numero2);
                            break;

                        case "6":
                            condicionales.MultioSuma(numero1, numero2);
                            break;

                        case "7":
                            condicionales.AñoBisiesto(numero1);
                            break;
                    }
                    break;

                case "3":

                    Menus.MenuCiclos();
                    String s3 = null;
                    s3 = Console.ReadLine().ToString();
                    Console.Clear();

                    Ejercicios ciclos = new Ejercicios();
                    switch (s3)
                    {
                        case "1":
                            ciclos.MultiplosTres(numero1);
                            break;

                        case "2":
                            ciclos.NumerosImpares(numero1);
                            break;

                        case "3":
                            ciclos.NumerosPares(numero1);
                            break;

                        case "4":
                            ciclos.NumeroCuadrado(numero1);
                            break;

                        case "5":
                            ciclos.SumaCien(numero1);
                            break;

                        case "6":
                            ciclos.NumerosComprendidos(numero1, numero2, numero3);
                            break;

                        case "7":
                            ciclos.SumaDigitos(numero1);
                            break;
                    }
                    break;
            }
        }
    }
}
