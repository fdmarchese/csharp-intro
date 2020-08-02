using System;

namespace chsarp_intro._5_Colecciones
{
    public class Producto
    {
        public Producto()
        {
        }

        public Producto(Guid codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public Guid Codigo { get; set; }
        public string Nombre { get; set; }

        public override string ToString() => $"Producto con código: {Codigo} y Nombre: {Nombre}";
    }
}
