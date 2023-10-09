
using System.Drawing;

namespace P2_2_Figuras;
abstract class Circulo : Figura{
private int _radio {get;set;}
public Circulo (int radio, Color color){
    _color = color;
    _radio = radio;
   
        
}
    public override double GetArea()
    {
      return Math.PI * Math.Pow(_radio, 2);
      
    }
}
