namespace Aplicacion_CURD
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Acciones = new System.Windows.Forms.GroupBox();
            this.rbnInsertar = new System.Windows.Forms.RadioButton();
            this.rbnActualizar = new System.Windows.Forms.RadioButton();
            this.rbnEliminar = new System.Windows.Forms.RadioButton();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dataGridPersonas = new System.Windows.Forms.DataGridView();
            this.rbnBuscar = new System.Windows.Forms.RadioButton();
            this.Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(288, 473);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(127, 51);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "CI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono:";
            // 
            // Acciones
            // 
            this.Acciones.Controls.Add(this.rbnBuscar);
            this.Acciones.Controls.Add(this.rbnEliminar);
            this.Acciones.Controls.Add(this.rbnActualizar);
            this.Acciones.Controls.Add(this.rbnInsertar);
            this.Acciones.Location = new System.Drawing.Point(599, 15);
            this.Acciones.Name = "Acciones";
            this.Acciones.Size = new System.Drawing.Size(104, 117);
            this.Acciones.TabIndex = 5;
            this.Acciones.TabStop = false;
            this.Acciones.Text = "Acciones";
            // 
            // rbnInsertar
            // 
            this.rbnInsertar.AutoSize = true;
            this.rbnInsertar.Location = new System.Drawing.Point(6, 23);
            this.rbnInsertar.Name = "rbnInsertar";
            this.rbnInsertar.Size = new System.Drawing.Size(60, 17);
            this.rbnInsertar.TabIndex = 0;
            this.rbnInsertar.Text = "Insertar";
            this.rbnInsertar.UseVisualStyleBackColor = true;
            this.rbnInsertar.CheckedChanged += new System.EventHandler(this.rbnInsertar_CheckedChanged);
            // 
            // rbnActualizar
            // 
            this.rbnActualizar.AutoSize = true;
            this.rbnActualizar.Location = new System.Drawing.Point(6, 46);
            this.rbnActualizar.Name = "rbnActualizar";
            this.rbnActualizar.Size = new System.Drawing.Size(71, 17);
            this.rbnActualizar.TabIndex = 1;
            this.rbnActualizar.TabStop = true;
            this.rbnActualizar.Text = "Actualizar";
            this.rbnActualizar.UseVisualStyleBackColor = true;
            this.rbnActualizar.CheckedChanged += new System.EventHandler(this.rbnActualizar_CheckedChanged);
            // 
            // rbnEliminar
            // 
            this.rbnEliminar.AutoSize = true;
            this.rbnEliminar.Location = new System.Drawing.Point(6, 69);
            this.rbnEliminar.Name = "rbnEliminar";
            this.rbnEliminar.Size = new System.Drawing.Size(61, 17);
            this.rbnEliminar.TabIndex = 2;
            this.rbnEliminar.TabStop = true;
            this.rbnEliminar.Text = "Eliminar";
            this.rbnEliminar.UseVisualStyleBackColor = true;
            this.rbnEliminar.CheckedChanged += new System.EventHandler(this.rbnEliminar_CheckedChanged);
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(120, 15);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(141, 20);
            this.txtCi.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(120, 96);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(141, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(119, 140);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(141, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // dataGridPersonas
            // 
            this.dataGridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonas.Location = new System.Drawing.Point(17, 181);
            this.dataGridPersonas.Name = "dataGridPersonas";
            this.dataGridPersonas.Size = new System.Drawing.Size(686, 276);
            this.dataGridPersonas.TabIndex = 10;
            // 
            // rbnBuscar
            // 
            this.rbnBuscar.AutoSize = true;
            this.rbnBuscar.Location = new System.Drawing.Point(6, 92);
            this.rbnBuscar.Name = "rbnBuscar";
            this.rbnBuscar.Size = new System.Drawing.Size(58, 17);
            this.rbnBuscar.TabIndex = 3;
            this.rbnBuscar.TabStop = true;
            this.rbnBuscar.Text = "Buscar";
            this.rbnBuscar.UseVisualStyleBackColor = true;
            this.rbnBuscar.CheckedChanged += new System.EventHandler(this.rbnBuscar_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 536);
            this.Controls.Add(this.dataGridPersonas);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.Acciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Acciones.ResumeLayout(false);
            this.Acciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Acciones;
        private System.Windows.Forms.RadioButton rbnEliminar;
        private System.Windows.Forms.RadioButton rbnActualizar;
        private System.Windows.Forms.RadioButton rbnInsertar;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.RadioButton rbnBuscar;
        private System.Windows.Forms.DataGridView dataGridPersonas;
    }
}

