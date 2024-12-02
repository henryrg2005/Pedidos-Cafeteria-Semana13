using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos_Cafeteria
{
    public class Productor
    {
        private Cola <Pedidos> _cola;

        public Productor(Cola<Pedidos> cola)
        {
            _cola = cola;
        }

        public void Producir(Pedidos item)
        {
            _cola.Agregar(item);
            Thread.Sleep(2000);
        }
    }
}
