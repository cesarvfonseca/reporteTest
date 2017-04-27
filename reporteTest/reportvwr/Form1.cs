using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportvwr
{
    public partial class Form1 : Form
    {

        int[] largo = {9,10};

        public Form1()
        {
            InitializeComponent();
        }

        private string hl(string cadena,int n)
        {
            int numberOfLetters = cadena.Length;
            int ne = n - numberOfLetters;
            string eBlanco = new string('/', ne);
            return cadena+eBlanco;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int i=0;
            string nombre = "Hitomi";
            int ns = 9;
            string ape = "Laine";
            nombre=hl(nombre,ns);
            foreach (int y in largo)
            {
                System.Console.Write("{0} ", y);
            }
            
            //MessageBox.Show("--"+nombre+"--","Important Message");
        }
    }
}
