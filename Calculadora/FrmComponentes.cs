using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmComponentes : Form
    {
        public FrmComponentes()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Executar a classe/objeto Tampa
            Tampa tp = new Tampa();
            tp.tampar();
        }

        

        
    }
}
