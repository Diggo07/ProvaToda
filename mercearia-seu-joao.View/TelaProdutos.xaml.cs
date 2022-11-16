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
    /// Lógica interna para TelaProdutos.xaml
    /// </summary>
    public partial class TelaProdutos : Window
    {
        List<Produto> listaDeProdutos = new List<Produto>();
        public TelaProdutos()
        {
            InitializeComponent();


            AtualizaDataGrid();
        }

        private void ClickNovo(object sender, RoutedEventArgs e)
        {
            if (VerificaCampos() == true)
            {
                AdicionaProduto();
                AtualizaDataGrid();
                MessageBoxResult result = MessageBox.Show(
                    "Produto cadastrado!",
                    "Sucesso",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                LimparCampos();
            }
        }

        private void ClickLimpar(object sender, RoutedEventArgs e)
        {
            LimparCampos();
        }

        private void ClickAlterar(object sender, RoutedEventArgs e)
        {
            if (txtIdProduto.Text != "")
            {
                int id = int.Parse(txtIdProduto.Text);
                MessageBoxResult result = MessageBox.Show(
                    $"Deseja alterar o produto id:{id}?",
                    "Alterar Produto",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    for(int i = 0; i < listaDeProdutos.Count; i++)
                    {
                        if(listaDeProdutos[i].id == id)
                        {
                            listaDeProdutos[i].nome = txtNomeProduto.Text;
                            listaDeProdutos[i].qnt = int.Parse(txtQntd1.Text);
                            listaDeProdutos[i].preco = int.Parse(txtPreco1.Text);
                            listaDeProdutos[i].fornecedor = txtFornecedor1.Text;
                            break;
                        }
                    }
                    AtualizaDataGrid();
                    MessageBoxResult result1 = MessageBox.Show(
                    "Produto Alterado!",
                    "Atenção",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                    LimparCampos();
                }
            }
        }

        private void ClickExcluir(object sender, RoutedEventArgs e)
        {
            if(txtIdProduto.Text != "")
            {
                int id = int.Parse(txtIdProduto.Text);
                MessageBoxResult result = MessageBox.Show(
                    $"Deseja excluir o produto id:{id}?",
                    "Excluir Produto",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if(result == MessageBoxResult.Yes)
                {
                    foreach(Produto produto in listaDeProdutos)
                    {
                        if(produto.id == id)
                        {
                            listaDeProdutos.Remove(produto);
                            break;
                        }
                    }
                    AtualizaDataGrid();
                    MessageBoxResult result1 = MessageBox.Show(
                    "Produto Excluído!",
                    "Atenção",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                    LimparCampos();
                }
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private bool VerificaCampos()
        {
            if (txtNomeProduto.Text != "" && txtQntd1.Text != "" && txtPreco1.Text != "" && txtFornecedor1.Text != "")
            {
                return true;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                    "Preencha todos os campos!",
                    "Atenção",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return false;
            }
        }

        private int RetornaUltimoIdIncrementadoDaLista()
        {
            int id = 0;
            if(listaDeProdutos.Count > 0)
            {
                int index = listaDeProdutos.Count - 1;
                id = listaDeProdutos[index].id;
            }
            id++;
            return id;
        }

        private void AtualizaDataGrid()
        {
            dataGridProdutos.ItemsSource = listaDeProdutos;
            dataGridProdutos.Items.Refresh();
        }

        private void LimparCampos()
        {
            txtFornecedor1.Text = "";
            txtIdProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQntd1.Text = "";
            txtPreco1.Text = "";
        }

        private void AdicionaProduto()
        {
            Produto produto = new Produto();
            produto.id = RetornaUltimoIdIncrementadoDaLista();
            produto.nome = txtNomeProduto.Text;
            produto.fornecedor = txtFornecedor1.Text;
            produto.qnt = int.Parse(txtQntd1.Text);
            produto.preco = int.Parse(txtPreco1.Text);
            listaDeProdutos.Add(produto);
        }

        private void PegarItemNoGrid(object sender, MouseButtonEventArgs e)
        {
            Produto produto = (Produto)dataGridProdutos.SelectedItem;
            txtIdProduto.Text = produto.id.ToString();
            txtNomeProduto.Text = produto.nome;
            txtQntd1.Text = produto.qnt.ToString();
            txtPreco1.Text = produto.preco.ToString();
            txtFornecedor1.Text = produto.fornecedor;
        }
    }
}
