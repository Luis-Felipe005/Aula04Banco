using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form2 : Form
    {

        // Variáveis globais 
        public List<String> extratos = new List<string>();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            int contador = 0;
            for (int i = 0; i < extratos.Count; i++)

            {

                listExtratos.Items.Add(extratos[i]);

            }

          
           



        }
    }
}
