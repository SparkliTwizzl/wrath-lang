using Wrath.Core;


var filePath = "../../../../test.wrath";
var text = File.ReadAllText(filePath);
var lexer = new Lexer();
var tokens = lexer.Tokenize(text);
foreach (var token in tokens)
{
	Console.Write($"{token}, ");
}
Console.WriteLine();
Console.WriteLine();
