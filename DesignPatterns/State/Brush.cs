using System;
namespace State
{
    public class Brush : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush Tool Down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Brush Tool Down");
        }
    }
}
