namespace ProyectoTraducciones
{
    partial class FormEditarCampos
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
            this.panelEditarTraduccion = new System.Windows.Forms.Panel();
            this.tituloEditarTraduccion = new System.Windows.Forms.Label();
            this.labelCodigoTraduccionEditar = new System.Windows.Forms.Label();
            this.codigoTraduccionEditar = new System.Windows.Forms.TextBox();
            this.btnEditarTraduccion = new System.Windows.Forms.Button();
            this.labelDropDownIdiomaEditar = new System.Windows.Forms.Label();
            this.dropDownIdiomaEditar = new System.Windows.Forms.ComboBox();
            this.labelDropDownTipoEditar = new System.Windows.Forms.Label();
            this.dropDownTipoEditar = new System.Windows.Forms.ComboBox();
            this.labelPalabraTraducidaEditar = new System.Windows.Forms.Label();
            this.palabraTraducidaEditar = new System.Windows.Forms.TextBox();
            this.labelPalabraOriginalEditar = new System.Windows.Forms.Label();
            this.palabraOriginalEditar = new System.Windows.Forms.TextBox();
            this.panelEditarTraduccion.SuspendLayout();
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
            // panelEditarTraduccion
            // 
            this.panelEditarTraduccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelEditarTraduccion.Controls.Add(this.tituloEditarTraduccion);
            this.panelEditarTraduccion.Controls.Add(this.labelCodigoTraduccionEditar);
            this.panelEditarTraduccion.Controls.Add(this.codigoTraduccionEditar);
            this.panelEditarTraduccion.Controls.Add(this.btnEditarTraduccion);
            this.panelEditarTraduccion.Controls.Add(this.labelDropDownIdiomaEditar);
            this.panelEditarTraduccion.Controls.Add(this.dropDownIdiomaEditar);
            this.panelEditarTraduccion.Controls.Add(this.labelDropDownTipoEditar);
            this.panelEditarTraduccion.Controls.Add(this.dropDownTipoEditar);
            this.panelEditarTraduccion.Controls.Add(this.labelPalabraTraducidaEditar);
            this.panelEditarTraduccion.Controls.Add(this.palabraTraducidaEditar);
            this.panelEditarTraduccion.Controls.Add(this.labelPalabraOriginalEditar);
            this.panelEditarTraduccion.Controls.Add(this.palabraOriginalEditar);
            this.panelEditarTraduccion.Location = new System.Drawing.Point(90, 12);
            this.panelEditarTraduccion.Name = "panelEditarTraduccion";
            this.panelEditarTraduccion.Size = new System.Drawing.Size(579, 486);
            this.panelEditarTraduccion.TabIndex = 2;
            // 
            // tituloEditarTraduccion
            // 
            this.tituloEditarTraduccion.AutoSize = true;
            this.tituloEditarTraduccion.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloEditarTraduccion.Location = new System.Drawing.Point(78, 18);
            this.tituloEditarTraduccion.Name = "tituloEditarTraduccion";
            this.tituloEditarTraduccion.Size = new System.Drawing.Size(375, 53);
            this.tituloEditarTraduccion.TabIndex = 20;
            this.tituloEditarTraduccion.Text = "Editar traducción";
            // 
            // labelCodigoTraduccionEditar
            // 
            this.labelCodigoTraduccionEditar.AutoSize = true;
            this.labelCodigoTraduccionEditar.Location = new System.Drawing.Point(147, 101);
            this.labelCodigoTraduccionEditar.Name = "labelCodigoTraduccionEditar";
            this.labelCodigoTraduccionEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCodigoTraduccionEditar.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoTraduccionEditar.TabIndex = 19;
            this.labelCodigoTraduccionEditar.Text = "Código";
            // 
            // codigoTraduccionEditar
            // 
            this.codigoTraduccionEditar.Location = new System.Drawing.Point(150, 122);
            this.codigoTraduccionEditar.Name = "codigoTraduccionEditar";
            this.codigoTraduccionEditar.ReadOnly = true;
            this.codigoTraduccionEditar.Size = new System.Drawing.Size(223, 20);
            this.codigoTraduccionEditar.TabIndex = 0;
            // 
            // btnEditarTraduccion
            // 
            this.btnEditarTraduccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarTraduccion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTraduccion.Location = new System.Drawing.Point(383, 414);
            this.btnEditarTraduccion.Name = "btnEditarTraduccion";
            this.btnEditarTraduccion.Size = new System.Drawing.Size(106, 33);
            this.btnEditarTraduccion.TabIndex = 5;
            this.btnEditarTraduccion.Text = "Editar";
            this.btnEditarTraduccion.UseVisualStyleBackColor = true;
            this.btnEditarTraduccion.Click += new System.EventHandler(this.btnEditarTraduccion_Click);
            // 
            // labelDropDownIdiomaEditar
            // 
            this.labelDropDownIdiomaEditar.AutoSize = true;
            this.labelDropDownIdiomaEditar.Location = new System.Drawing.Point(147, 269);
            this.labelDropDownIdiomaEditar.Name = "labelDropDownIdiomaEditar";
            this.labelDropDownIdiomaEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDropDownIdiomaEditar.Size = new System.Drawing.Size(38, 13);
            this.labelDropDownIdiomaEditar.TabIndex = 16;
            this.labelDropDownIdiomaEditar.Text = "Idioma";
            // 
            // dropDownIdiomaEditar
            // 
            this.dropDownIdiomaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownIdiomaEditar.FormattingEnabled = true;
            this.dropDownIdiomaEditar.Location = new System.Drawing.Point(150, 289);
            this.dropDownIdiomaEditar.Name = "dropDownIdiomaEditar";
            this.dropDownIdiomaEditar.Size = new System.Drawing.Size(200, 21);
            this.dropDownIdiomaEditar.TabIndex = 3;
            // 
            // labelDropDownTipoEditar
            // 
            this.labelDropDownTipoEditar.AutoSize = true;
            this.labelDropDownTipoEditar.Location = new System.Drawing.Point(147, 331);
            this.labelDropDownTipoEditar.Name = "labelDropDownTipoEditar";
            this.labelDropDownTipoEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDropDownTipoEditar.Size = new System.Drawing.Size(28, 13);
            this.labelDropDownTipoEditar.TabIndex = 14;
            this.labelDropDownTipoEditar.Text = "Tipo";
            // 
            // dropDownTipoEditar
            // 
            this.dropDownTipoEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownTipoEditar.FormattingEnabled = true;
            this.dropDownTipoEditar.Location = new System.Drawing.Point(150, 351);
            this.dropDownTipoEditar.Name = "dropDownTipoEditar";
            this.dropDownTipoEditar.Size = new System.Drawing.Size(200, 21);
            this.dropDownTipoEditar.TabIndex = 4;
            // 
            // labelPalabraTraducidaEditar
            // 
            this.labelPalabraTraducidaEditar.AutoSize = true;
            this.labelPalabraTraducidaEditar.Location = new System.Drawing.Point(147, 212);
            this.labelPalabraTraducidaEditar.Name = "labelPalabraTraducidaEditar";
            this.labelPalabraTraducidaEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPalabraTraducidaEditar.Size = new System.Drawing.Size(55, 13);
            this.labelPalabraTraducidaEditar.TabIndex = 12;
            this.labelPalabraTraducidaEditar.Text = "Traducido";
            // 
            // palabraTraducidaEditar
            // 
            this.palabraTraducidaEditar.Location = new System.Drawing.Point(150, 232);
            this.palabraTraducidaEditar.Name = "palabraTraducidaEditar";
            this.palabraTraducidaEditar.Size = new System.Drawing.Size(223, 20);
            this.palabraTraducidaEditar.TabIndex = 2;
            // 
            // labelPalabraOriginalEditar
            // 
            this.labelPalabraOriginalEditar.AutoSize = true;
            this.labelPalabraOriginalEditar.Location = new System.Drawing.Point(147, 154);
            this.labelPalabraOriginalEditar.Name = "labelPalabraOriginalEditar";
            this.labelPalabraOriginalEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPalabraOriginalEditar.Size = new System.Drawing.Size(42, 13);
            this.labelPalabraOriginalEditar.TabIndex = 10;
            this.labelPalabraOriginalEditar.Text = "Original";
            // 
            // palabraOriginalEditar
            // 
            this.palabraOriginalEditar.Location = new System.Drawing.Point(150, 175);
            this.palabraOriginalEditar.Name = "palabraOriginalEditar";
            this.palabraOriginalEditar.Size = new System.Drawing.Size(223, 20);
            this.palabraOriginalEditar.TabIndex = 1;
            // 
            // FormEditarCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 510);
            this.Controls.Add(this.panelEditarTraduccion);
            this.Controls.Add(this.btnCerrarFormulario);
            this.MinimumSize = new System.Drawing.Size(746, 549);
            this.Name = "FormEditarCampos";
            this.Text = "FormEditarCampos";
            this.panelEditarTraduccion.ResumeLayout(false);
            this.panelEditarTraduccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarFormulario;
        private System.Windows.Forms.Panel panelEditarTraduccion;
        private System.Windows.Forms.Button btnEditarTraduccion;
        private System.Windows.Forms.Label labelDropDownIdiomaEditar;
        private System.Windows.Forms.ComboBox dropDownIdiomaEditar;
        private System.Windows.Forms.Label labelDropDownTipoEditar;
        private System.Windows.Forms.ComboBox dropDownTipoEditar;
        private System.Windows.Forms.Label labelPalabraTraducidaEditar;
        private System.Windows.Forms.TextBox palabraTraducidaEditar;
        private System.Windows.Forms.Label labelPalabraOriginalEditar;
        private System.Windows.Forms.TextBox palabraOriginalEditar;
        private System.Windows.Forms.Label labelCodigoTraduccionEditar;
        private System.Windows.Forms.TextBox codigoTraduccionEditar;
        private System.Windows.Forms.Label tituloEditarTraduccion;
    }
}