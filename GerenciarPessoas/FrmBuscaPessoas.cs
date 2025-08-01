﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciarPessoas
{
    public partial class FrmBuscaPessoas : Form
    {
        public FrmBuscaPessoas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ltbPessoas.Items.Clear();
            ltbPessoas.Items.Add(txtDescricao.Text);
            txtDescricao.Focus();
            txtDescricao.Clear();
        }

        private void ltbPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = ltbPessoas.SelectedItem.ToString();

            FrmCadPessoas abrir= new FrmCadPessoas(nome);
            abrir.Show();
            this.Hide();
        }
    }
}
