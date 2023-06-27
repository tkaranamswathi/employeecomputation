namespace UC11MANAGEEMPWAGE
{

    public interface IEmpWageManager
    {
        void AddEmployee(string companyName, string employeeName, decimal wage);
        decimal CalculateTotalWage(string companyName);
    }


    public class EmpWageManager : IEmpWageManager
    {
        private Dictionary<string, Dictionary<string, decimal>> companyEmployees;

        public EmpWageManager()
        {
            companyEmployees = new Dictionary<string, Dictionary<string, decimal>>();
        }

        public void AddEmployee(string companyName, string employeeName, decimal wage)
        {
            if (!companyEmployees.ContainsKey(companyName))
            {
                companyEmployees[companyName] = new Dictionary<string, decimal>();
            }

            companyEmployees[companyName][employeeName] = wage;
        }

        public decimal CalculateTotalWage(string companyName)
        {
            if (!companyEmployees.ContainsKey(companyName))
            {
                throw new ArgumentException("Company not found.");
            }

            decimal totalWage = 0;
            foreach (var wage in companyEmployees[companyName].Values)
            {
                totalWage += wage;
            }

            return totalWage;
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            IEmpWageManager empWageManager = new EmpWageManager();

            empWageManager.AddEmployee("Company A", "John Doe", 2000);
            empWageManager.AddEmployee("Company A", "Jane Smith", 2200);
            empWageManager.AddEmployee("Company B", "Mike Johnson", 1800);
            empWageManager.AddEmployee("Company B", "Lisa Brown", 2500);


            decimal totalWageCompanyA = empWageManager.CalculateTotalWage("Company A");
            Console.WriteLine("Total wage for Company A: " + totalWageCompanyA);


            decimal totalWageCompanyB = empWageManager.CalculateTotalWage("Company B");
            Console.WriteLine("Total wage for Company B: " + totalWageCompanyB);
        }
    }
}

