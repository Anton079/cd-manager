using cd_manager.Cds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd_manager
{
    public class CdSService
    {
        private List<Cd> _cd;

        public CdSService()
        {
            _cd = new List<Cd>();
            this.LoadData();
        }

        private void LoadData()
        {
            Cd Cd1 = new Cd(1, "CD Audio standard",700,2,true );
            Cd Cd2 = new Cd(2, "CD-R", 1500, 1, false);
            Cd Cd3 = new Cd(3, "CD-RW", 150, 5, true);
            Cd Cd4 = new Cd(4, "CD-ROM", 500, 5, false);
            Cd Cd5 = new Cd(5, "Mini CD", 850, 3, false);

            _cd.Add(Cd1);
            _cd.Add(Cd2);
            _cd.Add(Cd3);
            _cd.Add(Cd4);
            _cd.Add(Cd5);
        }

        public void AfisareraCds()
        {
            foreach (Cd x in _cd)
            {
                Console.WriteLine(x.CdsInfo());
            }
        }

        public void AfisareCdsAvaiable()
        {
            foreach (Cd x in _cd)
            {
                if(x.Disponibila == true)
                {
                    Console.WriteLine(x.CdsInfo());
                }
            }
        }

        public List<Cd> FindAllCdsByIds(List<int> cdIds)
        {
            List <Cd> filteredCds = new List<Cd>();    

            for(int i = 0; i < cdIds.Count; i++)
            {
                if (cdIds.Contains(_cd[i].Id))
                {
                    filteredCds.Add(_cd[i]);
                }
            }
            return filteredCds;
        }

        public Cd FindCdById(int idCd)
        {
            foreach(Cd x in _cd)
            {
                if(x.Id == idCd)
                {
                    return x;
                }
            }
            return null;
        }

        public void DeleteCd(int idCd)
        {
            Cd cd = FindCdById(idCd);
            _cd.Remove(cd);
        }
    }
}
