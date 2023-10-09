using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

internal abstract class Figura
{
  protected Color _color;

  public abstract double GetArea();

  public static void Main(string[]args){
        Rectangulo r1 = new(5, 3);
  }

}