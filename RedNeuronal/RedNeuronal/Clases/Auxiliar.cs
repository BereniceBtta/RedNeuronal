using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNeuronal.Clases
{
    public class DataModel
    {
        public int filas = 0;
        public int clases = 0;
        public int descriptores = 0;
        public List<List<double>> Datos = new List<List<double>>();
    }

    static class Auxiliar
    {
        public static DataModel readDS(String pathDS)
        {
            DataModel dataModel = new DataModel();
            int contador = 0;
            string linea;

            List<List<double>> datos = new List<List<double>>();
            List<int> clases = new List<int>();

            //Lee el archivo y muestra linea a linea
            System.IO.StreamReader file = new System.IO.StreamReader(pathDS);
            while ((linea = file.ReadLine()) != null)
            {
                List<double> patron = new List<double>();
                foreach (String p in linea.Split(new char[] { ',' }))
                    patron.Add(double.Parse(p));

                if (!clases.Exists(x => x == patron.Last()))
                    clases.Add((Int32)patron.Last());

                datos.Add(patron);
                //System.Console.WriteLine(line);
                contador++;
            }

            file.Close();
            //System.Console.WriteLine("There were {0} lines.", datos.Count.ToString());
            dataModel.filas = contador;
            dataModel.Datos = datos;
            dataModel.descriptores = dataModel.Datos.ElementAt(0).Count - 1;
            dataModel.clases = clases.Count;
            return dataModel;
        }

        public static List<double> cargarG(String pathDS)
        {
            List<double> lista = new List<double>(); //SE CREA LA LISTA
            System.IO.StreamReader file = new System.IO.StreamReader(pathDS);// INICIAMOS EL LECTOR
            string linea; //LA LINEA QUE LEEMOS

            while ((linea = file.ReadLine()) != null) //MIENTRAS HAYA LINEAS CONTINÚA
            {
                foreach (String p in linea.Split(new char[] { ',' })) //SEPARA ELEMENTOS POR LA ','
                    lista.Add(double.Parse(p)); //SE AGREGAN LOS ELEMENTOS A LA LISTA
            }
            return lista; //REGRESA LA LISTA
        }

        public static List<double> Propagacion(List<double> input)
        {
            List<double> salida = new List<double>();

            for (int i = 0; i < Global.NN.NN.Count; i++) //SE RECORREN CADA UNA DE LAS CAPAS DE LA RED CREADA
            {
                List<double> Y_anterior = new List<double>();

                if (i != 0) //SIEMPRE QUE NO SEA LA CAPA DE ENTRADA
                    foreach (Neurona n in Global.NN.NN.ElementAt(i - 1).capa)
                        Y_anterior.Add(n.Y);

                for (int j = 0; j < Global.NN.NN.ElementAt(i).capa.Count; j++) //SE RECORREN LAS NEURONAS CONTENIDAS EN LAS CAPAS
                {
                    if (i == 0)//SI ES LA CAPA DE ENTRADA
                        Global.NN.NN.ElementAt(i).capa.ElementAt(j).activacion(input.ElementAt(j));
                    else
                        Global.NN.NN.ElementAt(i).capa.ElementAt(j).activacion(Y_anterior);
                }
            }

            for (int k = 0; k < Global.NN.NN.Last().capa.Count; k++)
            // foreach (Neurona n in Global.NN.NN.Last().capa)
            {
                salida.Add(Global.NN.NN.Last().capa.ElementAt(k).Y);

                Global.NN.NN.Last().capa.ElementAt(k).errorn = Global.NN.NN.Last().capa.ElementAt(k).errorEst(k, input.Last());
                //n.errorn = n.errorEst(input.Last(), n.Y);
            }

            return salida;
        }

        public static void retroPropagacion()
        {
            for (int i = Global.NN.NN.Count - 2; i >= 0; i--) // RECORRE HACIA ATRAS, DESDE LA PENULTIMA CAPA
            {
                for (int j = 0; j < Global.NN.NN.ElementAt(i).capa.Count; j++)
                {
                    double Sum_err = 0.0; //SUMATORIA DE ERRORES

                    for (int kj = 0; kj < Global.NN.NN.ElementAt(i + 1).capa.Count; kj++) //RECORRER DESDE 0 HASTA EL NUM DE NEURONAS EN LA CAPA DELANTERA
                    {
                        Sum_err += Global.NN.NN.ElementAt(i + 1).capa.ElementAt(kj).errorn * Global.NN.NN.ElementAt(i + 1).capa.ElementAt(kj).W.ElementAt(j);
                    }
                    Global.NN.NN.ElementAt(i).capa.ElementAt(j).errorn = Global.NN.NN.ElementAt(i).capa.ElementAt(j).Y * (1 - Global.NN.NN.ElementAt(i).capa.ElementAt(j).Y) * Sum_err;
                }
            }
        }

        public static void ajustePesos()
        {
            for (int i = Global.NN.NN.Count - 1; i >= 0; i--) // RECORRE HACIA ATRAS, DESDE LA PENULTIMA CAPA
            {
                for (int j = 0; j < Global.NN.NN.ElementAt(i).capa.Count; j++) //RECORREMOS NEURONAS
                {
                    //foreach (double w in Global.NN.NN.ElementAt(i).capa.ElementAt(j).W)
                    for (int w = 0; w < Global.NN.NN.ElementAt(i).capa.ElementAt(j).W.Count; w++) //RECORREMOS PESOS
                    {
                        double Incremento = Global.NN.NN.ElementAt(i).capa.ElementAt(j).W.ElementAt(w) +
                                            (Global.Alpha * Global.NN.NN.ElementAt(i).capa.ElementAt(j).errorn * Global.NN.NN.ElementAt(i).capa.ElementAt(j).X.ElementAt(w));

                        Global.NN.NN.ElementAt(i).capa.ElementAt(j).W[w] = Incremento;
                    }
                    double delta_b = (Global.Alpha * Global.NN.NN.ElementAt(i).capa.ElementAt(j).errorn * (-1.0));
                    Global.NN.NN.ElementAt(i).capa.ElementAt(j).bias += delta_b;
                }
            }
        }

    }


    //LOS ERRORES SE ELEVAN AL CUADRADO, SE SUMAN, AL TERMINAR SE MULTIPLICA POR 1/2, ESE ES EL ERROR CUADRATICO MEDIO, QUE DEBE TENER UN LÍMITE

    static class Global
    {
        public static Red NN;
        public static DataModel data;
        public static Random rnd = new Random(300); //SE USA UNA SEMILLA PARA RANDOMS
        public static double Alpha = 0.1; //FACTOR DE APRENDIZAJE
        public static int epocas = 100;
        
        //datos generales
        public static List<double> datos_archivo = new List<double>();
        public static List<double> datos_epoca = new List<double>();
        public static int aciertos = 0;
        public static int errores = 0;

        //datos por tipo
        public static int aciertosuno = 0;
        public static int aciertosdos = 0;
        public static int aciertostres = 0;
        public static int erroresuno = 0;
        public static int erroresuno_uno = 0;
        public static int erroresdos = 0;
        public static int erroresdos_dos = 0;
        public static int errorestres = 0;
        public static int errorestres_tres = 0;


    }
}
