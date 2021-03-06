﻿using Controllers;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Interaction logic for EditMaterial.xaml
    /// </summary>
    public partial class EditMaterial : Window
    {
        Context ctx = new Context();

        int Id;

        public EditMaterial(int MaterialId)
        {
            InitializeComponent();
            Id = MaterialId;
        }

        private void btn_salvar_update_material_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            
            MaterialController materialController = new MaterialController();
            Material mat = materialController.BuscarPorId(Id);
            mat.MaterialNome = tb_update_nome_material.Text;
            mat.MaterialDesc = tb_update_desc_material.Text;
            mat.QuantidadeCadastrada = tb_update_qtde_material.Text;

            if (string.IsNullOrEmpty(tb_update_nome_material.Text))
                throw new NullReferenceException("O campo nome é obrigatório.");
            if (string.IsNullOrEmpty(tb_update_desc_material.Text))
                throw new NullReferenceException("O campo descrição é obrigatório.");
            if (string.IsNullOrEmpty(tb_update_qtde_material.Text))
                throw new NullReferenceException("O campo quantidade é obrigatório.");
            materialController.Atualizar(mat);
            MessageBox.Show("Material salvo com sucesso!");

                ListaMateriais dg_listarMateriais = new ListaMateriais();
                dg_listarMateriais.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar material! (" + ex.Message + ")");
            }
        }
    }
}
