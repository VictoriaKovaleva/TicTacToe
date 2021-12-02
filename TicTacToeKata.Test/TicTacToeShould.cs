using System;
using Xunit;

namespace TicTacToeKata.Test
{
    public class TicTacToeShould
    {
        [Fact]
        public void AllowPlayerToPlaceX()
        {
            char actual = TicTacToe.TicTacToe.PlaceToken('x');
            Assert.Equal('x', actual);
        }
    }
}