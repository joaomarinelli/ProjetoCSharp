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
            Funcionario func = new Funcionario();
            FuncionarioController funcController = new FuncionarioController();
            funcController.Atualizar(func);
            this.Close();
            MessageBox.Show("Funcionario Atualizado com sucesso!");
        }
    }
}
