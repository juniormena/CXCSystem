
namespace CXCSystem
{
    partial class Transacciones
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.dgvTransacciones = new System.Windows.Forms.DataGridView();
            this.cbxMovimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTipoDoc = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(274, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 37);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 37);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Num. Documento";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(239, 158);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(147, 22);
            this.txtNumDoc.TabIndex = 30;
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.AllowUserToDeleteRows = false;
            this.dgvTransacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTransacciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTransacciones.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_transaccion,
            this.Tipo_Mov,
            this.Num_doc,
            this.Fecha,
            this.Monto,
            this.TipoDoc_ID,
            this.Cliente_ID});
            this.dgvTransacciones.Location = new System.Drawing.Point(12, 32);
            this.dgvTransacciones.Name = "dgvTransacciones";
            this.dgvTransacciones.ReadOnly = true;
            this.dgvTransacciones.RowHeadersWidth = 51;
            this.dgvTransacciones.RowTemplate.Height = 24;
            this.dgvTransacciones.Size = new System.Drawing.Size(816, 373);
            this.dgvTransacciones.TabIndex = 29;
            this.dgvTransacciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransacciones_CellDoubleClick);
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
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tipo de Documento";
            // 
            // cbxTipoDoc
            // 
            this.cbxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDoc.FormattingEnabled = true;
            this.cbxTipoDoc.Location = new System.Drawing.Point(239, 114);
            this.cbxTipoDoc.Name = "cbxTipoDoc";
            this.cbxTipoDoc.Size = new System.Drawing.Size(147, 24);
            this.cbxTipoDoc.TabIndex = 44;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Cliente";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(239, 258);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(147, 22);
            this.txtMonto.TabIndex = 49;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(239, 207);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(147, 22);
            this.dtFecha.TabIndex = 51;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Id_transaccion
            // 
            this.Id_transaccion.DataPropertyName = "Id_transaccion";
            this.Id_transaccion.HeaderText = "IdTransaccion";
            this.Id_transaccion.MinimumWidth = 6;
            this.Id_transaccion.Name = "Id_transaccion";
            this.Id_transaccion.ReadOnly = true;
            this.Id_transaccion.Width = 126;
            // 
            // Tipo_Mov
            // 
            this.Tipo_Mov.DataPropertyName = "Tipo_Mov";
            this.Tipo_Mov.HeaderText = "Tipo Movimiento";
            this.Tipo_Mov.MinimumWidth = 6;
            this.Tipo_Mov.Name = "Tipo_Mov";
            this.Tipo_Mov.ReadOnly = true;
            this.Tipo_Mov.Width = 128;
            // 
            // Num_doc
            // 
            this.Num_doc.DataPropertyName = "Num_doc";
            this.Num_doc.HeaderText = "Num Documento";
            this.Num_doc.MinimumWidth = 6;
            this.Num_doc.Name = "Num_doc";
            this.Num_doc.ReadOnly = true;
            this.Num_doc.Width = 130;
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
            // TipoDoc_ID
            // 
            this.TipoDoc_ID.DataPropertyName = "Descripcion";
            this.TipoDoc_ID.HeaderText = "Tipo Doc";
            this.TipoDoc_ID.MinimumWidth = 6;
            this.TipoDoc_ID.Name = "TipoDoc_ID";
            this.TipoDoc_ID.ReadOnly = true;
            this.TipoDoc_ID.Width = 87;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.txtNumDoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.cbxCliente);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.cbxMovimiento);
            this.panel1.Controls.Add(this.cbxTipoDoc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(857, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 373);
            this.panel1.TabIndex = 52;
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1326, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTransacciones);
            this.MaximizeBox = false;
            this.Name = "Transacciones";
            this.Text = "Transacciones";
            this.Load += new System.EventHandler(this.Transacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.DataGridView dgvTransacciones;
        private System.Windows.Forms.ComboBox cbxMovimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxTipoDoc;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Mov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_ID;
        private System.Windows.Forms.Panel panel1;
    }
}