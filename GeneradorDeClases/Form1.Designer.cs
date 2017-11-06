namespace GeneradorDeClases
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.get = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.set = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txbNomClase = new System.Windows.Forms.TextBox();
            this.lbNomClase = new System.Windows.Forms.Label();
            this.rtMostraClase = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.nombre,
            this.get,
            this.set});
            this.dataGridView1.Location = new System.Drawing.Point(87, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Items.AddRange(new object[] {
            "string",
            "int",
            "double",
            "float",
            "byte",
            "bool"});
            this.tipo.MaxDropDownItems = 12;
            this.tipo.Name = "tipo";
            this.tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipo.Width = 80;
            // 
            // nombre
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MaxInputLength = 20;
            this.nombre.Name = "nombre";
            this.nombre.Width = 120;
            // 
            // get
            // 
            this.get.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.get.HeaderText = "Get";
            this.get.Name = "get";
            this.get.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.get.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.get.Width = 49;
            // 
            // set
            // 
            this.set.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set.HeaderText = "Set";
            this.set.Name = "set";
            this.set.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.set.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.set.Width = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.txbNomClase);
            this.panel1.Controls.Add(this.lbNomClase);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 444);
            this.panel1.TabIndex = 1;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.SlateGray;
            this.btnBorrar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(237, 322);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(141, 52);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.AutoEllipsis = true;
            this.btnCrear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCrear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(67, 322);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(141, 52);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.TabStop = false;
            this.btnCrear.Text = "Crear Clase";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txbNomClase
            // 
            this.txbNomClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomClase.Location = new System.Drawing.Point(180, 27);
            this.txbNomClase.Name = "txbNomClase";
            this.txbNomClase.Size = new System.Drawing.Size(189, 22);
            this.txbNomClase.TabIndex = 2;
            // 
            // lbNomClase
            // 
            this.lbNomClase.AutoSize = true;
            this.lbNomClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomClase.Location = new System.Drawing.Point(22, 31);
            this.lbNomClase.Name = "lbNomClase";
            this.lbNomClase.Size = new System.Drawing.Size(146, 16);
            this.lbNomClase.TabIndex = 1;
            this.lbNomClase.Text = "Nombre de la Clase";
            // 
            // rtMostraClase
            // 
            this.rtMostraClase.BackColor = System.Drawing.SystemColors.Menu;
            this.rtMostraClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtMostraClase.Location = new System.Drawing.Point(493, 54);
            this.rtMostraClase.Name = "rtMostraClase";
            this.rtMostraClase.Size = new System.Drawing.Size(408, 567);
            this.rtMostraClase.TabIndex = 2;
            this.rtMostraClase.Text = "";
            this.rtMostraClase.TextChanged += new System.EventHandler(this.rtMostraClase_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 742);
            this.Controls.Add(this.rtMostraClase);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txbNomClase;
        private System.Windows.Forms.Label lbNomClase;
        private System.Windows.Forms.RichTextBox rtMostraClase;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn get;
        private System.Windows.Forms.DataGridViewCheckBoxColumn set;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

