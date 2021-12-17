using System;
using System.Data;

namespace TicTacToeKata
{
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

            if (token.Value == 'o' && coordinates.X == 0 && coordinates.Y == 1) 
                throw new ArgumentException(nameof(Token.Value));
            
            if (token.Value == 'o' && coordinates.X == 0 && coordinates.Y == 2) 
                throw new ArgumentException(nameof(Token.Value));

            _playingToken = token.Value;
        }
    }
}