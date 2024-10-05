using Easy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Easy
{
    public class DatabaseManager
    {
        private MeuContexto _context;

        public DatabaseManager()
        {
            _context = new MeuContexto(); // Inicializa o contexto
        }

        // Método para criar o banco de dados
        public void CriarBancoDeDados()
        {
            if (!_context.Database.Exists())
            {
                _context.Database.Create();
            }
        }

        // Método para adicionar exercícios de forma dinâmica
        public void AdicionarExerciciosPorAula(string caminhoBase, string modulo, string aula)
        {
            // Prefixos para os arquivos (nomes dos arquivos sem o E1, E2)
            string[] prefixos = { "coffee", "milk", "water", "tea", "beer", "juice", "soda", "wine" }; // Adicione outros prefixos conforme necessário

            for (int i = 0; i < prefixos.Length; i++)
            {
                // Gera o código para o exercício: Exemplo: M1A1E1, M1A1E2, etc.
                string codigo = $"{modulo}{aula}E{i + 1}"; // Ex: M1A1E1, M1A1E2

                // Caminhos dos arquivos sem sufixos como E1, E2
                string gifPath = Path.Combine(caminhoBase, $"{prefixos[i]}.gif");
                string mp3Path = Path.Combine(caminhoBase, $"{prefixos[i]}.mp3");
                string textoEnPath = Path.Combine(caminhoBase, $"{prefixos[i]}.txt");
                string textoPtPath = Path.Combine(caminhoBase, $"{prefixos[i]}_pt.txt");
                // Ler os arquivos
                
                string textoEn = File.ReadAllText(textoEnPath);
                string textoPt = File.ReadAllText(textoPtPath); // O texto em português é carregado diretamente do array
                string gif = gifPath;
                string mp3 = mp3Path;
                // Criar o novo exercício
                var novoExercicio = new Exercicio
                {
                    Codigo = codigo,
                    TextoEn = textoEn,
                    TextoPt = textoPt,
                    Gif = gif,
                    Mp3 = mp3
                };

                // Adicionar ao banco de dados
                using (var context = new MeuContexto())
                {
                    context.Exercicios.Add(novoExercicio);
                    context.SaveChanges();
                }
            }
        }
    } 
}