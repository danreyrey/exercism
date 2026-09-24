class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] {0, 2, 5, 3, 7, 8, 4};

    public int Today() => birdsPerDay[birdsPerDay.Length - 1]; // birdsPerDay.Last();

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1] = birdsPerDay[birdsPerDay.Length - 1] + 1; // birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds() => Array.Exists(birdsPerDay, x => x == 0); // birdsPerDay[birdsPerDay.Length - 1];

    public int CountForFirstDays(int numberOfDays) => birdsPerDay.Take(numberOfDays).Sum();

    public int BusyDays() => birdsPerDay.Count(x => x >= 5);
}
