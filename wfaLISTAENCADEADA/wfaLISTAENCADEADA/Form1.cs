using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaLISTAENCADEADA
{
    public partial class Form1 : Form
    {
        Lista mLista = new Lista();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt1Inserir(object sender, EventArgs e)
        {
            int item = 0;
            try
            {
                item = Convert.ToInt32(tb1.Text);
            }
            catch (FormatException)
            {
                tb1.Clear();
                MessageBox.Show("O item deve ser um inteiro!", "Item inválido");
            }
            if (tb1.Text.Length > 0)
            {
                mLista.InsereFim(item);
            }

            tb1.Clear();
            tb5.Clear();
        }

        private void bt2Remover(object sender, EventArgs e)
        {
            int valor;
            
            if (tb2.Text == "") 
            {
                tb2.Clear();
                MessageBox.Show("O item deve existir!", "Item inválido");
                return;
            }
            else
                valor = Convert.ToInt32(tb2.Text);
            
            
            if(mLista.AchaNo(valor) == null)
            {
                tb2.Clear();
                MessageBox.Show("O item deve existir!", "Item inválido");
                return;
            }

            mLista.Remove(valor);

            
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
        }

        private void bt3Menor(object sender, EventArgs e)
        {
            tb3.Clear();

            String menor;
            menor = Convert.ToString(mLista.EncontraMenor());
            if (menor == "-1")
            {
                tb3.Clear();
                MessageBox.Show("Não há itens na lista.", "Item inválido");
                return;
            }

            tb3.Text = menor;
        }

        private void bt4Maior(object sender, EventArgs e)
        {
            tb4.Clear();

            String maior;
            maior = Convert.ToString(mLista.EncontraMaior());

            if (maior == "-1")
            {
                tb4.Clear();
                MessageBox.Show("Não há itens na lista.", "Item inválido");
                return;
            }


            tb4.Text = maior;
        }

        private void bt5Imprimir(object sender, EventArgs e)
        {
            tb5.Clear();
            No auxNo = mLista.cabeca;
           
            if (mLista.Vazia())
            {
                tb5.Clear();
                MessageBox.Show("Não há itens na lista.", "Lista vazia.");
            }
            else
            {
                while (auxNo != null)
                {
                    tb5.Text = tb5.Text + " " + Convert.ToString(auxNo.Valor);
                    auxNo = auxNo.Proximo;
                }
            }
        }
    }
}
