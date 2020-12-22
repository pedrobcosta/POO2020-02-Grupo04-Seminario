using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLISTAENCADEADA
{
    class No
    {
       //atributos
        private int _valor;
        private No _proximo;
        private No _anterior;


        //getters e setters
        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public No Proximo
        {
            get { return _proximo; }
            set { _proximo = value; }
        }

        public No Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }
    }
}
