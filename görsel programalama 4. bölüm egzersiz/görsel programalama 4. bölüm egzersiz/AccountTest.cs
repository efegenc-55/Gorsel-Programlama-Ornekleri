using System;

public class AccountTest
{
    public static void Main(string[] args)
    {
        // Yeni hesap açıyoruz, başlangıç bakiyesi 1000 TL
        Account myAccount = new Account(1000m);

        Console.WriteLine($"Initial balance: {myAccount.GetBalance():C}");

        // Para yatırma işlemi
        myAccount.Deposit(500m);
        Console.WriteLine($"After deposit: {myAccount.GetBalance():C}");

        // Geçerli para çekme işlemi
        myAccount.Withdraw(200m);
        Console.WriteLine($"After withdrawal: {myAccount.GetBalance():C}");

        // Geçersiz para çekme işlemi (bakiye yetersiz)
        myAccount.Withdraw(2000m);
        Console.WriteLine($"After invalid withdrawal: {myAccount.GetBalance():C}");
    }
}
