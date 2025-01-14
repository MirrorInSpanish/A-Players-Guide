//initialize user score
int score = 0;

//intialize point system
int estate = 1;
int duchy = 3;
int province = 6;

//ask user for holdings amount input, which then converts to type int, then multiplies that amount against the point system and increments to score, done for all 3 holding types.
Console.WriteLine("Enter the amount of estates in your holding.");
string estatesHeld = Console.ReadLine();
int estates = Convert.ToInt32(estatesHeld);
int estateScore = estates * estate;
score = score + estateScore;

Console.WriteLine("Enter the amount of duchies in your holding.");
string duchyHeld = Console.ReadLine();
int duchies = Convert.ToInt32(duchyHeld);
int duchyScore = duchies * duchy;
score = score + duchyScore;

Console.WriteLine("Enter the amount of provinces in your holding.");
string provinceHeld = Console.ReadLine();
int provinces = Convert.ToInt32(provinceHeld);
int provinceScore = provinces * province;
score = score + provinceScore;

Console.Write("Your total score is " + score + "!\n");