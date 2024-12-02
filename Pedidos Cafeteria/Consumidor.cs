using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos_Cafeteria
{
    public class Consumidor
    {
        private Cola<Pedidos> _cola;
        public Consumidor(Cola<Pedidos> cola)
        {
            _cola = cola;
        }

        public Pedidos Consumir()
        {
            Pedidos pedidos = _cola.Extraer();
            Thread.Sleep(5000);
            return pedidos;
        }
    }
}
