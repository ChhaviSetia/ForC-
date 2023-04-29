// See https://aka.ms/new-console-template for more information
Console.WriteLine("This is practice question paper.");

//Question 1 - Number of days in month.
Console.Write("Enter a month name to know the number of days in it: ");
string? month = Console.ReadLine();

switch (month)
{
    case "january":
    case "march":
    case "may":
    case "july":
    case "august":
    case "october":
    case "december":
        Console.WriteLine("It has 31 days.");
        break;
    case "feburary":
        Console.WriteLine("It has 28 days.");
        break;
    case "april":
    case "june":
    case "september":
    case "november":
        Console.WriteLine("It has 30 days.");
        break;
    default:
        Console.WriteLine("Thats not a month.");
        break;
}

//Ques2 - print male or female according to M.F.
Console.Write("Enter M/f : ");
var gender = Convert.ToChar(Console.ReadLine());

switch (gender)
{
    case 'M':
    case 'm':
        Console.WriteLine("Male");
        break;
    case 'F':
    case 'f':
        Console.WriteLine("Female");
        break;
    default:
        Console.WriteLine("Gender not specified");
        break;
}

//Ques3 - simple calculator.
Console.WriteLine("My calculator: ");
Console.WriteLine("Enter 2 integers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Select any of these operators: + , - , * ,/ : ");
var optr = Convert.ToChar(Console.ReadLine());

 switch(optr)
   
 {
    case '+':
        Console.WriteLine("Addition of both the numbers is : " + (num1 + num2));
        break;
    case '-':
        Console.WriteLine("Subtraction of given numbers is: " + (num1 - num2));
        break;
    case '*':
        Console.WriteLine("Multiplication of given numbers is: " + (num1 * num2));
        break;
    case '/':
        Console.WriteLine("Divison of given numbers is: " + (num1 / num2));
        break;
        default:
        Console.WriteLine("Enter  integer values.");
        break;
    }
    Console.ReadLine();