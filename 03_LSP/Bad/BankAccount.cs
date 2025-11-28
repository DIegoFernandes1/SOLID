namespace SOLID._03_LSP.Bad
{
    /*É UMA MÁ PRÁTICA POIS A CLASSE DERIVADA (SavingsAccount) NÃO PODE SER USADA NO LUGAR DA CLASSE BASE (BankAccount) 
    * SEM CAUSAR ERROS. ISSO VIOLA O PRINCÍPIO DA SUBSTITUIÇÃO DE LISKOV, POIS UM OBJETO DE SavingsAccount 
    * PODE GERAR UMA EXCEÇÃO QUE NÃO EXISTE NA IMPLEMENTAÇÃO DA CLASSE BASE BankAccount.*/

    public class BankAccount
    {
        public virtual void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrawing {amount} from bank account.");
        }
    }

    public class SavingsAccount : BankAccount
    {
        public decimal Balance { get; set; }
        public override void Withdraw(decimal amount)
        {
            if (Balance < amount)
                throw new InvalidOperationException("Insufficient funds in savings account.");

            Balance -= amount;
            Console.WriteLine($"Withdrawing {amount} from savings account. New balance: {Balance}");
        }
    }
}