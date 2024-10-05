using Easy.Models;
using System;
using System.Drawing;
using System.Globalization; // Para CultureInfo
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis; // Para SpeechSynthesizer
using System.Windows.Forms;

namespace Easy.Views
{
    public partial class ExercicioForm : Form
    {
        private int moduloSelecionado;
        private int aulaSelecionada;
        private int exercicioSelecionado = 1;
        private int exercicioIndex = 1;
        private int totalDeExercicios = 8;

        private SpeechRecognitionEngine reconhecedor;
        private SpeechSynthesizer sintetizador;
        private CultureInfo ci = new CultureInfo("en-US");
        private int n;
        private Image imagemOriginal; // Para armazenar a imagem original


        // Add this method to the ExercicioForm class
        private void lblCodigo_Click(object sender, EventArgs e)
        {
            // Implement the event handler logic here
            MessageBox.Show("Label Código clicked!");
        }


        public ExercicioForm(int modulo, int aula)
        {
            InitializeComponent();
            moduloSelecionado = modulo;
            aulaSelecionada = aula;
            axWindowsMediaPlayer1.Visible = false;

            AtualizarCodigo();
            this.WindowState = FormWindowState.Maximized;

            // Configuração do sintetizador e reconhecimento de fala
            sintetizador = new SpeechSynthesizer();
            ConfigurarReconhecimento();
            // Configuração inicial dos botões
            ConfigurarBotao(btnOuvir);
            ConfigurarBotao(btnFalar);
            ConfigurarBotao(btnEscrever);
            // Para esconder o label do código
            lblCodigo.Visible = false; // Isso oculta o label

            // Carregar a imagem original
            imagemOriginal = btnProxima.Image; // Defina a imagem que você já tem
            btnProxima.Image = imagemOriginal; // Atribuir a imagem ao botão

        }

        private void ConfigurarReconhecimento()
        {
            try
            {
                reconhecedor = new SpeechRecognitionEngine(ci);
                Choices escolhas = new Choices();
                escolhas.Add(new string[] { "coffee", "water", "milk", "tea", "juice", "beer", "wine", "soda" }); // Adicione as palavras que deseja reconhecer

                GrammarBuilder gb = new GrammarBuilder();
                gb.Append(escolhas);
                Grammar gramática = new Grammar(gb);

                reconhecedor.LoadGrammar(gramática);
                reconhecedor.SetInputToDefaultAudioDevice();
                reconhecedor.SpeechRecognized += ReconhecerPalavra;
                reconhecedor.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao configurar reconhecimento de fala: " + ex.Message);
            }
        }

        private void ReconhecerPalavra(object sender, SpeechRecognizedEventArgs e)
        {
            string frase = e.Result.Text;
            string legenda = lblEn.Text;
            if (frase == legenda)
            {
                btnFalar.Text = "Acertou!";
                timerFalar.Enabled = false;
                timerEscrever.Enabled = true;
                textBoxProfessor.Visible = true;
                textBoxProfessor.KeyDown += textBoxProfessor_KeyDown;
                textBoxProfessor_KeyDown(sender, new KeyEventArgs(Keys.Enter));
            }
            else
            {
                btnFalar.Text = "Repetir!";

            }





        }
        // Método para configurar os botões e associar os eventos
        private void ConfigurarBotao(Button botao)
        {
            // Configurações de estilo da fonte
            botao.Font = new Font("Comic Sans MS", 48, FontStyle.Bold | FontStyle.Italic);
            botao.BackColor = this.BackColor;  // Mesma cor do fundo para esconder o botão
            botao.FlatStyle = FlatStyle.Flat;  // Remove bordas do botão
            botao.FlatAppearance.BorderSize = 0;  // Sem bordas visíveis
            botao.ForeColor = Color.White;  // Cor da fonte (ajuste se necessário para visibilidade)

            // Eventos para animar ao passar o mouse
            botao.MouseEnter += new EventHandler(Botao_MouseEnter);
            botao.MouseLeave += new EventHandler(Botao_MouseLeave);
        }

        // Método para aumentar a imagem
        private Image AumentarImagem(Image img, float fator)
        {
            int novaLargura = (int)(img.Width * fator);
            int novaAltura = (int)(img.Height * fator);
            Bitmap novaImagem = new Bitmap(novaLargura, novaAltura);

            using (Graphics g = Graphics.FromImage(novaImagem))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, novaLargura, novaAltura);
            }

