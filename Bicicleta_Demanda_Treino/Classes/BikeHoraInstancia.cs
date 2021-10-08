using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicleta_Demanda_Treino.Classes
{
    public class BikeHoraInstancia
    {

        [LoadColumn(2)]
        public float season { get; set; }

        [LoadColumn(3)]
        public float yr { get; set; }

        [LoadColumn(4)]
        public float mnth { get; set; }

        [LoadColumn(5)]
        public float hr { get; set; }

        [LoadColumn(6)]
        public float holiday { get; set; }

        [LoadColumn(7)]
        public string weekday { get; set; }

        [LoadColumn(8)]
        public float workingday { get; set; }

        [LoadColumn(9)]
        public float weathersit { get; set; }

        [LoadColumn(10)]
        public float temp { get; set; }

        [LoadColumn(11)]
        public float atemp { get; set; }

        [LoadColumn(12)]
        public float hum { get; set; }

        [LoadColumn(13)]
        public float windspeed { get; set; }

        [LoadColumn(16)]
        public float cnt { get; set; }


    }
}
