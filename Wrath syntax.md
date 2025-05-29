# Wrath syntax table (\\ indicates optional line break):

| name                                     | Wrath                                      | C++                                     | func signature                                         |
| ---------------------------------------- | ------------------------------------------ | --------------------------------------- | ------------------------------------------------------ |
| addition operator                        | `x + y`                                    | `x + y`                                 | `func + with args(type x, type y) returns type`        |
| subtraction operator                     | `x - y`                                    | `x - y`                                 | `func - with args(type x, type y) returns type`        |
| multiplication operator                  | `x * y`                                    | `x * y`                                 | `func * with args(type x, type y) returns type`        |
| division operator                        | `x / y`                                    | `x / y`                                 | `func / with args(type x, type y) returns type`        |
| modulus operator                         | `x % y`                                    | `x % y`                                 | `func % with args(type x, type y) returns type`        |
| exponentiation operator                  | `x ** y`                                   | `math.pow(x, y)`                        | `func ** with args(type x, type y) returns type`       |
| logarithm operator                       | `x // y`                                   | `math.log(x, y)`                        | `func // with args(type x, type y) returns type`       |
| preincrement operator                    | `++x`                                      | `++x`                                   | `func ++_ with args(type x) returns type`              |
| postincrement operator                   | `x++`                                      | `x++`                                   | `func _++ with args(type x) returns type`              |
| predecrement operator                    | `--x`                                      | `--x`                                   | `func --_ with args(type x) returns type`              |
| postdecrement operator                   | `x--`                                      | `x--`                                   | `func _-- with args(type x) returns type`              |
| bitwise not operator                     | `~x`                                       | `~x`                                    | `func ~ with args(type x) returns type`                |
| bitwise and operator                     | `x & y`                                    | `x & y`                                 | `func & with args(type x, type y) returns type`        |
| bitwise or operator                      | `x \| y`                                   | `x \| y`                                | `func \| with args(type x, type y) returns type`       |
| bitwise exclusive or operator            | `x ^ y`                                    | `x ^ y`                                 | `func ^ with args(type x, type y) returns type`        |
| bitwise left shift operator              | `x < y`                                    | `x << y`                                | `func < with args(type x, type y) returns type`        |
| bitwise right shift operator             | `x > y`                                    | `x >> y`                                | `func > with args(type x, type y) returns type`        |
| default assignment operator              | `x ::`                                     | `x = type()`                            | `func :: returns type`                                 |
| assignment operator                      | `x : y`                                    | `x = y`                                 | `func : with args(type x) returns type`                |
| addition assignment operator             | `x :+ y`                                   | `x += y`                                | `func :+ with args(type x) returns type`               |
| subtraction assignment operator          | `x :- y`                                   | `x -= y`                                | `func :- with args(type x) returns type`               |
| multiplication assignment operator       | `x :* y`                                   | `x *= y`                                | `func :* with args(type x) returns type`               |
| division assignment operator             | `x :/ y`                                   | `x /= y`                                | `func :/ with args(type x) returns type`               |
| modulus assignment operator              | `x :% y`                                   | `x %= y`                                | `func :% with args(type x) returns type`               |
| exponentiation assignment operator       | `x :** y`                                  | `x = math.pow(x, y)`                    | `func :** with args(type x) returns type`              |
| logarithm assignment operator            | `x :// y`                                  | `x = math.log(x, y)`                    | `func :// with args(type x) returns type`              |
| bitwise and assignment operator          | `x :& y`                                   | `x &= y`                                | func :& with args(type x) returns type                 |
| bitwise or assignment operator           | `x :\| y`                                  | `x \|= y`                               | `func :\| with args(type x, type y) returns type`      |
| bitwise exclusive or assignment operator | `x :^ y`                                   | `x ^= y`                                | `func :^ with args(type x) returns type`               |
| left shift assignment operator           | `x :< y`                                   | `x <<= y`                               | `func :< with args(type x) returns type`               |
| right shift assignment operator          | `x :> y`                                   | `x >>= y`                               | `func :> with args(type x) returns type`               |
| equality operator                        | `?=`                                       | `==`                                    | `func ?= with args(type x, type y) returns logic`      |
| inequality operator                      | `?<>`                                      | `!=`                                    | `func ?<> with args(type x, type y) returns logic`     |
| strict greater operator                  | `?>`                                       | `>`                                     | `func ?> with args(type x, type y) returns logic`      |
| strict lesser operator                   | `?<`                                       | `<`                                     | `func ?< with args(type x, type y) returns logic`      |
| loose greater operator                   | `?>=`                                      | `>=`                                    | `func ?>= with args(type x, type y) returns logic`     |
| loose lesser operator                    | `?<=`                                      | `<=`                                    | `func ?<= with args(type x, type y) returns logic`     |
| difference operator                      | `??`                                       | `<=>`                                   | `func ?? with args(type x, type y) returns difference` |
| logical not operator                     | `not x`                                    | `!x`                                    | `func not with args (type x) returns type`             |
| logical and operator                     | `x and y`                                  | `x && y`                                | `func and with args (type x, type y) returns type`     |
| logical or operator                      | `x or y`                                   | `x \|\| y`                              | `func or with args (type x, type y) returns type`      |
| logical and cluster                      | `x op and[y, z]`                           | `(x op y) && (x op z)`                  |                                                        |
| logical or cluster                       | `x op or[y, z]`                            | `(x op y) \|\| (x op z)`                |                                                        |
| logical ternary operator                 | `x\?y\;z`                                  | `x ? y : z`                             |                                                        |
| null type                                | `nothing`                                  |                                         |                                                        |
| non-null type                            | `something`                                |                                         |                                                        |
| 1 bit raw type                           | `bit1`                                     |                                         |                                                        |
| 2 bit raw type                           | `bit2`                                     |                                         |                                                        |
| 4 bit raw type                           | `bit4`                                     |                                         |                                                        |
| 8 bit raw type                           | `bit8`                                     | `unsigned char`                         |                                                        |
| 16 bit raw type                          | `bit16`                                    | `short`                                 |                                                        |
| 32 bit raw type                          | `bit32`                                    | `int`                                   |                                                        |
| 64 bit raw type                          | `bit64`                                    | `long long int`                         |                                                        |
| 128 bit raw type                         | `bit128`                                   |                                         |                                                        |
| 8 bit logical type                       | `logic8`                                   | `bool`\|                                |                                                        |
| 8 bit signed integer type                | `sint8`                                    | `char`                                  |                                                        |
| 16 bit signed integer type               | `sint16`                                   | `short`                                 |                                                        |
| 32 bit signed integer type               | `sint32`                                   | `int`                                   |                                                        |
| 64 bit signed integer type               | `sint64`                                   | `long long int`                         |                                                        |
| 128 bit signed integer type              | `sint128`                                  |                                         |                                                        |
| 8 bit unsigned integer type              | `uint8`                                    | `unsigned char`                         |                                                        |
| 16 bit unsigned integer type             | `uint16`                                   | `unsigned short`                        |                                                        |
| 32 bit unsigned integer type             | `uint32`                                   | `unsigned int`                          |                                                        |
| 64 bit unsigned integer type             | `uint64`                                   | `unsigned long long int`                |                                                        |
| 128 bit unsigned integer type            | `uint128`                                  |                                         |                                                        |
| 8 bit character type                     | `char8`                                    | `char`                                  |                                                        |
| 16 bit character type                    | `char16`                                   | `short`                                 |                                                        |
| 32 bit character type                    | `char32`                                   | `int`                                   |                                                        |
| 64 bit character type                    | `char64`                                   | `long long int`                         |                                                        |
| type alias                               | `alias x as y`                             | `typedef x y`                           |                                                        |
| prebuild function                        | `prebuild func ...`                        |                                         |                                                        |
| prebuild flag                            | `prebuild value x`                         | `#define x`                             |                                                        |
| prebuild value                           | `prebuild value x : y`                     | `#define x y`                           |                                                        |
| build error                              | `error("a...")`                            | `#error a...`                           |                                                        |
| prebuild flag conditional                | `if (x is defined)\{\a...\}`               | `#if defined(x)\a...\#endif`            |                                                        |
| prebuild flag conditional                | `if (x is not defined)\{\a...\}`           | `#if !defined(x)\a...\#endif`           |                                                        |
| prebuild flag conditional                | `if (x is defined)\{\a...\}\else\{\b...\}` | `#if defined(x)\a...\#else\b...\#endif` |                                                        |
| type check                               | `if (x is a y)`                            | `if (typeof(x) == y)`                   |                                                        |
| type check                               | `if (x is not a y)`                        | `if (typeof(x) != y)`                   |                                                        |
| function                                 | `func x returns nothing`                   | `void x()`                              |                                                        |
| function                                 | `func x\with args(...)\returns type`       | `type x(...)`                           |                                                        |

# Type aliases

| type   | alias    |
| ------ | -------- |
| bit1   | bit      |
| bit2   | doublet  |
| bit4   | tetret   |
| bit8   | octet    |
| bit16  | hextet   |
| bit16  | bitword  |
| bit32  | dbitword |
| bit64  | qbitword |
| bit2   | crumb    |
| bit4   | nibble   |
| bit8   | byte     |
| bit16  | morsel   |
| bit32  | snack    |
| bit64  | meal     |
| bit128 | feast    |
|        |          |
|        |          |
|        |          |
|        |          |
|        |          |
|        |          |
|        |          |
|        |          |
|        |          |

alias sint8 as tinyint
alias sint16 as smallint
alias sint32 as int
alias sint64 as bigint
alias sint128 as hugeint

alias uint8 as utinyint
alias uint16 as usmallint
alias uint32 as uint
alias uint64 as ubigint
alias uint128 as uhugeint

alias float8 as quarterfloat
alias float16 as halffloat
alias float32 as float
alias float64 as doublefloat
alias float128 as quadfloat
