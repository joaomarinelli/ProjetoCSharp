using Controllers;
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

        private void dg_ListaMateriais_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Material mat = (Material)dg.Items[dg.SelectedIndex];
        }

        private void Windows_Loaded_Materiais(object sender, RoutedEventArgs e)
        {
            MaterialController materialController = new MaterialController();
            dg_ListaMateriais.ItemsSource = materialController.ListarTodos();
        }

        private void btn_adicionar_material_Click(object sender, RoutedEventArgs e)
        {
            CadastroMateriais cadMat = new CadastroMateriais();
            cadMat.Show();

            this.Close();

            /* Material material = new Material();


             material.CodMaterial = Convert.ToInt32(txt_id_material.Text);
             material.MaterialNome = txt_nome_material1.Text;    
             material.MaterialDesc = txt_desc_material.Text;
             material.QuantidadeCadastrada = txt_qtde_material.Text;
             MaterialController materialController = new MaterialController();
             materialController.Adicionar(material);
             dg_ListaMateriais.ItemsSource = ctx.Materiais.ToList();*/

        }

        private void btn_salvar_material_Click(object sender, RoutedEventArgs e)
        {
            Material material = new Material();
            int cod = Convert.ToInt32(txt_id_material.Text);
            var row = ctx.Materiais.Where(m => m.CodMaterial == cod).FirstOrDefault();
            row.MaterialNome = txt_nome_material1.Text;
            row.MaterialDesc = txt_desc_material.Text;
            row.QuantidadeCadastrada = txt_qtde_material.Text;
            MaterialController materialController = new MaterialController();
            ctx.SaveChanges();
            dg_ListaMateriais.ItemsSource = ctx.Materiais.ToList();
        }

        private void btn_excluir_material_Click(object sender, RoutedEventArgs e)
        {
            Material material = new Material();
            int cod = Convert.ToInt32(txt_id_material.Text);
            var row = ctx.Materiais.Where(m => m.CodMaterial == cod).FirstOrDefault();
            MaterialController materialController = new MaterialController();
            ctx.Materiais.Remove(row);
            ctx.SaveChanges();
            dg_ListaMateriais.ItemsSource = ctx.Materiais.ToList();
        }
    }
}   
