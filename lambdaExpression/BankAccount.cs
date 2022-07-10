namespace lambdaExpression
{
    public class BankAccount
    {
        public delegate void BankAccountDel(string message);
        public event BankAccountDel? Notify;
        public decimal Remiander { get; set; }

        public string? Name { get; set; }

        public BankAccount(string? name)
        {
            Name = name;

            Remiander = 0;
        }

        public void TopUpAccount(decimal amount)
        {
            Remiander += amount;

            Notify?.Invoke($"Счет {this.Name} пополнен на {amount}$");
            CurrentRemiander();
        }

        public void Withdraw(decimal amount)
        {
            if (Remiander > amount)
            {
                Remiander -= amount;
                Notify?.Invoke($"Со счета {this.Name} снято {amount}$");
            }
            else
            {
                Notify?.Invoke($"Недостаточно средств на счету");
                CurrentRemiander();
            }


        }

        private void CurrentRemiander()
        {
            Notify?.Invoke($"Остаток по счету {this.Name}: {this.Remiander}$");
        }
    }
}
