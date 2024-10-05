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
    using System.Media; // Adicione esta linha para importar a classe SoundPlayer

    public partial class AulasForm : Form
    {
        private string ModuleName;
        private string LessonName;

        public AulasForm(string moduleName, string lessonName)
        {
            InitializeComponent();
            ModuleName = moduleName;
            LessonName = lessonName;
            LoadContent();
        }

        private void LoadContent()
        {
            // Simulação de conteúdo por lição
            var content = new Dictionary<string, (string Gif, string Audio, string TextEn, string TextPt)>
        {
            { "Lição 1", ("coffee.gif", "coffee.wav", "coffee", "café") },
            { "Lição 2", ("tea.gif", "tea.wav", "tea", "chá") },
            { "Lição 3", ("water.gif", "water.wav", "water", "água") }
        };

            if (content.ContainsKey(LessonName))
            {
                var lessonContent = content[LessonName];
                Tela.Image = Image.FromFile(lessonContent.Gif);
                lblIngles.Text = lessonContent.TextEn;
                lblPortugues.Text = lessonContent.TextPt;

                // Adicionar um botão para tocar o áudio
                Button btnAudio = new Button
                {
                    Text = "Tocar Áudio",
                    Dock = DockStyle.Top
                };
                btnAudio.Click += (sender, e) => PlayAudio(lessonContent.Audio); // Define o evento click
                Controls.Add(btnAudio);
            }
        }

        // Método para tocar o áudio usando SoundPlayer
        private void PlayAudio(string audioFile)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(audioFile); // Carrega o arquivo de áudio
                player.Play(); // Toca o áudio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao reproduzir áudio: " + ex.Message);
            }
        }
    }
}
