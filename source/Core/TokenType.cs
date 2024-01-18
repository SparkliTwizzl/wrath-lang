namespace Wrath.Core
{
	public enum TokenType
	{
		Unknown,

		AssignmentOperator,

		BinaryOperatorAdd,
		BinaryOperatorDivide,
		BinaryOperatorModulo,
		BinaryOperatorMultiply,
		BinaryOperatorSubtract,

		BitwiseOperatorAnd,
		BitwiseOperatorOr,
		BitwiseOperatorNot,
		BitwiseOperatorXor,

		ComparisonOperatorEqual,
		ComparisonOperatorIs,
		ComparisonOperatorGreater,
		ComparisonOperatorGreaterOrEqual,
		ComparisonOperatorLesser,
		ComparisonOperatorLesserOrEqual,
		ComparisonOperatorNotEqual,

		DataTypeCharacter,
		DataTypeFloatingPoint,
		DataTypeInteger,
		DataTypeLogical, // equivalent to boolean

		DataValueCharacter,
		DataValueFloatingPoint,
		DataValueInteger,
		DataValueLogical,

		Identifier,

		LogicalOperatorAnd,
		LogicalOperatorNot,
		LogicalOperatorOr,

		LogicalValueFalse,
		LogicalValueTrue,

		ParenthesisLeft,
		ParenthesisRight,

		StatementEnd,
	}
}
