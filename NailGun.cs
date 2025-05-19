class NailGun : Tool
{
    public NailGun(string name, float weight) : base(name, weight) {}

    public override void Describe()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"NailGun [Name: {Name}, Weight: {Weight}]";
    }
}
