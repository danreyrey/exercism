public class Player
{
    private Random rnd = new Random();
    
    public int RollDie() => rnd.Next(1, 19);
    
    public double GenerateSpellStrength() => 0.0d + rnd.NextDouble() * (99.9d - 0.0d);
}
