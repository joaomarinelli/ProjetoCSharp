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
    /// Interaction logic for ListarFuncionarios.xaml
    /// </summary>
    public partial class ListarFuncionarios : Window
    {
        private static Contexto ctx = new Contexto();
        public ListarFuncionarios()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded_Funcionario(object sender, RoutedEventArgs e)
        {
            FuncionarioController funcionarioController = new FuncionarioController();
            dg_ListaFuncionarios.ItemsSource = funcionarioController.ListarTodos();
        }


        private void dg_ListaFuncionarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataGrid dg = ((DataGrid)sender);
                Funcionario func = (Funcionario)dg.Items[dg.SelectedIndex];
            }catch(Exception ex)
            {
                MessageBox.Show(" Operação inválida! (" + ex.Message + " )");
            }
            
        }

        private void btn_AddFuncionario_Click(object sender, RoutedEventArgs e)
        {
            CadastroFuncionarios cadFunc = new CadastroFuncionarios();
            cadFunc.Show();
            this.Close();
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = (dg_ListaFuncionarios.SelectedItem as Funcionario).FuncionarioId;
                EditFuncionario EditFunc = new EditFuncionario(id);
                EditFunc.Show();
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Operação inválida! (" + ex.Message+ " )");
            }
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int id = (dg_ListaFuncionarios.SelectedItem as Funcionario).FuncionarioId;
                FuncionarioController funcController = new FuncionarioController();

                funcController.Excluir(id);
                MessageBox.Show("Funcionário excluido com Sucesso!");

                ListarFuncionarios dg_listarFuncionarios = new ListarFuncionarios();
                dg_listarFuncionarios.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Operação inválida! (" + ex.Message + " )");
            }

        }


    }
}
