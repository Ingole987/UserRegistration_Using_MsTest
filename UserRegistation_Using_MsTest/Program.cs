// See https://aka.ms/new-console-template for more information
using UserRegistation_Using_MsTest;

Console.WriteLine("User Registration Using MsTest !");

Pattern pattern = new Pattern();
bool result = pattern.ValidateFirstName("Pratik");
bool result1 = pattern.ValidateLastName("Ingole");
bool result2 = pattern.ValidateEmail("pratik.ingole98@gmail.com");
bool result3 = pattern.ValidateMobileNumber("91 7709197897");
bool result4 = pattern.validatePassword("Pass@123");

try
{
    if (result != true)
    {
        throw new Exception("Input string is not in correct format");
    }
    else
    {
        Console.WriteLine("Valid");
    }
    if (result1 != true)
    {
        throw new Exception("Input string is not in correct format");
    }
    else
    {
        Console.WriteLine("Valid");
    }
    if (result2 != true)
    {
        throw new Exception("Input string is not in correct format");
    }
    else
    {
        Console.WriteLine("Valid");
    }
    if (result3 != true)
    {
        throw new Exception("Input string is not in correct format");
    }
    else
    {
        Console.WriteLine("Valid");
    }
    if (result4 != true)
    {
        throw new Exception("Input string is not in correct format");
    }
    else
    {
        Console.WriteLine("Valid");
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}
Console.ReadLine();