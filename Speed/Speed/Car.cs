using System;
namespace Speed
{
    public class Car
    {
        int speed = 0;
        Random random = new Random();
        int sum = 0;
        int sredspeed;
        int time = 0;
        int timetoend;
        int mtosec;
        int s;
        int i;
        public Car(String name, int distance)
        {
            s = distance;
            Thread thread = new Thread(new ThreadStart(Speed));
            thread.Start();
            Distance();
        }
        public void Distance()
        {
            for (i = s * 1000; i > 0; i = i - mtosec)
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
                Console.WriteLine("Средняя скорость: " + sredspeed + " км/ч");
                Console.WriteLine("Скорость: " + speed + " км/ч");
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
            Console.WriteLine("Вы приехали");
            Console.ReadLine();
        }
        public void Speed()
        {
            for (i = s * 1000; i > 0; i = i - mtosec)
            {
                mtosec = (int)(speed / 3.6);
                timetoend = (int)(i / (sredspeed / 3.6));
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

