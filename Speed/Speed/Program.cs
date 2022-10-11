namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название машины: ");
            Car car = new Car(Console.ReadLine());
        }
    }
}
