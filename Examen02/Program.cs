// See https://aka.ms/new-console-template for more information



using Examen02.Clases;

GestorPedidos pedidoElectreonico1 = new GestorPedidos(new ProveedoresElectronicos(), new Pedido { idPedido = 1, descripcion="Laptop", cantidad=2});
GestorPedidos pedidoElectreonico2 = new GestorPedidos(new ProveedoresElectronicos(), new Pedido { idPedido = 2, descripcion = "Lavadora", cantidad = 5 });

GestorPedidos pedidoRopa1 = new GestorPedidos(new ProveedoresRopa(), new Pedido { idPedido = 3, descripcion = "Casaca Cuero LaCost", cantidad = 150 });
GestorPedidos pedidoRopa2 = new GestorPedidos(new ProveedoresRopa(), new Pedido { idPedido = 4, descripcion = "Zapatillas Coleccion thundercats Puma", cantidad = 20 });

pedidoElectreonico1.EnviarPedidosTipoProducto();
pedidoElectreonico2.EnviarPedidosTipoProducto();
pedidoRopa1.EnviarPedidosTipoProducto();
pedidoRopa2.EnviarPedidosTipoProducto();