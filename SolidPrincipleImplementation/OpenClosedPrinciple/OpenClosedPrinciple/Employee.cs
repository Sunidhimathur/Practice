namespace OpenClosedPrinciple
{
    // Code before Open Closed Principle:

    /*public class Employee
    {
        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }
        public Employee() 
        { 
        }
        public Employee(int id, string name, string employeetype)
        {
            ID = id;
            Name = name;
            EmployeeType = employeetype;
        }

        public decimal CalculateBonus(decimal salary)
        {
            if (EmployeeType == "Permanent")
                return salary * .1M;
            else
                return salary * .05M;
        }

        public override string ToString()
        {
            return string.Format("ID: {0} Name: {1}", ID, Name);
        }
    }*/


    // <-------------------------------------------------------------------> //


    // Code after Open Closed Principle Implementation:

    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee()
        {
        }
        public Employee(int id, string name)
        {
            ID = id; Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID: {0} Name: {1}", ID, Name);
        }
    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        { }

        public TemporaryEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}