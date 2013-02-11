using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK.Leap3D.MouseCursor
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveCursor();

        }

        private static void MoveCursor()
        {
            if (Cursor.Current != null)
            {
                var cursor = new Cursor(Cursor.Current.Handle);
            }
            Console.WriteLine("Move Cursor");
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y);
        }
    }
}
