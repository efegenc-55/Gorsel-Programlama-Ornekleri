using System;

public class Account
{
    private decimal balance; // hesap bakiyesi

    // Yapıcı metod (constructor) - başlangıç bakiyesi atanır
    public Account(decimal initialBalance)
    {
        if (initialBalance >= 0)
            balance = initialBalance;
        else
        {
            balance = 0;
            Console.WriteLine("Initial balance was invalid. Set to 0.");
        }
    }

    // Hesap bakiyesini döndürür
    public decimal GetBalance()
    {
        return balance;
    }

    // Para yatırma metodu
    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
        else
            Console.WriteLine("Deposit amount must be positive.");
    }

    // Para çekme metodu
    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawal successful. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Withdrawal amount exceeded account balance.");
        }
    }
}
