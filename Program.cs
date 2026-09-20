using System;

namespace Depi_Session06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(
                1,
                "Ahmed",
                SecurityLevel.DBA,
                25000,
                new HiringDate(10, 5, 2024),
                Gender.M
            );

            EmpArr[1] = new Employee(
                2,
                "Sara",
                SecurityLevel.Guest,
                12000,
                new HiringDate(15, 8, 2025),
                Gender.F
            );

            EmpArr[2] = new Employee(
                3,
                "Mohamed",
                SecurityLevel.DBA,
                30000,
                new HiringDate(20, 1, 2023),
                Gender.M
            );

            foreach (Employee employee in EmpArr)
            {
                Console.WriteLine(employee);
                Console.WriteLine("----------------------------");
            }

            Console.ReadKey();
        }
    }
}
