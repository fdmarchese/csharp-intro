using System;

namespace chsarp_intro._3_Clases_de_Usuario
{
    public static class Clases
    {
        /// <summary>
        /// Una clase es una receta o molde para fabricar un objeto.
        /// La clase posee un identificación única, la definición de 
        /// cada atributo que compone el estado interno de cada objeto y 
        /// el comportamiento que éstos tendrán.
        /// </summary>
        public static void ClasesDeUsuario()
        {
            // podemos instanciar un objeto del tipo Auto de la siguiente forma
            Auto auto = new Auto("renault");

            // podemos acceder a las propiedades públicas del objeto y obtener o asignar datos
            Console.WriteLine($"la {nameof(Auto.Marca)} del auto '{nameof(auto)}' es {auto.Marca}"); // marca es de solo lectura, no puede ser modificado.

            auto.Color = "negro"; // color es de lecto escritura => puede leerse y escribirse.
            Console.WriteLine($"el {nameof(Auto.Color)} del auto '{nameof(auto)}' es {auto.Color}");

            auto.CantidadDePuertas = 4; // CantidadDePuertas es de lecto escritura => puede leerse y escribirse.
            Console.WriteLine($"la {nameof(Auto.CantidadDePuertas)} del auto '{nameof(auto)}' es {auto.CantidadDePuertas}");

            // la fecha de creación es de lectura y se asigna automáticamente cuando se crea un objeto de tipo Auto.
            Console.WriteLine($"la {nameof(Auto.FechaDeCreacion)} del auto '{nameof(auto)}' es {auto.FechaDeCreacion:dd-MM-yyyy hh:mm:ss}");

            Console.WriteLine($"Ejecutamos el método '{nameof(Auto.AddRueda)}' del objeto auto");
            auto.AddRueda(new Rueda { Marca = "Firestone", Rodado = 175 });
            auto.AddRueda(new Rueda { Marca = "Firestone", Rodado = 175 });

            Console.WriteLine("El auto posee las siguientes ruedas:");

            foreach(var rueda in auto.Ruedas) // itera por cada elemento de la colección y la variable rueda apunta al elemento actual de la iteración
            {
                Console.WriteLine($"Una rueda {nameof(Rueda.Marca)} '{rueda.Marca}' y es {nameof(Rueda.Rodado)} '{rueda.Rodado}'");
            }
        }

        /// <summary>
        /// Como se vio en <see cref="_1_Tipos_de_datos.Tipos.Jerarquia"/>, todos los 
        /// tipos derivan, en algún punto, del tipo object.
        /// </summary>
        public static void MetodosDelTipoObject()
        {
            // Object provee a todos los tipos de 3 métodos que pueden sobreescribirse a conveniencia:
            // - GetHashCode()
            // - Equals(object)
            // - ToString()

            Console.WriteLine("Creamos 3 casas:");
            Casa casa1 = new Casa() { Calle = "Callao", Altura = 2600 };
            Console.WriteLine(casa1.ToString());
            Casa casa2 = new Casa() { Calle = "Corrientes", Altura = 9290 };
            Console.WriteLine(casa2.ToString());
            Casa casa3 = new Casa() { Calle = "Callao", Altura = 2600 };
            Console.WriteLine(casa3.ToString());

            Console.WriteLine($"El resultado de casa1.Equals(casa2) es: {casa1.Equals(casa2)}");
            Console.WriteLine($"El resultado de casa1.Equals(casa3) es: {casa1.Equals(casa3)}");

            Console.WriteLine($"El resultado de casa1 == casa2 es: {casa1 == casa2}");
            Console.WriteLine($"El resultado de casa1 == casa3 es: {casa1 == casa3}");
        }
    }
}