            return novaImagem;
        }

        // Evento ao passar o mouse sobre o botão (aumenta a imagem)
        private void botaoProximo_MouseEnter(object sender, EventArgs e)
        {
            btnProxima.Image = AumentarImagem(imagemOriginal, 1.2f); // Aumenta 20%
        }

        // Evento ao retirar o mouse do botão (retorna à imagem original)
        private void botaoProximo_MouseLeave(object sender, EventArgs e)
        {
            btnProxima.Image = imagemOriginal; // Retorna à imagem original
        }

        // Evento ao passar o mouse sobre o botão (aumenta a fonte)
        private void Botao_MouseEnter(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            botao.Font = new Font("Comic Sans MS", 54, FontStyle.Bold | FontStyle.Italic); // Aumenta o tamanho da fonte
        }

        // Evento ao retirar o mouse do botão (retorna à fonte original)
        private void Botao_MouseLeave(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            botao.Font = new Font("Comic Sans MS", 48, FontStyle.Bold | FontStyle.Italic); // Retorna ao tamanho original
        }
        private void btnProxima_Click(object sender, EventArgs e)
        {

            exercicioIndex++;

            if (exercicioIndex <= totalDeExercicios)
            {
                string codigo = $"M{moduloSelecionado}A{aulaSelecionada}E{exercicioIndex}";
                lblCodigo.Text = codigo;
                this.Text = $"Módulo {moduloSelecionado} - Aula {aulaSelecionada} - Exercício {exercicioIndex}";
                CarregarExercicio(codigo);
            }
            else
            {
                MessageBox.Show("Você já visualizou todos os exercícios desta aula.");
                exercicioIndex--;
            }

            btnEscrever.Text = "Escrever";
            btnOuvir.Text = "Ouvir";
            btnFalar.Text = "Falar";
            textBoxProfessor.Visible = false;
            timerOuvir.Enabled = true;
        }

        private void AtualizarCodigo()
        {
            string codigoFinal = $"M{moduloSelecionado}A{aulaSelecionada}E{exercicioSelecionado}";
            lblCodigo.Text = codigoFinal;
            this.Text = $"Módulo {moduloSelecionado} - Aula {aulaSelecionada} - Exercício {exercicioSelecionado}";
        }

        private void Aula_Load(object sender, EventArgs e)
        {
            string codigoExercicio = lblCodigo.Text;
            CarregarExercicio(codigoExercicio);

        }

        public void CarregarExercicio(string codigoExercicio)
        {
            using (var context = new MeuContexto())
            {
                var exercicio = context.Exercicios.FirstOrDefault(e => e.Codigo == codigoExercicio);

                if (exercicio != null)
                {
                    lblEn.Text = exercicio.TextoEn;
                    lblPt.Text = exercicio.TextoPt;
                    pictureBoxTela.ImageLocation = exercicio.Gif;
                    btnOuvir.Tag = exercicio.Mp3;
                }
                else
                {
                    MessageBox.Show("Exercício não encontrado.");
                }
            }
        }

        private void ModulosForm_Load(object sender, EventArgs e)
        {
            string codigoExercicio = lblCodigo.Text;
            CarregarExercicio(codigoExercicio);

        }

        private void btnOuvir_Click(object sender, EventArgs e)
        {
            string caminhoMp3 = btnOuvir.Tag.ToString();
            if (!string.IsNullOrEmpty(caminhoMp3))
            {
                axWindowsMediaPlayer1.URL = caminhoMp3;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Arquivo de áudio não encontrado.");
            }
        }

        private void btnFalar_Click(object sender, EventArgs e)
        {
            // Pega o texto em inglês e usa o sintetizador para falar
            string textoParaFalar = lblEn.Text;
            if (!string.IsNullOrEmpty(textoParaFalar))
            {
                sintetizador.SpeakAsync(textoParaFalar);
            }
            else
            {
                MessageBox.Show("Texto não encontrado para falar.");
            }
        }

        private void pictureBoxTela_Click(object sender, EventArgs e)
        {
            // Implementação para click no PictureBox, se necessário
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (reconhecedor != null)
            {
                reconhecedor.RecognizeAsyncStop();
                reconhecedor.Dispose();
            }
            base.OnFormClosing(e);
        }

        private void timerFalar_Tick(object sender, EventArgs e)
        {
            n = n == 58 ? 48 : 58;  // Alterna entre 48 e 58
            btnFalar.Font = new Font("Comic Sans MS", n, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);


        }

        private void btnEscrever_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerOuvir_Tick(object sender, EventArgs e)
        {
            n = n == 58 ? 48 : 58;  // fonte alterna entre 48 e 58
            btnOuvir.Font = new Font("Comic Sans MS", n, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);

        }

        private void timerEscrever_Tick(object sender, EventArgs e)
        {
            n = n == 58 ? 48 : 58;  // Alterna entre 48 e 58
            btnEscrever.Font = new Font("Comic Sans MS", n, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        }

        private void btnFalar_Click_1(object sender, EventArgs e)
        {
            timerOuvir.Enabled = false;
            timerFalar.Enabled = true;
            btnFalar.Text = "Gravando";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBoxProfessor.Focus();

        }
        private void textBoxProfessor_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string legenda = lblEn.Text;
                if (textBoxProfessor.Text == "") 
                {
                    btnEscrever.Text = "Escreva!";
                    timerEscrever.Enabled = true;
                    
                }
                else if (textBoxProfessor.Text == legenda)
                {
                    btnEscrever.Text = "Acertou!";
                    timerEscrever.Enabled = true;
                    btnProxima.Visible = true;

                }
                else
                {
                    btnEscrever.Text = "Repetir!";
                    timerEscrever.Enabled = true;
                }
            }

        }

    }
}
