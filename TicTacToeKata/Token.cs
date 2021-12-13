namespace TicTacToeKata
{
    public class Token
    {
        public Token(char value)
        {
            Value = value;
        }

        public char Value { get; private set; }

        public bool IsInvalidToken()
        {
            return Value != 'x' && Value != 'o';
        }
    }
}