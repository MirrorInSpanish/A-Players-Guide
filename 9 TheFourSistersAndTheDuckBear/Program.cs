Console.WriteLine("How many chocolate eggs were gathered today?");
//declare string eggs which takes input from user
string eggs = Console.ReadLine();
//convert string eggs into integer named eggshare
int eggshare = Convert.ToInt32(eggs);
//assign integer eggshares with the value of int eggshare divided 4
int eggshares = eggshare / 4;
//assign integer leftover with the remainder of int eggshare and 4
int leftover = eggshare % 4;
Console.Write("Each sister gets " + eggshares + " eggs and the duck bear receives " + leftover + " eggs.\n");