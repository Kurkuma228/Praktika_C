using metodichka;
using System.Security.AccessControl;

namespace ИзМетодички.classes
{
    internal class BankAccount
    {
        ulong AccountNumber;
        static ulong UniqueAccountNumber;
        decimal Balance;
        AccountType AccType;

        public BankAccount(ulong accountNumber, decimal balance, AccountType accountType)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            AccType = accountType;
        }

        public ulong accountNumber
        {
            get { return AccountNumber; }
            set { AccountNumber = value; }
        }

        public AccountType accountType
        {
            get { return  AccType; }
            set { AccType = value; }
        }
        public void GenAccountNumber()
        {
            AccountNumber = UniqueAccountNumber + 1;
        }
        public void Deposit(decimal cash)
        {
            Balance += cash;
        }
        public void Withdraw(decimal cash)
        {
            if (cash < Balance)
            {
                Balance -= cash;
            }
            else
            {
                Console.WriteLine("На счете недостаточно средств");
            }
        }
        public void PrintAccBank()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}\nБаланс счета: {Balance}\nТип счета: {AccType}");
        }

        public void Transfer(BankAccount target, decimal amount)
        {
            if (amount <= target.Balance)
            {
                Withdraw(amount);
                target.Deposit(amount);
                Console.WriteLine($"Перевод выполнен. Баланс вашего счета: {Balance}");
            }
            else
            {
                Console.WriteLine("На счете недостаточно средств для совершения перевода");
            }
        }
    }
}
