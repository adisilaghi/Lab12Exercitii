// See https://aka.ms/new-console-template for more information
using Lab12Exercitii;


try
{
    Lab12Exercitii.Queue<int> intQue = new Lab12Exercitii.Queue<int>(1);
    try
    {
        intQue.Enqueue(1);
        Console.WriteLine("Items enQued successfully.");
        intQue.Enqueue(2);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error while enQueing: {ex.Message}");
    }
    try
    {
        Console.WriteLine($"DeQued: {intQue.Dequeue()}");
        Console.WriteLine($"DeQued: {intQue.Dequeue()}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error while deQueing: {ex.Message}");
    }

    Lab12Exercitii.Queue<string> stringQue = new Lab12Exercitii.Queue<string>(1);

    try
    {
        stringQue.Enqueue("one");
        Console.WriteLine("String items enQued successfully.");

        stringQue.Enqueue("two");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error while enQueing string items: {ex.Message}");
    }

    try
    {
        Console.WriteLine($"DeQued: {stringQue.Dequeue()}");
        Console.WriteLine($"DeQued: {stringQue.Dequeue()}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error while deQueing string items: {ex.Message}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}