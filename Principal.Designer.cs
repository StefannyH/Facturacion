
namespace Facturacion_Electronica
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistroProductos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacturaVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(58, 26);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(188, 167);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registro Clientes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistroProductos
            // 
            this.btnRegistroProductos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistroProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroProductos.Image")));
            this.btnRegistroProductos.Location = new System.Drawing.Point(58, 214);
            this.btnRegistroProductos.Name = "btnRegistroProductos";
            this.btnRegistroProductos.Size = new System.Drawing.Size(188, 149);
            this.btnRegistroProductos.TabIndex = 1;
            this.btnRegistroProductos.Text = "Registro Productos";
            this.btnRegistroProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistroProductos.UseVisualStyleBackColor = true;
            this.btnRegistroProductos.Click += new System.EventHandler(this.btnRegistroProductos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(280, 214);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(191, 149);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFacturaVenta
            // 
            this.btnFacturaVenta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFacturaVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturaVenta.Image")));
            this.btnFacturaVenta.Location = new System.Drawing.Point(280, 26);
            this.btnFacturaVenta.Name = "btnFacturaVenta";
            this.btnFacturaVenta.Size = new System.Drawing.Size(191, 167);
            this.btnFacturaVenta.TabIndex = 3;
            this.btnFacturaVenta.Text = "Fatura De Venta";
            this.btnFacturaVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacturaVenta.UseVisualStyleBackColor = true;
            this.btnFacturaVenta.Click += new System.EventHandler(this.btnFacturaVenta_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 380);
            this.Controls.Add(this.btnFacturaVenta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistroProductos);
            this.Controls.Add(this.button1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button btnRegistroProductos;
        private Button btnSalir;
        private Button btnFacturaVenta;
    }
}