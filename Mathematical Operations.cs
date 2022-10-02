int inp, num1, num2, result;

Console.WriteLine("Operations available : ");
Console.WriteLine("1) Addition");
Console.WriteLine("2) Subtraction");
Console.WriteLine("3) Multiplication");
Console.WriteLine("4) Division");
Console.WriteLine();

Console.Write("Select an operation to perform (1-4): ");
inp = Convert.ToInt32(Console.ReadLine());
Console.Write("You have selected ");

if (inp == 1)
    Console.WriteLine("addition.");
if (inp == 2)
    Console.WriteLine("subtraction.");
if (inp == 3)
    Console.WriteLine("multiplication.");
if (inp == 4)
    Console.WriteLine("division.");

Console.Write("Enter the 1st number : ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 2nd number : ");
num2 = Convert.ToInt32(Console.ReadLine());

if (inp == 1)
{
    result = num1 + num2;
    Console.WriteLine("The sum is : " + result);
}
if (inp == 2)
{
    result = num1 - num2;
    Console.WriteLine("The difference is : " + result);
}
if (inp == 3)
{
    result = num1 * num2;
    Console.WriteLine("The product is : " + result);
}
if (inp == 4)
{
    result = num1 / num2;
    Console.WriteLine("The quotient is : " + result);
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

