using System;

namespace metod_1
{
    class Program
    {
        

            static string Entername() 
            {
            int temp = 0;
            string name1 = Console.ReadLine();

                while (name1.Trim().Length == 0)
                {
                    name1 = Console.ReadLine();
                }

                for (; ; )
            {
                if (Int32.TryParse(name1,out temp))
                {
                    Console.WriteLine("Введено неправильное имя, введите ещё раз");
                    name1 = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
                return name1;
               

            }

        static int Enterage()
        {
            int temp;
            string age =Console.ReadLine();
            for (; ; )
            {
                if (Int32.TryParse(age, out temp) && temp >= 0 && temp < 130)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"введите правильный возраст  ");
                    age=Console.ReadLine();
                }

            }
            return temp;
        }

        static void Result(string username1, string username2, int age1, int age2)
        {
            Console.WriteLine($"человек с каким именем старше? {username1} или {username2}");

            string older;
            
            for (; ; )
            {
                older = Console.ReadLine();
                if (older == username1 && age1 > age2)
                {

                    Console.WriteLine($" Правильно, {username1} старше на {age1 - age2} года");
                }

                else if (older == username1 && age1 < age2)
                {


                    Console.WriteLine($" Не правильно, {username1} младше на {age2 - age1} года");
                }

                else if (older == username2 && age1 < age2)
                {

                    Console.WriteLine($"Правильно, {username2} старше на {age2 - age1} года");
                }

                else if (older == username2 && age1 > age2)
                {

                    Console.WriteLine($" Не правильно, {username2} младше на {age1 - age2} года");

                }

                else if (age1 == age2)
                {
                    Console.WriteLine($"{username1} и {username2} ровестники");

                }
                else
                {
                    Console.WriteLine("Введено неправильное имя, введите корректное имя");
                    continue;
                }
            }
            Console.ReadKey();
        }
        
            
            
            static void Main(string[] args)
            {
                Console.WriteLine("введите первое имя");
                string username1 =Entername();
                Console.WriteLine($"имя первого человека: {username1} ");
                Console.WriteLine($" какой возраст у {username1} ?");
                int age1 = Enterage();
                Console.WriteLine($"{username1} , {age1} года(лет)");
                


                Console.WriteLine("Теперь введите второе имя:");
                string username2 =Entername();
                Console.WriteLine($" второго человека зовут {username2} ");
                Console.WriteLine($" введите возраст {username2} ");
                int age2 = Enterage();
                    Console.WriteLine($"{username2} , {age2} года(лет)");

            Result(username1, username2, age1, age2);



            }
        
    }
}