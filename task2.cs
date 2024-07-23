namespace Task2
{
    public class Bank
    {
        private int id;
        private string name;
        private float balance;

        public Bank(int id, string name, float balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public void Deposit(float amount)
        {
            if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Invalid deposit amount.");
        }
        public void Withdraw(float amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Invalid withdrawal amount.");
        }
        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Balance: {balance}");
        }

    }
}
