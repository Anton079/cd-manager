using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd_manager.Cds
{
    public class Cd
    {
        private int _id;
        private string _modelCd;
        private int _memorie;
        private int _garantie;
        private bool _disponibila;

        public Cd(int id, string modelCd, int memorie, int garantie, bool disponibila)
        {
            _id = id;
            _modelCd = modelCd;
            _memorie = memorie;
            _garantie = garantie;
            _disponibila = disponibila;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ModelCd
        {
            get { return _modelCd; }
            set { _modelCd = value; }
        }

        public int Memorie
        {
            get { return _memorie; }
            set { _memorie = value; }
        }

        public int Garantie
        {
            get { return _garantie; }
            set { _garantie = value; }
        }

        public bool Disponibila
        {
            get { return _disponibila; }
            set { _disponibila = value; }
        }

        public string CdsInfo()
        {
            string text = " ";
            text += "Id Cd" + Id + "\n";
            text += "Model Cd" + ModelCd + "\n";
            text += "Memorie " + ModelCd + "\n";
            text += "Garantie " + Garantie + "\n";
            text += "Disponibila " + Disponibila + "\n";
            return text;
        }

    }
}
