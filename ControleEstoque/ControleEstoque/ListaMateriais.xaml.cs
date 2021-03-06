﻿using Controllers;
using Controllers.DAL;
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
    /// Interaction logic for ListaMateriais.xaml
    /// </summary>
    public partial class ListaMateriais : Window
    {

        private static Contexto ctx = new Contexto();
        public ListaMateriais()
        {
            InitializeComponent();
        }

        private void dg_ListaMateriais_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Material mat = (Material)dg.Items[dg.SelectedIndex];
        }

        private void Windows_Loaded_Materiais(object sender, RoutedEventArgs e)
        {
            MaterialController materialController = new MaterialController();
            dg_ListaMateriais.ItemsSource = materialController.ListarTodos();
        }

        

        private void btn_AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            CadastroMateriais cadMat = new CadastroMateriais();
            cadMat.Show();
            this.Close();
        }

        private void btnUpdate_Material_Click(object sender, RoutedEventArgs e)
        {
            int id = (dg_ListaMateriais.SelectedItem as Material).MaterialId;
            EditMaterial EditMat = new EditMaterial(id);
            EditMat.Show();
            this.Close();
        }

        private void btnDelete_Material_Click(object sender, RoutedEventArgs e)
        {
            int id = (dg_ListaMateriais.SelectedItem as Material).MaterialId;
            MaterialController matController = new MaterialController();

            matController.Excluir(id);
            MessageBox.Show("Material excluido com Sucesso!");

            ListaMateriais dg_listamateriais = new ListaMateriais();
            dg_listamateriais.Show();
            this.Close();
        }
    }
}   
