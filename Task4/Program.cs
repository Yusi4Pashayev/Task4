namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Daxil edilən rəqəmə uyğun ingiliscə mənası çap olunsun(1 - one,2 - two..)


            while (true)
            {
                Console.WriteLine("Bir reqem daxil edin:");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    default:
                        Console.WriteLine("idk");
                        break;
                }

            }
        }
    }
}