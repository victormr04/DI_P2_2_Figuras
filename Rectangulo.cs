using System.Drawing;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace P2_2_Figuras;
abstract class Rectangulo : Figura{
    private int _base {get;set;}
    private int _altura { get; set;}
    public Rectangulo(int b, int altura, Color color){
         _base =b;
        _altura = altura;
        _color = color;
        
    }
    public override double GetArea()
    {
        return _base * _altura;

    }




}