namespace AlgoNuevo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int suma;
            int producto;

            CalcularSumaYProducto(a, b, out suma, out producto);

            Console.WriteLine("La suma de {0} y {1} es: {2}", a, b, suma);
            Console.WriteLine("El producto de {0} y {1} es: {2}", a, b, producto);
        }

        static void CalcularSumaYProducto(int x, int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
        }

    }
}
