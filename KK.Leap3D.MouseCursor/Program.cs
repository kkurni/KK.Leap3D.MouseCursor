using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leap;

namespace KK.Leap3D.MouseCursor
{
    class Program
    {
        public static void Main()
        {
            // Create a sample listener and controller
            var listener = new LeapListener();
            var controller = new Controller();

            // Have the sample listener receive events from the controller
            controller.AddListener(listener);

            // Keep this process running until Enter is pressed
            Console.WriteLine("Press Enter to quit...");
            Console.ReadLine();

            // Remove the sample listener when done
            controller.RemoveListener(listener);
            controller.Dispose();
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
