using System.Xml.Serialization;

Console.WriteLine("Enter your name");
String name = Console.ReadLine();

Console.WriteLine("The following items are available:\r\n1. Rope\r\n2. Torches\r\n3. Climbing Equipment\r\n4. Clean Water\r\n5. Machete\r\n6. Canoe\r\n7. Food Supplies\r\nWhat number do you want to see the price of?");

string choiceText = Console.ReadLine();
int choice = Convert.ToInt32(choiceText);




string input;

if (name == "Erik")
{
    input = choice switch
    {
        1 => "Ropes cost 5 Gold",
        2 => "Torches cost 7.5 Gold",
        3 => "Climbing Equipment costs 12.5 Gold",
        4 => "Clean Water costs 0.5 Gold",
        5 => "A Machete costs 10 Gold",
        6 => "A Canoe costs 100 Gold",
        7 => "Food supplies cost 0.5 Gold",
        _ => "We don't have that."
    };
}

else
{
    

input = choice switch
{
    1 => "Ropes cost 10 Gold",
    2 => "Torches cost 15 Gold",
    3 => "Climbing Equipment costs 25 Gold",
    4 => "Clean Water costs 1 Gold",
    5 => "A Machete costs 20 Gold",
    6 => "A Canoe costs 200 Gold",
    7 => "Food supplies cost 1 Gold",
    _ => "We don't have that."
};
}
Console.WriteLine(input);