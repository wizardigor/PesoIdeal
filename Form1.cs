using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class frmCalculoDePessoal : Form
    {
        RadioButton rbnSelecionado = null;

        public frmCalculoDePessoal()
        {
            InitializeComponent();
        }

        private void RbnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton) sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }

            int SetPesoIdeal()
            {

                return 0;
            }
        }
    }
}
