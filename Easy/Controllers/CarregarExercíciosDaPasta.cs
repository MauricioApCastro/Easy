using Easy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy
{
    internal class CarregarExercíciosDaPasta
    {
        

public void CarregarExerciciosDaPasta(string pasta)
    {
        var arquivosGif = Directory.GetFiles(pasta, "*.gif");
        var arquivosMp3 = Directory.GetFiles(pasta, "*.mp3");
        var arquivosTxt = Directory.GetFiles(pasta, "*.txt");

        using (var context = new MeuContexto())
        {
            foreach (var gif in arquivosGif)
            {
                // Supondo que o nome do arquivo contém o código do exercício
                string codigo = Path.GetFileNameWithoutExtension(gif); // Ex: "M1A1E1"

                // Para encontrar os textos correspondentes
                string textoEn = File.ReadAllLines(Path.Combine(pasta, $"{codigo}_en.txt")).FirstOrDefault();
                string textoPt = File.ReadAllLines(Path.Combine(pasta, $"{codigo}_pt.txt")).FirstOrDefault();
                string mp3 = arquivosMp3.FirstOrDefault(f => f.Contains(codigo)); // Encontre o MP3 correspondente

                var novoExercicio = new Exercicio
                {
                    Codigo = codigo,
                    TextoEn = textoEn,
                    TextoPt = textoPt,
                    Gif = gif,
                    Mp3 = mp3
                };

                context.Exercicios.Add(novoExercicio);
            }

            context.SaveChanges();
            MessageBox.Show("Exercícios carregados com sucesso!");
        }
    }





}
}
