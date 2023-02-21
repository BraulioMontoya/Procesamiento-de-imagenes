namespace Procesamiento_de_imagenes
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preprocesamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oscurecerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasaBajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaPonderadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasoAltasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bordesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esqueletizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esacalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.traslacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelEscala = new System.Windows.Forms.Panel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            this.labelEscala = new System.Windows.Forms.Label();
            this.cerrarEscala = new System.Windows.Forms.Button();
            this.panelTraslacion = new System.Windows.Forms.Panel();
            this.cerrarTraslacion = new System.Windows.Forms.Button();
            this.abajo = new System.Windows.Forms.Button();
            this.izquierda = new System.Windows.Forms.Button();
            this.derecha = new System.Windows.Forms.Button();
            this.arriba = new System.Windows.Forms.Button();
            this.quitarFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelEscala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panelTraslacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.preprocesamientoToolStripMenuItem,
            this.histogramaToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.bordesToolStripMenuItem,
            this.esqueletizacionToolStripMenuItem,
            this.geometriaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.originalToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Enabled = false;
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.originalToolStripMenuItem.Text = "Original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.OriginalToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Enabled = false;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.GuardarComoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // preprocesamientoToolStripMenuItem
            // 
            this.preprocesamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grisesToolStripMenuItem,
            this.powerToolStripMenuItem,
            this.binarizacionToolStripMenuItem,
            this.negativoToolStripMenuItem,
            this.quitarFondoToolStripMenuItem});
            this.preprocesamientoToolStripMenuItem.Enabled = false;
            this.preprocesamientoToolStripMenuItem.Name = "preprocesamientoToolStripMenuItem";
            this.preprocesamientoToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.preprocesamientoToolStripMenuItem.Text = "Pre-procesamiento";
            // 
            // grisesToolStripMenuItem
            // 
            this.grisesToolStripMenuItem.Name = "grisesToolStripMenuItem";
            this.grisesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grisesToolStripMenuItem.Text = "Grises";
            this.grisesToolStripMenuItem.Click += new System.EventHandler(this.GrisesToolStripMenuItem_Click);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brilloToolStripMenuItem,
            this.oscurecerToolStripMenuItem});
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.powerToolStripMenuItem.Text = "Power";
            // 
            // brilloToolStripMenuItem
            // 
            this.brilloToolStripMenuItem.Name = "brilloToolStripMenuItem";
            this.brilloToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.brilloToolStripMenuItem.Text = "Brillo";
            this.brilloToolStripMenuItem.Click += new System.EventHandler(this.BrilloToolStripMenuItem_Click);
            // 
            // oscurecerToolStripMenuItem
            // 
            this.oscurecerToolStripMenuItem.Name = "oscurecerToolStripMenuItem";
            this.oscurecerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.oscurecerToolStripMenuItem.Text = "Oscurecer";
            this.oscurecerToolStripMenuItem.Click += new System.EventHandler(this.OscurecerToolStripMenuItem_Click);
            // 
            // binarizacionToolStripMenuItem
            // 
            this.binarizacionToolStripMenuItem.Name = "binarizacionToolStripMenuItem";
            this.binarizacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.binarizacionToolStripMenuItem.Text = "Binarizacion";
            this.binarizacionToolStripMenuItem.Click += new System.EventHandler(this.BinarizacionToolStripMenuItem_Click);
            // 
            // negativoToolStripMenuItem
            // 
            this.negativoToolStripMenuItem.Name = "negativoToolStripMenuItem";
            this.negativoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negativoToolStripMenuItem.Text = "Negativo";
            this.negativoToolStripMenuItem.Click += new System.EventHandler(this.NegativoToolStripMenuItem_Click);
            // 
            // histogramaToolStripMenuItem
            // 
            this.histogramaToolStripMenuItem.Enabled = false;
            this.histogramaToolStripMenuItem.Name = "histogramaToolStripMenuItem";
            this.histogramaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.histogramaToolStripMenuItem.Text = "Histograma";
            this.histogramaToolStripMenuItem.Click += new System.EventHandler(this.HistogramaToolStripMenuItem_Click);
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasaBajasToolStripMenuItem,
            this.pasoAltasToolStripMenuItem});
            this.filtrosToolStripMenuItem.Enabled = false;
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // pasaBajasToolStripMenuItem
            // 
            this.pasaBajasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.mediaPonderadaToolStripMenuItem});
            this.pasaBajasToolStripMenuItem.Name = "pasaBajasToolStripMenuItem";
            this.pasaBajasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pasaBajasToolStripMenuItem.Text = "Pasa bajas";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.mediaToolStripMenuItem.Text = "Media";
            this.mediaToolStripMenuItem.Click += new System.EventHandler(this.MediaToolStripMenuItem_Click);
            // 
            // mediaPonderadaToolStripMenuItem
            // 
            this.mediaPonderadaToolStripMenuItem.Name = "mediaPonderadaToolStripMenuItem";
            this.mediaPonderadaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.mediaPonderadaToolStripMenuItem.Text = "Media Ponderada";
            this.mediaPonderadaToolStripMenuItem.Click += new System.EventHandler(this.MediaPonderadaToolStripMenuItem_Click);
            // 
            // pasoAltasToolStripMenuItem
            // 
            this.pasoAltasToolStripMenuItem.Name = "pasoAltasToolStripMenuItem";
            this.pasoAltasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pasoAltasToolStripMenuItem.Text = "Paso altas";
            this.pasoAltasToolStripMenuItem.Click += new System.EventHandler(this.PasoAltasToolStripMenuItem_Click);
            // 
            // bordesToolStripMenuItem
            // 
            this.bordesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laplaceToolStripMenuItem,
            this.prewittToolStripMenuItem,
            this.robertsToolStripMenuItem,
            this.sobelToolStripMenuItem});
            this.bordesToolStripMenuItem.Enabled = false;
            this.bordesToolStripMenuItem.Name = "bordesToolStripMenuItem";
            this.bordesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.bordesToolStripMenuItem.Text = "Bordes";
            // 
            // laplaceToolStripMenuItem
            // 
            this.laplaceToolStripMenuItem.Name = "laplaceToolStripMenuItem";
            this.laplaceToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.laplaceToolStripMenuItem.Text = "Laplace";
            this.laplaceToolStripMenuItem.Click += new System.EventHandler(this.LaplaceToolStripMenuItem_Click);
            // 
            // prewittToolStripMenuItem
            // 
            this.prewittToolStripMenuItem.Name = "prewittToolStripMenuItem";
            this.prewittToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.prewittToolStripMenuItem.Text = "Prewitt";
            this.prewittToolStripMenuItem.Click += new System.EventHandler(this.PrewittToolStripMenuItem_Click);
            // 
            // robertsToolStripMenuItem
            // 
            this.robertsToolStripMenuItem.Name = "robertsToolStripMenuItem";
            this.robertsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.robertsToolStripMenuItem.Text = "Roberts";
            this.robertsToolStripMenuItem.Click += new System.EventHandler(this.RobertsToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.SobelToolStripMenuItem_Click);
            // 
            // esqueletizacionToolStripMenuItem
            // 
            this.esqueletizacionToolStripMenuItem.Enabled = false;
            this.esqueletizacionToolStripMenuItem.Name = "esqueletizacionToolStripMenuItem";
            this.esqueletizacionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.esqueletizacionToolStripMenuItem.Text = "Esqueletizacion";
            this.esqueletizacionToolStripMenuItem.Click += new System.EventHandler(this.EsqueletizacionToolStripMenuItem_Click);
            // 
            // geometriaToolStripMenuItem
            // 
            this.geometriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esacalaToolStripMenuItem,
            this.rotacionToolStripMenuItem,
            this.traslacionToolStripMenuItem});
            this.geometriaToolStripMenuItem.Enabled = false;
            this.geometriaToolStripMenuItem.Name = "geometriaToolStripMenuItem";
            this.geometriaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.geometriaToolStripMenuItem.Text = "Geometria";
            // 
            // esacalaToolStripMenuItem
            // 
            this.esacalaToolStripMenuItem.Name = "esacalaToolStripMenuItem";
            this.esacalaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.esacalaToolStripMenuItem.Text = "Esacala";
            this.esacalaToolStripMenuItem.Click += new System.EventHandler(this.EsacalaToolStripMenuItem_Click);
            // 
            // rotacionToolStripMenuItem
            // 
            this.rotacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.rotacionToolStripMenuItem.Name = "rotacionToolStripMenuItem";
            this.rotacionToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rotacionToolStripMenuItem.Text = "Rotacion";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem2.Text = "90°";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Rotacion90ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem3.Text = "180°";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Rotacion180ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem4.Text = "270°";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.Rotacion270ToolStripMenuItem_Click);
            // 
            // traslacionToolStripMenuItem
            // 
            this.traslacionToolStripMenuItem.Name = "traslacionToolStripMenuItem";
            this.traslacionToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.traslacionToolStripMenuItem.Text = "Traslacion";
            this.traslacionToolStripMenuItem.Click += new System.EventHandler(this.TraslacionToolStripMenuItem_Click);
            // 
            // panelPicture
            // 
            this.panelPicture.AutoScroll = true;
            this.panelPicture.Controls.Add(this.pictureBox);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicture.Location = new System.Drawing.Point(0, 54);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(634, 407);
            this.panelPicture.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(553, 177);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panelEscala
            // 
            this.panelEscala.Controls.Add(this.trackBar);
            this.panelEscala.Controls.Add(this.labelPorcentaje);
            this.panelEscala.Controls.Add(this.labelEscala);
            this.panelEscala.Controls.Add(this.cerrarEscala);
            this.panelEscala.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEscala.Location = new System.Drawing.Point(0, 24);
            this.panelEscala.Name = "panelEscala";
            this.panelEscala.Size = new System.Drawing.Size(784, 30);
            this.panelEscala.TabIndex = 0;
            this.panelEscala.Visible = false;
            // 
            // trackBar
            // 
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.LargeChange = 10;
            this.trackBar.Location = new System.Drawing.Point(75, 0);
            this.trackBar.Maximum = 200;
            this.trackBar.Minimum = 10;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(559, 30);
            this.trackBar.SmallChange = 10;
            this.trackBar.TabIndex = 10;
            this.trackBar.TickFrequency = 10;
            this.trackBar.Value = 100;
            this.trackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelPorcentaje.Location = new System.Drawing.Point(634, 0);
            this.labelPorcentaje.Margin = new System.Windows.Forms.Padding(3);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(75, 30);
            this.labelPorcentaje.TabIndex = 11;
            this.labelPorcentaje.Text = "100%";
            this.labelPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEscala
            // 
            this.labelEscala.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelEscala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscala.Location = new System.Drawing.Point(0, 0);
            this.labelEscala.Margin = new System.Windows.Forms.Padding(3);
            this.labelEscala.Name = "labelEscala";
            this.labelEscala.Size = new System.Drawing.Size(75, 30);
            this.labelEscala.TabIndex = 0;
            this.labelEscala.Text = "Escala:";
            this.labelEscala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cerrarEscala
            // 
            this.cerrarEscala.Dock = System.Windows.Forms.DockStyle.Right;
            this.cerrarEscala.Location = new System.Drawing.Point(709, 0);
            this.cerrarEscala.Name = "cerrarEscala";
            this.cerrarEscala.Size = new System.Drawing.Size(75, 30);
            this.cerrarEscala.TabIndex = 2;
            this.cerrarEscala.Text = "Cerrar";
            this.cerrarEscala.UseVisualStyleBackColor = true;
            this.cerrarEscala.Click += new System.EventHandler(this.CerrarEscala_Click);
            // 
            // panelTraslacion
            // 
            this.panelTraslacion.Controls.Add(this.cerrarTraslacion);
            this.panelTraslacion.Controls.Add(this.abajo);
            this.panelTraslacion.Controls.Add(this.izquierda);
            this.panelTraslacion.Controls.Add(this.derecha);
            this.panelTraslacion.Controls.Add(this.arriba);
            this.panelTraslacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTraslacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelTraslacion.Location = new System.Drawing.Point(634, 54);
            this.panelTraslacion.Name = "panelTraslacion";
            this.panelTraslacion.Size = new System.Drawing.Size(150, 407);
            this.panelTraslacion.TabIndex = 1;
            this.panelTraslacion.Visible = false;
            // 
            // cerrarTraslacion
            // 
            this.cerrarTraslacion.Location = new System.Drawing.Point(38, 114);
            this.cerrarTraslacion.Name = "cerrarTraslacion";
            this.cerrarTraslacion.Size = new System.Drawing.Size(75, 30);
            this.cerrarTraslacion.TabIndex = 4;
            this.cerrarTraslacion.Text = "Cerrar";
            this.cerrarTraslacion.UseVisualStyleBackColor = true;
            this.cerrarTraslacion.Click += new System.EventHandler(this.CerrarTraslacion_Click);
            // 
            // abajo
            // 
            this.abajo.Location = new System.Drawing.Point(38, 78);
            this.abajo.Name = "abajo";
            this.abajo.Size = new System.Drawing.Size(75, 30);
            this.abajo.TabIndex = 3;
            this.abajo.Text = "Abajo";
            this.abajo.UseVisualStyleBackColor = true;
            this.abajo.Click += new System.EventHandler(this.Abajo_Click);
            // 
            // izquierda
            // 
            this.izquierda.Location = new System.Drawing.Point(0, 42);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(75, 30);
            this.izquierda.TabIndex = 2;
            this.izquierda.Text = "Izquierda";
            this.izquierda.UseVisualStyleBackColor = true;
            this.izquierda.Click += new System.EventHandler(this.Izquierda_Click);
            // 
            // derecha
            // 
            this.derecha.Location = new System.Drawing.Point(75, 42);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(75, 30);
            this.derecha.TabIndex = 1;
            this.derecha.Text = "Derecha";
            this.derecha.UseVisualStyleBackColor = true;
            this.derecha.Click += new System.EventHandler(this.Derecha_Click);
            // 
            // arriba
            // 
            this.arriba.Location = new System.Drawing.Point(38, 6);
            this.arriba.Name = "arriba";
            this.arriba.Size = new System.Drawing.Size(75, 30);
            this.arriba.TabIndex = 0;
            this.arriba.Text = "Arriba";
            this.arriba.UseVisualStyleBackColor = true;
            this.arriba.Click += new System.EventHandler(this.Arriba_Click);
            // 
            // quitarFondoToolStripMenuItem
            // 
            this.quitarFondoToolStripMenuItem.Name = "quitarFondoToolStripMenuItem";
            this.quitarFondoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitarFondoToolStripMenuItem.Text = "Quitar Fondo";
            this.quitarFondoToolStripMenuItem.Click += new System.EventHandler(this.quitarFondoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.panelTraslacion);
            this.Controls.Add(this.panelEscala);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesamiento de imagenes";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelEscala.ResumeLayout(false);
            this.panelEscala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panelTraslacion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preprocesamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bordesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativoToolStripMenuItem;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelEscala;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label labelEscala;
        private System.Windows.Forms.Button cerrarEscala;
        private System.Windows.Forms.Label labelPorcentaje;
        private System.Windows.Forms.ToolStripMenuItem pasaBajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaPonderadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasoAltasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oscurecerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esqueletizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esacalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traslacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Panel panelTraslacion;
        private System.Windows.Forms.Button abajo;
        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Button arriba;
        private System.Windows.Forms.Button cerrarTraslacion;
        private System.Windows.Forms.ToolStripMenuItem quitarFondoToolStripMenuItem;
    }
}

