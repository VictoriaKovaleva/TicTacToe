﻿using System;

namespace TicTacToeKata
{
    public class Board
    {
        private char _playingToken;

        public object GetTokenAtPosition(int x, int y)
        {
            return _playingToken;
        }

        public void PlaceToken(char token, int x, int y)
        {
            if (token != 'x' && token != 'o')
                throw new ArgumentException(nameof(token));
            
            _playingToken = token;
        }
    }
}