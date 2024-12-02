namespace Pedidos_Cafeteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            btnProcesar = new Button();
            dgvPedidos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre_Pedido = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            BtnRegistrar = new Button();
            txtCantidad = new TextBox();
            label2 = new Label();
            txtNombrePedido = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProcesar);
            panel2.Controls.Add(dgvPedidos);
            panel2.Location = new Point(66, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 209);
            panel2.TabIndex = 1;
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.Azure;
            btnProcesar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProcesar.Location = new Point(130, 10);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 32);
            btnProcesar.TabIndex = 2;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = false;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre_Pedido, Cantidad });
            dgvPedidos.Location = new Point(0, 48);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(346, 158);
            dgvPedidos.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre_Pedido
            // 
            Nombre_Pedido.HeaderText = "Nombre_Pedido";
            Nombre_Pedido.Name = "Nombre_Pedido";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(BtnRegistrar);
            panel3.Controls.Add(txtCantidad);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtNombrePedido);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 192);
            panel3.TabIndex = 1;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.LimeGreen;
            BtnRegistrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnRegistrar.Location = new Point(269, 148);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(75, 31);
            BtnRegistrar.TabIndex = 4;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(36, 110);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(281, 23);
            txtCantidad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 84);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            // 
            // txtNombrePedido
            // 
            txtNombrePedido.Location = new Point(33, 43);
            txtNombrePedido.Name = "txtNombrePedido";
            txtNombrePedido.Size = new Size(284, 23);
            txtNombrePedido.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 16);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Pedido:";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(63, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 195);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Pedidos Cafeteria";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Button BtnRegistrar;
        private TextBox txtCantidad;
        private Label label2;
        private TextBox txtNombrePedido;
        private Label label1;
        private Panel panel1;
        private Button btnProcesar;
        private DataGridView dgvPedidos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre_Pedido;
        private DataGridViewTextBoxColumn Cantidad;
    }
}
