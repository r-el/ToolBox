class Screwdriver : Tool
{
    public Screwdriver(string name, float weight) : base(name, weight) {}

    public override void Describe()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Screwdriver [Name: {Name}, Weight: {Weight}]";
    }
}
