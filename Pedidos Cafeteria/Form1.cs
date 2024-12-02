namespace Pedidos_Cafeteria
{
    public partial class Form1 : Form
    {
        private int contadorId = 1;
        private Cola<Pedidos> colaPedidos;
        private Productor productor;
        private Consumidor consumidor;
        public Form1()
        {
            InitializeComponent();
            colaPedidos = new Cola<Pedidos>(10);
            productor = new Productor(colaPedidos);
            consumidor = new Consumidor(colaPedidos);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Pedidos nuevoPedido = new Pedidos(
               contadorId++,
               txtNombrePedido.Text,
               txtCantidad.Text
               );

            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaPedidos.Agregar(nuevoPedido);

                }
                );
            txtNombrePedido.Clear();
            txtCantidad.Clear();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarPedidos);
            hiloConsumidor.Start();
        }

        private void ProcesarPedidos()
        {
            Pedidos pedidos = colaPedidos.Extraer();
            AgregarPedidosADataGrid(pedidos);
        }

        private void AgregarPedidosADataGrid(Pedidos pedidos)
        {
            if (dgvPedidos.InvokeRequired)
            {
                dgvPedidos.Invoke(new Action(() =>
                {
                    dgvPedidos.Rows.Add(
                        pedidos.Id,
                        pedidos.Nombre_Pedido,
                        pedidos.Cantidad
                        );
                })
                );
            }
            else 
            {
                dgvPedidos.Rows.Add(
                        pedidos.Id,
                        pedidos.Nombre_Pedido,
                        pedidos.Cantidad
                        );
            }
        } 
    }
}
