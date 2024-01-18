namespace Wrath.Core
{
	public class Token
	{
		public string Value { get; set; } = string.Empty;
		public TokenType Type { get; set; } = TokenType.Unknown;


		public Token(TokenType type = TokenType.Unknown, string value = "")
		{
			Value = value;
			Type = type;
		}


		public override string ToString()
		{
			return $"{Type}{(Value != string.Empty ? ":" : "")}{Value}";
		}
	}
}
