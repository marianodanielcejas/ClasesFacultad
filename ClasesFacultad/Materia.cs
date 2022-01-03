using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFacultad
{
    public class Materia
    {
        public string Catedra { get; set; }
        public int Edad { get; set; }
        public Contenidos Temas { get; set; } = new Contenidos();

        public string DevolucionContenido(Contenidos Cont)
        {
            string tema1;
            string tema2;
            Temas = Cont;
            tema1 = Temas.TemaUno;
            tema2 = Temas.TemaDos;
            return tema1 + ", " + tema2;


        }
    }
}
