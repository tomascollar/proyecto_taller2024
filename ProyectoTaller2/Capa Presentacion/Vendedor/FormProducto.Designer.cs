namespace ProyectoTaller2
{
    partial class FormProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregarCarrito = new FontAwesome.Sharp.IconButton();
            this.btnBuscarProd = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(310, 45);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(198, 26);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarrito.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAgregarCarrito.IconColor = System.Drawing.Color.White;
            this.btnAgregarCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCarrito.IconSize = 30;
            this.btnAgregarCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(658, 102);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(110, 46);
            this.btnAgregarCarrito.TabIndex = 6;
            this.btnAgregarCarrito.Text = "Agregar al carrito";
            this.btnAgregarCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.White;
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.btnBuscarProd.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProd.IconSize = 20;
            this.btnBuscarProd.Location = new System.Drawing.Point(365, 77);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(96, 28);
            this.btnBuscarProd.TabIndex = 7;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 266);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(780, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnAgregarCarrito;
        private FontAwesome.Sharp.IconButton btnBuscarProd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}