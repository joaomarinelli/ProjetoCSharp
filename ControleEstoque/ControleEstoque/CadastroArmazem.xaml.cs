﻿using Controllers;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControleEstoque
{
    /// <summary>
    /// Interaction logic for CadastroArmazem.xaml
    /// </summary>
    public partial class CadastroArmazem : Window
    {
        public CadastroArmazem()
        {
            InitializeComponent();
        }

        private void btn_salvarArmazem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Armazem arm = new Armazem();

                arm.Local= tb_local.Text;
                arm.ArmazemDesc = tb_DescArmazem.Text;

                ArmazemController armazemController = new ArmazemController();

                if (string.IsNullOrEmpty(tb_local.Text))
                    throw new NullReferenceException("O campo nome é obrigatório.");

                if (string.IsNullOrEmpty(tb_DescArmazem.Text))
                    throw new NullReferenceException("O campo descrição é obrigatório.");
                armazemController.Adicionar(arm);

                this.Close();
                MessageBox.Show("Armazem salvo com sucesso!");

                ListarArmazens dg_listarArmazens = new ListarArmazens();
                dg_listarArmazens.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o armazem (" + ex.Message + ")");
            }
        }
    }
}
