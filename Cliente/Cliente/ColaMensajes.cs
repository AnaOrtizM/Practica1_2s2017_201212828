﻿using System;
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
    public partial class ColaMensajes : Form
    {
        public ColaMensajes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mensajes msj = new Mensajes();
            msj.Show();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

        }
    }
}
