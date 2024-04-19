using cd_manager.Cds;
using cd_manager.Inchiriere;
using cd_manager.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd_manager
{
    public class View
    {
        private User _user;
        private CdSService _cdsService;
        private InchiriereService _inchirieriService;


        public View()
        {
            _user = new User(1, "Ariana@gmail.com", "grsthtdxr", 073643634);
            _cdsService = new CdSService();
            _inchirieriService = new InchiriereService();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate cd-urile");
            Console.WriteLine("Apasati tasta 2 pentru a afisa toate cd-urile disponbile din magazin");
            Console.WriteLine("Apasati tasta 3 pentru a afisa istoricul unui user");
            Console.WriteLine("Apasati tasta 4 pentru a inchiria o carte");
            Console.WriteLine("Apasati tasta 5 pentru a edita un cd");
            Console.WriteLine("Apasati tasta 6 pentru a sterge un cd");
            Console.WriteLine("Apasati tasta 7 pentru a adauga un cd in bliblioteca");
        }

        public void play()
        {
            bool running = true;
            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        _cdsService.AfisareraCds();
                        break;

                    case "2":
                        _cdsService.AfisareCdsAvaiable();
                        break;

                    case "3":
                        AfisareIstoricInchirieriByIdUser();
                        break;

                    case "4":
                        InchiriereCd();
                        break;

                    case "5":
                        EditCd();
                        break;

                    case "6":
                        DeleteCd();
                        break;

                    case "7":
                        AddCdInShop();
                        break;


                }
            }
        }

        public void AfisareIstoricInchirieriByIdUser()
        {
            List<int> idCd = _inchirieriService.FiltrareInchirieriByUser(_user.Id);

            List<Cd> CdById = _cdsService.FindAllCdsByIds(idCd);

            for(int i = 0; i < CdById.Count; i++)
            {
                Console.WriteLine(CdById[i].CdsInfo());
            }
        }

        public void InchiriereCd()
        {
            Console.WriteLine("Introduceti id cd ului ce doriti sa il inchiriati");
            int idCd = Int32.Parse(Console.ReadLine());

            int NrGrnt = _inchirieriService.GenerateId();
            Cd cd = _cdsService.FindCdById(idCd);

            if (cd != null && cd.Disponibila == true)
            {
                Inchiriere.Inchiriere inchiriereUser = new Inchiriere.Inchiriere(NrGrnt, 1, idCd);
                _inchirieriService.AddIstoricInchiriere(inchiriereUser);

                Console.WriteLine("Cd ul a fost inchiriat.");
                cd.Disponibila = false;
            }
            else
            {
                Console.WriteLine("Cd ul nu a putut fi inchiriat!");
            }
        }

        public void EditCd()
        {
            Console.WriteLine("Introduceti id-ul cd ului pe care doriti sa o modificati");
            int cdAles = Int32.Parse(Console.ReadLine());

            Cd cd = _cdsService.FindCdById(cdAles);
            if(cd != null)
            {
                Console.WriteLine("ce vrei sa editezi din carte?");
                string editAles = Console.ReadLine();

                switch(editAles.ToLower())
                {
                    case "modelcd":
                        Console.WriteLine("Introduceti noul model");
                        string modelNou = Console.ReadLine();
                        cd.ModelCd = modelNou;
                        break;

                    case "memorie":
                        Console.WriteLine("Introduceti noua memorie");
                        int memorieNou = Int32.Parse(Console.ReadLine());
                        cd.Memorie = memorieNou;
                        break;

                    case "garantie":
                        Console.WriteLine("Introduceti noua garantie");
                        int garantieNou = Int32.Parse(Console.ReadLine());
                        cd.Garantie = garantieNou;
                        break;

                    default:
                        Console.WriteLine("Optiunea aleasa nu este valida.");
                        break;
                }
                Console.WriteLine("S-a editat cartea!");
            }
        }

        public void DeleteCd()
        {
            Console.WriteLine("Ce cd vrei sa stergi?");
            int alegereCd = Int32.Parse(Console.ReadLine());

            Cd cd = _cdsService.FindCdById(alegereCd);

            if(cd != null)
            {
                if(cd.Disponibila == true)
                {
                    _cdsService.DeleteCd(cd.Id);
                    Console.WriteLine("Id-ul a fost sters cu succes!");
                }
                else
                {
                    Console.WriteLine("Id ul nu poate fi sers pentru ca nu este disponibil");
                }
            }
            else
            {
                Console.WriteLine("Id ul cd ului nu a fost gasit sau nu exista!");
            }
        }

        public void AddCdInShop()
        {
            int idNewBook = _inchirieriService.GenerateId(); 

            Console.WriteLine("Ce model o sa fie cd ul?");
            string modelNou = Console.ReadLine();

            Console.WriteLine("Ce memorie vrei sa aiba cd ul");
            int memorieNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ce garantie vrei sa aiba");
            int garantieNou = Int32.Parse(Console.ReadLine());

            int nrGrnt = _inchirieriService.GenerateId();

            Cd cd6 = new Cd(idNewBook, modelNou, memorieNou, garantieNou, true);
            _cdsService.AddCdinLoadData(cd6);

            Console.WriteLine("Cd ul a fost adaugat cu succes");
        }

    }

}
