using System.Drawing;

namespace P2_2_Figuras;
internal class Triangulo : Figura{


    #region CTOR
    //Constructor por defecto
    public Triangulo (double b , double h, Color color){
       Color  =color;
       Base = b;
       Altura = h;

       
     }
    #endregion

    #region Metodos
    /*
    * Método para calcular el área del triángulo.
    *
    * @returns El área del triángulo como un valor double.
    */
    public override double GetArea()
    {
      return Math.Round((Base * Altura)/2);
    }

     //Metodo ToString
    public override string ToString()
    {
        return $"Figura TRIANGULO\nAlto: {Altura}\nAncho: {Base}\nColor:[ A:{Color.A},R:{Color.R},G:{Color.G} ,B:{Color.B}]\nArea: {GetArea()}\n____________";
    }
    #endregion



}