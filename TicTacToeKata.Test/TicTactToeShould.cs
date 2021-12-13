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
                
            Assert.Equal(token, board.GetTokenAtPosition(0,0));

        }
    }
}