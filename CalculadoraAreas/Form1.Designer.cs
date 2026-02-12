namespace CalculadoraAreas
{
    partial class Form1
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

   
      
        private void InitializeComponent()
        {
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFigura = new System.Windows.Forms.Label();
            this.cboFiguras = new System.Windows.Forms.ComboBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.cboUnidades = new System.Windows.Forms.ComboBox();
            this.panelParametros = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblResultadoArea = new System.Windows.Forms.Label();
            this.lblResultadoPerimetro = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.panelParametros.SuspendLayout();
            this.gbResultados.SuspendLayout();
            
             
            // panelTitulo
             
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(550, 60);
            this.panelTitulo.TabIndex = 0;
            
            // lblTitulo
             
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(550, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CALCULADORA DE ÁREAS GEOMÉTRICAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             
            // lblFigura
             
            this.lblFigura.AutoSize = true;
            this.lblFigura.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigura.Location = new System.Drawing.Point(30, 80);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(167, 16);
            this.lblFigura.TabIndex = 1;
            this.lblFigura.Text = "Seleccione la figura:";
             
            // cboFiguras
             
            this.cboFiguras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiguras.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiguras.FormattingEnabled = true;
            this.cboFiguras.Location = new System.Drawing.Point(30, 105);
            this.cboFiguras.Name = "cboFiguras";
            this.cboFiguras.Size = new System.Drawing.Size(200, 23);
            this.cboFiguras.TabIndex = 2;
            this.cboFiguras.SelectedIndexChanged += new System.EventHandler(this.cboFiguras_SelectedIndexChanged);
             
            // lblUnidad
             
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(250, 80);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(54, 15);
            this.lblUnidad.TabIndex = 3;
            this.lblUnidad.Text = "Unidad:";
             
            // cboUnidades
            
            this.cboUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidades.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidades.FormattingEnabled = true;
            this.cboUnidades.Location = new System.Drawing.Point(250, 105);
            this.cboUnidades.Name = "cboUnidades";
            this.cboUnidades.Size = new System.Drawing.Size(100, 23);
            this.cboUnidades.TabIndex = 4;
             
            // panelParametros
             
            this.panelParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParametros.Controls.Add(this.lbl4);
            this.panelParametros.Controls.Add(this.txt4);
            this.panelParametros.Controls.Add(this.lbl3);
            this.panelParametros.Controls.Add(this.txt3);
            this.panelParametros.Controls.Add(this.lbl2);
            this.panelParametros.Controls.Add(this.txt2);
            this.panelParametros.Controls.Add(this.lbl1);
            this.panelParametros.Controls.Add(this.txt1);
            this.panelParametros.Location = new System.Drawing.Point(30, 140);
            this.panelParametros.Name = "panelParametros";
            this.panelParametros.Size = new System.Drawing.Size(480, 150);
            this.panelParametros.TabIndex = 5;
             
            // lbl1
             
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(10, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 15);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Param1:";
            this.lbl1.Visible = false;
            
            // txt1
           
            this.txt1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(150, 18);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(120, 21);
            this.txt1.TabIndex = 1;
            this.txt1.Visible = false;
           
            // lbl2
         
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(10, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(50, 15);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Param2:";
            this.lbl2.Visible = false;
           
            // txt2
            
            this.txt2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(150, 53);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(120, 21);
            this.txt2.TabIndex = 3;
            this.txt2.Visible = false;
           
            // lbl3
          
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(10, 90);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(50, 15);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Param3:";
            this.lbl3.Visible = false;
            
            // txt3
            
            this.txt3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(150, 88);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(120, 21);
            this.txt3.TabIndex = 5;
            this.txt3.Visible = false;
            
            // lbl4
            
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(10, 125);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(50, 15);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Param4:";
            this.lbl4.Visible = false;
            
            // txt4
            
            this.txt4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt4.Location = new System.Drawing.Point(150, 123);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(120, 21);
            this.txt4.TabIndex = 7;
            this.txt4.Visible = false;
            
            // btnCalcular
            
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(150, 305);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 30);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            
            // btnLimpiar
           
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(280, 305);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
             
            // gbResultados
            
            this.gbResultados.Controls.Add(this.lblResultadoPerimetro);
            this.gbResultados.Controls.Add(this.lblResultadoArea);
            this.gbResultados.Controls.Add(this.lblDescripcion);
            this.gbResultados.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultados.Location = new System.Drawing.Point(30, 345);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(480, 150);
            this.gbResultados.TabIndex = 8;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            this.gbResultados.Visible = false;
             
            // lblDescripcion
             
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(15, 25);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(450, 30);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción de la figura";
            
            // lblResultadoArea
            
            this.lblResultadoArea.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoArea.Location = new System.Drawing.Point(15, 60);
            this.lblResultadoArea.Name = "lblResultadoArea";
            this.lblResultadoArea.Size = new System.Drawing.Size(450, 35);
            this.lblResultadoArea.TabIndex = 1;
            this.lblResultadoArea.Text = "Área: 0.00 cm²";
            
            // lblResultadoPerimetro
             
            this.lblResultadoPerimetro.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPerimetro.Location = new System.Drawing.Point(15, 100);
            this.lblResultadoPerimetro.Name = "lblResultadoPerimetro";
            this.lblResultadoPerimetro.Size = new System.Drawing.Size(450, 35);
            this.lblResultadoPerimetro.TabIndex = 2;
            this.lblResultadoPerimetro.Text = "Perímetro: 0.00 cm";
           
            // Form1
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 520);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panelParametros);
            this.Controls.Add(this.cboUnidades);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.cboFiguras);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Áreas - POO";
            this.panelTitulo.ResumeLayout(false);
            this.panelParametros.ResumeLayout(false);
            this.panelParametros.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.ComboBox cboFiguras;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.ComboBox cboUnidades;
        private System.Windows.Forms.Panel panelParametros;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblResultadoArea;
        private System.Windows.Forms.Label lblResultadoPerimetro;
    }
}

