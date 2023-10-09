
using System.Drawing;

namespace P2_2_Figuras;
 internal class Circulo : Figura{
private double _radio {get;set;}
public Circulo (double radio, Color color){
    _color = color;
    _radio = radio;
   
        
}

    public Circulo()
    {
    }

    public override double GetArea()
    {
      return Math.PI * Math.Pow(_radio, 2);

    }
    public override string ToString()
    {
        return $"Círculo de radio {_radio}, Área: {GetArea()}, Color: {_color}";
    }
}
