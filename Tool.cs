using System;

class Tool
{
    protected string Name;
    protected float Weight;

    public Tool(string name, float weight)
    {
        Name = name;
        Weight = weight;
    }
    public virtual void Describe()
    {
        Console.WriteLine(ToString());
    }
    public void Use()
    {
        Console.WriteLine($"{Name} is being used");
    }
    public override string ToString()
    {
        return $"Tool [Name: {Name}, Weight: {Weight}]";
    }
}