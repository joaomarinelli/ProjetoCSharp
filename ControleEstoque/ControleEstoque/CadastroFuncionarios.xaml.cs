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
    /// Interaction logic for CadastroFuncionarios.xaml
    /// </summary>
    public partial class CadastroFuncionarios : Window
    {
        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void btn_salvarFunc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Funcionario func = new Funcionario();

                func.NomeFuncionario = tb_nomeFunc.Text;
                func.Cargo = tb_cargoFunc.Text;

                FuncionarioController funcionarioController = new FuncionarioController();
                funcionarioController.Adicionar(func);

                MessageBox.Show("Funcionairo salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o funcionario (" + ex.Message + ")");
            }
        }

        private void dg_ListaFuncionarios(object sender, RoutedEventArgs e)
        {

        }
    }
}
