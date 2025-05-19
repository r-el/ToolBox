class Wrench : Tool
{
    public Wrench(string name, float weight) : base(name, weight) {}

    public override void Describe()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Wrench [Name: {Name}, Weight: {Weight}]";
    }
}
