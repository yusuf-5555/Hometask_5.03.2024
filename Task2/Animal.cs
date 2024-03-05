public abstract class Animal
{
    string _name;

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public abstract void Eat();
}