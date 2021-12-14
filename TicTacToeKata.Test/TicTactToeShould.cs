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

            board.PlaceToken(new Token(token), new Coordinates(0, 0));

            Assert.Equal(token, board.GetTokenAtPosition(0, 0));
        }

        [Theory]
        [InlineData('d')]
        [InlineData('m')]
        [InlineData('g')]
        [InlineData('u')]
        public void NotAllowPlayerToPlaceOtherTokenThanXOrO(char token)
        {
            Board board = new Board();

            Action action = () => board.PlaceToken(new Token(token), new Coordinates(0, 0));

            Assert.Throws<ArgumentException>(action);
        }

        [Fact]
        public void AllowPlayerToPlaceXTokenOn0And1()
        {
            Board board = new();
            Coordinates coordinates = new Coordinates(0, 1);
            Token token = new Token('x');

            board.PlaceToken(token, coordinates);
            
            Assert.Equal('x', board.GetTokenAtPosition(0, 1));
        }

        [Fact]
        public void DoNotAllowPlayerToPlaceOTokenOn0And1WhenThereIsXTokenPlaced()
        {
            Board board = new();
            Coordinates coordinates = new Coordinates(0, 1);
            Token token = new Token('o');

            Action action = () => board.PlaceToken(token, coordinates);
            
            Assert.Throws<ArgumentException>(action);
        }

    }
}