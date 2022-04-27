using System;

using Microsoft.CodeAnalysis;


namespace R5T.T0130
{
    public static class SyntaxTriviaListExtensions
    {
        public static LineIndentation ToLineIndentation(this SyntaxTriviaList lineIndentation)
        {
            var output = LineIndentation.From(lineIndentation);
            return output;
        }

        public static Indentation ToIndentation(this SyntaxTriviaList lineIndentation)
        {
            var output = Indentation.From(lineIndentation);
            return output;
        }
    }
}
