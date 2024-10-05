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
    public partial class ContentForm : Form
    {
        private string selectedModule;
        private string selectedLesson;

        public ContentForm(string moduleName, string lessonName)
        {
            InitializeComponent();
            selectedModule = moduleName;
            selectedLesson = lessonName;
            LoadContent();
        }

        private void LoadContent()
        {
            // Simulando o carregamento de conteúdo para a lição
            string gifPath = @"C:\path\to\images\coffee.gif";
            string audioPath = @"C:\path\to\audios\coffee.wav";
            string englishText = "coffee";
            string portugueseText = "café";

            // Exibindo os conteúdos na tela
            PictureBox pictureBox = new PictureBox
            {
                ImageLocation = gifPath,
                Dock = DockStyle.Top,
                Height = 200
            };

            Label lblEnglish = new Label
            {
                Text = "English: " + englishText,
                Dock = DockStyle.Top
            };

            Label lblPortuguese = new Label
            {
                Text = "Portuguese: " + portugueseText,
                Dock = DockStyle.Top
            };

            Button btnPlayAudio = new Button
            {
                Text = "Play Audio",
                Dock = DockStyle.Top
            };

            btnPlayAudio.Click += (sender, e) => PlayAudio(audioPath);

            // Adiciona os componentes ao formulário
            Controls.Add(btnPlayAudio);
            Controls.Add(lblPortuguese);
            Controls.Add(lblEnglish);
            Controls.Add(pictureBox);
        }

        private void PlayAudio(string audioPath)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(audioPath);
            player.Play();
        }
    }
}
