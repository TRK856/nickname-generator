// See https://aka.ms/new-console-template for more information
#nullable disable

// init
Console.WriteLine("Please enter your name");
Console.Write("Please enter first name: "); string firstName = Console.ReadLine();
Console.Write("Please enter last name: "); string lastName = Console.ReadLine();
Console.WriteLine($"Current Name is {firstName} {lastName}");

// init
nickname = new List<string>() 
{
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
    Console.WriteLine("MAIN MENU (John Doe)");
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
        Console.WriteLine($"{firstName} {nickname[rnd.Next(0, nickname.Count())]} {lastName}");
    }
    // if(mainMenuChoice == 3){
    //     Console.Clear();
    //     Console.WriteLine("STATS");
    //     int largestNum = 0;
    //     int smallestNum = 100;
    //     int averageNum = 0;

    //     for (int i = 0; i < grades.Length; i++) {
    //         if(grades[i] > largestNum){
    //             largestNum = grades[i];
    //         }
    //         if(grades[i] < smallestNum){
    //             smallestNum = grades[i];
    //         }
    //         averageNum += grades[i];
    //     }
    //     Console.WriteLine($"Highest Grade: {largestNum}");
    //     Console.WriteLine($"Lowest Grade: {smallestNum}");
    //     Console.WriteLine($"Average Grade: {averageNum/grades.Length}");
    //     Console.WriteLine("");
    // }
    // if(mainMenuChoice == 4){
    //     Console.Clear();
    //     Console.WriteLine("# of Students?");
    //     Console.Write("-> "); AmountOfGrades = Convert.ToInt32(Console.ReadLine());
    //     AmountOfGrades = 35;
    //     for(int n=0; n < AmountOfGrades; n++){
    //         grades[n] = rnd.Next(0, 100);
    //     }
    //     Console.WriteLine("GRADES HAVE BEEN RANDOMIZED");
    // }
    // if(mainMenuChoice == 5){
    //     Console.Clear();
    //     Console.WriteLine("# of Students?");
    //     Console.Write("-> "); AmountOfGrades = Convert.ToInt32(Console.ReadLine());
    //     AmountOfGrades = 35;
    //     for(int n=0; n < AmountOfGrades; n++){
    //         grades[n] = rnd.Next(0, 100);
    //     }
    //     Console.WriteLine("GRADES HAVE BEEN RANDOMIZED");
    // }
    if(mainMenuChoice == 6){
        Console.Clear();
        break;
    }
    Console.WriteLine("");
    Console.WriteLine("Back to Main Menu?");
    Console.Write("-> "); Console.ReadLine();
}