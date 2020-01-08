using System;
namespace State
{
    public class Selection : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection Tool Down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Selection Tool Up");
        }
    }
}
