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

    public class Materiais
    {

    }
    /// <summary>
    /// Interaction logic for Retirada.xaml
    /// </summary>
    public partial class Retirada : Window
    {
        public Retirada()
        {
            InitializeComponent();
        }
        private void cbo_listaMateriais(object sender, TextChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Material mat = (Material)dg.Items[dg.SelectedIndex];
        }

        private void tb_qtde_retirada_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cb_listaMateriais(object sender, RoutedEventArgs e)
        {

        }

        private void cbo_listaMateriais(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
