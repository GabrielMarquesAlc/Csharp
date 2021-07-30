using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploCRUD
{
    public class Fabricante
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}