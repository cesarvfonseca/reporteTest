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

        int[] largo = {3,15,12,3};
        string[] datos = {"HL","Hitomi","Laine","23"};

        public Form1()
        {
            InitializeComponent();
        }

        private string hl(string cadena,int n)
        {
            int numberOfLetters = cadena.Length;
            int ne = n - numberOfLetters;
            string eBlanco = new string('+', ne);
            return cadena+eBlanco;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            string nombres="";
            for (int i = 0; i < largo.Length; i++)
            {
                nombres = nombres + "" + hl(datos[i], largo[i]);
            }
            MessageBox.Show(nombres,"Mensaje Zukulemtozon!!!");
        }
    }
}
