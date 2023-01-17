using System.Runtime.CompilerServices;

string? nullString = null;

Assert(nullString == null);

void Assert(bool isTrue, 
    [CallerArgumentExpression(nameof(isTrue))] string? message = null, 
    [CallerMemberName] string? callingMethod = null, 
    [CallerFilePath] string? callingFile = null, 
    [CallerLineNumber] int line = 0)
{
    if (isTrue)
    {
        Console.WriteLine($"Assert was true: {message}, called from {callingFile} -> {callingMethod}:{line}");
    }
}