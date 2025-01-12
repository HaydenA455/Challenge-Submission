static string Search(string search){
    System.Console.WriteLine($"Results for your search of '{search}';");
    string result = "############################################################################";
    return result;
}
static string Feedback(string service){
        // Ask the user for the rating of a service
        Console.WriteLine($"You chose the service '{service}'");
        Console.Write("Please provide a rating for this service: ");
        
        // Get the reason input from the user
        string reason = Console.ReadLine();
        string feedback = ($"Your feedback for '{service}' is; '{reason}' ");

        // Return the service, and reason
        return feedback;
}
//------------------------------------------------------------------------------------------------------------------------------------------
//Login system for GOV.UK
System.Console.WriteLine("Enter your GOV.UK ID;");
int govID = int.Parse(Console.ReadLine());
//Checks if the entered ID is correct
if (govID == 1)
{
    System.Console.WriteLine("Enter your Password;");
    string Password = Console.ReadLine();
    //Checks if the entered password is correct.
    if (Password == "Password123")
    {
        System.Console.WriteLine("Hello user, welcome to GOV.UK");
    }
    else
    {
        //Returns an error message if the password is incorrect
        System.Console.WriteLine("Incorrect Password");
    }
}
else
{
    //Returns an error message if the ID is incorrect.
    System.Console.WriteLine("Invalid ID");
}

//Asks the user what they want to do on the GOV.UK Website
System.Console.WriteLine("What would you like to do?");
string choice = Console.ReadLine();
string upperChoice = choice.ToUpper();
if (upperChoice == "FEEDBACK")
{
    //Calls the function and sets the parameters
System.Console.WriteLine("Which service would you like to review?");
string service = Console.ReadLine();
string feedback = Feedback(service);
System.Console.WriteLine(feedback);
}
else if (upperChoice == "SEARCH")
{
    System.Console.WriteLine("What would you like to search?");
    string search = Console.ReadLine();
    string result = Search(search);
    System.Console.WriteLine(result);
}
else if (upperChoice == "CATAGORIES")
{
    string[] catagories = new string[7]; // Declare an array of 6 strings
    catagories[0] = "Finances";
    catagories[1] = "Life/Death";
    catagories[2] = "Parenting";
    catagories[3] = "Travel/Driving";
    catagories[4] = "Crime/Justice/Law";
    catagories[5] = "Disabilities";
    catagories[6] = "Housing/Local Services";
    System.Console.WriteLine("The Catagories available are;");
    for (int i = 0; i < catagories.Length; i++)
    {
    Console.WriteLine(catagories[i]);
    }
    System.Console.WriteLine("Which Catagory would you like to view?");
    string catagory = Console.ReadLine();
    System.Console.WriteLine("#############################################################################################");
}

