namespace SOLID._04_ISP.Good
{
    /* NESSE CASO ESTAMOS SEGREGANDO AS INTERFACES, ASSIM CADA CLASSE IMPLEMENTA APENAS O QUE É RELEVANTE PARA ELA.*/
    public interface ICalculateSalary
    {
        void CalculateSalary();
    }

    public interface ICalculateBenefits
    {
        void CalculateBenefits();
    }

    public class FullTimeEmployee : ICalculateSalary, ICalculateBenefits
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Calculating salary for full-time employee");
        }
        public void CalculateBenefits()
        {
            Console.WriteLine("Calculating benefits for full-time employee");
        }
    }

    public class ContractEmployee : ICalculateSalary
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Calculating salary for contract employee");
        }
    }
}
