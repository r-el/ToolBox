Tool t = new Tool("Patish", 5);
Hammer h = new("Hammer", 200);
Drill d = new("Drill", 150);
Saw s = new("Saw", 120);
Wrench w = new("Wrench", 80);
Screwdriver sd = new("Screwdriver", 30);
PipeCutter pc = new("PipeCutter", 60);
WireStripper ws = new("WireStripper", 20);
NailGun ng = new("NailGun", 250);

Tool[] tools = { t, h, d, s, w, sd, pc, ws, ng };
foreach (Tool tool in tools)
{
    tool.Describe();
    tool.Use();
}
