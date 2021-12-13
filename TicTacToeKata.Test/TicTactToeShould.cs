using System;
using Xunit;

namespace TicTacToeKata.Test
{
    public class TicTactToeShould
    {
        [Theory]
        [InlineData('o')]
        [InlineData('x')]
        public void AllowPlayerToPlaceAToken(char token)
        {
            Board board = new Board();

            board.PlaceToken(token, 0, 0);

            Assert.Equal(token, board.GetTokenAtPosition(0, 0));
        }

        [Theory]
        [InlineData('d')]
        [InlineData('m')]
        [InlineData('g')]
        public void NotAllowPlayerToPlaceOtherTokenThanXOrO(char token)
        {
            Board board = new Board();

            Action action = () => board.PlaceToken(token, 0, 0);

            Assert.Throws<ArgumentException>(action);
        }
    }
}