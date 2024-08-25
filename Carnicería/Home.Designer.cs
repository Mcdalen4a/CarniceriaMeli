namespace Carnicería
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Proveedores = new System.Windows.Forms.Button();
            this.Pedidos = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.Stock = new System.Windows.Forms.Button();
            this.Precios = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.MELI = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Proveedores
            // 
            this.Proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Proveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proveedores.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedores.ForeColor = System.Drawing.Color.White;
            this.Proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Proveedores.Image")));
            this.Proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Proveedores.Location = new System.Drawing.Point(-3, 210);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Proveedores.Size = new System.Drawing.Size(236, 55);
            this.Proveedores.TabIndex = 5;
            this.Proveedores.Text = "          Proveedores ";
            this.Proveedores.UseVisualStyleBackColor = false;
            this.Proveedores.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // Pedidos
            // 
            this.Pedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Pedidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pedidos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pedidos.ForeColor = System.Drawing.Color.White;
            this.Pedidos.Image = ((System.Drawing.Image)(resources.GetObject("Pedidos.Image")));
            this.Pedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pedidos.Location = new System.Drawing.Point(-3, 149);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Pedidos.Size = new System.Drawing.Size(239, 55);
            this.Pedidos.TabIndex = 0;
            this.Pedidos.Text = "Pedidos";
            this.Pedidos.UseVisualStyleBackColor = false;
            this.Pedidos.Click += new System.EventHandler(this.Pedidos_Click);
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Menu.Controls.Add(this.Stock);
            this.Menu.Controls.Add(this.Precios);
            this.Menu.Controls.Add(this.Clientes);
            this.Menu.Controls.Add(this.Home);
            this.Menu.Controls.Add(this.Pedidos);
            this.Menu.Controls.Add(this.Proveedores);
            this.Menu.Location = new System.Drawing.Point(0, -2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(228, 536);
            this.Menu.TabIndex = 6;
            // 
            // Stock
            // 
            this.Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Stock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stock.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.ForeColor = System.Drawing.Color.White;
            this.Stock.Image = ((System.Drawing.Image)(resources.GetObject("Stock.Image")));
            this.Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stock.Location = new System.Drawing.Point(-3, 385);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Stock.Size = new System.Drawing.Size(236, 55);
            this.Stock.TabIndex = 9;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = false;
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // Precios
            // 
            this.Precios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Precios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Precios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Precios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precios.ForeColor = System.Drawing.Color.White;
            this.Precios.Image = ((System.Drawing.Image)(resources.GetObject("Precios.Image")));
            this.Precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Precios.Location = new System.Drawing.Point(-3, 332);
            this.Precios.Name = "Precios";
            this.Precios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Precios.Size = new System.Drawing.Size(236, 55);
            this.Precios.TabIndex = 8;
            this.Precios.Text = " Precios";
            this.Precios.UseVisualStyleBackColor = false;
            this.Precios.Click += new System.EventHandler(this.Precios_Click);
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Clientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.Color.White;
            this.Clientes.Image = ((System.Drawing.Image)(resources.GetObject("Clientes.Image")));
            this.Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.Location = new System.Drawing.Point(-3, 271);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Clientes.Size = new System.Drawing.Size(236, 55);
            this.Clientes.TabIndex = 7;
            this.Clientes.Text = " Clientes";
            this.Clientes.UseVisualStyleBackColor = false;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(-3, 88);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Home.Size = new System.Drawing.Size(236, 55);
            this.Home.TabIndex = 6;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.Controls.Add(this.MELI);
            this.pnlContenedor.Location = new System.Drawing.Point(255, 41);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(651, 397);
            this.pnlContenedor.TabIndex = 7;
            // 
            // MELI
            // 
            this.MELI.AutoSize = true;
            this.MELI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.MELI.Font = new System.Drawing.Font("Century Gothic", 60.8F, System.Drawing.FontStyle.Bold);
            this.MELI.ForeColor = System.Drawing.Color.White;
            this.MELI.Location = new System.Drawing.Point(185, 130);
            this.MELI.Name = "MELI";
            this.MELI.Size = new System.Drawing.Size(271, 121);
            this.MELI.TabIndex = 0;
            this.MELI.Text = "MELI";
            this.MELI.Click += new System.EventHandler(this.MELI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(930, 528);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Carnicería";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Button Proveedores;
        private System.Windows.Forms.Button Pedidos;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Precios;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label MELI;
    }
}

