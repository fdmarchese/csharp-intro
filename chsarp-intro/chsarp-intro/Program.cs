using System;

namespace chsarp_intro
{
    public class Program
    {
        public static void Main()
        {
            Opcion opcion;
            do
            {
                ImprimirMenu();

                int.TryParse(Console.ReadLine(), out int seleccion);
                opcion = seleccion != 0 ? 
                    (Opcion)seleccion : 
                    Opcion.Void;

                Console.Clear();

                Dispatcher.Execute(opcion);

                Console.WriteLine();
                Console.WriteLine("Desea ejecutar otra acción? S/N");

                opcion = char.ToUpper(Console.ReadKey().KeyChar) == 'N' ? 
                    Opcion.Salir : 
                    opcion;
            }
            while (opcion != Opcion.Salir);
        }

        private static void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("Menú");
            Console.WriteLine("Elegir qué desea mostrar:");
            foreach (var opcion in Enum.GetValues(typeof(Opcion)))
            {
                Console.WriteLine($"{(int)opcion} - {opcion.ToString().Replace("_", " ")}");
            }
        }
    }
}
