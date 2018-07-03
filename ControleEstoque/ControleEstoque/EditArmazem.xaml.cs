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
    /// Interaction logic for EditArmazem.xaml
    /// </summary>
    public partial class EditArmazem : Window
    {

        Contexto ctx = new Contexto();

        int id;

        public EditArmazem(int ArmazemId)
        {
            InitializeComponent();
            id = ArmazemId;
        }

        private void btn_edit_salvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            
            ArmazemController armController = new ArmazemController();
            Armazem arm = armController.BuscarPorId(id);
            arm.Local = txt_edit_localArmazem.Text;
            arm.ArmazemDesc = txt_edir_descArmazem.Text;

            if (string.IsNullOrEmpty(txt_edit_localArmazem.Text))
                throw new NullReferenceException("O campo local é obrigatório.");

            if (string.IsNullOrEmpty(txt_edir_descArmazem.Text))
                throw new NullReferenceException("O campo descrição é obrigatório.");

            armController.Atualizar(arm);
            MessageBox.Show("Armazem atualizado!");

            ListarArmazens dg_listarArmazens = new ListarArmazens();
            dg_listarArmazens.Show();
            this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao atualizar armazem! (" + ex.Message + ")");
            }

        }
    }
}
