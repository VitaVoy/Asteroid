using System;
using System.Windows.Forms;
using System.Drawing;

namespace Asteroid
{
    static class AsteroidView
    {
        public static void GameScreen()
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 600;
            Game.Init(form);
            form.Show();
            Game.Draw();            
        }

        public static void StartScreen()
        {
            Form form = new Form();            

            Button btnStart = new Button
            {
                Text = "Game Start",
                Location = new Point(300, 100),
                Width = 200,
                Height = 50,
                Name = "btnStart"
            };           

            btnStart.Click += new EventHandler(Buttons.BtnStartClick);

            form.Controls.Add(btnStart);

            Button btnExit = new Button
            {
                Text = "Exit",
                Location = new Point(300, 200),
                Width = 200,
                Height = 50,
                Name = "btnExit"
            };

            btnExit.Click += new EventHandler(Buttons.BtnExitClick);

            form.Controls.Add(btnExit);

            form.Width = 800;
            form.Height = 600;
            form.Show();
            Application.Run();
        }
    }

}
