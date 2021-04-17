using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obtener_Texto_de_un_Texbox_e_imprimir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string informacion = TxtInformacion.Text;
            string info2 = TxtInfo.Text;
            MessageBox.Show(""+ info2 + informacion);        }
    }
}
