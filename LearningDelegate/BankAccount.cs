namespace LearningDelegate
{
    public class BankAccount
    {
        public delegate void BankAccountDel(string message);
        public BankAccountDel? BankAccountHandler;
        public decimal Remiander { get; set; }

        public string? Name { get; set; }

        public BankAccount(string? name)
        {
            Name = name;

            Remiander = 0;
        }
        public void RegisterDelegate(BankAccountDel del)
        {
            BankAccountHandler = del;
        }

        public void TopUpAccount(decimal amount)
        {
            Remiander += amount;

            BankAccountHandler?.Invoke($"Счет {this.Name} пополнен на {amount}$");
            CurrentRemiander();
        }

        public void Withdraw(decimal amount)
        {
            if (Remiander > amount)
                Remiander -= amount;

            BankAccountHandler?.Invoke($"Со счета {this.Name} снято {amount}$");
            CurrentRemiander();
        }

        private void CurrentRemiander()
        {
            BankAccountHandler?.Invoke($"Остаток по счету {this.Name}: {this.Remiander}$");
        }
    }
}
