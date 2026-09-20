namespace Depi_Session06
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public SecurityLevel SecurityLevel { get; set; }

        public decimal Salary { get; set; }

        public HiringDate HireDate { get; set; }

        public Gender Gender { get; set; }

        public Employee()
        {
            ID = 0;
            Name = "Unknown";
            SecurityLevel = SecurityLevel.Guest;
            Salary = 0;
            HireDate = new HiringDate();
            Gender = Gender.M;
        }

        public Employee(
            int id,
            string name,
            SecurityLevel securityLevel,
            decimal salary,
            HiringDate hireDate,
            Gender gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {ID}\n" +
                   $"Name: {Name}\n" +
                   $"Security Level: {SecurityLevel}\n" +
                   $"Salary: {string.Format("{0:C}", Salary)}\n" +
                   $"Hire Date: {HireDate}\n" +
                   $"Gender: {Gender}";
        }
    }
}
