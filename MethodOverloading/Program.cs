namespace MethodOverloading
{
    class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isTrue)
        {
            var sum = Add(a, b);
            var response = "";

            if (isTrue)
            {
                sum = a + b;

                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            
            }

            return response;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine();
            Console.WriteLine(Add(5, 7,true));  
            Console.WriteLine();
            Console.WriteLine(Add(-6, 3, true));

        }
    }
}

