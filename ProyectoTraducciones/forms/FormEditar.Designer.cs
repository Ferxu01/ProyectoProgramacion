namespace ProyectoTraducciones
{
    partial class FormEditar
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
            this.panelSeleccionarTraduccionEditar = new System.Windows.Forms.Panel();
            this.labelTraduccionFiltrarEditar = new System.Windows.Forms.Label();
            this.labelTipoSeleccionarEditar = new System.Windows.Forms.Label();
            this.labelIdiomaSeleccionarEditar = new System.Windows.Forms.Label();
            this.nombreTraduccionFiltrar = new System.Windows.Forms.TextBox();
            this.dropDownIdiomaSeleccionarEditar = new System.Windows.Forms.ComboBox();
            this.dropDownTipoSeleccionarEditar = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarTraduccionEditar = new System.Windows.Forms.Button();
            this.listaSeleccionarTraduccionEditar = new System.Windows.Forms.ListBox();
            this.tituloSeleccionarTraduccionEditar = new System.Windows.Forms.Label();
            this.panelSeleccionarTraduccionEditar.SuspendLayout();
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
            // panelSeleccionarTraduccionEditar
            // 
            this.panelSeleccionarTraduccionEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSeleccionarTraduccionEditar.Controls.Add(this.labelTraduccionFiltrarEditar);
            this.panelSeleccionarTraduccionEditar.Controls.Add(this.labelTipoSeleccionarEditar);
            this.panelSeleccionarTraduccionEditar.Controls.Add(this.labelIdiomaSeleccionarEditar);
            this.panelSeleccionarTraduccionEditar.Controls.Add(this.nombreTraduccionFiltrar);
            this.panelSeleccionarTraduccionEditar.Controls.Add(this.dropDownIdiomaSeleccionarEditar);
            this.panelSeleccionarTraduccionEditar.Controls.Add(this.dropDownTipoSeleccionarEditar);
            this.panelSeleccionarTraduccionEditar.Controls.Add(this.btnSeleccionarTraduccionEditar);
            this.panelSeleccionarTraduccionEditar.Controls.Add(this.listaSeleccionarTraduccionEditar);
            this.panelSeleccionarTraduccionEditar.Controls.Add(this.tituloSeleccionarTraduccionEditar);
            this.panelSeleccionarTraduccionEditar.Location = new System.Drawing.Point(60, 23);
            this.panelSeleccionarTraduccionEditar.Name = "panelSeleccionarTraduccionEditar";
            this.panelSeleccionarTraduccionEditar.Size = new System.Drawing.Size(583, 436);
            this.panelSeleccionarTraduccionEditar.TabIndex = 2;
            // 
            // labelTraduccionFiltrarEditar
            // 
            this.labelTraduccionFiltrarEditar.AutoSize = true;
            this.labelTraduccionFiltrarEditar.Location = new System.Drawing.Point(386, 97);
            this.labelTraduccionFiltrarEditar.Name = "labelTraduccionFiltrarEditar";
            this.labelTraduccionFiltrarEditar.Size = new System.Drawing.Size(97, 13);
            this.labelTraduccionFiltrarEditar.TabIndex = 11;
            this.labelTraduccionFiltrarEditar.Text = "Nombre traducción";
            // 
            // labelTipoSeleccionarEditar
            // 
            this.labelTipoSeleccionarEditar.AutoSize = true;
            this.labelTipoSeleccionarEditar.Location = new System.Drawing.Point(209, 98);
            this.labelTipoSeleccionarEditar.Name = "labelTipoSeleccionarEditar";
            this.labelTipoSeleccionarEditar.Size = new System.Drawing.Size(28, 13);
            this.labelTipoSeleccionarEditar.TabIndex = 10;
            this.labelTipoSeleccionarEditar.Text = "Tipo";
            // 
            // labelIdiomaSeleccionarEditar
            // 
            this.labelIdiomaSeleccionarEditar.AutoSize = true;
            this.labelIdiomaSeleccionarEditar.Location = new System.Drawing.Point(34, 98);
            this.labelIdiomaSeleccionarEditar.Name = "labelIdiomaSeleccionarEditar";
            this.labelIdiomaSeleccionarEditar.Size = new System.Drawing.Size(38, 13);
            this.labelIdiomaSeleccionarEditar.TabIndex = 9;
            this.labelIdiomaSeleccionarEditar.Text = "Idioma";
            // 
            // nombreTraduccionFiltrar
            // 
            this.nombreTraduccionFiltrar.Location = new System.Drawing.Point(386, 117);
            this.nombreTraduccionFiltrar.Name = "nombreTraduccionFiltrar";
            this.nombreTraduccionFiltrar.Size = new System.Drawing.Size(155, 20);
            this.nombreTraduccionFiltrar.TabIndex = 2;
            // 
            // dropDownIdiomaSeleccionarEditar
            // 
            this.dropDownIdiomaSeleccionarEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownIdiomaSeleccionarEditar.FormattingEnabled = true;
            this.dropDownIdiomaSeleccionarEditar.Location = new System.Drawing.Point(34, 117);
            this.dropDownIdiomaSeleccionarEditar.Name = "dropDownIdiomaSeleccionarEditar";
            this.dropDownIdiomaSeleccionarEditar.Size = new System.Drawing.Size(152, 21);
            this.dropDownIdiomaSeleccionarEditar.TabIndex = 0;
            // 
            // dropDownTipoSeleccionarEditar
            // 
            this.dropDownTipoSeleccionarEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownTipoSeleccionarEditar.FormattingEnabled = true;
            this.dropDownTipoSeleccionarEditar.Location = new System.Drawing.Point(209, 117);
            this.dropDownTipoSeleccionarEditar.Name = "dropDownTipoSeleccionarEditar";
            this.dropDownTipoSeleccionarEditar.Size = new System.Drawing.Size(147, 21);
            this.dropDownTipoSeleccionarEditar.TabIndex = 1;
            // 
            // btnSeleccionarTraduccionEditar
            // 
            this.btnSeleccionarTraduccionEditar.Location = new System.Drawing.Point(439, 387);
            this.btnSeleccionarTraduccionEditar.Name = "btnSeleccionarTraduccionEditar";
            this.btnSeleccionarTraduccionEditar.Size = new System.Drawing.Size(102, 31);
            this.btnSeleccionarTraduccionEditar.TabIndex = 4;
            this.btnSeleccionarTraduccionEditar.Text = "Seleccionar";
            this.btnSeleccionarTraduccionEditar.UseVisualStyleBackColor = true;
            // 
            // listaSeleccionarTraduccionEditar
            // 
            this.listaSeleccionarTraduccionEditar.FormattingEnabled = true;
            this.listaSeleccionarTraduccionEditar.Location = new System.Drawing.Point(34, 163);
            this.listaSeleccionarTraduccionEditar.Name = "listaSeleccionarTraduccionEditar";
            this.listaSeleccionarTraduccionEditar.Size = new System.Drawing.Size(507, 212);
            this.listaSeleccionarTraduccionEditar.TabIndex = 3;
            // 
            // tituloSeleccionarTraduccionEditar
            // 
            this.tituloSeleccionarTraduccionEditar.AutoSize = true;
            this.tituloSeleccionarTraduccionEditar.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloSeleccionarTraduccionEditar.Location = new System.Drawing.Point(109, 11);
            this.tituloSeleccionarTraduccionEditar.Name = "tituloSeleccionarTraduccionEditar";
            this.tituloSeleccionarTraduccionEditar.Size = new System.Drawing.Size(375, 53);
            this.tituloSeleccionarTraduccionEditar.TabIndex = 3;
            this.tituloSeleccionarTraduccionEditar.Text = "Editar traducción";
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 471);
            this.Controls.Add(this.panelSeleccionarTraduccionEditar);
            this.Controls.Add(this.btnCerrarFormulario);
            this.Name = "FormEditar";
            this.Text = "FormEditar";
            this.panelSeleccionarTraduccionEditar.ResumeLayout(false);
            this.panelSeleccionarTraduccionEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarFormulario;
        private System.Windows.Forms.Panel panelSeleccionarTraduccionEditar;
        private System.Windows.Forms.Label tituloSeleccionarTraduccionEditar;
        private System.Windows.Forms.Button btnSeleccionarTraduccionEditar;
        private System.Windows.Forms.ListBox listaSeleccionarTraduccionEditar;
        private System.Windows.Forms.TextBox nombreTraduccionFiltrar;
        private System.Windows.Forms.ComboBox dropDownIdiomaSeleccionarEditar;
        private System.Windows.Forms.ComboBox dropDownTipoSeleccionarEditar;
        private System.Windows.Forms.Label labelTraduccionFiltrarEditar;
        private System.Windows.Forms.Label labelTipoSeleccionarEditar;
        private System.Windows.Forms.Label labelIdiomaSeleccionarEditar;
    }
}