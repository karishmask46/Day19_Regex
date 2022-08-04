using UserRegistration;
Patterns patterns= new Patterns();
if (patterns.ValidateString("Abc.xyz@gmail.co.in"))

{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
Console.ReadKey();