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
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataDeHoje();
        }
        public void DataDeHoje()
        {
            string diadehoje = DateTime.Now.ToString(" d MMMM 'de' yyyy");
            txtOlaUsuario.Text = $"Olá, hoje é dia {diadehoje}";
        }


        private void ClickProdutos(object sender, RoutedEventArgs e)
        {
            var frmTelaProdutos = new TelaProdutos();
            frmTelaProdutos.Show();
        }

        private void ClickUsuario(object sender, RoutedEventArgs e)
        {
            var frmTelaUsuario = new TelaUsuario();
            frmTelaUsuario.Show();
        }

        private void ClickVenda(object sender, RoutedEventArgs e)
        {
            var frmTelaVenda = new TelaVenda();
            frmTelaVenda.Show();
        }

        private void ClickSair(object sender, RoutedEventArgs e)
        {
            var frmTelaLogin = new MainWindow();
            frmTelaLogin.Show();
            Close();
        }
    }
}
