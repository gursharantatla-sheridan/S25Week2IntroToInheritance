namespace S25Week2IntroToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass objDerived = new DerivedClass();
            //objDerived.myPublicVar = 1;


            //BaseClass objBase = new BaseClass();
            //DerivedClass objDerived = new DerivedClass();


            CommissionEmployee commEmp = new CommissionEmployee(101, "John", 10000, 0.15);
            Console.WriteLine(commEmp);
            Console.WriteLine($"\nEarnings = {commEmp.Earnings():C}\n\n");

            SalaryPlusCommissionEmployee salCommEmp = new SalaryPlusCommissionEmployee(102, "Anne", 8000, 0.12, 500);
            Console.WriteLine(salCommEmp);
            Console.WriteLine($"\nEarnings = {salCommEmp.Earnings():C}\n\n");
        }
    }
}
