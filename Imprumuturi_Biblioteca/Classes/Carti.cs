using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprumuturi_Biblioteca
{   [Serializable]
    class Carti
    {
        private int codCarte;
        private string titlu;
        private string autor;
        private static int c = 0;

        public Carti(string titluP, string autorP)
        {
            codCarte = ++c;
            titlu = titluP;
            autor = autorP;
        }

        public int CodCarte
        {
            get => codCarte;
        }

        public string Titlu
        {
            get => titlu;
        }

        public string Autor
        {
            get => autor;
        }

        public override string ToString()
        {
            return codCarte.ToString() + "," + titlu + "," + autor;
        }
    }
}
