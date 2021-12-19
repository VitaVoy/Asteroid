using System.Drawing;

namespace Asteroid
{
    class Star : BaseObject
    {        
        static Image _imageStar { get; } = Image.FromFile("Images/Star.png");
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        public override void Draw()
        {
            //Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X, Pos.Y,
            //Pos.X + Size.Width, Pos.Y + Size.Height);
            Game.Buffer.Graphics.DrawImage(_imageStar, Pos);
        }

        public override void Update()
        {
            Pos.X -= Dir.X;
            if (Pos.X < 0)
                Pos.X = Game.Width + Size.Width;
        }
    }

}
