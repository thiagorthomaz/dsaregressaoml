using Bicicleta_Demanda_Treino.Classes;
using Microsoft.ML;
using System;
using System.IO;

namespace Bicicleta_Demanda_Treino
{
    class Program
    {


        static readonly string _dadosTreinoPath = Path.Combine(Environment.CurrentDirectory, "Dados/day.csv");

        static readonly string _dadosTestePath = Path.Combine(Environment.CurrentDirectory, "Dados/Teste_day.csv");

        static MLContext mLContext;

        static void Main(string[] args)
        {

            if (!File.Exists(_dadosTreinoPath))
            {
                Console.WriteLine("Datasets não encontrados!");
                return;
            }

            mLContext = new MLContext(seed: 34);

            var treinoDataView = mLContext.Data.LoadFromTextFile<BikeHoraInstancia>(_dadosTreinoPath, separatorChar: ',', hasHeader: true);



            Console.WriteLine("Programa finalizado!");
        }
    }
}
