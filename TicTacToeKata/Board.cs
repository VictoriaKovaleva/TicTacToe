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
            _playingToken = token;
        }
    }
}