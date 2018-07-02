using System;

namespace Shapes
{
  public class Rectangle
  {
    private int _length;
    private int _width;

    public Rectangle(int sideLength, int sideWidth)
    {
      _length = sideLength;
      _width = sideWidth;
    }

    public int GetLength()
    {
      return _length;
    }
    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    public int GetWidth()
    {
      return _width;
    }
    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetArea()
    {
      return _length * _width;
    }

    public bool IsSquare()
    {
      if(_length == _width)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}

class Rectangle
{
  public int Length;
  public int Width;

  public bool IsSquare()
  {
    if (Length == Width)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public int GetArea()
  {
   return Length * Width;
  }
}


public class Program
{
  public static void Main()
  {
    Rectangle myRectangle = new Rectangle();

    Console.WriteLine("Enter the length: ");
    string stringLength = Console.ReadLine();
    int myLength = int.Parse(stringLength);
    myRectangle.Length = myLength;

    Console.WriteLine("Enter the width: ");
    string stringWidth = Console.ReadLine();
    int myWidth = int.Parse(stringWidth);
    myRectangle.Width = myWidth;

    if (myRectangle.IsSquare())
    {
      Console.WriteLine("Congratulations! You made a square!");
    }
    else
    {
      Console.WriteLine("Sorry! This isn't a square.");
    }

    Console.WriteLine("The area of your rectangle is " + myRectangle.GetArea());
  }
}
