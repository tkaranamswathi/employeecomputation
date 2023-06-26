namespace UC9SAVETOTALWAGE
{
 
    class program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart",20,2,10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance",10,4,20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(dMart.ToString());
        }
    }
}


    
