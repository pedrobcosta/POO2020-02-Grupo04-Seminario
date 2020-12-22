using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLISTAENCADEADA
{
    class Lista
    {
        //atributos
        public No cabeca;
        public No cauda;
        
        //construtor default
        public Lista()
        {
            cabeca = null;
            cauda = null;
        }

        //métodos
        //função para verificar se esta vazia
        public bool Vazia()
        {
            if (cabeca == null)
                return true;
            else
                return false;

        }
        
        //função para encontrar nó
        public No AchaNo(int valor)
        {
            No auxNo;
            auxNo = cabeca;

            
            while (auxNo!= null)
            {
                if (auxNo.Valor == valor)
                    break;

                auxNo = auxNo.Proximo;
            }

            //se a posição passada no parâmetro não existe na lista
            if (auxNo == null)
                return null;
            else
                return auxNo;
        }

        public void InsereFim(int elemento)
        {
            //instanciando um nó
            No novoNo = new No();
            novoNo.Valor = elemento;

            //verificando se é a lista é vazia
            if (Vazia())
            {
                cabeca = novoNo;
            }
            else
            {
                cauda.Proximo = novoNo;
                novoNo.Anterior = cauda;
            }

            //cauda sempre acaba no último inserido
            cauda = novoNo;
        }

        public void InsereComeco(int elemento)
        {
            //instanciando um nó
            No novoNo = new No();
            novoNo.Valor = elemento;

            //verificando se é a lista é vazia
            if (Vazia())
            {
                cabeca = novoNo;
                cauda = novoNo;
            }
            else
            {
                novoNo.Proximo = cabeca.Proximo;
                cabeca = novoNo;
            }

        }

        public void InsereMeio(int elemento, int valoranterior)
        {
            //instanciando um nó
            No novoNo = new No();
            novoNo.Valor = elemento;

            No auxNo = AchaNo(valoranterior);

            //verificando se é a lista é vazia
            if (Vazia())
            {
                cabeca = novoNo;
                cauda = novoNo;
            }
            else if(auxNo.Proximo == null) //se é o último
            {
                novoNo.Anterior = auxNo;
                novoNo.Proximo = null;
                auxNo.Proximo = novoNo;
                cauda = novoNo;
            }
            else
            {
                novoNo.Anterior = auxNo;
                novoNo.Proximo = auxNo.Proximo;
                auxNo.Proximo = novoNo;
            }
        }

        public void Remove(int conteudo)
        {
            No noParaRemover = AchaNo(conteudo);
           
            //se não existir a posição
            if (noParaRemover == null) 
                return;
           

            No noAnterior = noParaRemover.Anterior;

            //se for o nó cabeça
            if (noParaRemover == cabeca) 
            {
                cabeca = cabeca.Proximo;
                noParaRemover.Proximo = null;
                return;
            }
           
            //refazendo encadeamento
            noAnterior.Proximo = noParaRemover.Proximo;
           
            //se for o último nó
            if (noParaRemover.Proximo == null)
            {
                cauda = noAnterior;
            }
            
            noParaRemover.Proximo = null;
        }

        public int EncontraMaior()
        {
            No noAux = cabeca;

            if (noAux == null)
                return -1;

            int maior = cabeca.Valor;

            while (noAux != null)
            {
                if (noAux.Valor > maior)
                    maior = noAux.Valor;
                
                noAux = noAux.Proximo;
            }

            return maior;
        }

        public int EncontraMenor()
        {
            No noAux = cabeca;

            if (noAux == null)
                return -1;
            
            int menor = cabeca.Valor;

            while (noAux != null)
            {
                if (noAux.Valor < menor)
                    menor = noAux.Valor;

                noAux = noAux.Proximo;
            }

            return menor;
        }

        public void ImprimeLista()
        {
            
        }
    }
}
