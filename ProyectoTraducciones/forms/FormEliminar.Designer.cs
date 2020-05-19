namespace ProyectoTraducciones
{
    partial class FormEliminar
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
            this.btnCerrarFormulario = new System.Windows.Forms.Button();
            this.panelEliminarTraduccion = new System.Windows.Forms.Panel();
            this.listaEliminarTraduccion = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tradOriginal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tradTraducida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tituloFormularioEliminar = new System.Windows.Forms.Label();
            this.btnEliminarTraduccion = new System.Windows.Forms.Button();
            this.labelDropDownIdiomaEliminar = new System.Windows.Forms.Label();
            this.dropDownIdiomaEliminar = new System.Windows.Forms.ComboBox();
            this.labelDropDownTipoEliminar = new System.Windows.Forms.Label();
            this.dropDownTipoEliminar = new System.Windows.Forms.ComboBox();
            this.panelEliminarTraduccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarFormulario
            // 
            this.btnCerrarFormulario.BackColor = System.Drawing.Color.Silver;
            this.btnCerrarFormulario.FlatAppearance.BorderSize = 0;
            this.btnCerrarFormulario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFormulario.Location = new System.Drawing.Point(12, 12);
            this.btnCerrarFormulario.Name = "btnCerrarFormulario";
            this.btnCerrarFormulario.Size = new System.Drawing.Size(32, 23);
            this.btnCerrarFormulario.TabIndex = 1;
            this.btnCerrarFormulario.Text = "X";
            this.btnCerrarFormulario.UseVisualStyleBackColor = false;
            this.btnCerrarFormulario.Click += new System.EventHandler(this.btnCerrarFormulario_Click);
            // 
            // panelEliminarTraduccion
            // 
            this.panelEliminarTraduccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelEliminarTraduccion.Controls.Add(this.listaEliminarTraduccion);
            this.panelEliminarTraduccion.Controls.Add(this.tituloFormularioEliminar);
            this.panelEliminarTraduccion.Controls.Add(this.btnEliminarTraduccion);
            this.panelEliminarTraduccion.Controls.Add(this.labelDropDownIdiomaEliminar);
            this.panelEliminarTraduccion.Controls.Add(this.dropDownIdiomaEliminar);
            this.panelEliminarTraduccion.Controls.Add(this.labelDropDownTipoEliminar);
            this.panelEliminarTraduccion.Controls.Add(this.dropDownTipoEliminar);
            this.panelEliminarTraduccion.Location = new System.Drawing.Point(80, 12);
            this.panelEliminarTraduccion.Name = "panelEliminarTraduccion";
            this.panelEliminarTraduccion.Size = new System.Drawing.Size(611, 454);
            this.panelEliminarTraduccion.TabIndex = 2;
            // 
            // listaEliminarTraduccion
            // 
            this.listaEliminarTraduccion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.tradOriginal,
            this.tradTraducida});
            this.listaEliminarTraduccion.HideSelection = false;
            this.listaEliminarTraduccion.Location = new System.Drawing.Point(6, 162);
            this.listaEliminarTraduccion.MultiSelect = false;
            this.listaEliminarTraduccion.Name = "listaEliminarTraduccion";
            this.listaEliminarTraduccion.Size = new System.Drawing.Size(537, 240);
            this.listaEliminarTraduccion.TabIndex = 7;
            this.listaEliminarTraduccion.UseCompatibleStateImageBehavior = false;
            this.listaEliminarTraduccion.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 44;
            // 
            // tradOriginal
            // 
            this.tradOriginal.Text = "Original";
            this.tradOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tradOriginal.Width = 174;
            // 
            // tradTraducida
            // 
            this.tradTraducida.Text = "Traducida";
            this.tradTraducida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tradTraducida.Width = 171;
            // 
            // tituloFormularioEliminar
            // 
            this.tituloFormularioEliminar.AutoSize = true;
            this.tituloFormularioEliminar.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloFormularioEliminar.Location = new System.Drawing.Point(95, 15);
            this.tituloFormularioEliminar.Name = "tituloFormularioEliminar";
            this.tituloFormularioEliminar.Size = new System.Drawing.Size(420, 53);
            this.tituloFormularioEliminar.TabIndex = 6;
            this.tituloFormularioEliminar.Text = "Eliminar traducción";
            // 
            // btnEliminarTraduccion
            // 
            this.btnEliminarTraduccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarTraduccion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTraduccion.Location = new System.Drawing.Point(462, 419);
            this.btnEliminarTraduccion.Name = "btnEliminarTraduccion";
            this.btnEliminarTraduccion.Size = new System.Drawing.Size(93, 28);
            this.btnEliminarTraduccion.TabIndex = 3;
            this.btnEliminarTraduccion.Text = "Eliminar";
            this.btnEliminarTraduccion.UseVisualStyleBackColor = true;
            this.btnEliminarTraduccion.Click += new System.EventHandler(this.btnEliminarTraduccion_Click);
            // 
            // labelDropDownIdiomaEliminar
            // 
            this.labelDropDownIdiomaEliminar.AutoSize = true;
            this.labelDropDownIdiomaEliminar.Location = new System.Drawing.Point(65, 101);
            this.labelDropDownIdiomaEliminar.Name = "labelDropDownIdiomaEliminar";
            this.labelDropDownIdiomaEliminar.Size = new System.Drawing.Size(38, 13);
            this.labelDropDownIdiomaEliminar.TabIndex = 3;
            this.labelDropDownIdiomaEliminar.Text = "Idioma";
            // 
            // dropDownIdiomaEliminar
            // 
            this.dropDownIdiomaEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownIdiomaEliminar.FormattingEnabled = true;
            this.dropDownIdiomaEliminar.Location = new System.Drawing.Point(68, 119);
            this.dropDownIdiomaEliminar.Name = "dropDownIdiomaEliminar";
            this.dropDownIdiomaEliminar.Size = new System.Drawing.Size(174, 21);
            this.dropDownIdiomaEliminar.TabIndex = 0;
            // 
            // labelDropDownTipoEliminar
            // 
            this.labelDropDownTipoEliminar.AutoSize = true;
            this.labelDropDownTipoEliminar.Location = new System.Drawing.Point(309, 100);
            this.labelDropDownTipoEliminar.Name = "labelDropDownTipoEliminar";
            this.labelDropDownTipoEliminar.Size = new System.Drawing.Size(28, 13);
            this.labelDropDownTipoEliminar.TabIndex = 1;
            this.labelDropDownTipoEliminar.Text = "Tipo";
            // 
            // dropDownTipoEliminar
            // 
            this.dropDownTipoEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownTipoEliminar.FormattingEnabled = true;
            this.dropDownTipoEliminar.Location = new System.Drawing.Point(309, 119);
            this.dropDownTipoEliminar.Name = "dropDownTipoEliminar";
            this.dropDownTipoEliminar.Size = new System.Drawing.Size(177, 21);
            this.dropDownTipoEliminar.TabIndex = 1;
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 471);
            this.Controls.Add(this.panelEliminarTraduccion);
            this.Controls.Add(this.btnCerrarFormulario);
            this.Name = "FormEliminar";
            this.Text = "FormEliminar";
            this.panelEliminarTraduccion.ResumeLayout(false);
            this.panelEliminarTraduccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarFormulario;
        private System.Windows.Forms.Panel panelEliminarTraduccion;
        private System.Windows.Forms.Label labelDropDownIdiomaEliminar;
        private System.Windows.Forms.ComboBox dropDownIdiomaEliminar;
        private System.Windows.Forms.Label labelDropDownTipoEliminar;
        private System.Windows.Forms.ComboBox dropDownTipoEliminar;
        private System.Windows.Forms.Button btnEliminarTraduccion;
        private System.Windows.Forms.Label tituloFormularioEliminar;
        private System.Windows.Forms.ListView listaEliminarTraduccion;
        private System.Windows.Forms.ColumnHeader tradOriginal;
        private System.Windows.Forms.ColumnHeader tradTraducida;
        public System.Windows.Forms.ColumnHeader id;
    }
}