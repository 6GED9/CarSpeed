using System;
namespace Speed
{
    public class Car
    {
        public Car(String name)
        {
            Console.WriteLine("Название машины: " + name);
            Console.Write("Введите растояние: ");
            Run(int.Parse(Console.ReadLine()));
            Console.WriteLine("Вы приехали!");
        }
        public static void Run(int s)
        {
            int speed = 0;
            Random random = new Random();
            int sum = 0;
            int sredspeed;
            int time = 0;
            int timetoend;
            int mtosec;
            for (int i = s * 1000; i > 0; i = i - mtosec)
            {
                speed = speed + random.Next(8) + 2;
                if (speed > 100)
                {
                    speed = speed - 7;
                }
                sum += speed;
                time++;
                sredspeed = sum / time;
                mtosec = (int)(speed / 3.6);
                timetoend = (int)(i / (sredspeed/3.6));
                Console.WriteLine("Текущая скорость: " + speed + " км/ч");
                Console.WriteLine("Средняя скорость: " + sredspeed + " км/ч");
                Console.WriteLine("Осталось ехать: " + i + " м");
                Console.WriteLine("Времени до прибытия: " + timetoend + " c");
                Console.WriteLine();
                try
                {
                    Thread.Sleep(1000);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        }
}

