using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RedNeuronal
{
    public partial class Form1 : Form
    {
        List<double> graficarError = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void crearControles()
        {
            panelCapas.Controls.Clear(); //CONTENEDOR!
            panelFunciones.Controls.Clear();

            for (int i = 0; i < numCapas.Value; i++)
            {
                NumericUpDown item = new NumericUpDown();
                ComboBox lista = new ComboBox();
                lista.Items.Add("LINEAL");
                lista.Items.Add("SIGMOIDE");
                lista.Items.Add("ESCALÓN");
                lista.Items.Add("RELU");
                lista.SelectedIndex = 1;

                item.Size = new Size(85, 30);
                lista.Size = new Size(85, 30);

                panelCapas.Controls.Add(item);
                panelFunciones.Controls.Add(lista);
            }
        }

        private void graficarDatos()
        {
            foreach (List<double> graficar in RedNeuronal.Clases.Global.data.Datos)
            {
                if (graficar.ElementAt(4) == 0)
                    grafica.Series["Elemento1"].Points.AddXY(graficar.ElementAt(0), graficar.ElementAt(1));
                if (graficar.ElementAt(4) == 1)
                    grafica.Series["Elemento2"].Points.AddXY(graficar.ElementAt(0), graficar.ElementAt(1));
                if (graficar.ElementAt(4) == 2)
                    grafica.Series["Elemento3"].Points.AddXY(graficar.ElementAt(0), graficar.ElementAt(1));
            }
        }


        public void graficarErrores(List<double> e)
        {
          // String [] series = {"ECM2"};
            grafica_error.Series["ECM"].Points.Clear();
           // Series serie = grafica_error.Series.Add(series[0]);
            foreach (double item in e){
              /*  serie.Label = item.ToString();
                serie.Points.AddXY("", item);*/
                grafica_error.Series["ECM"].Points.AddXY("", item);
            }   
        }

        public void graficarDatosConfusion(int correcto1, int incorrecto1,int incorrecto11,
                                           int incorrecto2, int correcto2,int incorrecto22,
                                           int incorrecto3, int incorrecto33, int correcto3, int contador)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(" ", typeof(string));
            dt.Columns.Add("Columna1", typeof(int));
            dt.Columns.Add("Columna2", typeof(int));
            dt.Columns.Add("Columna3", typeof(int));
            dt.Columns.Add("Columna4", typeof(int));


            DataRow dr = dt.NewRow();
            dr[" "] = "Columna1";
            dr["Columna1"] = correcto1;
            dr["Columna2"] = incorrecto11;
            dr["Columna3"] = incorrecto1;
            dr["Columna4"] = correcto1 + incorrecto1 + incorrecto11;
            dt.Rows.Add(dr);
        
            dr = dt.NewRow();
            dr[" "] = "Columna2"; 
            dr["Columna1"] = incorrecto22; 
            dr["Columna2"] = correcto2;
            dr["Columna3"] = incorrecto2;
            dr["Columna4"] = correcto2 + incorrecto2 +  incorrecto22;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[" "] = "Columna3";
            dr["Columna1"] = incorrecto33;
            dr["Columna2"] = incorrecto3;
            dr["Columna3"] = correcto3;
            dr["Columna4"] = correcto1 + incorrecto3 + incorrecto33;
            dt.Rows.Add(dr);

            matriz_conf.DataSource = dt;

            int valor_final = correcto1 + incorrecto1 + correcto2 + incorrecto2 + correcto3 + incorrecto3 + incorrecto22 + incorrecto11 + incorrecto33;
            cant_Vueltas.Text = "Cantidad total de Vueltas" + contador;
            total_datos.Text = "Cantidad total de datos" + valor_final;


        }



        private void graficarResultados(int x,int y)
        {
            Aciertos.Series["Errores"].Points.Clear();
            Aciertos.Series["Aciertos"].Points.Clear();
            
                Aciertos.Series["Errores"].Points.AddXY("", x);
                Aciertos.Series["Aciertos"].Points.AddXY("", y);

        }

        private void cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            String ruta = "";
            int cont = 0;
            List<double> graficar = new List<double>();            

            fd.InitialDirectory = Application.StartupPath; //QUE SE ABRA EN LA RUTA DE LA APLICACION
            if (fd.ShowDialog() == DialogResult.OK)
                ruta = fd.FileName; //SE ASIGNA EL NOMBRE DEL ARCHIVO SELECCIONADO

            //AL CONJUNTO DE ELEMENTOS SE LE EXTRAEN LOS VALORES
            RedNeuronal.Clases.Global.data = RedNeuronal.Clases.Auxiliar.readDS(ruta);
            //SE CARGAN LOS DATOS A LA LISTA PARA GRAFICAR
            graficar = RedNeuronal.Clases.Auxiliar.cargarG(ruta);

            foreach (NumericUpDown item in panelCapas.Controls)
            {
                if (cont == 0)
                    item.Value = RedNeuronal.Clases.Global.data.descriptores;

                if (cont == panelCapas.Controls.Count - 1)
                    item.Value = RedNeuronal.Clases.Global.data.clases;

                if (cont == 1)
                    item.Value = 10;

                cont++;
            }
            graficarDatos();
           // MessageBox.Show("Datos Cargados");
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            RedNeuronal.Clases.Global.epocas = (int)numEpocas.Value;
            RedNeuronal.Clases.Global.Alpha = (double)numAprendizaje.Value;

            List<int[]> arq = new List<int[]>();
            for (int i = 0; i < panelCapas.Controls.Count; i++)
            //foreach (NumericUpDown item in panelCapas.Controls)
            {
                int[] item2 = new int[2];
                //item2[0] = (int)item.Value;
                item2[0] = (int)(panelCapas.GetControlFromPosition(i, 0) as NumericUpDown).Value;
                //item2[1] = 1;
                item2[1] = (panelFunciones.GetControlFromPosition(i, 0) as ComboBox).SelectedIndex;
                arq.Add(item2);
            }

            RedNeuronal.Clases.Global.NN = new RedNeuronal.Clases.Red(arq);

            //COMIENZA EL PROCESO DE LA PROPAGACIÓN HACIA ADELANTE
            //SE PASAN LOS VALORES DEL CONJUNTO DE DATOS POR LA RED

            List<double> salida = new List<double>();
            List<double> entrada = new List<double>();
            int contador = 0;
            double errorc2 = 0.0;

            //PARAR EL ERROR CUADRATICO MEDIO CUANDO YA SEA SUFICIENTE, SERÍA UN WHILE, NO FOR
            for (int epoca = 0; epoca < RedNeuronal.Clases.Global.epocas; epoca++)
            {
                foreach (List<double> patron in RedNeuronal.Clases.Global.data.Datos)
                {
                    double errort = 0.0;
                    String sd = "";

                    salida = RedNeuronal.Clases.Auxiliar.Propagacion(patron);

                    foreach (double sal in salida)                    
                        sd += sal;
                    //Console.Out.WriteLine("SALIDA: " + sd);
                    if (epoca == RedNeuronal.Clases.Global.epocas - 1)
                    {
                        if (sd.Equals("100"))		sd = "0";
                        else if (sd.Equals("010"))	sd = "1";
                        else if (sd.Equals("001"))  sd = "2";
                        else                        sd = "3";

                        RedNeuronal.Clases.Global.datos_epoca.Add(Convert.ToDouble(sd));
                        RedNeuronal.Clases.Global.datos_archivo.Add(patron.ElementAt(4));
                    }



                    foreach (RedNeuronal.Clases.Neurona e_s in RedNeuronal.Clases.Global.NN.NN.Last().capa)
                        errort += Math.Pow(e_s.errorn, 2f);

                    RedNeuronal.Clases.Auxiliar.retroPropagacion();
                    RedNeuronal.Clases.Auxiliar.ajustePesos();

                    contador++;
                    errorc2 += errort;
                }

                errorc2 = errorc2 * (1 / (double)RedNeuronal.Clases.Global.data.filas);
                graficarError.Add(errorc2);                
            }

            for (int i = 0; i < RedNeuronal.Clases.Global.datos_archivo.Count; i++)
            {
                if (RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) == RedNeuronal.Clases.Global.datos_archivo.ElementAt(i))
                {
                    RedNeuronal.Clases.Global.aciertos++;
                    if (RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) == 0)
                    {
                        RedNeuronal.Clases.Global.aciertosuno++;
                    }
                    else if (RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) == 1)
                    {
                        RedNeuronal.Clases.Global.aciertosdos++;
                    }
                    else if (RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) == 2)
                    {
                        RedNeuronal.Clases.Global.aciertostres++;
                    }
                    //System.Console.Out.WriteLine("Correctos: "+"Epoca: " + RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) + " Archivo: " + RedNeuronal.Clases.Global.datos_archivo.ElementAt(i));
                }
                else
                {
                    RedNeuronal.Clases.Global.errores++;
                    if (RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) == 0 && RedNeuronal.Clases.Global.datos_archivo.ElementAt(i) == 1)
                    {
                        RedNeuronal.Clases.Global.erroresuno++;
                    }
                    else if (RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) == 0 && RedNeuronal.Clases.Global.datos_archivo.ElementAt(i) == 2)
                    {
                        RedNeuronal.Clases.Global.erroresuno_uno++;
                    }
                    else if (RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) == 1 && RedNeuronal.Clases.Global.datos_archivo.ElementAt(i) == 0)
                    {
                        RedNeuronal.Clases.Global.erroresdos++;
                    }
                    else if (RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) == 1 && RedNeuronal.Clases.Global.datos_archivo.ElementAt(i) == 2)
                    {
                        RedNeuronal.Clases.Global.erroresdos_dos++;
                    }
                    else if (RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) == 2 && RedNeuronal.Clases.Global.datos_archivo.ElementAt(i) == 0)
                    {
                        RedNeuronal.Clases.Global.errorestres++;
                    }
                    else if (RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) == 2 && RedNeuronal.Clases.Global.datos_archivo.ElementAt(i) == 1)
                    {
                        RedNeuronal.Clases.Global.errorestres_tres++;
                    }
                   System.Console.Out.WriteLine("Incorrectos: " + "Epoca: " + RedNeuronal.Clases.Global.datos_epoca.ElementAt(i) + " Archivo: " + RedNeuronal.Clases.Global.datos_archivo.ElementAt(i));
                }
            }
            graficarErrores(graficarError);
            graficarResultados(RedNeuronal.Clases.Global.errores, RedNeuronal.Clases.Global.aciertos);

            graficarDatosConfusion(RedNeuronal.Clases.Global.aciertosuno,RedNeuronal.Clases.Global.erroresuno,RedNeuronal.Clases.Global.erroresuno_uno,
                RedNeuronal.Clases.Global.erroresdos,RedNeuronal.Clases.Global.aciertosdos,RedNeuronal.Clases.Global.erroresdos_dos,
                RedNeuronal.Clases.Global.errorestres, RedNeuronal.Clases.Global.errorestres_tres, RedNeuronal.Clases.Global.aciertostres, contador);

           System.Console.Out.WriteLine("VUELTAS: " +RedNeuronal.Clases.Global.erroresuno + RedNeuronal.Clases.Global.erroresdos_dos
                + RedNeuronal.Clases.Global.errorestres);
            //System.Console.Out.WriteLine("VUELTAS: " + contador);
        }

        private void numCapas_ValueChanged(object sender, EventArgs e)
        {
            crearControles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crearControles();
        }

        private void btnEntrenar_Click(object sender, EventArgs e)
        {
            RedNeuronal.Clases.Global.epocas = (int)numEpocas.Value;
            RedNeuronal.Clases.Global.Alpha = (double)numAprendizaje.Value;

            //se grafican los errores
            //MessageBox.Show("Cargados " + RedNeuronal.Clases.Global.epocas + "Cargados " + RedNeuronal.Clases.Global.Alpha);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
