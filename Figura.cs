using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

internal abstract class Figura
{

    #region Propiedades
    public Color Color { get;  set; }

    public double Radio { get; internal set; }

    public double Base { get; internal set; }

    public double Altura { get; internal set; }

    #endregion

    #region Metodos
    public abstract double GetArea();

    public override string ToString()
    {
        return base.ToString();
    }
    #endregion
}