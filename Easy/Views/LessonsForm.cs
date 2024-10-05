using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ActivationContext;

namespace Easy.Views
{
    public partial class LessonsForm : Form
    {
        private string selectedModule;

        public LessonsForm(string moduleName)
        {
            InitializeComponent();
            selectedModule = moduleName;
            LoadLessons();
        }

        private void LoadLessons()
        {
            // Simulando uma lista de lições do módulo selecionado
            var lessons = new List<string> { "Lição 1", "Lição 2", "Lição 3" };

            foreach (var lesson in lessons)
            {
                Button btnLesson = new Button
                {
                    Text = lesson,
                    Dock = DockStyle.Top
                };
                btnLesson.Click += (sender, e) => OpenContentForm(lesson);
                Controls.Add(btnLesson);
            }
        }

        private void OpenContentForm(string lessonName)
        {
            // Abre a tela de conteúdo passando a lição selecionada
            ContentForm contentForm = new ContentForm(selectedModule, lessonName);
            contentForm.Show();
        }
    }
}

