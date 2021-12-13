using System;

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

    public class Coordinates
    {
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }

    public class Board
    {
        private char _playingToken;

        public object GetTokenAtPosition(int x, int y)
        {
            return _playingToken;
        }

        public void PlaceToken(Token token, Coordinates coordinates)
        {
            if (token.IsInvalidToken())
                throw new ArgumentException(nameof(Token.Value));
            
            _playingToken = token.Value;
        }
    }
}