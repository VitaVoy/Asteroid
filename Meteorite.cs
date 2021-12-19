using System.Drawing;

namespace Asteroid
{
    class Meteorite : BaseObject
    {
        static Image _meteorite { get; } = Image.FromFile("Images/Stoun.png");
        public Meteorite(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }
        public override void Draw()
        {            
            Game.Buffer.Graphics.DrawImage(_meteorite, Pos);
        }

        public override void Update()
        {
            Pos.X -= Dir.X;
            if (Pos.X < 0)
                Pos.X = Game.Width + Size.Width;
        }
    }
}
