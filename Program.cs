String inputstr,name;
int input; 
 

Console.WriteLine("\t\t\t\t\tWelcome to my Te Reo Maori Quiz");
Console.WriteLine("\nThere's 4 questions per level of difficulty ");
Console.WriteLine("\nplease enter your name: ");
name = Console.ReadLine(); 
Console.WriteLine("\nWell hello there "+name+", I welcome you to my quiz");
Console.WriteLine(value: $"\nplease select a level \n(1)Easy \n(2)Intermidiate\n(3)Expert\n(4)Exit");
input = Convert.ToInt32(Console.ReadLine()); 
inputstr=Convert.ToString((input));
if (input == 1)
{
    Easy();
}
else if (input == 2)
{
    Intermidiate();
}
else if (input == 3)
{
    Expert(); 
}
else if (input ==4)
{
    Exit(); 
}

{

}

Console.Read();


static void Easy()
{//added levels with greeting 
    System.Console.WriteLine("You have chosen easy mode");
}
static void Intermidiate()
{
    System.Console.WriteLine("Intermidiate mode\nGoodluck!!!");
        
}
static void Expert()
{
    System.Console.WriteLine("You have chosen Expert mode\n extra luck to you"); 
}
static void Exit()
{
    System.Console.WriteLine("Goodbye!!!"); 
}