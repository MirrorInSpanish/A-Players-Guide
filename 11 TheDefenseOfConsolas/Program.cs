Console.Title = "Defense of Consolas.";

Console.Write("What row is under attack? ");
string attack1 = Console.ReadLine();
int a = Convert.ToInt32(attack1);

Console.Write("What column is under attack? ");
string attack2 = Console.ReadLine();
int b = Convert.ToInt32(attack2);

a = a + 1;
int unit1a = a;
int unit1b = b;

a = a - 1;
b = b - 1;
int unit2a = a;
int unit2b = b;

a = a - 1;
b = b + 1;
int unit3a = a;
int unit3b = b;

a = a + 1;
b = b + 1;
int unit4a = a;
int unit4b = b;

string unit1aa = Convert.ToString(unit1a);
string unit1bb = Convert.ToString(unit1b);
string unit2aa = Convert.ToString(unit2a);
string unit2bb = Convert.ToString(unit2b);
string unit3aa = Convert.ToString(unit3a);
string unit3bb = Convert.ToString(unit3b);
string unit4aa = Convert.ToString(unit4a);
string unit4bb = Convert.ToString(unit4b);

Console.WriteLine("Deploy all units to the following defensive formation!");
Console.WriteLine($"({unit1aa},{unit1bb})");
Console.WriteLine($"({unit2aa},{unit2bb})");
Console.WriteLine($"({unit3aa},{unit3bb})");
Console.WriteLine($"({unit4aa},{unit4bb})");

Console.Beep();