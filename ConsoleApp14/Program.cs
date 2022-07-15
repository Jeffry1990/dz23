using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любой день недели или exit чтобы завершить");

            string day = Console.ReadLine();
   
                switch (day)
                {
                    case "понедельник":
                    Console.WriteLine("Прогулка в лесу");
                    break;
                    case "вторник":
                    Console.WriteLine("Уборка дома");
                    break;
                case "среда":
                    Console.WriteLine("Изучение материала");
                    break;
                case "четверг":
                    Console.WriteLine("Просмотр фильма");
                    break;
                case "пятница":
                    Console.WriteLine("Готовим обед");
                    break;
                case "суббота":
                    Console.WriteLine("Поездка на дачу");
                    break;
                case "воскресенье":
                    Console.WriteLine("Идем в гости");
                    break;
                case "exit":
                        Console.WriteLine("Выход из программы");
                    break;
                default:
                        Console.WriteLine("Я такого дня недели не знаю");
                        break;
                }
        }
        }
    }
    

