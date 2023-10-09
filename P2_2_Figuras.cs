//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Diagnostics.Metrics;
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{

    static void Main(string[] args)
    {
        #region Variables
        //Declaramos una lista de figuras para poder almacenar las diferentes figuras
        List<Figura> listaFiguras = new List<Figura>();
        Figura circulo = new Circulo(2.0, color: Color.Aqua);
        Figura rectangulo = new Rectangulo(3.9, 3, color: Color.FromArgb(50, 20, 34));
        Figura triangulo = new Triangulo(2, 2, Color.Black);
        Figura circulo2 = new Circulo(9.0, color: Color.Gray);
        Figura rectangulo2 = new Rectangulo(4, 4, color: Color.Aqua);
        Figura triangulo2 = new Triangulo(8, 9, Color.FromArgb(69,69,69,69));
        listaFiguras.Add(circulo);
        listaFiguras.Add(rectangulo);
        listaFiguras.Add(triangulo);
        listaFiguras.Add(rectangulo2);
        listaFiguras.Add(circulo2);
        listaFiguras.Add(triangulo2);
        bool terminado = false;
        bool terminado2parte = false;
        string info = "PRIMERA PARTE\n__________\n";
        #endregion

        #region Operaciones
        Console.WriteLine(info);
        foreach (Figura figura in listaFiguras)
        {


           
                switch (figura)
                {
                    case Rectangulo _:

                    info = $"{(Rectangulo)figura}";
                        Console.WriteLine(info);
                        break;

                    case Circulo _:
                        info = $"{(Circulo)figura}";
                        Console.WriteLine(info);
                        break;

                    case Triangulo _:
                        info = $"{(Triangulo)figura}";
                    Console.WriteLine(info);
                        break;
                }
                terminado = true;
            



          





        }

        if (terminado == true)
        {
             info = "SEGUNDA PARTE\n__________";
            Console.WriteLine(info + "\n");
            foreach (Figura figura in listaFiguras)
            {
                figura.Color = Color.FromArgb(245, 40, 15, 200);
               
                

                switch (figura)
                {
                    case Circulo:
                        info = $"{(Circulo)figura}";

                        Console.WriteLine(info);
                        break;

                    case Rectangulo:
                        info = $"{(Rectangulo)figura}";
                        Console.WriteLine(info);
                        break;

                    case Triangulo:
                        info = $"{(Triangulo)figura}";
                        Console.WriteLine(info);
                        break;


                }

                




            }
            terminado2parte = true;
        }
        if (terminado == true && terminado2parte == true)
        {
            double areac = 0.0;
            double arear = 0.0;
            double areat = 0.0;
             info = "TERCERA PARTE";
            Console.WriteLine(info + "\n");
            foreach (Figura figura in listaFiguras)
            {
              
               

               

                switch (figura)
                {
                    case Circulo:
                        var a = (Circulo)figura;
                        areac += a.GetArea();


                        break;

                    case Rectangulo:
                        var b = (Rectangulo)figura;
                        areac += b.GetArea();
                        break;

                    case Triangulo:
                        var c = (Triangulo)figura;
                        areac += c.GetArea();
                        break;


                }






            }
            var areatotal = areac + arear + areat;
            Console.WriteLine($"Area Total:{areatotal}");
        }

    }

    #endregion


}

