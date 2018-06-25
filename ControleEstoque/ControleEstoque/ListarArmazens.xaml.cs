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
    /// Interaction logic for ListarArmazens.xaml
    /// </summary>
    public partial class ListarArmazens : Window
    {
        public ListarArmazens()
        {
            InitializeComponent();
        }
        private void Window_Loaded_Armazem(object sender, RoutedEventArgs e)
        {
            ArmazemController armazemController = new ArmazemController();
            dg_ListarArmazens.ItemsSource = armazemController.ListarTodos();
        }

        private void dg_armazens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Armazem arm = (Armazem)dg.Items[dg.SelectedIndex];
        }

        private void btn_AddArmazem_Click(object sender, RoutedEventArgs e)
        {
            CadastroArmazem cadArm = new CadastroArmazem();

            cadArm.Show();
            this.Close();

        }
    }
}
