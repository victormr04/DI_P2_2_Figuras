using System.Drawing;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace P2_2_Figuras;
internal class Rectangulo : Figura{
    private double _base {get;set;}
    private double _altura { get; set;}
    public Rectangulo(double b, double altura, Color color){
         _base =b;
        _altura = altura;
        _color = color;
        
    }
    public override double GetArea()
    {
        return _base * _altura;

    }
    public override string ToString()
    {
        return $"base: {_base} altura: {_altura} Area: {GetArea()} color: {_color}";
    }





}