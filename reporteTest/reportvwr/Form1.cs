using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace reportvwr
{
    public partial class Form1 : Form
    {
        
        int[] largo = { 3, 15, 12, 3, 6, 4, 5 };
        int[] largo2 = { 15, 10, 12, 8, 5 };
        string[] datos = { "HL", "Hitomi", "Laine", "25", "921123", "JM", "AGS", "MX" };
        string[] datos2 = { "Mirai Nikki", "Clannad", "Death Note", "Totoro","SNK"};

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
            string now = DateTime.Now.ToString("yyMMdd_hhmm");

            string nombres = "";
            string series = "";
            for (int i = 0; i < largo.Length; i++)
            {
                nombres = nombres + "" + hl(datos[i], largo[i]);
            }
            for (int i = 0; i < largo2.Length; i++)
            {
                series = series + "" + hl(datos2[i], largo2[i]);
            }
            
            string folder = @"C:\output\";
            string path = folder + now + ".txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = nombres + "\r\n" + series  + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            /*This text is always added, making the file longer over time
            if it is not deleted.*/
            //string appendText = "This is extra text" + Environment.NewLine;
            //File.AppendAllText(path, appendText);

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);

            
            
            //MessageBox.Show(nombres+ "\r\n" +series,"Mensaje Zukulemtozon!!!");
        }
    }
}
