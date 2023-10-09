//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  
  static void Main(string[] args)
  {
      Figura circulo = new Circulo(2.0,color:Color.Aqua);
      Figura rectangulo  = new Rectangulo(3.9, 3,color:Color.FromArgb(50,20,34));

      Console.WriteLine(circulo);
      Console.WriteLine(rectangulo);
  }

}