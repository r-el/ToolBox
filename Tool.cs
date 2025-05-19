using System;

class Tool
{
    string Name;
    float Weight;

    public Tool(string name, float weight)
    {
        Name = name;
        Weight = weight;
    }
    public void Describe()
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
    public static void Main()
    {
        Tool t = new Tool("Patish", 5);
        t.Describe();
        t.Use();
    }

}