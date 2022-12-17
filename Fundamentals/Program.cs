namespace Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Equality pro různé typy
            //var emp1 = new Employee
            //{
            //    Name = "Pepa"
            //};
            //var emp2 = new Employee
            //{
            //    Name = "Pepa"
            //};
            //Console.WriteLine($"emp1 = emp2: {emp1.Equals(emp2)}");

            //var emp1rec = new EmployeeRecord("Pepa");
            //var emp2rec = new EmployeeRecord("Pepa");

            //Console.WriteLine($"emp1rec = emp2rec: {emp1rec.Equals(emp2rec)}");

            //Property accessors
            //var emp = new Employee(salary: 50000)
            //{
            //    Age = 30
            //};

            //emp.Name = "Test";

            //Constructor chain
            //var manager = new Manager(20)
            //{
            //    Age = 10
            //};

            //Console.WriteLine(manager.Age);

            var publicC = new PublicC();
            var internalC = new InternalC();
        }
    }
}