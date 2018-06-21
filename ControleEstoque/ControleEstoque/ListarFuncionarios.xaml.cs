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
    /// Interaction logic for ListarFuncionarios.xaml
    /// </summary>
    public partial class ListarFuncionarios : Window
    {
        public ListarFuncionarios()
        {
            InitializeComponent();
        }

        private void btn_AddFuncionario_Click(object sender, RoutedEventArgs e)
        {
            CadastroFuncionarios cadFunc = new CadastroFuncionarios();
            //cadUsu.Show();
            cadFunc.ShowDialog();
            //this.Close();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
