//program to compute the area of a triangle
//area = (base * height) / 2

double area;
string baseNumText;
string heightText;

//input from user as string
Console.Write("What is the base size of the triangle?\n");
baseNumText = Console.ReadLine();

Console.Write("What is the height of the triangle?\n");
heightText = Console.ReadLine();

//converts string values into doubles to be used in arithmetic
double baseNum = Convert.ToDouble(baseNumText);
double height = Convert.ToDouble(heightText);

//assigns double variable area with the result of (baseNum * height) / 2 and writes to screen
area = (baseNum * height) / 2;
Console.Write("The area of the triangle is " + area + ".\n");