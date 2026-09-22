using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("Aqui tiene que insertar la figura");
            string? figura = Console.ReadLine(); //aqui va el nombre de la figura que el usuario quiere calcular el area

            if (figura != "Círculo" && figura != "Circulo" && figura != "círculo" && figura != "circulo" && figura != "Cuadrado" && figura != "cuadrado" && figura != "Rectángulo" && figura != "rectángulo" && figura != "Rectangulo" && figura != "rectangulo" && figura != "Rombo" && figura != "rombo")
            {
                Console.WriteLine("Por favor ingrese una figura válida");
                continue;
            }

            if (figura == "Círculo" || figura == "Circulo" || figura == "círculo" || figura == "circulo")
            {
                Console.WriteLine("Por favor ingrese la medida del radio");
                string? medida = Console.ReadLine();

                //control de que efectivamente se ingresen números
                if (!double.TryParse(medida, out double medidaRadio))
                {
                    Console.WriteLine("Favor de indicar NÚMEROS");
                    continue;
                }
                if (medidaRadio <= 0)
                {
                    Console.WriteLine("Favor de indicar un NÚMERO positivo");
                    continue;
                }
                double areacirculo = areaCirculo(medidaRadio);

                Console.WriteLine($"El area del círculo es {areacirculo}");
            }



            if (figura == "Cuadrado" || figura == "cuadrado")
            {

                Console.WriteLine("Por favor ingrese la medida de uno de los lados");
                string? medida = Console.ReadLine();

                //control de que efectivamente se ingresen números
                if (!double.TryParse(medida, out double medidaLado))
                {
                    Console.WriteLine("Favor de indicar NÚMEROS");
                    continue;
                }
                if (medidaLado <= 0)
                {
                    Console.WriteLine("Favor de indicar un NÚMERO positivo");
                    continue;
                }
                double areacuadrado = areaCuadrado(medidaLado);

                Console.WriteLine($"El area del cuadrado es {areacuadrado}");
            }


            if (figura == "Rectángulo" || figura == "rectángulo" || figura == "Rectangulo" || figura == "rectangulo")
            {
                Console.WriteLine("Por favor ingrese la medida de la altura");
                string? medida = Console.ReadLine();

                Console.WriteLine("Por favor ingrese la medida de la base");
                string? medida2 = Console.ReadLine();

                //control de que efectivamente se ingresen números
                if (!double.TryParse(medida, out double medidaAltura) || !double.TryParse(medida2, out double medidaBase))
                {
                    Console.WriteLine("Favor de indicar NÚMEROS");
                    continue;
                }

                if (medidaAltura <= 0 || medidaBase <= 0)
                {
                    Console.WriteLine("Favor de indicar NÚMEROS positivos");
                    continue;
                }

                double arearectangulo = areaRectangulo(medidaAltura, medidaBase);

                Console.WriteLine($"El area del reactángulo es {arearectangulo}");
            }


            if (figura == "Rombo" || figura == "rombo")
            {
                Console.WriteLine("Por favor ingrese la medida de la diagonal mayor");
                string? medida = Console.ReadLine();

                Console.WriteLine("Por favor ingrese la medida de la diagonal menor");
                string? medida2 = Console.ReadLine();

                //control de que efectivamente se ingresen números
                if (!double.TryParse(medida, out double medidaDiagonalMayor) || !double.TryParse(medida2, out double medidaDiagonalMenor))
                {
                    Console.WriteLine("Favor de indicar NÚMEROS");
                    continue;
                }

                if (medidaDiagonalMayor <= 0 || medidaDiagonalMenor <= 0)
                {
                    Console.WriteLine("Favor de indicar NÚMEROS positivos");
                    continue;
                }

                double arearombo = areaRombo(medidaDiagonalMayor, medidaDiagonalMenor);

                Console.WriteLine($"El area del rombo es {arearombo}");
            }

        }
    }

    public static double areaCirculo(double medidaRadio)
    {
        return 3.14 * (medidaRadio * medidaRadio);
    }

    public static double areaCuadrado(double medidaLado)
    {
        return medidaLado * medidaLado;
    }

    public static double areaRectangulo(double medidaAltura, double medidaBase)
    {
        return medidaAltura * medidaBase;
    }
    public static double areaRombo(double medidaDiagonalMayor, double medidaDiagonalMenor)
    {
        return (medidaDiagonalMayor * medidaDiagonalMenor) / 2;
    }
}
