using System;

public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}

public abstract class Account
{
    public string AccountNumber { get; set; }
    public Customer Customer { get; set; }
    public decimal Balance { get; set; }

    public abstract void DisplayAccountDetails();
}

public class SavingsAccount : Account
{
    public decimal InterestRate { get; set; }

    public override void DisplayAccountDetails()
    {
        Console.WriteLine($"Savings Account: {AccountNumber}, Balance: {Balance}, Interest Rate: {InterestRate}%");
    }
}

public class CurrentAccount : Account
{
    public decimal OverdraftLimit { get; set; }

    public override void DisplayAccountDetails()
    {
        Console.WriteLine($"Current Account: {AccountNumber}, Balance: {Balance}, Overdraft Limit: {OverdraftLimit}");
    }
}
