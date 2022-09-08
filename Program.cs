// See https://aka.ms/new-console-template for more information
#nullable disable

// init
Console.WriteLine("Please enter your name");
Console.WriteLine("----------------------");
Console.Write("Please enter first name: "); string firstName = Console.ReadLine();
Console.Write("Please enter last name: "); string lastName = Console.ReadLine();
Console.WriteLine($"Current Name is {firstName} {lastName}");

// init
List<string> nickname = new List<string>() {
    "Crusher" ,
    "the Scientist", 
    "Twinkle-toes" , 
    "the Coder", 
    "the Jester" , 
    "the Sloth", 
    "Quick-Silver"
};
Random rnd = new Random();

// actual program
bool loop = true;
while (loop){
    Console.Clear();
    Console.WriteLine($"MAIN MENU ({firstName} {lastName})");
    Console.WriteLine("    1. Change Name");
    Console.WriteLine("    2. Display a Random Nickname");
    Console.WriteLine("    3. Display All Nicknames");
    Console.WriteLine("    4. Add a Nickname");
    Console.WriteLine("    5. Remove a Nickname");
    Console.WriteLine("    6. Exit");
    Console.Write("-> "); int mainMenuChoice = Convert.ToInt32(Console.ReadLine());
    if(mainMenuChoice == 1){
        Console.Clear();
        Console.WriteLine("CHANGE NAME");
        Console.Write("Please enter first name: "); firstName = Console.ReadLine();
        Console.Write("Please enter last name: "); lastName = Console.ReadLine();
        Console.WriteLine($"Current Name is {firstName} {lastName}");
    }
    if(mainMenuChoice == 2){
        Console.Clear();
        Console.WriteLine("RANDOM NICKNAME");
        Console.WriteLine($"{firstName} '{nickname[rnd.Next(0, nickname.Count())]}' {lastName}");
    }
    if(mainMenuChoice == 3){
        Console.Clear();
        Console.WriteLine("ALL NICKNAMES");
        for (int i = 0; i < nickname.Count(); i++) {
            Console.WriteLine($"{firstName} '{nickname[i]}' {lastName}");
        }
    }
    if(mainMenuChoice == 4){
        Console.Clear();
        Console.WriteLine("ADD A NICKNAME");
        Console.Write("Please enter a nickname to add: "); string newNickname = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < nickname.Count(); i++) {
            if(nickname[i] == newNickname){
                found = true;
            }
        }
        if(found == true){
            Console.WriteLine($"{newNickname} is already in the nickname list.");
        } else {
            nickname.Add(newNickname);
            Console.WriteLine($"{newNickname} has been added to the nickname list.");        
        }
    }
    if(mainMenuChoice == 5){
        Console.Clear();
        Console.WriteLine("REMOVE A NICKNAME");
        Console.Write("Please enter a nickname to remove: "); string removeNickname = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < nickname.Count(); i++) {
            if(nickname[i] == removeNickname){
                found = true;
            }
        }
        if(found == true){
            nickname.Remove(removeNickname);
            Console.WriteLine($"{removeNickname} has been removed from the nickname list.");
        } else {
            Console.WriteLine($"{removeNickname} was not found in the nickname list."); 
        }
    }
    if(mainMenuChoice == 6){
        Console.Clear();
        break;
    }
    Console.WriteLine("");
    Console.WriteLine("Back to Main Menu?");
    Console.Write("-> "); Console.ReadLine();
}