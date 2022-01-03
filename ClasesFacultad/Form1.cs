using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesFacultad
{
    public partial class Form1 : Form
    {
        Profesor ProfesorMostrar = new Profesor();
        Materia CátedraPropia = new Materia();
        public Form1()
        {
            InitializeComponent();
        }

        private void btProfesor_Click(object sender, EventArgs e)
        {
            ProfesorMostrar.Nombre = txtNombreProfesor.Text;
            ProfesorMostrar.Apellido = txtApellidoProfesor.Text;
            ProfesorMostrar.Documento = Convert.ToInt32(txtDocumento.Text);
            ProfesorMostrar.Dirección = txtDirección.Text;


            lblProfesor.Text = ProfesorMostrar.NombreCompletoProfesor();
        }

        private void btCátedra_Click(object sender, EventArgs e)
        {
           
            CátedraPropia.Catedra = txtCátedra.Text;
            CátedraPropia.Edad = Convert.ToInt32(txtEdad.Text);

            lblCátedra.Text = ProfesorMostrar.Catprof(CátedraPropia) + " Años";

        }

        private void btTodosLosDatos_Click(object sender, EventArgs e)
        {
            lblDatosTotales.Text = ProfesorMostrar.NombreCompletoProfesor() 
                                   + "\r\n" 
                                   +  lblCátedra.Text
                                   + "\r\n"
                                   +  lblContenidos.Text;
        }

        private void btContenido_Click(object sender, EventArgs e)
        {
            Contenidos contenido = new Contenidos();
            contenido.TemaUno = txtContenidoUno.Text;
            contenido.TemaDos = txtContenidoDos.Text;

            lblContenidos.Text = CátedraPropia.DevolucionContenido(contenido);

            
        }

        
    }
}
 