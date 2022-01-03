using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFacultad
{
    public class Profesor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Documento { get; set; }
        public string Dirección { get; set; }

        public Materia CátedraProfesor { get; set; } = new Materia();

        public string NombreCompletoProfesor()
        {
            return Nombre + ", " + Apellido 
                   + "\r\n"
                   + Documento + ", " + Dirección ;
        }
        public string Catprof (Materia ArgumentoCátedra)
        {
            string Años;
            string Cat;
            CátedraProfesor = ArgumentoCátedra;
            Años = CátedraProfesor.Edad.ToString();
            Cat = CátedraProfesor.Catedra;

            return Cat + ", " + Años;
        }
    }
}
