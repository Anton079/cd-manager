using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd_manager.Inchirieri
{
    public class InchirieriService
    {
        private List<Inchirieri> _Inchiriere;

        public InchirieriService()
        {
            _Inchiriere = new List<Inchirieri>();

            this.LoadData();
        }

        public void LoadData()
        {
            Inchirieri Inchiriere1 = new Inchirieri(1, 2, 1);
            Inchirieri Inchiriere2 = new Inchirieri(2, 1, 4);
            Inchirieri Inchiriere3 = new Inchirieri(3, 2, 5);
            Inchirieri Inchiriere4 = new Inchirieri(4, 1, 2);
            Inchirieri Inchiriere5 = new Inchirieri(5, 2, 3);

            this._Inchiriere.Add(Inchiriere1);
            this._Inchiriere.Add(Inchiriere2);
            this._Inchiriere.Add(Inchiriere3);
            this._Inchiriere.Add(Inchiriere4);
            this._Inchiriere.Add(Inchiriere5);
        }

        public List <int> FiltrareInchirieriByUser(int idUser)
        {
            List<int> listIstoric = new List<int>();

            for (int i = 0; i < _Inchiriere.Count; i++)
            {
                if(idUser == _Inchiriere[i].IdUser)
                {
                    listIstoric.Add(_Inchiriere[i].IdCd);
                }
            }
            return listIstoric;
        }

        Inchiriere FindInchiriereById(int idInchiriere)
        {

            foreach (Inchiriere inchiriere in _Inchiriere)
            {

                if (inchiriere.Id == idInchiriere)
                {
                    return inchiriere;
                }


            }
            return null;
        }

        public int GenerateId()
        {
            Random rand = new Random();

            int id = rand.Next(1, 10000000);


            while (FindInchiriereById(id) != null)
            {
                id = rand.Next(1, 10000000);
            }


            return id;
        }
    }
}
