using System;

using Microsoft.CodeAnalysis;


namespace R5T.T0130
{
    /// <summary>
    /// A strong type for <see cref="SyntaxTriviaList"/>.
    /// </summary>
    public struct Indentation : IEquatable<Indentation>
    {
        #region Static

        public static Indentation From(SyntaxTriviaList value)
        {
            var output = new Indentation(value);
            return output;
        }

        public static implicit operator SyntaxTriviaList(Indentation lineIndentation)
        {
            return lineIndentation.Value;
        }

        public static bool operator ==(Indentation a, Indentation b)
        {
            var output = a.Equals(b);
            return output;
        }

        public static bool operator !=(Indentation a, Indentation b)
        {
            var output = !(a == b);
            return output;
        }

        public static bool operator ==(Indentation a, SyntaxTriviaList b)
        {
            var output = a.Value == b;
            return output;
        }

        public static bool operator !=(Indentation a, SyntaxTriviaList b)
        {
            var equals = a == b;

            var output = !equals;
            return output;
        }

        #endregion


        public SyntaxTriviaList Value { get; }


        public Indentation(
            SyntaxTriviaList value)
        {
            this.Value = value;
        }

        public bool ValueEquals(Indentation other)
        {
            var output = this.Value == other.Value;
            return output;
        }

        public bool Equals(Indentation other)
        {
            var output = this.ValueEquals(other);
            return output;
        }

        public override bool Equals(object other)
        {
            if (other is Indentation indentation)
            {
                var output = this.ValueEquals(indentation);
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