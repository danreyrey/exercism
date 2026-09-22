static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0m)
        {
            return 3.213f;
        }
        else if (balance >= 0m && balance < 1000m)
        {
            return 0.5f;
        }
        else if (balance >= 1000m && balance < 5000m)
        {
            return 1.621f;
        }
        else
        {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance) => (decimal)InterestRate(balance) / 100 * balance;

    public static decimal AnnualBalanceUpdate(decimal balance) 
        => (decimal)InterestRate(balance) / 100 * balance + balance;

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal tmpAnnualSum = balance;
        int counter = 0;
        while (tmpAnnualSum < targetBalance)
        {
            tmpAnnualSum = AnnualBalanceUpdate(tmpAnnualSum);
            counter++;
        }
        return counter;
    }
}
