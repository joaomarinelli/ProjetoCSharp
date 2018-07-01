using Controllers;
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
    /// Interaction logic for EditFuncionario.xaml
    /// </summary>
    public partial class EditFuncionario : Window
    {
        Context ctx = new Context();
        int id;
        public EditFuncionario(int FuncionarioId)
        {
            InitializeComponent();
            id = FuncionarioId;
        }

        private void btn_salvarFunc_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                FuncionarioController funcController = new FuncionarioController();
                Funcionario func = funcController.BuscarPorId(id);
                func.NomeFuncionario = tb_nomeFunc.Text;
                func.Cargo = tb_cargoFunc.Text;

                funcController.Atualizar(func);
                MessageBox.Show("Funcionairo atualizado com sucesso!");

                ListarFuncionarios dg_listarFuncionarios = new ListarFuncionarios();
                dg_listarFuncionarios.Show();
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao atualizar funcionário! ("+ex.Message+")");
            }

        }
    }
}
