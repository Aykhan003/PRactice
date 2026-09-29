namespace ConsoleApp55.Methods;

internal class BankAccount
{
    public string AccountHolder { get; set; }
    public decimal Balance { get; private set; }

    // Constructor
    public BankAccount(string accountHolder, decimal initialBalance)
    {
        AccountHolder = accountHolder;
        if (initialBalance >= 0)
        {
            Balance = initialBalance;
        }
        else
        {
            Balance = 0;
        }
    }
}
