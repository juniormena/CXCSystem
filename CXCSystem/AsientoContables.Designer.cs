
namespace CXCSystem
{
    partial class AsientoContables
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCuentaContable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxMovimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvAsientos = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbxEstado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.txtCuentaContable);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.cbxCliente);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.cbxMovimiento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(866, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 398);
            this.panel1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Cliente";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(239, 207);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(147, 22);
            this.dtFecha.TabIndex = 51;
            // 
            // txtCuentaContable
            // 
            this.txtCuentaContable.Location = new System.Drawing.Point(239, 158);
            this.txtCuentaContable.Name = "txtCuentaContable";
            this.txtCuentaContable.Size = new System.Drawing.Size(147, 22);
            this.txtCuentaContable.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cuenta Contable";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(239, 258);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(147, 22);
            this.txtMonto.TabIndex = 49;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 37);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Fecha";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(182, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(239, 10);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(147, 24);
            this.cbxCliente.TabIndex = 46;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(288, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 37);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxMovimiento
            // 
            this.cbxMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMovimiento.FormattingEnabled = true;
            this.cbxMovimiento.Items.AddRange(new object[] {
            "DB",
            "CR"});
            this.cbxMovimiento.Location = new System.Drawing.Point(239, 58);
            this.cbxMovimiento.Name = "cbxMovimiento";
            this.cbxMovimiento.Size = new System.Drawing.Size(147, 24);
            this.cbxMovimiento.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tipo de Movimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Descripcion";
            // 
            // dgvAsientos
            // 
            this.dgvAsientos.AllowUserToDeleteRows = false;
            this.dgvAsientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAsientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAsientos.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_Asiento,
            this.Descripcion,
            this.Tipo_movimiento,
            this.Cuenta,
            this.Fecha,
            this.Monto,
            this.Cliente_ID,
            this.Estado});
            this.dgvAsientos.Location = new System.Drawing.Point(12, 23);
            this.dgvAsientos.Name = "dgvAsientos";
            this.dgvAsientos.ReadOnly = true;
            this.dgvAsientos.RowHeadersWidth = 51;
            this.dgvAsientos.RowTemplate.Height = 24;
            this.dgvAsientos.Size = new System.Drawing.Size(806, 398);
            this.dgvAsientos.TabIndex = 53;
            this.dgvAsientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsientos_CellDoubleClick);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(239, 112);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(147, 22);
            this.txtDescripcion.TabIndex = 52;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cbxEstado.Location = new System.Drawing.Point(241, 300);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(147, 24);
            this.cbxEstado.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Estado";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 48;
            // 
            // Id_Asiento
            // 
            this.Id_Asiento.DataPropertyName = "Id_Asiento";
            this.Id_Asiento.HeaderText = "IdAsiento";
            this.Id_Asiento.MinimumWidth = 6;
            this.Id_Asiento.Name = "Id_Asiento";
            this.Id_Asiento.ReadOnly = true;
            this.Id_Asiento.Width = 95;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 111;
            // 
            // Tipo_movimiento
            // 
            this.Tipo_movimiento.DataPropertyName = "Tipo_movimiento";
            this.Tipo_movimiento.HeaderText = "Tipo Movimiento";
            this.Tipo_movimiento.MinimumWidth = 6;
            this.Tipo_movimiento.Name = "Tipo_movimiento";
            this.Tipo_movimiento.ReadOnly = true;
            this.Tipo_movimiento.Width = 128;
            // 
            // Cuenta
            // 
            this.Cuenta.DataPropertyName = "Cuenta";
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            this.Cuenta.Width = 82;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 76;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 76;
            // 
            // Cliente_ID
            // 
            this.Cliente_ID.DataPropertyName = "Nombre";
            this.Cliente_ID.HeaderText = "Cliente";
            this.Cliente_ID.MinimumWidth = 6;
            this.Cliente_ID.Name = "Cliente_ID";
            this.Cliente_ID.ReadOnly = true;
            this.Cliente_ID.Width = 80;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 81;
            // 
            // AsientoContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1354, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAsientos);
            this.MaximizeBox = false;
            this.Name = "AsientoContables";
            this.Text = "Asiento Contables";
            this.Load += new System.EventHandler(this.AsientoContables_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtCuentaContable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbxMovimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAsientos;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}