using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre;
            int[] numeroCuenta;
            double[] saldoApertura;
            int aux;
            double saldo;
            nombre = new string[3];
            numeroCuenta = new int[3];
            saldoApertura = new double[3];
            char op;
            int s1;

            do
            {

                Console.Clear();
                Console.WriteLine("\n---------ELIGA UNA OPCION--------");
                Console.WriteLine("1. REGISTRAR USUARIO");
                Console.WriteLine("2. CONSIGNAR A CUENTA BANCARIA");
                Console.WriteLine("3. RETIRAR DE CUENTA BANCARIA");
                Console.WriteLine("4. CONSULTAR CUENTA BANCARIA");
                Console.WriteLine("5. SALIR");
                Console.WriteLine("--------------MENU---------------");

                s1 = int.Parse(Console.ReadLine());

                switch (s1)
                {
                    case 1:
                        Console.Clear();
                        op = 'N';
                        do
                        {
                            int f = 0;
                            Console.WriteLine("BIENVENIDO");
                            Console.WriteLine("DIGITE EL NOMBRE DEL USUARIO:");
                            nombre[f] = Console.ReadLine();

                            Console.WriteLine("\nDIGITE EL NUMERO DE CUENTA:");
                            string linea;
                            linea = Console.ReadLine();
                            numeroCuenta[f] = int.Parse(linea);

                            Console.WriteLine("\nDIGITE EL SALDO DE APERTURA:");
                            string linea1;
                            linea1 = Console.ReadLine();
                            saldoApertura[f] = double.Parse(linea1);
                            f = f + 1;

                            Console.WriteLine("\nDESEA REGISTRAR OTRO USUARIO?");
                            op = char.Parse(Console.ReadLine());

                        } while (op == 'S');



                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("DIGITE EL NUMERO DE CUENTA:");
                        aux = int.Parse(Console.ReadLine());

                        for (int f = 0; f < numeroCuenta.Length; f++)
                        {

                            if (aux == numeroCuenta[f])
                            {
                                Console.WriteLine("CUENTA ENCONTRADA...");
                                Console.WriteLine("\nNumero cuenta: " + numeroCuenta[f]);
                                Console.Write("\nNombre: " + nombre[f]);
                                Console.Write("\nSaldo: " + saldoApertura[f]);
                                Console.WriteLine("\nDIGITE LA CANTIDAD DE DINERO QUE DESEA DEPOSITAR");
                                saldo = double.Parse(Console.ReadLine());

                                saldoApertura[f] = saldoApertura[f] + saldo;

                                Console.WriteLine("\nEL NUEVO SALDO ES DE: ");
                                Console.Write(saldoApertura[f]);
                                op = 'S';
                            }
                            else if (f == 19)
                            {
                                Console.WriteLine("No se encontre la cuenta digitada");
                            }
                        }

                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("DIGITE EL NUMERO DE CUENTA:");
                        aux = int.Parse(Console.ReadLine());

                        for (int f = 0; f < numeroCuenta.Length; f++)
                        {

                            if (aux == numeroCuenta[f])
                            {
                                Console.WriteLine("CUENTA ENCONTRADA...");
                                Console.WriteLine("\nNumero cuenta: " + numeroCuenta[f]);
                                Console.Write("\nNombre: " + nombre[f]);
                                Console.Write("\nSaldo: " + saldoApertura[f]);
                                Console.WriteLine("\nDIGITE LA CANTIDAD DE DINERO QUE DESEA RETIRAR");
                                saldo = double.Parse(Console.ReadLine());

                                saldoApertura[f] = saldoApertura[f] - saldo;

                                Console.WriteLine("\nEL NUEVO SALDO ES DE: ");
                                Console.Write(saldoApertura[f]);
                                op = 'S';
                            }
                            else if (f == 19)
                            {
                                Console.WriteLine("No se encontre la cuenta digitada");
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("DIGITE EL NUMERO DE CUENTA:");
                        aux = int.Parse(Console.ReadLine());

                        for (int f = 0; f < numeroCuenta.Length; f++)
                        {

                            if (aux == numeroCuenta[f])
                            {
                                Console.WriteLine("CUENTA ENCONTRADA...");

                                Console.WriteLine("\nNumero cuenta: " + numeroCuenta[f]);
                                Console.Write("\nNombre: " + nombre[f]);
                                Console.Write("\nSaldo: " + saldoApertura[f]);

                                op = 'S';
                            }
                            else if (f == 19)
                            {
                                Console.WriteLine("No se encontre la cuenta digitada");
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 5:

                        break;

                    default:
                        Console.WriteLine("OPCION INVALIDA");
                        break;

                }

            } while (s1 != 5);

        }
    }
}
