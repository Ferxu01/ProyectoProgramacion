namespace ProyectoTraducciones
{
    partial class FormCrear
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
            this.btnBorrarDatos = new System.Windows.Forms.Button();
            this.btnAddTraduccion = new System.Windows.Forms.Button();
            this.panelCrearTraduccion = new System.Windows.Forms.Panel();
            this.labelDropDownIdiomaCrear = new System.Windows.Forms.Label();
            this.dropDownIdiomaCrear = new System.Windows.Forms.ComboBox();
            this.labelDropDownTipoCrear = new System.Windows.Forms.Label();
            this.dropDownTipoCrear = new System.Windows.Forms.ComboBox();
            this.labelTraducida = new System.Windows.Forms.Label();
            this.palabraTraducida = new System.Windows.Forms.TextBox();
            this.tituloFormularioCrear = new System.Windows.Forms.Label();
            this.labelOriginal = new System.Windows.Forms.Label();
            this.palabraOriginal = new System.Windows.Forms.TextBox();
            this.panelCrearTraduccion.SuspendLayout();
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
            this.btnCerrarFormulario.TabIndex = 0;
            this.btnCerrarFormulario.Text = "X";
            this.btnCerrarFormulario.UseVisualStyleBackColor = false;
            this.btnCerrarFormulario.Click += new System.EventHandler(this.btnCerrarFormulario_Click);
            // 
            // btnBorrarDatos
            // 
            this.btnBorrarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarDatos.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBorrarDatos.Location = new System.Drawing.Point(414, 400);
            this.btnBorrarDatos.Name = "btnBorrarDatos";
            this.btnBorrarDatos.Size = new System.Drawing.Size(82, 28);
            this.btnBorrarDatos.TabIndex = 1;
            this.btnBorrarDatos.Text = "Borrar";
            this.btnBorrarDatos.UseVisualStyleBackColor = true;
            // 
            // btnAddTraduccion
            // 
            this.btnAddTraduccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTraduccion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTraduccion.Location = new System.Drawing.Point(313, 400);
            this.btnAddTraduccion.Name = "btnAddTraduccion";
            this.btnAddTraduccion.Size = new System.Drawing.Size(82, 28);
            this.btnAddTraduccion.TabIndex = 2;
            this.btnAddTraduccion.Text = "Añadir";
            this.btnAddTraduccion.UseVisualStyleBackColor = true;
            // 
            // panelCrearTraduccion
            // 
            this.panelCrearTraduccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCrearTraduccion.Controls.Add(this.labelDropDownIdiomaCrear);
            this.panelCrearTraduccion.Controls.Add(this.btnAddTraduccion);
            this.panelCrearTraduccion.Controls.Add(this.dropDownIdiomaCrear);
            this.panelCrearTraduccion.Controls.Add(this.btnBorrarDatos);
            this.panelCrearTraduccion.Controls.Add(this.labelDropDownTipoCrear);
            this.panelCrearTraduccion.Controls.Add(this.dropDownTipoCrear);
            this.panelCrearTraduccion.Controls.Add(this.labelTraducida);
            this.panelCrearTraduccion.Controls.Add(this.palabraTraducida);
            this.panelCrearTraduccion.Controls.Add(this.tituloFormularioCrear);
            this.panelCrearTraduccion.Controls.Add(this.labelOriginal);
            this.panelCrearTraduccion.Controls.Add(this.palabraOriginal);
            this.panelCrearTraduccion.Location = new System.Drawing.Point(90, 12);
            this.panelCrearTraduccion.Name = "panelCrearTraduccion";
            this.panelCrearTraduccion.Size = new System.Drawing.Size(561, 447);
            this.panelCrearTraduccion.TabIndex = 3;
            // 
            // labelDropDownIdiomaCrear
            // 
            this.labelDropDownIdiomaCrear.AutoSize = true;
            this.labelDropDownIdiomaCrear.Location = new System.Drawing.Point(144, 236);
            this.labelDropDownIdiomaCrear.Name = "labelDropDownIdiomaCrear";
            this.labelDropDownIdiomaCrear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDropDownIdiomaCrear.Size = new System.Drawing.Size(38, 13);
            this.labelDropDownIdiomaCrear.TabIndex = 8;
            this.labelDropDownIdiomaCrear.Text = "Idioma";
            // 
            // dropDownIdiomaCrear
            // 
            this.dropDownIdiomaCrear.FormattingEnabled = true;
            this.dropDownIdiomaCrear.Location = new System.Drawing.Point(147, 256);
            this.dropDownIdiomaCrear.Name = "dropDownIdiomaCrear";
            this.dropDownIdiomaCrear.Size = new System.Drawing.Size(200, 21);
            this.dropDownIdiomaCrear.TabIndex = 7;
            // 
            // labelDropDownTipoCrear
            // 
            this.labelDropDownTipoCrear.AutoSize = true;
            this.labelDropDownTipoCrear.Location = new System.Drawing.Point(144, 298);
            this.labelDropDownTipoCrear.Name = "labelDropDownTipoCrear";
            this.labelDropDownTipoCrear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDropDownTipoCrear.Size = new System.Drawing.Size(28, 13);
            this.labelDropDownTipoCrear.TabIndex = 6;
            this.labelDropDownTipoCrear.Text = "Tipo";
            // 
            // dropDownTipoCrear
            // 
            this.dropDownTipoCrear.FormattingEnabled = true;
            this.dropDownTipoCrear.Location = new System.Drawing.Point(147, 318);
            this.dropDownTipoCrear.Name = "dropDownTipoCrear";
            this.dropDownTipoCrear.Size = new System.Drawing.Size(200, 21);
            this.dropDownTipoCrear.TabIndex = 5;
            // 
            // labelTraducida
            // 
            this.labelTraducida.AutoSize = true;
            this.labelTraducida.Location = new System.Drawing.Point(144, 179);
            this.labelTraducida.Name = "labelTraducida";
            this.labelTraducida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTraducida.Size = new System.Drawing.Size(55, 13);
            this.labelTraducida.TabIndex = 4;
            this.labelTraducida.Text = "Traducido";
            // 
            // palabraTraducida
            // 
            this.palabraTraducida.Location = new System.Drawing.Point(147, 199);
            this.palabraTraducida.Name = "palabraTraducida";
            this.palabraTraducida.Size = new System.Drawing.Size(223, 20);
            this.palabraTraducida.TabIndex = 3;
            // 
            // tituloFormularioCrear
            // 
            this.tituloFormularioCrear.AutoSize = true;
            this.tituloFormularioCrear.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloFormularioCrear.Location = new System.Drawing.Point(92, 16);
            this.tituloFormularioCrear.Name = "tituloFormularioCrear";
            this.tituloFormularioCrear.Size = new System.Drawing.Size(371, 53);
            this.tituloFormularioCrear.TabIndex = 2;
            this.tituloFormularioCrear.Text = "Crear traducción";
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(144, 121);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelOriginal.Size = new System.Drawing.Size(42, 13);
            this.labelOriginal.TabIndex = 1;
            this.labelOriginal.Text = "Original";
            // 
            // palabraOriginal
            // 
            this.palabraOriginal.Location = new System.Drawing.Point(147, 142);
            this.palabraOriginal.Name = "palabraOriginal";
            this.palabraOriginal.Size = new System.Drawing.Size(223, 20);
            this.palabraOriginal.TabIndex = 0;
            // 
            // FormCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 471);
            this.Controls.Add(this.panelCrearTraduccion);
            this.Controls.Add(this.btnCerrarFormulario);
            this.Name = "FormCrear";
            this.Text = "FormCrear";
            this.panelCrearTraduccion.ResumeLayout(false);
            this.panelCrearTraduccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarFormulario;
        private System.Windows.Forms.Button btnBorrarDatos;
        private System.Windows.Forms.Button btnAddTraduccion;
        private System.Windows.Forms.Panel panelCrearTraduccion;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.TextBox palabraOriginal;
        private System.Windows.Forms.Label tituloFormularioCrear;
        private System.Windows.Forms.TextBox palabraTraducida;
        private System.Windows.Forms.Label labelTraducida;
        private System.Windows.Forms.Label labelDropDownTipoCrear;
        private System.Windows.Forms.ComboBox dropDownTipoCrear;
        private System.Windows.Forms.Label labelDropDownIdiomaCrear;
        private System.Windows.Forms.ComboBox dropDownIdiomaCrear;
    }
}