using chsarp_intro._1_Tipos_de_datos;
using System;
using System.Collections.Generic;

namespace chsarp_intro
{
    public static class Dispatcher
    {
        private static readonly IDictionary<Opcion, Action> _acciones = new Dictionary<Opcion, Action>
        {
            { Opcion.Tipos_de_valor, Tipos.DeValor },
            { Opcion.Tipos_de_referencia, Tipos.DeReferencia },
            { Opcion.Jerarquia_de_tipos, Tipos.Jerarquia },
            { Opcion.Nulables, Tipos.Nulables },
            { Opcion.Enteros, Numericos.Enteros },
            { Opcion.Decimales, Numericos.Decimales },
            { Opcion.Fechas, Fechas.Ejemplo },
            { Opcion.Tipos_anonimos, Tipos.Anonimos },
            { Opcion.Genericos, Generics.Genericos }
        };

        public static void Execute(Opcion opcion)
        {
            _acciones.TryGetValue(opcion, out Action action);
            action?.Invoke();
        }
    }
}
