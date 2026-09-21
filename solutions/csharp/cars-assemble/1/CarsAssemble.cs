static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
        {
            return 0.00;
        }
        else if (speed > 0 && speed < 5)
        {
            return 1.00;
        }    
        else if (speed > 4 && speed < 9)
        {
            return 0.90;
        }    
        else if (speed == 9)
        {
            return 0.80;
        }    
        else
        {
            return 0.77;
        }    
    }
    
    public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => Convert.ToInt32(ProductionRatePerHour(speed)) / 60;

}
