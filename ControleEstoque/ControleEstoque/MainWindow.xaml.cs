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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControleEstoque
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_materiais_Click(object sender, RoutedEventArgs e)
        {
            ListaMateriais listMat = new ListaMateriais();
            //cadUsu.Show();
            listMat.ShowDialog();
            //this.Close();
        }

        private void btn_funcionario_Click(object sender, RoutedEventArgs e)
        {
            ListarFuncionarios listFunc = new ListarFuncionarios();
            //cadUsu.Show();
            listFunc.ShowDialog();
            //this.Close();
        }

        private void btn_local_Click(object sender, RoutedEventArgs e)
        {
            ListarArmazens listArmazem = new ListarArmazens();
            //cadUsu.Show();
            listArmazem.ShowDialog();
            //this.Close();
        }

        private void btn_novoRegistro_Click(object sender, RoutedEventArgs e)
        {
            Retirada retirada = new Retirada();
            //cadUsu.Show();
            retirada.ShowDialog();
            //this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Retirada retirada = new Retirada();
            //cadUsu.Show();
            retirada.ShowDialog();
            //this.Close();
        }
    }
}
