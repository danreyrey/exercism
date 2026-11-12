class RemoteControlCar
{
    public int speed;        
    public int batteryDrain;
    public int battery = 100;
    private int distanceDriven = 0;

    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar (int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return battery < batteryDrain ? true : false;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
        else
        {
            // battery drained
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    private int distance;

    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack (int distance)
    {
        this.distance = distance;
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        return distance - ((car.battery / car.batteryDrain) * car.speed) <= 0 ? true : false;
    }
}
