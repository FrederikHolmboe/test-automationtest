// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine(test1(5, true));

int test1 (int test1, bool multiply)
{
    if (multiply)
        return test1 * test1;
    else
        return test1;


}