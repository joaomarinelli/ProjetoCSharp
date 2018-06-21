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
    /// Interaction logic for CadastroMateriais.xaml
    /// </summary>
    public partial class CadastroMateriais : Window
    {
        public CadastroMateriais()
        {
            InitializeComponent();
        }

        private void btn_SalvarMaterial_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Material mat = new Material();

                mat.MaterialNome = tb_NomeMaterial.Text;
                mat.MaterialDesc = tb_MaterialDesc.Text;

                MaterialController materialController = new MaterialController();
                materialController.Adicionar(mat);

                MessageBox.Show("Material salvo com sucesso!");

                ListaMateriais dg_ListaMateriais = new ListaMateriais();
                dg_ListaMateriais.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o usuário (" + ex.Message + ")");
            }
        }

        private void tb_NomeMaterial_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_ListarMateriais_Click(object sender, RoutedEventArgs e)
        {
            ListaMateriais telaListaMateriais = new ListaMateriais();
            telaListaMateriais.ShowDialog();
        }
    }
}
