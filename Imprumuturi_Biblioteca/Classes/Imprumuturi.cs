using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprumuturi_Biblioteca
{   [Serializable]
    class Imprumuturi
    {
        private int codImprumut;
        private int codCarte;
        private int codCititor;
        private DateTime dataInceput;
        private DateTime dataSfarsit;
        private static int c = 0;

        public Imprumuturi(int codCa, int codCi, DateTime di, DateTime ds)
        {
            codImprumut = ++c;
            codCarte = codCa;
            codCititor = codCi;
            dataInceput = di;
            dataSfarsit = ds;
        }

        public int CodImprumut
        {
            get => codImprumut;
        }

        public int CodCarte
        {
            get => codCarte;
            set
            {
                if (value > 0)
                    codCarte = value;
            }
        }

        public int CodCititor
        {
            get => codCititor;
            set
            {
                if (value > 0)
                    codCititor = value;
            }
        }

        public DateTime DataInceput { get; set; }

        public DateTime DataSfarsit
        {
            get => dataSfarsit;
            set { dataSfarsit = value; }
        }

        public override string ToString()
        {
            return codImprumut.ToString() + "," + codCarte.ToString() + "," + codCititor.ToString() + "," + dataInceput.ToString() + "," + dataSfarsit.ToString();
        }
    }
}
