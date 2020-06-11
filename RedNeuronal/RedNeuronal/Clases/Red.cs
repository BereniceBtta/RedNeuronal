using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNeuronal.Clases
{
    class Red
    {
        public List<Capa> NN = new List<Capa>();
        /*
        public Red(List<int> arq) //4,10,3 CAPAS DE ENTRADA, OCULTAS, SALIDA
        {
            for (int i = 0; i < arq.Count; i++)
            {
                Capa item = new Capa(arq.ElementAt(i));
                NN.Add(item);
            }
        }
        */
        public Red(List<int[]> arq) //4,10,3 CAPAS DE ENTRADA, OCULTAS, SALIDA
        {
            for (int i = 0; i < arq.Count; i++)
            {
                Capa item;
                if (i == 0) // SI ES LA CAPA DE ENTRADA RECIBIR SOLO UNA ENTRADA
                    item = new Capa(arq.ElementAt(i), 1);
                else
                    item = new Capa(arq.ElementAt(i), arq.ElementAt(i - 1)[0]);

                NN.Add(item);
            }
        }
    }
}

//PATRÓN DE ENTRADA
//DATASET DE IRIS, 4 ENTRADAS, 3 SALIDAS

