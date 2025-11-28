namespace SOLID._04_ISP.Bad
{
    /* É RUIM POIS NESSE EXEMPLO ESTAMOS OBRIGANDO UMA CLASSE (ContractEmployee)
     A IMPLEMENTAR MÉTODOS QUE NÃO SÃO RELEVANTES PARA ELA. */
    public interface IEmployee
    {
        string Name { get; set; }
        void CalculateSalary();
        void CalculateBenefits();
    }

    public class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public void CalculateSalary()
        {
            Console.WriteLine("Calculating salary for full-time employee");
        }
        public void CalculateBenefits()
        {
            Console.WriteLine("Calculating benefits for full-time employee");
        }
    }

    public class ContractEmployee : IEmployee
    {
        public string Name { get; set; }
        public void CalculateSalary()
        {
            Console.WriteLine("Calculating salary for contract employee");
        }

        public void CalculateBenefits()
        {
            throw new NotImplementedException("Contract employees do not have benefits");
        }
    }
}
