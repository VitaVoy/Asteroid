using System;
using System.Drawing;
using System.Windows.Forms;

namespace Asteroid
{
    static class Game
    {
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;

        public static BaseObject[] objects;

        static public Random random { get; } = new Random();

        public static int Width { get; set; }
        public static int Height { get; set; }

        static Image _background = Image.FromFile("Images/Space.png");

        static Game()
        {

        }

        public static void Init(Form form)
        {
            Graphics graphics;
            _context = BufferedGraphicsManager.Current;
            graphics = form.CreateGraphics();

            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;

            Buffer = _context.Allocate(graphics, new Rectangle(0, 0, Width, Height));
            Load();

            Timer timer = new Timer { Interval = 100 };
            timer.Start();
            timer.Tick += TimerTick;
        }

        public static void Draw()
        {
            //Buffer.Graphics.Clear(Color.Black);
            Buffer.Graphics.DrawImage(_background, Point.Empty);
            foreach (BaseObject obj in objects)
                obj.Draw();
            Buffer.Render();
        }

        public static void Load()
        {
            objects = new BaseObject[30];
            for (int i = 0; i < objects.Length / 2; i++)
            {
                int speed = random.Next(1, 10);
                int posY = random.Next(20, 580);
                objects[i] = new Meteorite(new Point(900, posY),
                    new Point(speed, posY), new Size(10, 10));
            }
            for (int i = 15; i < objects.Length; i++)
            {
                int speed = random.Next(5, 20);
                int posY = random.Next(20, 580);
                objects[i] = new Star(new Point(900, posY),
                    new Point(speed, posY), new Size(5, 5));
            }
        }

        public static void Update()
        {
            foreach (BaseObject obj in objects)
                obj.Update();
        }

        private static void TimerTick(object sender, EventArgs eventArgs)
        {
            Draw();
            Update();
        }
    }
}
