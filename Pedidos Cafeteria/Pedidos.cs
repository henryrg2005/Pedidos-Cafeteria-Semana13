using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pedidos_Cafeteria
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string Nombre_Pedido { get; set; }
        public string Cantidad { get; set; }

        public Pedidos(int id, string nombre_pedido, string cantidad)
        {
            Id = id;
            Nombre_Pedido = nombre_pedido;
            Cantidad = cantidad;

        }

        public override string ToString()
        {
            return $"Id:{Id},Nombre_Pedido:{Nombre_Pedido},Cantidad:{Cantidad}";
        }

    }
}
