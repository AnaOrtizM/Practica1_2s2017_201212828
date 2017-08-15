using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Mensajes : Form
    {
        public Mensajes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal p = new Principal();
            p.Show();
        }

        private void btnEnviarMsjs_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnviarMensajes em = new EnviarMensajes();
            em.Show();
        }

        private void btnColaMsjs_Click(object sender, EventArgs e)
        {
            this.Hide();
            ColaMensajes cm = new ColaMensajes();
            cm.Show();
        }

        private void btnRespuestaMsj_Click(object sender, EventArgs e)
        {
            this.Hide();
            RespuestaMensajes rm = new RespuestaMensajes();
            rm.Show();
        }
    }
}
