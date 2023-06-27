namespace UC12ARRAYLIST
{
   using System;
using System.Collections;

public class Company
{
    public string Name { get; set; }
    public ArrayList EmployeeWages { get; set; }

    public Company(string name)
    {
        Name = name;
        EmployeeWages = new ArrayList();
    }

    public void AddEmployeeWage(double wage)
    {
        EmployeeWages.Add(wage);
    }

    public void DisplayEmployeeWages()
    {
        Console.WriteLine($"Employee wages for {Name}:");
        foreach (var wage in EmployeeWages)
        {
            Console.WriteLine(wage);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create companies
        Company company1 = new Company("Company 1");
        Company company2 = new Company("Company 2");

        // Add employee wages
        company1.AddEmployeeWage(1000);
        company1.AddEmployeeWage(1500);

        company2.AddEmployeeWage(2000);
        company2.AddEmployeeWage(2500);

        // Display employee wages
        company1.DisplayEmployeeWages();
        company2.DisplayEmployeeWages();
    }
}

}