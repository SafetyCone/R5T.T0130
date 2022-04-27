using System;

using Microsoft.CodeAnalysis;


namespace R5T.T0130
{
    /// <summary>
    /// A strong type for <see cref="SyntaxTriviaList"/>.
    /// </summary>
    public struct LineIndentation : IEquatable<LineIndentation>
    {
        #region Static

        public static LineIndentation From(SyntaxTriviaList value)
        {
            var output = new LineIndentation(value);
            return output;
        }

        public static implicit operator SyntaxTriviaList(LineIndentation lineIndentation)
        {
            return lineIndentation.Value;
        }

        public static bool operator ==(LineIndentation a, LineIndentation b)
        {
            var output = a.Equals(b);
            return output;
        }

        public static bool operator !=(LineIndentation a, LineIndentation b)
        {
            var output = !(a == b);
            return output;
        }

        public static bool operator ==(LineIndentation a, SyntaxTriviaList b)
        {
            var output = a.Value == b;
            return output;
        }

        public static bool operator !=(LineIndentation a, SyntaxTriviaList b)
        {
            var equals = a == b;

            var output = !equals;
            return output;
        }

        #endregion


        public SyntaxTriviaList Value { get; }


        public LineIndentation(
            SyntaxTriviaList value)
        {
            this.Value = value;
        }

        public bool ValueEquals(LineIndentation other)
        {
            var output = this.Value == other.Value;
            return output;
        }

        public bool Equals(LineIndentation other)
        {
            var output = this.ValueEquals(other);
            return output;
        }

        public override bool Equals(object other)
        {
            if (other is LineIndentation lineIndentation)
            {
                var output = this.ValueEquals(lineIndentation);
                return output;
            }
            // Else

            return false;
        }

        public override int GetHashCode()
        {
            var output = this.Value.GetHashCode();
            return output;
        }

        public override string ToString()
        {
            var representation = this.Value.ToString();
            return representation;
        }
    }
}