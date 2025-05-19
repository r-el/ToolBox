class Saw : Tool
{
    public Saw(string name, float weight) : base(name, weight) {}

    public override void Describe()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Saw [Name: {Name}, Weight: {Weight}]";
    }
}
