using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNeuronal.Clases
{
    class Neurona
    {
        public List<double> X = new List<double>();
        public List<double> W = new List<double>();
        public double Y; //SALIDA DE LA NEURONA
        public double bias = 0.0;
        int tf = 0; //Tipo de la función que se utilizará en la neurona
        int tam_x = 0;
        public double errorn = 0.0;

        public Neurona(int n, int funcion)
        {
            this.tf = funcion;
            this.tam_x = n;

            iniciaPesos();
        }

        private void iniciaPesos()
        {
            for (int i = 0; i < tam_x; i++)
                W.Add(Global.rnd.NextDouble());

            bias = Global.rnd.NextDouble();
        }

        private double fActivacion(double a)
        {
            double res = 0.0;

            //linea1, sigmoide, escalón, relu
            switch (tf)
            {
                case 0: //LINEAL
                    res = a;
                    //e= d_comparar -y;
                    break;
                case 1: //SIGMOIDE
                    //e= (d_comparar-y)*y*(1-y);
                    res = 1 / (1 + Math.Pow(Math.E, (-1 * a)));
                    break;
                case 2: //ESCALÓN
                    //e= d_comparar-y;
                    res = (a <= 0) ? 0 : 1;
                    break;
                case 3: //RELU
                    res = (a <= 0) ? 0 : a;
                    break;
            }
            return res;
        }

        public void activacion(List<double> X)
        {
            double act = 0.0; //activación para PRODUCTO PUNTO
            this.X.Clear();
            this.X = X;

            for (int i = 0; i < X.Count; i++)
            {
                act += X.ElementAt(i) * W.ElementAt(i);
            }

            act += (-1.0) * bias; //SE UTILIZA LA CONSTANTE -1 PARA EL BIAS
            this.Y = fActivacion(act);

            //return act;
        }

        public void activacion(double x)
        {
            double act = 0.0; //activación para PRODUCTO PUNTO
            this.X.Clear();
            this.X.Add(x);

            for (int i = 0; i < X.Count; i++)
            {
                act += X.ElementAt(i) * W.ElementAt(i);
            }

            act += (-1.0) * bias; //SE UTILIZA LA CONSTANTE -1 PARA EL BIAS
            this.Y = fActivacion(act);
        }

        public double errorEst(int indice, double d)
        {
            double e = 0.0;
            double compararD = 0.0;
            String[] aux;
            String salida = "";

            for(int i= 0; i < Global.data.clases; i++) //FORMAMOS LA CADENA DE LA CLASE CON RESPECTO A LAS NEURONAS DE SALIDA
                salida += ((int) d == i) ? "1," : "0,"; 

            salida = salida.Remove(salida.Length - 1, 1); //QUITAR LA COMA
            aux = salida.Split(new char[] { ',' });
            compararD = Double.Parse(aux[indice]);

            switch (tf)
            {
                case 0: //LINEAL
                    e = compararD - Y;
                    break;
                case 1: //SIGMOIDE
                    e = (compararD - Y) * Y * (1 - Y); //CALCULO DE LA DERIVADA PARCIAL
                    break;
                case 2: //ESCALÓN
                    e = compararD - Y;
                    break;
                case 3: //RELU
                    e = compararD - Y;
                    break;
            }            
            return e;
        }
    }
}