String inputstr,name;
int input;


Console.WriteLine("\t\t\t\t\tWelcome to my Te Reo Maori Quiz");
Console.WriteLine("\nThere's 4 questions per level of difficulty ");
Console.WriteLine("\nplease enter your name: ");//gets users name
name = Console.ReadLine(); //stores
Console.WriteLine("\nWell hello there "+name+", I welcome you to my quiz");//welcomes user
Console.WriteLine(value: $"\nplease select a level \n(1)Easy \n(2)Intermidiate\n(3)Expert\n(4)Exit");//selects level
input = Convert.ToInt32(Console.ReadLine());
inputstr = Convert.ToString((input));
while (true)//while loop starts
{


    if (input < 1 || input > 4)
    {
        Console.WriteLine("please choose the numbers listed 1,2,3,4");
    }
    else if (input == 1)
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
    else if (input == 4)
    {
        Exit();
    }
    break; 
}//while loop ends





static void Easy()
{//added levels with greeting 
    Console.Clear(); 
    int answer1;
    System.Console.WriteLine("You have chosen easy mode");
    
    Console.WriteLine("lets start with the first question\nWhat is hello in Maori");
    
    Console.WriteLine($"select your answer\n(a)Kia ora\n(b)Tena koutou\n(c)Whanau");
    Console.ReadLine();
    
    
    

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