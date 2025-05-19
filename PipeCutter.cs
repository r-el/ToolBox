class PipeCutter : Tool
{
    public PipeCutter(string name, float weight) : base(name, weight) {}

    public override void Describe()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"PipeCutter [Name: {Name}, Weight: {Weight}]";
    }
}
