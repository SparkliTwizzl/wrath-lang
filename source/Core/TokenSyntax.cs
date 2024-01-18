namespace Wrath.Core
{
	public static class TokenSyntax
	{
		public static string ComparisonOperatorCharacters => $"{ComparisonOperatorEqual}{ComparisonOperatorGreater}{ComparisonOperatorLesser}{ComparisonOperatorStart}";
		public static char ComparisonOperatorEqual => '=';
		public static char ComparisonOperatorGreater => '>';
		public static char ComparisonOperatorLesser => '<';
		public static char ComparisonOperatorStart => '?';

		public static Dictionary<string, TokenType> LookUpTable = new()
		{
			{ "=", TokenType.AssignmentOperator },

			{ "+", TokenType.BinaryOperatorAdd },
			{ "/", TokenType.BinaryOperatorDivide },
			{ "%", TokenType.BinaryOperatorModulo },
			{ "*", TokenType.BinaryOperatorMultiply },
			{ "-", TokenType.BinaryOperatorSubtract },

			{ "&", TokenType.BitwiseOperatorAnd },
			{ "|", TokenType.BitwiseOperatorOr },
			{ "~", TokenType.BitwiseOperatorNot },
			{ "^", TokenType.BitwiseOperatorXor },

			{ $"{ComparisonOperatorStart}{ComparisonOperatorEqual}", TokenType.ComparisonOperatorEqual },
			{ "is", TokenType.ComparisonOperatorIs },
			{ $"{ComparisonOperatorStart}{ComparisonOperatorGreater}", TokenType.ComparisonOperatorGreater },
			{ $"{ComparisonOperatorStart}{ComparisonOperatorGreater}{ComparisonOperatorEqual}", TokenType.ComparisonOperatorGreaterOrEqual },
			{ $"{ComparisonOperatorStart}{ComparisonOperatorLesser}", TokenType.ComparisonOperatorLesser },
			{ $"{ComparisonOperatorStart}{ComparisonOperatorLesser}{ComparisonOperatorEqual}", TokenType.ComparisonOperatorLesserOrEqual },
			{ $"{ComparisonOperatorStart}{ComparisonOperatorLesser}{ComparisonOperatorGreater}", TokenType.ComparisonOperatorNotEqual },

			{ "char", TokenType.DataTypeCharacter },
			{ "float", TokenType.DataTypeFloatingPoint },
			{ "int", TokenType.DataTypeInteger },
			{ "logical", TokenType.DataTypeLogical },

			{ "and", TokenType.LogicalOperatorAnd },
			{ "not", TokenType.LogicalOperatorNot },
			{ "or", TokenType.LogicalOperatorOr },

			{ "false", TokenType.LogicalValueFalse },
			{ "true", TokenType.LogicalValueTrue },

			{ "(", TokenType.ParenthesisLeft },
			{ ")", TokenType.ParenthesisRight },

			{ ";", TokenType.StatementEnd },
		};
	}
}
