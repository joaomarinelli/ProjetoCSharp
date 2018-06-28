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
        int Id;

        public EditArmazem()
        {
            InitializeComponent();
        }

        private void btn_Atualiza_Armazem_Click(object sender, RoutedEventArgs e, int? id)
        {
            Armazem armazem = new Armazem();
            var row = ctx.Armazens.Where(a => a.ArmazemId == id).FirstOrDefault();

            row.Local = txt_editar_NomeArmazem.Text;
            row.ArmazemDesc = txt_Editar_DescArmazem.Text;
            ArmazemController armazemController = new ArmazemController();
            ctx.SaveChanges();

           
        }

        private void btn_Atualiza_Armazem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
