namespace edu.ejercicio.siete.nrojlla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 10, 45, 60, 6, 7, 3, 2, 10 };
            int longitud = numeros.Length;
            Console.WriteLine(longitud);
            Console.WriteLine("--------");

            int primera = numeros[0];
            int penultima = numeros.Length - 2;
            int ultima = numeros.Length - 1;
            Console.WriteLine(primera);
            Console.WriteLine(penultima);
            Console.WriteLine(ultima);
            Console.WriteLine("--------");

            Array.Sort(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------");

            numeros.SetValue(100, ultima);

            Array.Reverse(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            int[] cantidad = { 45, 56, 2, -1, 98, 34 };
            int extension = cantidad.Length;

            int cantidadPrimera = cantidad[0];
            int cantidadPenultima = cantidad.Length - 2;
            int cantidadUltima = cantidad.Length - 1;

        }
    }
}
