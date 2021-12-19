using System;
using System.Windows.Forms;

namespace Asteroid
{
    class Buttons
    {
        public static void BtnStartClick(object sender, EventArgs e)
        {
            AsteroidView.GameScreen();
        }

        public static void BtnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
