namespace SOLID._03_LSP.Good
{
    /*NESSE CASO AS CLASSES DERIVADAS NÃO ESTÃO COMPROMETENDO O COPORTAMENTO DA CLASSE BASE POIS,
     * A CLASSE BASE NÃO TEM IMPLEMENTAÇÃO DE Withdraw, APENAS A ASSINATURA DO MÉTODO.*/

    public abstract class BankAccount
    {
        public double Balance { get; protected set; }
        public abstract double Withdraw(double amount);
    }

    public class SavingsAccount : BankAccount
    {
        public override double Withdraw(double amount)
        {
            if (amount <= Balance)
                Balance -= amount;

            return amount;
        }
    }

    public class CheckingAccount : BankAccount
    {
        public override double Withdraw(double amount)
        {
            //IMPLEMENTAÇÃO
            throw new NotImplementedException();
        }
    }
}
