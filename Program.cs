namespace UC6TOTALWORKINGHOURS
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        static void Main(string[] args)
        {
            int emphrs = 0;
            int totalemphrs = 0;
            int totalworkingdays = 0;
            while (totalemphrs <= MAX_HRS_IN_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                {
                    totalworkingdays++;
                    Random rnd = new Random();
                    int empcheck = rnd.Next(0, 3);
                    switch (empcheck)
                    {
                        case IS_PART_TIME:
                            emphrs = 4;
                            break;
                        case IS_FULL_TIME:
                            emphrs = 8;
                            break;
                        default:
                            emphrs = 0;
                            break;
                    }
                    totalemphrs += emphrs;
                    Console.WriteLine("day#:" + totalworkingdays + "emp hrs" + emphrs);
                }
                int totalempwage = totalemphrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("total emp wage : " + totalempwage);
            }
        }
    }
}


