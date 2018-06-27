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
    /// Interaction logic for EditMaterial.xaml
    /// </summary>
    public partial class EditMaterial : Window
    {
        Context ctx = new Context();

        int Id;

        public EditMaterial(int MaterialId)
        {
            InitializeComponent();
            Id = MaterialId;
        }

        private void btn_salvar_update_material_Click(object sender, RoutedEventArgs e)
        {
            Material mat = new Material();

            MaterialController materialController = new MaterialController();
            materialController.Atualizar(mat);
            this.Close();
            MessageBox.Show("Material salvo com sucesso!");
        }
    }
}
