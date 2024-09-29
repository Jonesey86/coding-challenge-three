public class Challenge_three
{
    public void FizzBuzz()
    {
        // Todo: Implement fizzbuzz, if a number is divisible by 3: Fizz, if a number is divisible by 5: Buzz, if the number is divisible by both 3 and 5, FizzBuzz
        // https://www.geeksforgeeks.org/fizz-buzz-implementation/

        for(int i = 1; i <= count; ++i) 
    {
        // can also use i % 15
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
            Console.WriteLine(i);
    }
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }

        else 
        {
            return n1 * (RecursiveFactorial(n1 - 1));
        }
        // n * Method(n - 1);
        return n;
    }

    public string ReverseString(string str)
    {
        // Todo: reverse the given string
        char[] charArray = str.ToCharArray();
        return str;
    }
    public string Reverse(string text)
{
    char[] cArray = text.ToCharArray();
    string reverse = String.Empty;
    for (int i = cArray.Length - 1; i > -1; i--)
    {
        reverse += cArray[i];
    }
    return reverse;
}
}