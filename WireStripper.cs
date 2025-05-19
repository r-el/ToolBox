class WireStripper : Tool
{
    public WireStripper(string name, float weight) : base(name, weight) {}

    public override void Describe()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"WireStripper [Name: {Name}, Weight: {Weight}]";
    }
}
