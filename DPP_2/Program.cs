// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");
//ques1- Factorial program using recursion.
Console.Write("Enter the number for which you want to find the factorial: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(recfunc(n));
static int recfunc(int n)
{
    if (n == 1)
        return 1;
    else
        return n * recfunc(n - 1);

}

//ques 2 - calculate sum of digit of an integer.
Console.Write("Enter any integer number: ");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (x != 0)
{
    sum += x % 10;
    x /= 10;
}
Console.WriteLine($"The sum of digits is : {sum}");

//ques 4 - exchange first and last character of string
Console.Write("Enter any string : ");
string original = Console.ReadLine();
Console.WriteLine(original[0]);
Console.WriteLine(original.Length);
string substrng = original.Substring(1 , original.Length-2);
Console.WriteLine(substrng);
//string


//q5 - multiple of 3 or 7 
//Console.WriteLine("Enter any integer : ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Main(string[x]));

Console.WriteLine("Input any integer:");
int x2 = Convert.ToInt32(Console.ReadLine());
static void Main(int x2)
{
    if (x2 > 0)
    {
        Console.WriteLine(x2 % 3 == 0 || x2 % 7 == 0);
    }
}
Main(x2);

//q6- check if string starts with c#

Console.WriteLine("Enter any string: ");
string st1 = Console.ReadLine();
Console.Write(st1.StartsWith("c#"));

//q8 - rigth angle triangle

int i = 1;
while (i < 5)
{
    Console.WriteLine(i * );
    i++;
}