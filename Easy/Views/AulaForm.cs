using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy.Views
{
    public partial class AulaForm : Form
    {
        private int moduloSelecionado;



        public AulaForm(int modulo)//construtor
        {
            InitializeComponent();
            moduloSelecionado = modulo; // Armazena o módulo
            this.Text = $"Módulo {moduloSelecionado}";
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // Obtenha o número da aula a partir do texto do botão (ex: "Aula 1")
            int aulaSelecionada = int.Parse(btn.Text.Replace("Aula ", ""));

            // Cria a tela de exercícios e passa o módulo e a aula selecionados
            ExercicioForm aula = new ExercicioForm(moduloSelecionado, aulaSelecionada);
            
            aula.Show();
            
        }


        private void FormAulas_Load(object sender, EventArgs e)
        {

        }


    }
}
