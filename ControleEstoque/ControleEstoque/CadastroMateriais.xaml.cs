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
    /// Interaction logic for CadastroMateriais.xaml
    /// </summary>
    public partial class CadastroMateriais : Window
    {
        public CadastroMateriais()
        {
            InitializeComponent();
            bindcombo();
        }

        public List<Armazem> Lista { get; set; }
        private void bindcombo()
        {
            // throw new NotImplementedException();
           Contexto ctx = new Contexto();
           var item = ctx.Armazens.ToList();
           Lista = item;
           DataContext = Lista;
        }

        private void btn_SalvarMaterial_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Material mat = new Material();

               // mat.Local_Armazem = (Armazem)this.cbo_armazens.SelectedItem;

                mat.MaterialNome = tb_NomeMaterial.Text;
                mat.MaterialDesc = tb_MaterialDesc.Text;
                //mat.Local_Armazem = cbo_armazens
                //mat.Local_Armazem = cbo_armazens.SelectedItem.ToString;
                var selectedItem = ((Armazem)cbo_armazens.SelectedItem).ArmazemId;

                //mat.Local_Armazem = 
                //cbo_armazens.SelectedItem = Convert.ToInt32(cbo_armazens);
                //ComboBoxItem cbi = cbo_armazens.ItemContainerGenerator.ContainerFromItem(selectedItem) as ComboBoxItem;

                MaterialController materialController = new MaterialController();
                materialController.Adicionar(mat);
                this.Close();
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

        private void cbo_materiais_armazens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void cbo_armazens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
