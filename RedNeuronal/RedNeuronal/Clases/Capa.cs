using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNeuronal.Clases
{
    class Capa
    {
        public List<Neurona> capa = new List<Neurona>();

        public Capa(int[] n, int n_anterior)
        {
            for (int i = 0; i < n[0]; i++)
            {
                Neurona item = new Neurona(n_anterior, n[1]); //ENTRADAS Y LA FUNCION DE ACTIVACIÓN
                capa.Add(item);
            }
        }
    }
}

