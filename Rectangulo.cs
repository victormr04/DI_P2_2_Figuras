using System.Drawing;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace P2_2_Figuras;
internal class Rectangulo : Figura{
    #region CTOR
    //Constructor por defecto
    public Rectangulo(double b, double altura, Color color){
         Base =b;
        Altura = altura;
        Color = color;
        
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
        return Math.Round(Base * Altura);

    }
    //Metodo ToString
    public override string ToString()
    {
        return $"Figura RECTANGULO\nAlto: {Altura}\nAncho: {Base}\nColor: [A:{Color.A},R: {Color.R},G: {Color.G} ,B: {Color.B}]\nArea: {GetArea()}\n____________";
    }
    #endregion




}