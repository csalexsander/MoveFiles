using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretorioOrigem = @"C:\NFe\xml-exploder\entrada_BKP";
            string diretorioDestino = @"C:\NFe\xml-exploder\entrada";

          try
            {
                string[] files = Directory.GetFiles(diretorioOrigem, "*.xml", SearchOption.AllDirectories);
                int restante = files.Length;
                int ultimo = 0;
                while (restante > 0)
                {
                    int valor = (restante - 10000) > 0 ? 10000 : (10000 - restante);
                    restante -= valor;
                    Console.WriteLine("Iniciando Copia dos Arquivos, Cerca de "+ restante + " restantes");
                    for (int i = 0; i < valor; i++)
                    {
                        Log.IniciandoCopia(files[ultimo]);
                        string destino = Path.Combine(diretorioDestino, FileName(files[ultimo]));
                        File.Copy(files[ultimo], destino,true);
                        File.Delete(files[ultimo]);
                        Log.FinalzandoCopia(FileName(files[ultimo]) + "PARA " + diretorioDestino);
                        ultimo++;
                    }
                    Console.WriteLine("Pausa de 0 Segundos");
                    Thread.Sleep(1);
                }


                Console.WriteLine(files.Length + " arquivos processados, pressione qualquer tecla para sair");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Log.ExcecaoCopia(ex.ToString());
            }
        }

        public static string FileName(string arquivo)
        {
            string[] split = arquivo.Split(Convert.ToChar(@"\"));
            return split[split.Length-1];
        }
    } 
}
