using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_WIP
{
    static class Program
    {
        public static void Main()
        {
            Game game = new Game();
            Player p1 = game.P1;
            Player p2 = game.P2;

            p1.IsTurn = true;
            p2.IsTurn = false;

            StartingPage firstPage = new StartingPage(game);
            Application.Run(firstPage);

            GetPlayer1Name p1Name = new GetPlayer1Name(game);
            Application.Run(p1Name);

            GetPlayer2Name p2Name = new GetPlayer2Name(game);
            Application.Run(p2Name);

            Player1Menu player1Menu = new Player1Menu(game);
            Application.Run(player1Menu);

            Player2Menu player2Menu = new Player2Menu(game);
            Application.Run(player2Menu);

            MainWindow window = new MainWindow(game);
            Application.Run(window);

            Credits credits = new Credits(game);
            Application.Run(credits);

            //Thread th = Thread.CurrentThread;
        }
    }
}