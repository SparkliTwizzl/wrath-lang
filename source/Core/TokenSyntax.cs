namespace Wrath.Core
{
	public static class TokenSyntax
	{
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

			{ "?=", TokenType.ComparisonOperatorEqual },
			{ "is", TokenType.ComparisonOperatorIs },
			{ "?>", TokenType.ComparisonOperatorGreater },
			{ "?>=", TokenType.ComparisonOperatorGreaterOrEqual },
			{ "?<", TokenType.ComparisonOperatorLesser },
			{ "?<=", TokenType.ComparisonOperatorLesserOrEqual },
			{ "?<>", TokenType.ComparisonOperatorNotEqual },

			// { "char", TokenType.DataTypeCharacter },
			{ "float", TokenType.DataTypeFloatingPoint },
			{ "int", TokenType.DataTypeInteger },
			// { "logical", TokenType.DataTypeLogical },

			// { "and", TokenType.LogicalOperatorAnd },
			// { "not", TokenType.LogicalOperatorNot },
			// { "or", TokenType.LogicalOperatorOr },

			// { "false", TokenType.LogicalValueFalse },
			// { "true", TokenType.LogicalValueTrue },

			{ "(", TokenType.ParenthesisLeft },
			{ ")", TokenType.ParenthesisRight },
		};
	}
}
