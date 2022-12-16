namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber, secondnumber;
            Console.WriteLine("Enter starting number of range");
            firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number of range");
            secondnumber = int.Parse(Console.ReadLine());
            int sum = 0, n, i;
            Console.WriteLine("the perfect numbers between {0} and {1} is ", firstnumber, secondnumber);
            for (n = firstnumber; n < secondnumber; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0} ", n);
            }
        }
    }
}