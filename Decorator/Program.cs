using System;
using Decorator.Interfaces;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            ICarro carro = new Carro();

            // Decorator  com 1 items      
            ICarro airbagDecorator = new AirbagDecorator(carro);
            ICarro arDecorator = new ArDecorator(carro);
            ICarro insulfilmDecorator = new InsulfilmDecorator(carro);
            ICarro mp3Decorator = new Mp3Decorator(carro);
            ICarro xenonDecorator = new XenonDecorator(carro);
            //Decorator com 2  items
            ICarro airbagArDecorator = new ArDecorator(airbagDecorator);
            ICarro insulfilmXenonDecorator = new XenonDecorator(insulfilmDecorator);

            //Decorator com 3  items
            ICarro xenonInsulfilmMp3Decorator = new Mp3Decorator(insulfilmXenonDecorator);


            //decorator com 5 items 
            ICarro todosairbagDecorator = new AirbagDecorator(xenonInsulfilmMp3Decorator);
            ICarro todosDecorator = new ArDecorator(todosairbagDecorator);
           
            string opc;
            do
            {
                
            Console.WriteLine("\n\t\t\t\t\t_____________________________________________________");
            Console.WriteLine("\t\t\t\t\t|+++++++++++++++++++| Opcionais |++++++++++++++++++++|");
            Console.WriteLine("\t\t\t\t\t|1| - AIRBAG                                         |");
            Console.WriteLine("\t\t\t\t\t|2| - AR CONDICIONADO AUTOMOTIVO                     |");
            Console.WriteLine("\t\t\t\t\t|3| - INSULFILM                                      |");
            Console.WriteLine("\t\t\t\t\t|4| - RADIO MP3 PLAYER                               |");
            Console.WriteLine("\t\t\t\t\t|5| - FAROL DE XENON                                 |");
            Console.WriteLine("\t\t\t\t\t|6| - AIRBAG E AR CONDICIONADO AUTOMOTIVO            |");
            Console.WriteLine("\t\t\t\t\t|7| - INSULFILM  E FAROL DE XENON                    |");
            Console.WriteLine("\t\t\t\t\t|8| - FAROL DE XENON , INSULFILM  E  RADIO MP3 PLAYER|");
            Console.WriteLine("\t\t\t\t\t|9| - COM TODOS OS OPCIONAIS                         |");
            Console.WriteLine("\t\t\t\t\t|10| - SEM OPCIONAIS                                 |");
            Console.Write("\t\t\t\t\t|____________________________________________________|\n" +
                          "\t\t\t\t\t|Opção: ");
            opc = Console.ReadLine();


              

                    switch (opc)
                    {
                        case "1": 
                            Console.Clear();
                            Console.WriteLine(airbagDecorator.TipoCarro());
                            Console.ReadKey();
                            break;
                        case "2":
                        Console.Clear();
                        Console.WriteLine(arDecorator.TipoCarro());
                        Console.ReadKey();
                        break;
                        case "3":
                        Console.Clear();
                        Console.WriteLine(insulfilmDecorator.TipoCarro());
                        Console.ReadKey();
                        break;
                        case "4":
                        Console.Clear();
                        Console.WriteLine(mp3Decorator.TipoCarro());
                        Console.ReadKey();
                        break;
                        case "5":
                        Console.Clear();
                        Console.WriteLine(xenonDecorator.TipoCarro());
                        Console.ReadKey();
                        break;
                        case "6":
                        Console.Clear();
                        Console.WriteLine(airbagArDecorator.TipoCarro());
                        Console.ReadKey();
                        break;
                        case "7":
                        Console.Clear();
                        Console.WriteLine(insulfilmXenonDecorator.TipoCarro());
                        Console.ReadKey();
                        break;
                        case "8":
                        Console.Clear();
                        Console.WriteLine(xenonInsulfilmMp3Decorator.TipoCarro());
                        Console.ReadKey();
                        break;
                        case "9":
                        Console.Clear();
                        Console.WriteLine(todosDecorator.TipoCarro());
                        Console.ReadKey();
                        break;
                    case "10":
                        Console.Clear();
                        Console.WriteLine(carro.TipoCarro());
                        Console.ReadKey();
                        break;
                    default:
                            Console.WriteLine("Opção invalida!");
                            break;
                    }

                    Console.Clear();
                } while (opc != "0");
            }
      
           
        
    }
}
