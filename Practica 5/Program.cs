// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Hacer un programa que lea nombre cantidad y precio de 5 productos el progrma mostrara al finalizar , el porcentaje de
//IVA y el TOTAL  a PAGAR 


namespace EjemploProgramaProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            const double IVA = 0.16;
            string[] nombres = new string[5];
            int[] cantidades = new int[5];
            double[] precios = new double[5];
            double subTotal = 0;

            Console.WriteLine("Introduce los datos de los 5 productos:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Producto " + (i + 1) + ":");
                Console.Write("Nombre: ");
                nombres[i] = (Console.ReadLine());
                Console.Write("Cantidad: ");
                cantidades[i] = int.Parse(Console.ReadLine());
                Console.Write("Precio: ");
                precios[i] = double.Parse(Console.ReadLine());
                subTotal += cantidades[i] * precios[i];
            }

            double iva = subTotal * IVA;
            double total = subTotal + iva;

            Console.WriteLine("\nResumen:");
            Console.WriteLine("Porcentaje de IVA: " + IVA * 100 + "%");
            Console.WriteLine("Total a pagar: $" + total);
        }
    }
}