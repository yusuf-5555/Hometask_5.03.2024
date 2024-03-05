public class Car : IVehicle
{
    int _fuel;

    public Car(int fuel)
    {
        _fuel = fuel;
    }

    public void Drive()
    {
        if(_fuel>0)System.Console.WriteLine("Driving");
        else System.Console.WriteLine("You must refuel your car!");
    }

    public bool Refuel(int amount)
    {
        _fuel = _fuel+amount;
        return true;
    }
}