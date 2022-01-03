
namespace ClasesFacultad
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoProfesor = new System.Windows.Forms.Label();
            this.btProfesor = new System.Windows.Forms.Button();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.txtApellidoProfesor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCátedra = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btCátedra = new System.Windows.Forms.Button();
            this.lblCátedra = new System.Windows.Forms.Label();
            this.btTodosLosDatos = new System.Windows.Forms.Button();
            this.lblDatosTotales = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btContenido = new System.Windows.Forms.Button();
            this.txtContenidoUno = new System.Windows.Forms.TextBox();
            this.txtContenidoDos = new System.Windows.Forms.TextBox();
            this.lblContenidos = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDirección = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NombreProfesor";
            // 
            // lblApellidoProfesor
            // 
            this.lblApellidoProfesor.AutoSize = true;
            this.lblApellidoProfesor.Location = new System.Drawing.Point(220, 28);
            this.lblApellidoProfesor.Name = "lblApellidoProfesor";
            this.lblApellidoProfesor.Size = new System.Drawing.Size(83, 13);
            this.lblApellidoProfesor.TabIndex = 1;
            this.lblApellidoProfesor.Text = "ApellidoProfesor";
            // 
            // btProfesor
            // 
            this.btProfesor.Location = new System.Drawing.Point(133, 46);
            this.btProfesor.Name = "btProfesor";
            this.btProfesor.Size = new System.Drawing.Size(75, 23);
            this.btProfesor.TabIndex = 2;
            this.btProfesor.Text = "Profesor";
            this.btProfesor.UseVisualStyleBackColor = true;
            this.btProfesor.Click += new System.EventHandler(this.btProfesor_Click);
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(396, 52);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(0, 17);
            this.lblProfesor.TabIndex = 3;
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.Location = new System.Drawing.Point(15, 48);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProfesor.TabIndex = 1;
            // 
            // txtApellidoProfesor
            // 
            this.txtApellidoProfesor.Location = new System.Drawing.Point(223, 48);
            this.txtApellidoProfesor.Name = "txtApellidoProfesor";
            this.txtApellidoProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoProfesor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cátedra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            // 
            // txtCátedra
            // 
            this.txtCátedra.Location = new System.Drawing.Point(12, 144);
            this.txtCátedra.Name = "txtCátedra";
            this.txtCátedra.Size = new System.Drawing.Size(100, 20);
            this.txtCátedra.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(223, 141);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // btCátedra
            // 
            this.btCátedra.Location = new System.Drawing.Point(133, 141);
            this.btCátedra.Name = "btCátedra";
            this.btCátedra.Size = new System.Drawing.Size(75, 23);
            this.btCátedra.TabIndex = 8;
            this.btCátedra.Text = "Cátedra";
            this.btCátedra.UseVisualStyleBackColor = true;
            this.btCátedra.Click += new System.EventHandler(this.btCátedra_Click);
            // 
            // lblCátedra
            // 
            this.lblCátedra.AutoSize = true;
            this.lblCátedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCátedra.Location = new System.Drawing.Point(396, 141);
            this.lblCátedra.Name = "lblCátedra";
            this.lblCátedra.Size = new System.Drawing.Size(0, 17);
            this.lblCátedra.TabIndex = 9;
            // 
            // btTodosLosDatos
            // 
            this.btTodosLosDatos.Location = new System.Drawing.Point(133, 226);
            this.btTodosLosDatos.Name = "btTodosLosDatos";
            this.btTodosLosDatos.Size = new System.Drawing.Size(75, 23);
            this.btTodosLosDatos.TabIndex = 10;
            this.btTodosLosDatos.Text = "DT";
            this.btTodosLosDatos.UseVisualStyleBackColor = true;
            this.btTodosLosDatos.Click += new System.EventHandler(this.btTodosLosDatos_Click);
            // 
            // lblDatosTotales
            // 
            this.lblDatosTotales.AutoSize = true;
            this.lblDatosTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosTotales.Location = new System.Drawing.Point(139, 252);
            this.lblDatosTotales.Name = "lblDatosTotales";
            this.lblDatosTotales.Size = new System.Drawing.Size(0, 17);
            this.lblDatosTotales.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ContenidoUno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ContenidoDos";
            // 
            // btContenido
            // 
            this.btContenido.Location = new System.Drawing.Point(133, 190);
            this.btContenido.Name = "btContenido";
            this.btContenido.Size = new System.Drawing.Size(75, 23);
            this.btContenido.TabIndex = 14;
            this.btContenido.Text = "Contenidos";
            this.btContenido.UseVisualStyleBackColor = true;
            this.btContenido.Click += new System.EventHandler(this.btContenido_Click);
            // 
            // txtContenidoUno
            // 
            this.txtContenidoUno.Location = new System.Drawing.Point(15, 193);
            this.txtContenidoUno.Name = "txtContenidoUno";
            this.txtContenidoUno.Size = new System.Drawing.Size(100, 20);
            this.txtContenidoUno.TabIndex = 15;
            // 
            // txtContenidoDos
            // 
            this.txtContenidoDos.Location = new System.Drawing.Point(223, 192);
            this.txtContenidoDos.Name = "txtContenidoDos";
            this.txtContenidoDos.Size = new System.Drawing.Size(100, 20);
            this.txtContenidoDos.TabIndex = 16;
            // 
            // lblContenidos
            // 
            this.lblContenidos.AutoSize = true;
            this.lblContenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenidos.Location = new System.Drawing.Point(396, 196);
            this.lblContenidos.Name = "lblContenidos";
            this.lblContenidos.Size = new System.Drawing.Size(0, 17);
            this.lblContenidos.TabIndex = 17;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(12, 85);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 18;
            this.lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(12, 101);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 19;
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Location = new System.Drawing.Point(224, 85);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(52, 13);
            this.lblDirección.TabIndex = 20;
            this.lblDirección.Text = "Dirección";
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(223, 101);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(100, 20);
            this.txtDirección.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDirección);
            this.Controls.Add(this.lblDirección);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblContenidos);
            this.Controls.Add(this.txtContenidoDos);
            this.Controls.Add(this.txtContenidoUno);
            this.Controls.Add(this.btContenido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDatosTotales);
            this.Controls.Add(this.btTodosLosDatos);
            this.Controls.Add(this.lblCátedra);
            this.Controls.Add(this.btCátedra);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtCátedra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidoProfesor);
            this.Controls.Add(this.txtNombreProfesor);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.btProfesor);
            this.Controls.Add(this.lblApellidoProfesor);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoProfesor;
        private System.Windows.Forms.Button btProfesor;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.TextBox txtApellidoProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCátedra;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btCátedra;
        private System.Windows.Forms.Label lblCátedra;
        private System.Windows.Forms.Button btTodosLosDatos;
        private System.Windows.Forms.Label lblDatosTotales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btContenido;
        private System.Windows.Forms.TextBox txtContenidoUno;
        private System.Windows.Forms.TextBox txtContenidoDos;
        private System.Windows.Forms.Label lblContenidos;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.TextBox txtDirección;
    }
}

