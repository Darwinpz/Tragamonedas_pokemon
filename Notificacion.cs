using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tragamonedas_pokemon.Properties;

namespace Tragamonedas_pokemon
{
    public partial class Notificacion : Form
    {

        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;

        public Notificacion(bool ganaste)
        {
            InitializeComponent();

            if (ganaste)
            {
                LBL_MENSAJE.Text = "¡ACERTASTE!";

                IMAGEN.Image = Resources.ganaste;
            }

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }

        private void BTN_ACEPTAR_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
