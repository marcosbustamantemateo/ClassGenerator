namespace Generador_de_clases
{
    partial class ClassGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassGenerator));
            this.text1 = new System.Windows.Forms.Label();
            this.nombreClase = new System.Windows.Forms.TextBox();
            this.datos = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.get = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.set = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigo = new System.Windows.Forms.RichTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.line1 = new Generador_de_clases.Line();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(27, 70);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(92, 20);
            this.text1.TabIndex = 0;
            this.text1.Text = "Class name";
            // 
            // nombreClase
            // 
            this.nombreClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClase.Location = new System.Drawing.Point(125, 70);
            this.nombreClase.Name = "nombreClase";
            this.nombreClase.Size = new System.Drawing.Size(239, 26);
            this.nombreClase.TabIndex = 1;
            // 
            // datos
            // 
            this.datos.BackgroundColor = System.Drawing.Color.White;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.identificador,
            this.get,
            this.set});
            this.datos.Location = new System.Drawing.Point(25, 102);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(465, 203);
            this.datos.TabIndex = 2;
            // 
            // tipo
            // 
            this.tipo.Frozen = true;
            this.tipo.HeaderText = "Data Type";
            this.tipo.Items.AddRange(new object[] {
            "string",
            "byte",
            "int",
            "double",
            "float",
            "long",
            "bool"});
            this.tipo.Name = "tipo";
            this.tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipo.Width = 150;
            // 
            // identificador
            // 
            this.identificador.Frozen = true;
            this.identificador.HeaderText = "Identifier";
            this.identificador.Name = "identificador";
            this.identificador.Width = 170;
            // 
            // get
            // 
            this.get.Frozen = true;
            this.get.HeaderText = "GET";
            this.get.Name = "get";
            this.get.Width = 50;
            // 
            // set
            // 
            this.set.HeaderText = "SET";
            this.set.Name = "set";
            this.set.Width = 50;
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.Color.PeachPuff;
            this.codigo.Cursor = System.Windows.Forms.Cursors.No;
            this.codigo.Location = new System.Drawing.Point(25, 354);
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.ShortcutsEnabled = false;
            this.codigo.Size = new System.Drawing.Size(465, 298);
            this.codigo.TabIndex = 3;
            this.codigo.Text = "";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(370, 70);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(120, 26);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Go Preview";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearArchivo.Location = new System.Drawing.Point(25, 658);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(233, 26);
            this.btnCrearArchivo.TabIndex = 5;
            this.btnCrearArchivo.Text = "Create CS File";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(264, 658);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(226, 26);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Delete";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "PREVIEW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "C# CLASS GENERATOR";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(86, 47);
            this.line1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.line1.MinimumSize = new System.Drawing.Size(0, 2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(350, 2);
            this.line1.TabIndex = 11;
            // 
            // ClassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(508, 693);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrearArchivo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.nombreClase);
            this.Controls.Add(this.text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 736);
            this.Name = "ClassGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Generator";
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox nombreClase;
        private System.Windows.Forms.DataGridView datos;
        private System.Windows.Forms.RichTextBox codigo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn get;
        private System.Windows.Forms.DataGridViewCheckBoxColumn set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Line line1;
    }
}

