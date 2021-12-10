using Xunit;

namespace TicTacToeKata.Test
{
    public class TicTactToeShould
    {
        [Fact]
        public void AllowPlayerToPlaceX()
        {
            Board board = new Board();

            board.PlaceToken('x', 0, 0);
                
            Assert.Equal('x', board.GetTokenAtPosition(0,0));
        }
        
    }
}