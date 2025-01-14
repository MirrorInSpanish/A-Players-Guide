Console.WriteLine("What is the enemies x coordinate?");
string x1 = Console.ReadLine();
int x = Convert.ToInt32(x1);
Console.WriteLine("What is the enemies y coordinate?");
string y1 = Console.ReadLine();
int y = Convert.ToInt32(y1);

if (x < 0)
{
    if (y > 0)
        Console.WriteLine("The enemy is to the Northwest!");
    else if (y < 0)
        Console.WriteLine("The enemy is to the Southwest!");
    else
        Console.WriteLine("The enemy is to the West!");
}

if (x == 0)
{
    if (y > 0)
        Console.WriteLine("The enemy is to the North!");
    else if (y < 0)
        Console.WriteLine("The enemy is to the South!");
    else
        Console.WriteLine("The enemy is here!");
}

if (x > 0)
{ 
    if (y > 0)
        Console.WriteLine("The enemy is to the Northeast!");
    else if (y < 0)
        Console.WriteLine("The enemy is to the Southeast!");
    else
        Console.WriteLine("The enemy is to the East!");
}