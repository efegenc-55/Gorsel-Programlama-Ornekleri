using System;

public class Account
{
    private decimal balance; // instance variable (hesap bakiyesi)

    // Hesap sahibinin adını tutan otomatik özellik (auto-implemented property)
    public string Name { get; set; }

    // İki parametreli kurucu (isim ve ilk bakiye alır)
    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        Balance = initialBalance; // Balance property'sine değer atar (set metodu devreye girer)
    }

    // Balance özelliği — bakiyeyi kontrol ederek atama yapar
    public decimal Balance
    {
        get
        {
            return balance;
        }
        private set // dışarıdan doğrudan değiştirilemesin diye private
        {
            // negatif bir bakiye atamasını engelle
            if (value > 0.0m)
            {
                balance = value;
            }
            else
            {
                balance = 0.0m; // geçersiz girişte 0.0 yap
            }
        }
    }

    // Para yatırma metodu
    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m) // sadece pozitif miktarlarda para yatır
        {
            Balance = Balance + depositAmount;
        }
    }
}
