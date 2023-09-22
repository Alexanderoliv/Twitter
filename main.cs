using System;

public class Program
{
    public static string CheckMessage(string message)
    {
        if (message.Length <= 140)
            return "Posted";
        else
            return "Rejected";
    }
    
    public static void Main()
    {
        Console.WriteLine("Enter your message:");
        string message = Console.ReadLine();
        Console.WriteLine(CheckMessage(message));
    }
}

public class Tests
{
    public static void RunTests()
    {
        Test("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Posted");
        Test("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Id semper risus in hendrerit. Viverra mauris in aliquam sem. Arcu felis bibendum ut tristique et egestas quis. Pretium fusce id velit ut tortor pretium viverra suspendisse. Arcu cursus vitae congue mauris rhoncus aenean vel elit. In nisl nisi scelerisque eu ultrices. Mattis enim ut tellus elementum sagittis vitae et leo duis. In massa tempor nec feugiat. Feugiat nibh sed pulvinar proin. Elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at. Scelerisque eu ultrices vitae auctor eu augue ut. Ac turpis egestas integer eget aliquet nibh praesent tristique. Viverra suspendisse potenti nullam ac tortor. Tortor id aliquet lectus proin. Dictum non consectetur a erat nam at lectus urna duis. Dui vivamus arcu felis bibendum ut tristique et egestas.", "Rejected");
        Test("Massa vitae tortor condimentum lacinia quis vel eros donec ac.", "Posted");
        Test("Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris.", "Posted");
    }
    
    private static void Test(string input, string expectedOutput)
    {
        string result = Program.CheckMessage(input);
        Console.WriteLine($"Input: {input}\nExpected: {expectedOutput}\nGot: {result}\nTest {(result == expectedOutput ? "Passed" : "Failed")}");
        Console.WriteLine("---------------------------------------------------------");
    }
}

// Uncomment the following line to run the tests
// Tests.RunTests();
