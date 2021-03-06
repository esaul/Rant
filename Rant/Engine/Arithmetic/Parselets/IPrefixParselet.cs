﻿using Rant.Stringes.Tokens;

namespace Rant.Arithmetic.Parselets
{
    internal interface IPrefixParselet
    {
        Expression Parse(Parser parser, Token<RMathToken> token);
    }
}