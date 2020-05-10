namespace ProyectoTraducciones
{
    partial class FormBuscar
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
            this.panelBuscarTraduccion = new System.Windows.Forms.Panel();
            this.tituloTraduccionBuscar = new System.Windows.Forms.Label();
            this.dropDownTipoBuscar = new System.Windows.Forms.ComboBox();
            this.labelDropDownTipoBuscar = new System.Windows.Forms.Label();
            this.listaMostrarTraduccionBuscada = new System.Windows.Forms.ListBox();
            this.dropDownIdiomaBuscar = new System.Windows.Forms.ComboBox();
            this.labelDropDownIdiomaBuscar = new System.Windows.Forms.Label();
            this.labelNombreOriginalTraduccionBuscar = new System.Windows.Forms.Label();
            this.btnBuscarTraduccion = new System.Windows.Forms.Button();
            this.nombreOriginalTraduccionBuscar = new System.Windows.Forms.TextBox();
            this.panelBuscarTraduccion.SuspendLayout();
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
            // panelBuscarTraduccion
            // 
            this.panelBuscarTraduccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBuscarTraduccion.Controls.Add(this.tituloTraduccionBuscar);
            this.panelBuscarTraduccion.Controls.Add(this.dropDownTipoBuscar);
            this.panelBuscarTraduccion.Controls.Add(this.labelDropDownTipoBuscar);
            this.panelBuscarTraduccion.Controls.Add(this.listaMostrarTraduccionBuscada);
            this.panelBuscarTraduccion.Controls.Add(this.dropDownIdiomaBuscar);
            this.panelBuscarTraduccion.Controls.Add(this.labelDropDownIdiomaBuscar);
            this.panelBuscarTraduccion.Controls.Add(this.labelNombreOriginalTraduccionBuscar);
            this.panelBuscarTraduccion.Controls.Add(this.btnBuscarTraduccion);
            this.panelBuscarTraduccion.Controls.Add(this.nombreOriginalTraduccionBuscar);
            this.panelBuscarTraduccion.Location = new System.Drawing.Point(82, 12);
            this.panelBuscarTraduccion.Name = "panelBuscarTraduccion";
            this.panelBuscarTraduccion.Size = new System.Drawing.Size(596, 447);
            this.panelBuscarTraduccion.TabIndex = 2;
            // 
            // tituloTraduccionBuscar
            // 
            this.tituloTraduccionBuscar.AutoSize = true;
            this.tituloTraduccionBuscar.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTraduccionBuscar.Location = new System.Drawing.Point(91, 9);
            this.tituloTraduccionBuscar.Name = "tituloTraduccionBuscar";
            this.tituloTraduccionBuscar.Size = new System.Drawing.Size(400, 53);
            this.tituloTraduccionBuscar.TabIndex = 9;
            this.tituloTraduccionBuscar.Text = "Buscar traducción";
            // 
            // dropDownTipoBuscar
            // 
            this.dropDownTipoBuscar.FormattingEnabled = true;
            this.dropDownTipoBuscar.Location = new System.Drawing.Point(140, 143);
            this.dropDownTipoBuscar.Name = "dropDownTipoBuscar";
            this.dropDownTipoBuscar.Size = new System.Drawing.Size(197, 21);
            this.dropDownTipoBuscar.TabIndex = 8;
            // 
            // labelDropDownTipoBuscar
            // 
            this.labelDropDownTipoBuscar.AutoSize = true;
            this.labelDropDownTipoBuscar.Location = new System.Drawing.Point(137, 125);
            this.labelDropDownTipoBuscar.Name = "labelDropDownTipoBuscar";
            this.labelDropDownTipoBuscar.Size = new System.Drawing.Size(28, 13);
            this.labelDropDownTipoBuscar.TabIndex = 7;
            this.labelDropDownTipoBuscar.Text = "Tipo";
            // 
            // listaMostrarTraduccionBuscada
            // 
            this.listaMostrarTraduccionBuscada.FormattingEnabled = true;
            this.listaMostrarTraduccionBuscada.Location = new System.Drawing.Point(43, 227);
            this.listaMostrarTraduccionBuscada.Name = "listaMostrarTraduccionBuscada";
            this.listaMostrarTraduccionBuscada.Size = new System.Drawing.Size(498, 160);
            this.listaMostrarTraduccionBuscada.TabIndex = 6;
            // 
            // dropDownIdiomaBuscar
            // 
            this.dropDownIdiomaBuscar.FormattingEnabled = true;
            this.dropDownIdiomaBuscar.Location = new System.Drawing.Point(140, 95);
            this.dropDownIdiomaBuscar.Name = "dropDownIdiomaBuscar";
            this.dropDownIdiomaBuscar.Size = new System.Drawing.Size(197, 21);
            this.dropDownIdiomaBuscar.TabIndex = 5;
            // 
            // labelDropDownIdiomaBuscar
            // 
            this.labelDropDownIdiomaBuscar.AutoSize = true;
            this.labelDropDownIdiomaBuscar.Location = new System.Drawing.Point(137, 77);
            this.labelDropDownIdiomaBuscar.Name = "labelDropDownIdiomaBuscar";
            this.labelDropDownIdiomaBuscar.Size = new System.Drawing.Size(38, 13);
            this.labelDropDownIdiomaBuscar.TabIndex = 4;
            this.labelDropDownIdiomaBuscar.Text = "Idioma";
            // 
            // labelNombreOriginalTraduccionBuscar
            // 
            this.labelNombreOriginalTraduccionBuscar.AutoSize = true;
            this.labelNombreOriginalTraduccionBuscar.Location = new System.Drawing.Point(137, 176);
            this.labelNombreOriginalTraduccionBuscar.Name = "labelNombreOriginalTraduccionBuscar";
            this.labelNombreOriginalTraduccionBuscar.Size = new System.Drawing.Size(97, 13);
            this.labelNombreOriginalTraduccionBuscar.TabIndex = 3;
            this.labelNombreOriginalTraduccionBuscar.Text = "Nombre traducción";
            // 
            // btnBuscarTraduccion
            // 
            this.btnBuscarTraduccion.Location = new System.Drawing.Point(453, 404);
            this.btnBuscarTraduccion.Name = "btnBuscarTraduccion";
            this.btnBuscarTraduccion.Size = new System.Drawing.Size(88, 31);
            this.btnBuscarTraduccion.TabIndex = 2;
            this.btnBuscarTraduccion.Text = "Buscar";
            this.btnBuscarTraduccion.UseVisualStyleBackColor = true;
            // 
            // nombreOriginalTraduccionBuscar
            // 
            this.nombreOriginalTraduccionBuscar.Location = new System.Drawing.Point(140, 195);
            this.nombreOriginalTraduccionBuscar.Name = "nombreOriginalTraduccionBuscar";
            this.nombreOriginalTraduccionBuscar.Size = new System.Drawing.Size(197, 20);
            this.nombreOriginalTraduccionBuscar.TabIndex = 0;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 471);
            this.Controls.Add(this.panelBuscarTraduccion);
            this.Controls.Add(this.btnCerrarFormulario);
            this.Name = "FormBuscar";
            this.Text = "FormBuscar";
            this.panelBuscarTraduccion.ResumeLayout(false);
            this.panelBuscarTraduccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarFormulario;
        private System.Windows.Forms.Panel panelBuscarTraduccion;
        private System.Windows.Forms.TextBox nombreOriginalTraduccionBuscar;
        private System.Windows.Forms.Label labelDropDownIdiomaBuscar;
        private System.Windows.Forms.Label labelNombreOriginalTraduccionBuscar;
        private System.Windows.Forms.Button btnBuscarTraduccion;
        private System.Windows.Forms.ListBox listaMostrarTraduccionBuscada;
        private System.Windows.Forms.ComboBox dropDownIdiomaBuscar;
        private System.Windows.Forms.ComboBox dropDownTipoBuscar;
        private System.Windows.Forms.Label labelDropDownTipoBuscar;
        private System.Windows.Forms.Label tituloTraduccionBuscar;
    }
}