// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var cts = new CancellationTokenSource();
var t = new Task(() =>
{
    int i = 0;
    while (true)
    {
        cts.Token.ThrowIfCancellationRequested();
        Console.WriteLine(i++);
    }
}, cts.Token);
t.Start();
Console.ReadKey();

cts.Cancel();