using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen02.Interfaces;

namespace Examen02.Clases
{
     class ProveedoresElectronicos : IProveedores
    {
        public void EnviarPedido (Pedido pedido) {
            Console.WriteLine($"Enviando productos electronicos...!{pedido.idPedido} - {pedido.descripcion} - {pedido.cantidad}");
        }
    }
}
