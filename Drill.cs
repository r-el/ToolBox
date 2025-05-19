class Drill : Tool
{
    public Drill(string name, float weight) : base(name, weight) {}

    public override void Describe()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Drill [Name: {Name}, Weight: {Weight}]";
    }
}
