namespace proyectoProductoPrgm
{
    partial class FormProductos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCarga = new System.Windows.Forms.TabPage();
            this.btnCarga = new System.Windows.Forms.Button();
            this.lblMuestraStock = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtbxDescripcion = new System.Windows.Forms.TextBox();
            this.txtbxCodigo = new System.Windows.Forms.TextBox();
            this.tabMovimientos = new System.Windows.Forms.TabPage();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.rdbtnEgreso = new System.Windows.Forms.RadioButton();
            this.rdbtnIngreso = new System.Windows.Forms.RadioButton();
            this.txtbxCantidadTab2 = new System.Windows.Forms.TextBox();
            this.lblCantidadTab2 = new System.Windows.Forms.Label();
            this.lblDescripcionTab2 = new System.Windows.Forms.Label();
            this.lblCodigoTab2 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabCarga.SuspendLayout();
            this.tabMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCarga);
            this.tabControl1.Controls.Add(this.tabMovimientos);
            this.tabControl1.Location = new System.Drawing.Point(76, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 189);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCarga
            // 
            this.tabCarga.Controls.Add(this.btnCarga);
            this.tabCarga.Controls.Add(this.lblMuestraStock);
            this.tabCarga.Controls.Add(this.lblStock);
            this.tabCarga.Controls.Add(this.lblDescripcion);
            this.tabCarga.Controls.Add(this.lblCodigo);
            this.tabCarga.Controls.Add(this.txtbxDescripcion);
            this.tabCarga.Controls.Add(this.txtbxCodigo);
            this.tabCarga.Location = new System.Drawing.Point(4, 24);
            this.tabCarga.Name = "tabCarga";
            this.tabCarga.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarga.Size = new System.Drawing.Size(455, 161);
            this.tabCarga.TabIndex = 0;
            this.tabCarga.Text = "Carga productos";
            this.tabCarga.UseVisualStyleBackColor = true;
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(374, 132);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(75, 23);
            this.btnCarga.TabIndex = 6;
            this.btnCarga.Text = "Cargar";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // lblMuestraStock
            // 
            this.lblMuestraStock.AutoSize = true;
            this.lblMuestraStock.Location = new System.Drawing.Point(101, 67);
            this.lblMuestraStock.Name = "lblMuestraStock";
            this.lblMuestraStock.Size = new System.Drawing.Size(0, 15);
            this.lblMuestraStock.TabIndex = 5;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(15, 67);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 41);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // txtbxDescripcion
            // 
            this.txtbxDescripcion.Location = new System.Drawing.Point(101, 36);
            this.txtbxDescripcion.Name = "txtbxDescripcion";
            this.txtbxDescripcion.Size = new System.Drawing.Size(122, 23);
            this.txtbxDescripcion.TabIndex = 1;
            // 
            // txtbxCodigo
            // 
            this.txtbxCodigo.Location = new System.Drawing.Point(101, 7);
            this.txtbxCodigo.Name = "txtbxCodigo";
            this.txtbxCodigo.Size = new System.Drawing.Size(122, 23);
            this.txtbxCodigo.TabIndex = 0;
            // 
            // tabMovimientos
            // 
            this.tabMovimientos.Controls.Add(this.btnAplicar);
            this.tabMovimientos.Controls.Add(this.rdbtnEgreso);
            this.tabMovimientos.Controls.Add(this.rdbtnIngreso);
            this.tabMovimientos.Controls.Add(this.txtbxCantidadTab2);
            this.tabMovimientos.Controls.Add(this.lblCantidadTab2);
            this.tabMovimientos.Controls.Add(this.lblDescripcionTab2);
            this.tabMovimientos.Controls.Add(this.lblCodigoTab2);
            this.tabMovimientos.Location = new System.Drawing.Point(4, 24);
            this.tabMovimientos.Name = "tabMovimientos";
            this.tabMovimientos.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovimientos.Size = new System.Drawing.Size(455, 161);
            this.tabMovimientos.TabIndex = 1;
            this.tabMovimientos.Text = "Movimientos Productos";
            this.tabMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(307, 82);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 7;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // rdbtnEgreso
            // 
            this.rdbtnEgreso.AutoSize = true;
            this.rdbtnEgreso.Location = new System.Drawing.Point(225, 97);
            this.rdbtnEgreso.Name = "rdbtnEgreso";
            this.rdbtnEgreso.Size = new System.Drawing.Size(60, 19);
            this.rdbtnEgreso.TabIndex = 6;
            this.rdbtnEgreso.TabStop = true;
            this.rdbtnEgreso.Text = "Egreso";
            this.rdbtnEgreso.UseVisualStyleBackColor = true;
            // 
            // rdbtnIngreso
            // 
            this.rdbtnIngreso.AutoSize = true;
            this.rdbtnIngreso.Checked = true;
            this.rdbtnIngreso.Location = new System.Drawing.Point(225, 72);
            this.rdbtnIngreso.Name = "rdbtnIngreso";
            this.rdbtnIngreso.Size = new System.Drawing.Size(64, 19);
            this.rdbtnIngreso.TabIndex = 5;
            this.rdbtnIngreso.TabStop = true;
            this.rdbtnIngreso.Text = "Ingreso";
            this.rdbtnIngreso.UseVisualStyleBackColor = true;
            // 
            // txtbxCantidadTab2
            // 
            this.txtbxCantidadTab2.Location = new System.Drawing.Point(136, 82);
            this.txtbxCantidadTab2.Name = "txtbxCantidadTab2";
            this.txtbxCantidadTab2.Size = new System.Drawing.Size(83, 23);
            this.txtbxCantidadTab2.TabIndex = 4;
            // 
            // lblCantidadTab2
            // 
            this.lblCantidadTab2.AutoSize = true;
            this.lblCantidadTab2.Location = new System.Drawing.Point(75, 85);
            this.lblCantidadTab2.Name = "lblCantidadTab2";
            this.lblCantidadTab2.Size = new System.Drawing.Size(55, 15);
            this.lblCantidadTab2.TabIndex = 3;
            this.lblCantidadTab2.Text = "Cantidad";
            // 
            // lblDescripcionTab2
            // 
            this.lblDescripcionTab2.AutoSize = true;
            this.lblDescripcionTab2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcionTab2.Location = new System.Drawing.Point(75, 58);
            this.lblDescripcionTab2.Name = "lblDescripcionTab2";
            this.lblDescripcionTab2.Size = new System.Drawing.Size(40, 15);
            this.lblDescripcionTab2.TabIndex = 1;
            this.lblDescripcionTab2.Text = "label2";
            // 
            // lblCodigoTab2
            // 
            this.lblCodigoTab2.AutoSize = true;
            this.lblCodigoTab2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoTab2.Location = new System.Drawing.Point(75, 32);
            this.lblCodigoTab2.Name = "lblCodigoTab2";
            this.lblCodigoTab2.Size = new System.Drawing.Size(40, 15);
            this.lblCodigoTab2.TabIndex = 0;
            this.lblCodigoTab2.Text = "label1";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(80, 224);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(455, 153);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.tabControl1.ResumeLayout(false);
            this.tabCarga.ResumeLayout(false);
            this.tabCarga.PerformLayout();
            this.tabMovimientos.ResumeLayout(false);
            this.tabMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCarga;
        private Button btnCarga;
        private Label lblMuestraStock;
        private Label lblStock;
        private Label lblDescripcion;
        private Label lblCodigo;
        private TextBox txtbxDescripcion;
        private TextBox txtbxCodigo;
        private TabPage tabMovimientos;
        private Label lblDescripcionTab2;
        private Label lblCodigoTab2;
        private Button btnAplicar;
        private RadioButton rdbtnEgreso;
        private RadioButton rdbtnIngreso;
        private TextBox txtbxCantidadTab2;
        private Label lblCantidadTab2;
        private DataGridView dgvProductos;
    }
}