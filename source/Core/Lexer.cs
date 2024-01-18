
using System.Text;
using System.Text.RegularExpressions;

namespace Wrath.Core
{
	public class Lexer
	{
		private int ColumnNumber { get; set; } = 0;
		private char CurrentChar { get; set; } = '\0';
		private int LineNumber { get; set; } = 0;
		private int Position { get; set; } = -1;
		private string Text { get; set; } = string.Empty;


		public Token[] Tokenize(string text)
		{
			Text = text;
			Advance();
			var result = new List<Token>();
			while (Position < Text.Length)
			{
				if (CurrentChar == '\n')
				{
					++LineNumber;
					ColumnNumber = 0;
				}
				if (IsWhitespace(CurrentChar))
				{
					Advance();
				}
				else if (CurrentChar == TokenSyntax.ComparisonOperatorStart)
				{
					result.Add(ParseComparisonOperator());
				}
				else if (IsDigit(CurrentChar))
				{
					result.Add(ParseNumber());
				}
				else if (TokenSyntax.LookUpTable.ContainsKey(CurrentChar.ToString()))
				{
					TokenType type;
					TokenSyntax.LookUpTable.TryGetValue(CurrentChar.ToString(), out type);
					var token = new Token(type);
					result.Add(token);
					Advance();
				}
				else
				{
					throw new InvalidDataException($"Source file contains an unknown character at ({LineNumber}, {ColumnNumber}): \'{CurrentChar}\'");
				}
			}
			return result.ToArray();
		}

		private void Advance()
		{
			++Position;
			++ColumnNumber;
			if (Position < Text.Length)
			{
				CurrentChar = Text[Position];
			}
		}

		private static bool IsAlphabetic(char c)
		{
			var regex = new Regex(@"[\p{L}]");
			return regex.Match(c.ToString()).Success;
		}

		private static bool IsDigit(char c)
		{
			const string digits = "0123456789";
			return digits.Contains(c);
		}

		private static bool IsWhitespace(char c)
		{
			return c == ' ' || c == '\t' || c == '\n';
		}

		private Token ParseComparisonOperator()
		{
			var builder = new StringBuilder();
			while (TokenSyntax.ComparisonOperatorCharacters.Contains(CurrentChar))
			{
				builder.Append(CurrentChar);
				Advance();
			}
			var parsed = builder.ToString();
			if (!TokenSyntax.LookUpTable.ContainsKey(parsed))
			{
				throw new InvalidDataException($"Source file contains an invalid string: {parsed}");
			}
			TokenType type;
			TokenSyntax.LookUpTable.TryGetValue(parsed, out type);
			return new Token(type);
		}

		private Token ParseNumber()
		{
			var builder = new StringBuilder();
			var dotCount = 0;

			while (IsDigit(CurrentChar) || CurrentChar == '.')
			{
				if (CurrentChar == '.')
				{
					++dotCount;
					if (dotCount > 1)
					{
						break;
					}
					builder.Append('.');
				}
				else
				{
					builder.Append(CurrentChar);
				}
				Advance();
			}

			var type = dotCount == 0 ? TokenType.DataValueInteger : TokenType.DataValueFloatingPoint;
			return new Token(type, builder.ToString());
		}
	}
}
