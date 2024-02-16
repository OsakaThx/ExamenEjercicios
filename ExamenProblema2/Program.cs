namespace ExamenProblema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double examen1 = 0;
            double examen2 = 0;
            Console.WriteLine("Ingrese la nota del examen 1:");
            if (double.TryParse(Console.ReadLine(), out examen1))
            {
                Console.WriteLine($"La nota del examen 1 es: {examen1}");
            }
            else
            {
                Console.WriteLine("Ingrese un valor numérico válido para la nota del examen 1.");
            }

            Console.WriteLine("Ingrese la nota del examen 2:");
            if (double.TryParse(Console.ReadLine(), out examen2))
            {
                Console.WriteLine($"La nota del examen 2 es: {examen2}");
            }
            else
            {
                Console.WriteLine("Ingrese un valor numérico válido para la nota del examen 2.");
                return; 
            }


            double promedio = (examen1 + examen2) / 2;
            Console.WriteLine($"El promedio de las notas es: {promedio}");

        }
    }
}
