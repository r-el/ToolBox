class Hammer : Tool
{
    public Hammer(string name, float weight) : base(name, weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine(ToString());
        
    }
    
    public override string ToString()
    {
        return $"Hammer [Name: {Name}, Weight: {Weight}]";
    }
}