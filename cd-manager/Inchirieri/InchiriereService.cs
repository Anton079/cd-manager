using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd_manager.Inchiriere
{
    public class InchiriereService
    {
        private List<Inchiriere> _Inchiriere;

        public InchiriereService()
        {
            _Inchiriere = new List<Inchiriere>();

            this.LoadData();
        }

        public void LoadData()
        {
            Inchiriere Inchiriere1 = new Inchiriere(1, 2, 1);
            Inchiriere Inchiriere2 = new Inchiriere(2, 1, 4);
            Inchiriere Inchiriere3 = new Inchiriere(3, 2, 5);
            Inchiriere Inchiriere4 = new Inchiriere(4, 1, 2);
            Inchiriere Inchiriere5 = new Inchiriere(5, 2, 3);

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

        public void AddIstoricInchiriere(Inchiriere inchirieri)
        {
           this._Inchiriere.Add(inchirieri);
        }

    }
}
