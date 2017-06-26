using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveFiles
{
    static class Log
    {
        static string arquivo = @"C:\Oobj\Aplicativos\Oobj\move-thousand-files\Logs\move-thousand-files.txt";

        public static void IniciandoCopia(String arquivoAmover)
        {
            StreamReader leitura = new StreamReader(arquivo);
            string line = String.Empty;
            List<string> Linhas = new List<string>();
            bool cond = true;

            while (cond)
            {
                line = leitura.ReadLine();
                if (line != null)
                {
                    Linhas.Add(line);
                }
                else
                {
                    cond = false;
                }
            }
            leitura.Close();
            Linhas.Add("Iniciando a copia do Arquivo " + arquivoAmover);

            File.WriteAllLines(arquivo, Linhas);
        }
        public static void FinalzandoCopia(string arquivomovido)
        {
            StreamReader leitura = new StreamReader(arquivo);
            string line = String.Empty;
            List<string> Linhas = new List<string>();
            bool cond = true;

            while (cond)
            {
                line = leitura.ReadLine();
                if (line != null)
                {
                    Linhas.Add(line);
                }
                else
                {
                    cond = false;
                }
            }
            leitura.Close();
            Linhas.Add("Finalizada a copia do Arquivo " + arquivomovido);
            File.WriteAllLines(arquivo, Linhas);
        }
        public static void ExcecaoCopia(string excecao)
        {
            StreamReader leitura = new StreamReader(arquivo);
            string line = String.Empty;
            List<string> Linhas = new List<string>();
            bool cond = true;

            while (cond)
            {
                line = leitura.ReadLine();
                if (line != null)
                {
                    Linhas.Add(line);
                }
                else
                {
                    cond = false;
                }
            }
            leitura.Close();
            Linhas.Add(@"Copia do arquivo Não foi realizada por conta da seguinte exceção: " + excecao);
            File.WriteAllLines(arquivo, Linhas);
        }
    }
}
