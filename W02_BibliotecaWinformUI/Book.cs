using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_BibliotecaWinformUI
{
    public class Book
    {
        public int ID_LLIB { get; set; }
        //public string TITOL { get; set; }
        public string TITOL { get; set; }
        public string DESCRIP_LLIB { get; set; }
        public string NOM_AUTOR { get; set; }
        public string FK_DEPARTAMENT { get; set; }
        public string FullInfo
        {
            get
            {
                return ID_LLIB + ":\t" + TITOL;
            }
        }

    }
}
