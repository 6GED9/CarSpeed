namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название машины и дистанцию: ");
            Car car = new Car(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
    }
}
