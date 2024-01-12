/////// Project 2 Do-While 
string? readResult;
string roleName = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Adminstrator, Manager, or User)");
    readResult = Console.ReadLine();
    if(readResult != null)
        roleName = readResult;
    
    if(roleName.ToLower()== "administrator" || roleName.ToLower()== "manager" || roleName.ToLower() =="user")
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"The role name that youi entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();

///////// Project 1 Do-While
/*
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validateNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
        valueEntered = readResult;

    validateNumber = int.TryParse(valueEntered, out numValue);

    if(validateNumber  == true)
    {
        if(numValue <= 5 || numValue >= 10)
        {
            validateNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try agian");
    }

} while (validateNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/

//int hero = 10;
//int monster = 10;

//Random dice = new Random();

//do
//{
//    int roll = dice.Next(1,11);
//    monster -= roll;
//    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health");

//    if (monster <= 0) continue;

//    roll = dice.Next(1,11);
//    hero -= roll;
//    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
//} while (hero > 0 && monster > 0);

//Console.WriteLine(hero>monster ? "Hero wins!": "Monster wins!");

//Random random = new Random();
//int current = 0;

//do
//{
//    current = random.Next(1,11);
//    Console.WriteLine(current);
//}while(current != 12);

//string[] names = { "Alex", "Eddie", "David", "Micheal" };
//for (int i = 0; i < names.Length; i++)
//    if (names[i] == "David") names[i] = "Sammy";

//foreach (var name in names) Console.WriteLine(name);


//string sku = "01-MN-L";

//string[] product = sku.Split("-");

//string type = "";
//string color = "";
//string size = "";

//switch (product[0])
//{
//    case "01":
//        type = "Sweat shirt";
//        break;
//    case "02":
//        type = "T-Shirt";
//        break;
//    case "03":
//        type = "Sweat Pants";
//        break;
//    default:
//        type = "Other";
//        break;
//}

//switch (product[1])
//{
//    case "BL":
//        color = "Black";
//        break;
//    case "MN":
//        color = "Maroon";
//        break;
//    default:
//        color = "White";
//        break;
//}

//switch (product[2])
//{
//    case "S":
//        size = "Small";
//        break;
//    case "M":
//        size = "Medium";
//        break;
//    case "L":
//        size = "Large";
//        break;
//    default:
//        size = "One size Fits All";
//        break;
//}

//Console.WriteLine($"Product Details: {size} {color} {type}");


//int[] numbers = { 4,8,15, 16, 23, 42}
//;
//bool found = false;
//int total = 0;

//foreach (int number in numbers)
//{
//    total += number;
//    if (number == 42) found = true;
//}

//if (found) Console.WriteLine("Set contains 42");

//Console.WriteLine($"Total: {total}");

//string name = "steve";
//if (name == "bob") Console.WriteLine("Found Bob");
//else if (name =="steve") Console.WriteLine("Found Steve");
//else Console.WriteLine("Found Chuck");



//string permissions = "Admin|Manager";
//int level = 60;

//if (permissions.Contains("Admin"))
//{
//    if (level > 55)
//    {
//        Console.WriteLine("Welcome, Super Admin User");
//    }
//    else
//    {
//        Console.WriteLine("Welcome, Admin user.");
//    }
//}
//else if (permissions.Contains("Manager"))
//{
//    if(level >= 20)
//    {
//        Console.WriteLine("Contact Admin for access");
//    }
//    else
//    {
//        Console.WriteLine("You do not have sufficient privileges.");
//    }
//}
//else
//{
//    Console.WriteLine("You do not have sufficient privileges.");
//}









////// See https://aka.ms/new-console-template for more information
////Console.WriteLine("***C# Collections***\n\n");

////string[] students = new string[] 
////{
////    "John","Jane","Lily","Lavine","Nancy"
////};



////foreach (var student in students)
////{
////    Console.WriteLine(student);
////}
////decimal x = 12.3m;
////decimal gradePointAverage = 3.99872831m;

////Console.WriteLine((int) gradePointAverage);
//////Console.WriteLine(grades);
/////
///// students's name array

//int currentAssignments = 5;

//int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
//int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
//int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
//int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

//string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

//int[] studentScores = new int[10];
//string currentStudentLetterGrade = "";


//foreach (string name in studentNames)
//{

//    string currentStudent = name;

//    if (currentStudent == "Sophia")
//        studentScores = sophiaScores;
//    else if (currentStudent =="Andrew")
//        studentScores = andrewScores;
//    else if(currentStudent =="Emma")
//        studentScores = emmaScores;
//    else if (currentStudent == "Logan")
//        studentScores = loganScores;

//        int sumAssignmentScores = 0;

//        decimal currentStudentGrade =0;

//        foreach(int score in studentScores )
//        {
//        sumAssignmentScores += score;
//        }

//    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

//    if (currentStudentGrade >= 97)
//        currentStudentLetterGrade = "A+";

//    else if (currentStudentGrade >= 93)
//        currentStudentLetterGrade = "A";

//    else if (currentStudentGrade >= 90)
//        currentStudentLetterGrade = "A-";

//    else if (currentStudentGrade >= 87)
//        currentStudentLetterGrade = "B+";

//    else if (currentStudentGrade >= 83)
//        currentStudentLetterGrade = "B";

//    else if (currentStudentGrade >= 80)
//        currentStudentLetterGrade = "B-";

//    else if (currentStudentGrade >= 77)
//        currentStudentLetterGrade = "C+";

//    else if (currentStudentGrade >= 73)
//        currentStudentLetterGrade = "C";

//    else if (currentStudentGrade >= 70)
//        currentStudentLetterGrade = "C-";

//    else if (currentStudentGrade >= 67)
//        currentStudentLetterGrade = "D+";

//    else if (currentStudentGrade >= 63)
//        currentStudentLetterGrade = "D";

//    else if (currentStudentGrade >= 60)
//        currentStudentLetterGrade = "D-";
//    else
//        currentStudentLetterGrade = "F";

//    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{currentStudentLetterGrade}");

//}