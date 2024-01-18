
using System.Text;

namespace Wrath.Core
{
	public class Lexer
	{
		private char? CurrentChar { get; set; } = null;
		private int Position { get; set; } = -1;
		private string Text { get; set; } = string.Empty;


		public Token[] Tokenize(string text)
		{
			Text = text;
			Advance();
			var result = new List<Token>();
			while (CurrentChar is not null)
			{
				if (IsWhitespace(CurrentChar))
				{
					Advance();
				}
				else if (IsDigit(CurrentChar))
				{
					result.Add(ParseNumber());
				}
				else if (TokenSyntax.LookUpTable.ContainsKey(((char)CurrentChar).ToString()))
				{
					TokenType type;
					TokenSyntax.LookUpTable.TryGetValue(((char)CurrentChar).ToString(), out type);
					var token = new Token(type);
					result.Add(token);
					Advance();
				}
				else
				{
					Advance();
				}
			}
			return result.ToArray();
		}

		private void Advance()
		{
			++Position;
			if (Position < Text.Length)
			{
				CurrentChar = Text[Position];
			}
			else
			{
				CurrentChar = null;
			}
		}

		private static bool IsDigit(char? c)
		{
			const string digits = "0123456789";
			if (c is null)
			{
				return false;
			}
			return digits.Contains((char)c);
		}

		private static bool IsWhitespace(char? c)
		{
			return c == ' ' || c == '\t' || c == '\n';
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
