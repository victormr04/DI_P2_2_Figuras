
using System.Drawing;

namespace P2_2_Figuras;
internal class Circulo : Figura
{
    #region CTOR
    //Constructor por defecto
    public Circulo(double radio, Color color)
    {
        Color = color;
        Radio = radio;


    }

    #endregion

    #region Metodos
    /*
    * Método para calcular el área del triángulo.
    *
    * @returns El área del rectangulo como un valor double.
    */
    public override double GetArea()
    {
        double area = Math.Round(Math.PI * Math.Pow(Radio, 2));
        return area;

    }
    public override string ToString()
    {
        return $"Figura CIRCULO\nRadio: {Radio}\nColor: [A:{Color.A},R: {Color.R},G: {Color.G} ,B: {Color.B}]\nArea: {GetArea()}\n____________";
    }
    #endregion
}
