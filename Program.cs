namespace UC1ATTENDANCE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            Console.WriteLine("welcome to employeewagecompute");
            Random random = new Random();
            int randomInput = random.Next(0, 2);// 0 or 1
            if (IS_PRESENT == randomInput)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");

            }
        }
    }
}
        }
    }
}