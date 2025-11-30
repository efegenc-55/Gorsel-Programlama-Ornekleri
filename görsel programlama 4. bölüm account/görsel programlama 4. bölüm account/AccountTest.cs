using System;

class AccountTest
{
    static void Main()
    {
        // 2 tane hesap nesnesi oluşturuluyor
        Account account1 = new Account("Jane Green", 50.00m);
        Account account2 = new Account("John Blue", -7.53m);

        // Başlangıç bakiyelerini göster
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        // account1 için para yatırma işlemi
        Console.Write("\nEnter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
        account1.Deposit(depositAmount);

        // account2 için para yatırma işlemi
        Console.Write("Enter deposit amount for account2: ");
        depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
        account2.Deposit(depositAmount);

        // Son bakiyeleri göster
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
    }
}
