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
    public partial class ModuloForm : Form
    {
        private string ModuleName;

        public ModuloForm(string moduleName)
        {
            InitializeComponent();
            ModuleName = moduleName;
            LoadLessons();
        }

        private void LoadLessons()
        {
            // Simulando uma lista de lições por módulo
            var lessons = new Dictionary<string, List<string>>
        {
            { "Módulo 1", new List<string> { "Lição 1", "Lição 2", "Lição 3" } },
            { "Módulo 2", new List<string> { "Lição 1", "Lição 2", "Lição 3" } },
            { "Módulo 3", new List<string> { "Lição 1", "Lição 2", "Lição 3" } }
        };

            if (lessons.ContainsKey(ModuleName))
            {
                foreach (var lesson in lessons[ModuleName])
                {
                    Button btnLesson = new Button
                    {
                        Text = lesson,
                        Dock = DockStyle.Top
                    };
                    btnLesson.Click += (sender, e) => OpenLessonForm(lesson);
                    Controls.Add(btnLesson);
                }
            }
        }

        private void OpenLessonForm(string lessonName)
        {
            AulasForm aulasForm = new AulasForm(ModuleName, lessonName);
            aulasForm.Show();
        }
    }
}

