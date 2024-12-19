using metodichka;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
namespace ИзМетодички.classes
{
    internal class BankAccount
    {
        static Guid accountNumber;
        decimal balance;
        AccountType accType;
        Queue<BankTransaction> queue;

        public BankAccount(decimal balance)
        {
            this.balance = balance;
            accountNumber = GenAccountNumber();
            queue = new Queue<BankTransaction>();
        }
        public BankAccount(AccountType accountType)
        {
            accType = accountType;
            accountNumber = GenAccountNumber();
            queue = new Queue<BankTransaction>();
        }
        public BankAccount(decimal balance, AccountType accountType)
        {
            this.balance = balance;
            accType = accountType;
            accountNumber = GenAccountNumber();
            queue = new Queue<BankTransaction>();
        }
        public AccountType accountType
        {
            get { return accType; }
            set { accType = accountType; }
        }
        public Guid GenAccountNumber()
        {
            return Guid.NewGuid();
        }
        public void Deposit(decimal cash)
        {
            if (cash >= 0)
            {
                balance += cash;
                BankTransaction unitQueue = new BankTransaction(cash);
                queue.Enqueue(unitQueue);
            }
            else
            {
                Console.WriteLine("Нельзя внести отрицательное кол-во денег");
            }
        }
        public void Withdraw(decimal cash)
        {
            if (cash < balance)
            {
                if (cash > 0)
                {
                    balance -= cash;
                    BankTransaction unitQueue = new BankTransaction(cash);
                    queue.Enqueue(unitQueue);
                }
                else
                {
                    Console.WriteLine("Нельзя снять отрицательное кол-во денег");
                }
            }
            else
            {
                Console.WriteLine("На счете недостаточно средств");
            }
        }
        public void PrintAccBank()
        {
            Console.WriteLine($"Номер счета: {accountNumber}\nБаланс счета: {balance}\nТип счета: {accType}");
        }

        public void Transfer(BankAccount target, decimal amount)
        {
            if (amount > 0)
            {
                if (amount <= target.balance)
                {
                    Withdraw(amount);
                    target.Deposit(amount);
                    Console.WriteLine($"Перевод выполнен. Баланс вашего счета: {balance}");
                }
                else
                {
                    Console.WriteLine("На счете недостаточно средств для совершения перевода");
                }
            }
            else
            {
                Console.WriteLine("Нельзя перевести отрицательное кол-во денег");
            }
        }
        public void Dispose()
        {
            foreach (BankTransaction t in queue)
            {
                File.AppendAllText(@"..\..\..\files\Transactions.txt", $"Сумма: {t.GetAmount()}. Дата и время: {t.GetDateTime()}\n");
            }
            GC.SuppressFinalize(queue);
        }
        public void PrintFileQueue()
        {
            string textQueue = File.ReadAllText(@"..\..\..\files\Transactions.txt");
            Console.WriteLine(textQueue);
        }
    }
}
