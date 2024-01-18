using Wrath.Core;


var filePath = "../../../../test.wrath";
var text = File.ReadAllText(filePath);
var lexer = new Lexer();
try
{
	var tokens = lexer.Tokenize(text);
	foreach (var token in tokens)
	{
		Console.Write($"{token}, ");
	}
}
catch (Exception exception)
{
	Console.WriteLine(exception.Message);
}
Console.WriteLine();
Console.WriteLine();
