
namespace P2_2_Figuras;
abstract class Circulo : Figura{
private int _radio {get;set;}
public Circulo (int radio){
    radio  = _radio;
    double area  = Math.PI * Math.Pow(radio, 2);
        
}
}