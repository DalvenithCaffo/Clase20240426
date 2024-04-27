using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen02.Interfaces;

namespace Examen02.Clases
{
     class GestorPedidos
    {
        private readonly IProveedores _proveedores;
        private Pedido _pedido;

        public GestorPedidos(IProveedores proveedores, Pedido pedido)
        {
            _proveedores = proveedores;
            _pedido = pedido;
        }

        public void EnviarPedidosTipoProducto() { 
             _proveedores.EnviarPedido(_pedido);
        }
    }
}
