using System;
using Mythonia.Game;

namespace Mythonia
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new GameMain())
                game.Run();
        }
    }
}
