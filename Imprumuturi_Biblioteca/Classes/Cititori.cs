using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprumuturi_Biblioteca
{   [Serializable]
    class Cititori
    {
        private int codCititor;
        private string numeCititor;
        private static int c = 0;

        public Cititori(string numeC)
        {
            codCititor = ++c;
            numeCititor = numeC;
        }

        public int CodCititor
        {
            get => codCititor;
        }

        public string NumeCititor
        {
            get => numeCititor;
            set
            {
                if (value.Length >= 3)
                    numeCititor = value;
            }
        }

        public override string ToString()
        {
            return codCititor.ToString() + "," + numeCititor;
        }
    }
}
