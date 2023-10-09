using System.Drawing;

namespace P2_2_Figuras;
internal class Triangulo : Figura{
    
    private double _b;
    private double _h;
  
     public Triangulo (double b , double h, Color color){
       _color  =color;
       _b = b;
       _h = h;

       
     }
    public override double GetArea()
    {
      return (_b * _h)/2;
    }
    public override string ToString()
    {
        return $"base {_b} altura:{_h} Area: {GetArea()} Color:{_color}";
    }



}