using System.Drawing;

namespace P2_2_Figuras;
abstract class Triangulo : Figura{
    
    private int _b;
    private int _h;
  
     public Triangulo (int b , int h, Color color){
       _color  =color;
       _b = b;
       _h = h;

       
     }
    public override double GetArea()
    {
      return (_b * _h)/2;
    }



}