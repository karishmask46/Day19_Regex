using UserRegistration;
Patterns emailSample = new Patterns();
List<string> validtests = new List<string>() {"abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,
                                                     "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};

foreach (var test in validtests)
{
    bool result = emailSample.ValidateString(test);
    if (result)
    {
        Console.WriteLine("\n{0} is a valid email address", test);
    }
    else
    {
        Console.WriteLine("\n{0} is an invalid email address", test);
    }
}