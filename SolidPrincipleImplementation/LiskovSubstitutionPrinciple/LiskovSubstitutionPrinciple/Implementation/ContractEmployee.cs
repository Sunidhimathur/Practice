using LiskovSubstitutionPrinciple.Interface;

namespace LiskovSubstitutionPrinciple.Implementation
{
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public ContractEmployee()
        { }

        public ContractEmployee(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", ID, Name);
        }
    }
}
