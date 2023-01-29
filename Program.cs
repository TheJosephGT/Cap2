internal class Program
{

    /*
    1 Hacer un programa que calcule el
    perímetro de cualquier polígono regular.

    3.Hacer un programa que transforme de
    grados a radianes.

    4.Hacer un programa que transforme de
    grados centígrados a grados Fahrenheit.

    5.Hacer un programa que transforme entre
    dólares y euros y que también pida el tipo
    de cambio del día.
    
    
    */
    private static void Main(string[] args)
    {

        //1

        float num_lados, medida_lado, perimetro;

        System.Console.Write("Ingrese el numero de lados: ");
        num_lados = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Ingrese la medida de los lados: ");
        medida_lado = Convert.ToInt32(Console.ReadLine());

        perimetro = num_lados * medida_lado;

        System.Console.WriteLine($"El perimetro es: {perimetro}");


        //3

        double grados, rad;


        System.Console.Write("Ingrese los grados:");
        grados = Convert.ToInt32(Console.ReadLine());

        rad = grados * (3.14/180);

        System.Console.WriteLine($"El resultado de radianes: {rad}");

        //4

        double cel;

        System.Console.Write("Ingrese los celsius: ");
        cel = Convert.ToInt32(Console.ReadLine());

        cel = cel * 1.8;
        cel = cel + 32;

        System.Console.WriteLine($"El valor en fahrenheit es: {cel}");

        //5

        double cambio;

        System.Console.WriteLine("1. Dolares a euros\n2. Euros a dolares");

        System.Console.Write("Ingrese la opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        if(opcion == 1)
        {
            System.Console.Write($"Ingrese la cantidad de dolares: ");
            cambio = Convert.ToInt32(Console.ReadLine());

            cambio = cambio * 0.92;

            System.Console.WriteLine($"La cantidad en euros es: {cambio}");
        }

        if(opcion == 2)
        {
            System.Console.Write($"Ingrese la cantidad de euros: ");
            cambio = Convert.ToInt32(Console.ReadLine());

            cambio = cambio * 1.09;

            System.Console.WriteLine($"La cantidad en dolares es: {cambio}");
        }

    }
}