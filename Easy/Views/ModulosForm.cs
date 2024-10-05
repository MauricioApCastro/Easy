
using Easy.Views;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy
{
    public partial class ModulosForm : Form
    {
        public ModulosForm()//construtor
        {
            InitializeComponent();//inicializa os componentes
            this.WindowState = FormWindowState.Maximized;//maximiza a janela
        }
        
        
        private void btnModulo_Click(object sender, EventArgs e)//evento de clique no botão
        { 
            Button btn = (Button)sender; // Obtém o botão clicado
            int moduloSelecionado = int.Parse(btn.Text.Replace("Módulo ", ""));//obtém o número do módulo selecionado
            AulaForm aula = new AulaForm(moduloSelecionado);//cria um novo formulário de aula
            aula.Show();//exibe o formulário de aula
        }
        private void BtnModulo12_Click(object sender, EventArgs e)//evento de clique no botão
        {
            var dbManager = new DatabaseManager();//instancia um novo gerenciador de banco de dados

            // Tenta criar o banco de dados
            try
            {
                dbManager.CriarBancoDeDados(); // Cria o banco de dados se não existir
                MessageBox.Show("Banco de dados criado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar banco de dados: {ex.Message}");
            }

            // Adiciona exercícios ao banco de dados
            try
            {
                dbManager.AdicionarExerciciosPorAula("C:\\Users\\MAC\\source\\Repos\\MauricioApCastro\\SoftwareIngles\\Easy\\Repository\\Modulo1", "M1", "A1");
                MessageBox.Show("Exercícios adicionados com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar exercícios: {ex.Message}");
            }
        }

        private void ModulosForm_Load(object sender, EventArgs e)//evento de carregamento do formulário
        {
          
        }

    }
    
}