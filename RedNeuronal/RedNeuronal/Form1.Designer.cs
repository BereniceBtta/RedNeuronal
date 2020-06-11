namespace RedNeuronal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.numCapas = new System.Windows.Forms.NumericUpDown();
            this.cargar_datos = new System.Windows.Forms.Button();
            this.iniciar_proc = new System.Windows.Forms.Button();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelFunciones = new System.Windows.Forms.TableLayoutPanel();
            this.panelCapas = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.grafica_error = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numAprendizaje = new System.Windows.Forms.NumericUpDown();
            this.numEpocas = new System.Windows.Forms.NumericUpDown();
            this.btnEntrenar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Aciertos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.matriz_conf = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cant_Vueltas = new System.Windows.Forms.Label();
            this.total_datos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCapas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica_error)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAprendizaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEpocas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aciertos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriz_conf)).BeginInit();
            this.SuspendLayout();
            // 
            // numCapas
            // 
            this.numCapas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numCapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCapas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numCapas.Location = new System.Drawing.Point(3, 17);
            this.numCapas.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numCapas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCapas.Name = "numCapas";
            this.numCapas.Size = new System.Drawing.Size(104, 20);
            this.numCapas.TabIndex = 2;
            this.numCapas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCapas.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numCapas.ValueChanged += new System.EventHandler(this.numCapas_ValueChanged);
            // 
            // cargar_datos
            // 
            this.cargar_datos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cargar_datos.Location = new System.Drawing.Point(3, 43);
            this.cargar_datos.Name = "cargar_datos";
            this.cargar_datos.Size = new System.Drawing.Size(108, 23);
            this.cargar_datos.TabIndex = 6;
            this.cargar_datos.Text = "CARGAR DATOS";
            this.cargar_datos.UseVisualStyleBackColor = false;
            this.cargar_datos.Click += new System.EventHandler(this.cargar_Click);
            // 
            // iniciar_proc
            // 
            this.iniciar_proc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iniciar_proc.Location = new System.Drawing.Point(3, 102);
            this.iniciar_proc.Name = "iniciar_proc";
            this.iniciar_proc.Size = new System.Drawing.Size(108, 23);
            this.iniciar_proc.TabIndex = 5;
            this.iniciar_proc.Text = "INICIAR";
            this.iniciar_proc.UseVisualStyleBackColor = false;
            this.iniciar_proc.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // grafica
            // 
            chartArea4.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.grafica.Legends.Add(legend4);
            this.grafica.Location = new System.Drawing.Point(12, 148);
            this.grafica.Name = "grafica";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.Name = "Elemento1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Color = System.Drawing.Color.DodgerBlue;
            series8.Legend = "Legend1";
            series8.Name = "Elemento2";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series9.Color = System.Drawing.Color.MediumSeaGreen;
            series9.Legend = "Legend1";
            series9.Name = "Elemento3";
            series9.YValuesPerPoint = 2;
            this.grafica.Series.Add(series7);
            this.grafica.Series.Add(series8);
            this.grafica.Series.Add(series9);
            this.grafica.Size = new System.Drawing.Size(498, 275);
            this.grafica.TabIndex = 11;
            title4.Name = "Title1";
            title4.Text = "Dispersión de datos de entrenamiento";
            this.grafica.Titles.Add(title4);
            // 
            // panelFunciones
            // 
            this.panelFunciones.ColumnCount = 10;
            this.panelFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunciones.Location = new System.Drawing.Point(309, 100);
            this.panelFunciones.Name = "panelFunciones";
            this.panelFunciones.RowCount = 1;
            this.panelFunciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelFunciones.Size = new System.Drawing.Size(763, 42);
            this.panelFunciones.TabIndex = 13;
            // 
            // panelCapas
            // 
            this.panelCapas.ColumnCount = 10;
            this.panelCapas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCapas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCapas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCapas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCapas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCapas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCapas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCapas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCapas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCapas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCapas.Location = new System.Drawing.Point(309, 40);
            this.panelCapas.Name = "panelCapas";
            this.panelCapas.RowCount = 1;
            this.panelCapas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelCapas.Size = new System.Drawing.Size(763, 42);
            this.panelCapas.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "CAPAS";
            // 
            // grafica_error
            // 
            chartArea5.Name = "ChartArea1";
            this.grafica_error.ChartAreas.Add(chartArea5);
            this.grafica_error.Cursor = System.Windows.Forms.Cursors.Hand;
            legend5.Name = "Legend1";
            this.grafica_error.Legends.Add(legend5);
            this.grafica_error.Location = new System.Drawing.Point(516, 148);
            this.grafica_error.Name = "grafica_error";
            this.grafica_error.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.grafica_error.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))))};
            series10.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series10.Legend = "Legend1";
            series10.MarkerBorderColor = System.Drawing.Color.Maroon;
            series10.Name = "ECM";
            this.grafica_error.Series.Add(series10);
            this.grafica_error.Size = new System.Drawing.Size(556, 275);
            this.grafica_error.TabIndex = 15;
            this.grafica_error.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Error Cuadrático Medio";
            this.grafica_error.Titles.Add(title5);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numAprendizaje);
            this.panel1.Controls.Add(this.numEpocas);
            this.panel1.Location = new System.Drawing.Point(129, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 130);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tasa de aprendizaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Épocas: ";
            // 
            // numAprendizaje
            // 
            this.numAprendizaje.DecimalPlaces = 2;
            this.numAprendizaje.Location = new System.Drawing.Point(114, 40);
            this.numAprendizaje.Name = "numAprendizaje";
            this.numAprendizaje.Size = new System.Drawing.Size(45, 20);
            this.numAprendizaje.TabIndex = 1;
            this.numAprendizaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAprendizaje.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // numEpocas
            // 
            this.numEpocas.Location = new System.Drawing.Point(114, 14);
            this.numEpocas.Name = "numEpocas";
            this.numEpocas.Size = new System.Drawing.Size(45, 20);
            this.numEpocas.TabIndex = 0;
            this.numEpocas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEpocas.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEntrenar.Location = new System.Drawing.Point(3, 72);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(108, 23);
            this.btnEntrenar.TabIndex = 17;
            this.btnEntrenar.Text = "Entrenar";
            this.btnEntrenar.UseVisualStyleBackColor = false;
            this.btnEntrenar.Click += new System.EventHandler(this.btnEntrenar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.numCapas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cargar_datos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEntrenar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.iniciar_proc, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(114, 130);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // Aciertos
            // 
            chartArea6.Name = "ChartArea1";
            this.Aciertos.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.Aciertos.Legends.Add(legend6);
            this.Aciertos.Location = new System.Drawing.Point(12, 430);
            this.Aciertos.Name = "Aciertos";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Aciertos";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Errores";
            this.Aciertos.Series.Add(series11);
            this.Aciertos.Series.Add(series12);
            this.Aciertos.Size = new System.Drawing.Size(498, 259);
            this.Aciertos.TabIndex = 18;
            this.Aciertos.Text = "chart1";
            title6.Name = "Title1";
            title6.Text = "Resultados de la Dispersión";
            this.Aciertos.Titles.Add(title6);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.total_datos);
            this.panel2.Controls.Add(this.cant_Vueltas);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.matriz_conf);
            this.panel2.Location = new System.Drawing.Point(516, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 259);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // matriz_conf
            // 
            this.matriz_conf.AllowUserToDeleteRows = false;
            this.matriz_conf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matriz_conf.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.matriz_conf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matriz_conf.Location = new System.Drawing.Point(59, 75);
            this.matriz_conf.Name = "matriz_conf";
            this.matriz_conf.ReadOnly = true;
            this.matriz_conf.Size = new System.Drawing.Size(476, 108);
            this.matriz_conf.TabIndex = 0;
            this.matriz_conf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Matriz de Confusión ";
            // 
            // cant_Vueltas
            // 
            this.cant_Vueltas.AutoSize = true;
            this.cant_Vueltas.Location = new System.Drawing.Point(173, 186);
            this.cant_Vueltas.Name = "cant_Vueltas";
            this.cant_Vueltas.Size = new System.Drawing.Size(0, 13);
            this.cant_Vueltas.TabIndex = 2;
            // 
            // total_datos
            // 
            this.total_datos.AutoSize = true;
            this.total_datos.Location = new System.Drawing.Point(173, 214);
            this.total_datos.Name = "total_datos";
            this.total_datos.Size = new System.Drawing.Size(0, 13);
            this.total_datos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1073, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Aciertos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grafica_error);
            this.Controls.Add(this.panelFunciones);
            this.Controls.Add(this.panelCapas);
            this.Controls.Add(this.grafica);
            this.Name = "Form1";
            this.Text = "Red Neuronal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCapas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica_error)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAprendizaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEpocas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aciertos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriz_conf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numCapas;
        private System.Windows.Forms.Button cargar_datos;
        private System.Windows.Forms.Button iniciar_proc;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.TableLayoutPanel panelFunciones;
        private System.Windows.Forms.TableLayoutPanel panelCapas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica_error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numAprendizaje;
        private System.Windows.Forms.NumericUpDown numEpocas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Aciertos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView matriz_conf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cant_Vueltas;
        private System.Windows.Forms.Label total_datos;
    }
}

