﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaWindowsForm.Cidade;
using UrnaWindowsForm.Consultas;
using UrnaWindowsForm.Funcoes;

namespace UrnaWindowsForm.Interface.CadastroCargoInterface
{
    public partial class CPrefeito : Form
    {
        public CPrefeito()
        {
            InitializeComponent();
            
        }

        private void BntCadastrarPresidente_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            Prefeito prefeito = new Prefeito();
            inserir.Cadastrar(6, Convert.ToInt32(txtNumPrefeito.Text), txtNomePrefeito.Text, ComboBox.SelectedItem.ToString(),prefeito.ConsultaPrefeito());
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultaCidade conCidade = new ConsultaCidade();
            if (ComboBox.SelectedItem.ToString() == "RJ")
            {
                comboBox1.Items.Add(conCidade.ResultadoSigla(ComboBox.SelectedItem.ToString())); 
            }
        }
    }
}
