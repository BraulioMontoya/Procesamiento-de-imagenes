namespace Procesamiento_de_imagenes
{
    partial class FormHistograma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rojo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.verde = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.azul = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azul)).BeginInit();
            this.SuspendLayout();
            // 
            // rojo
            // 
            chartArea1.Name = "ChartArea1";
            this.rojo.ChartAreas.Add(chartArea1);
            this.rojo.Dock = System.Windows.Forms.DockStyle.Left;
            this.rojo.Location = new System.Drawing.Point(0, 0);
            this.rojo.Name = "rojo";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.rojo.Series.Add(series1);
            this.rojo.Size = new System.Drawing.Size(200, 261);
            this.rojo.TabIndex = 0;
            this.rojo.Text = "rojo";
            // 
            // verde
            // 
            chartArea2.Name = "ChartArea1";
            this.verde.ChartAreas.Add(chartArea2);
            this.verde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verde.Location = new System.Drawing.Point(200, 0);
            this.verde.Name = "verde";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.verde.Series.Add(series2);
            this.verde.Size = new System.Drawing.Size(200, 261);
            this.verde.TabIndex = 1;
            this.verde.Text = "verde";
            // 
            // azul
            // 
            chartArea3.Name = "ChartArea1";
            this.azul.ChartAreas.Add(chartArea3);
            this.azul.Dock = System.Windows.Forms.DockStyle.Right;
            this.azul.Location = new System.Drawing.Point(400, 0);
            this.azul.Name = "azul";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.azul.Series.Add(series3);
            this.azul.Size = new System.Drawing.Size(200, 261);
            this.azul.TabIndex = 2;
            this.azul.Text = "azul";
            // 
            // FormHistograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 261);
            this.Controls.Add(this.verde);
            this.Controls.Add(this.rojo);
            this.Controls.Add(this.azul);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHistograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histograma";
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azul)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart rojo;
        private System.Windows.Forms.DataVisualization.Charting.Chart verde;
        private System.Windows.Forms.DataVisualization.Charting.Chart azul;
    }
}