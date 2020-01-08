using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas c = new Canvas
            {
                CurrentTool = new Selection()
            };
            c.MouseDown();
        }
    }
}
