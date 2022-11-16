using mercearia_seu_joao.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mercearia_seu_joao.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<UsuarioBD> listaDeUsuario = new List<UsuarioBD>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EntrarMenu(object sender, MouseButtonEventArgs e)
        {
            VerificarUsuario();
        }

        private void EsquecerSenha(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Contate o seu Gerente!", "Informação", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void VerificarUsuario()
        {
            if(inserir_email.Text == usuario.email)
            {
                var frmTelaMenu = new Window1();
                frmTelaMenu.Show();
                Close();
            }

            else
            {
                MessageBox.Show("Contate o seu Gerente!", "Informação", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            inserir_email.Text = "";
            inserir_senha.Text = "";
        }
    }
}
