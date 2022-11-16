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

namespace mercearia_seu_joao.View
{
    /// <summary>
    /// Lógica interna para TelaVenda.xaml
    /// </summary>
    public partial class TelaVenda : Window
    {

        List<ProdutoBD> listaProdutos = new List<ProdutoBD>();
    
        public TelaVenda()
        {
            InitializeComponent();
        }

        private void ClickLimparVenda(object sender, RoutedEventArgs e)
        {
            LimparCampos();
        }

        private void ClickAdicionar(object sender, RoutedEventArgs e)
        {

        }

        private void ClickRealizarVenda(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Venda Realizada!", "Informação", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }

        private void ClickBuscar(object sender, RoutedEventArgs e)
        {
            if (campoIDVenda.Text == "")
            {
                campoIDVenda.IsReadOnly = true;
            }
            else
            {
                campoIDVenda.IsReadOnly = false;
            }
        }

        private void LimparCampos()
        {
            campoIDVenda.Text = "";
            campoNomeVenda.Text = "";
            campoQntdVenda.Text = "";
            campoPrecoTotal.Text = "";
        }
    }
}
