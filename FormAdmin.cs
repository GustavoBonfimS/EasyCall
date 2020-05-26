﻿using EasyCall.modelo;
using EasyCall.Relatorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        { 
            var telaCadastro = new FormCadastro();
            telaCadastro.Show();
            this.Dispose();
        }

        private async void btnArquivo_Click(object sender, EventArgs e)
        {
            await Dados.carregarDados();
        }

        private void btnGerarR_Click(object sender, EventArgs e)
        {
            new FormOptions().Show();
        }
    }
}