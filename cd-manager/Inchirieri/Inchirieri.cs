﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd_manager.Inchirieri
{
    public class Inchirieri
    {
        private int _id;
        private int _idUser;
        private int _idCd;

        public Inchirieri(int id, int idUser, int idCd)
        {
            _id = id;
            _idUser = idUser;
            _idBook = idBook;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        public int IdCd
        {
            get { return _idCd; }
            set { _idCd = value; }
        }

        public string InchiriereInfp()
        {
            string text = " ";
            text += "Idul " + Id + "\n";
            text += "Idul User " + IdUser + "\n";
            text += "Id Cd " + IdCd + "\n";
            return text;
        }
    }
}
