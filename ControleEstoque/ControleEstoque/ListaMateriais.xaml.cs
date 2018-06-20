using Controllers;
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
        public ListaMateriais()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MaterialController materialController = new MaterialController();
            dg_ListaMateriais.ItemsSource = materialController.ListarTodos();
        }


        private void dg_ListaMateriais_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Material mat = (Material)dg.Items[dg.SelectedIndex];
        }

        private void btn_AddMateriais_Click(object sender, RoutedEventArgs e)
        {
            CadastroMateriais cadMat = new CadastroMateriais();
            //cadUse.Show();
            cadMat.ShowDialog();
            //this.Close();
        }
    }
}   
