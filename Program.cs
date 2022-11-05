//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello World!");
//    }
//}

//namespace Paint___Yvan_Luna_Kalalo
//{
//    public class Canvas
//    {
//        string _currentTool;

//        public void setCurrentTool(string tool)
//        {
//            this._currentTool = tool;
//        }

//        public void mouseOver()
//        {
//            if (_currentTool == "pencil")
//            {
//                Console.WriteLine("Show pencil icon");
//            }
//            else if (_currentTool == "square")
//            {
//                Console.WriteLine("Show square icon");
//            }
//            else if (_currentTool == "eraser")
//            {
//                Console.WriteLine("Show an eraser icon");
//            }
//        }

//        public void mouseUp()
//        {
//            if (_currentTool == "pencil")
//            {
//                Console.WriteLine("Draw a line.");
//            }
//            else if (_currentTool == "square")
//            {
//                Console.WriteLine("Draw a square.");
//            }
//            else if (_currentTool == "eraser")
//            {
//                Console.WriteLine("Erase the selected object.");
//            }
//        }
//    }

//}

using System;

namespace Paint___Yvan_Luna_Kalalo
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

}

public interface IPaintTool
{
    void MouseOver();
    void MouseUp();
}

public class PencilTool : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show pencil icon.");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw a line.");

    }
}

public class ShapeTool : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show square icon.");

    }

    public void MouseUp()
    {
        Console.WriteLine("Draw a square.");

    }
}

public class EraserTool : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show an eraser icon.");

    }

    public void MouseUp()
    {
        Console.WriteLine("Erase the selected object.");
    }
}
