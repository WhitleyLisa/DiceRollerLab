var goAgain = true;
while (goAgain)
{
    Console.Write("Welcome to the dice show! You may roll 2 dice. ");
    Console.WriteLine("");
    Console.Write("How many sides should the dice have?");


    var clientAnswer = Console.ReadLine();

    int nSides;
    bool clientsNumber = int.TryParse(clientAnswer, out nSides);

    if (clientsNumber)
    {

        if (nSides == 6)
        {
            var output = RollerSixSides();
            Console.WriteLine(output);
        }

        else
        {
            var output = OtherRoll(nSides);
            Console.WriteLine(output);
        }

    }
    else
        Console.WriteLine("Please enter a number larger than 0.");

    Console.Write("Would you like to roll the dice again? (y/n)");
    var rollAgain = Console.ReadLine().ToLower();

    if (rollAgain == "y" || rollAgain == "yes")
        continue;
    else
        goAgain = false;
    Console.WriteLine("Thank you for playing! See you next time!");

}

        
  static string OtherRoll(int sides)
{
    var random = new Random();
    var roll1Result = random.Next(1, sides + 1);
    var roll2Result = random.Next(1, sides + 1);
    string output = $"{roll1Result} and {roll2Result} make {roll1Result + roll2Result}.";
    return output;
}
 static string RollerSixSides()
{
    var random = new Random();
    var rollResult1 = random.Next(1, 7);
    var rollResult2 = random.Next(1, 7);
    string output;

    if (rollResult1 == 1 && rollResult2 == 1)
        output = "Thats Snake eyes!!";
    else if ((rollResult1 == 1 && rollResult2 == 2) || (rollResult1 == 2 && rollResult2 == 1))
        output = "Thats a 1 and a 2, Craps!";
    else if (rollResult1 == 6 && rollResult2 == 6)
        output = "Thats a double sixes!!!";
    else if (rollResult1 + rollResult2 == 7)
        output = $"{rollResult1} and {rollResult2}, 7 wins!";
    else if (rollResult1 + rollResult2 == 11)
        output = $"{rollResult1} and {rollResult2}, 11 wins!";
    else
        output = $"{rollResult1} and {rollResult2} make {rollResult1 + rollResult2}!";

    return output;
}