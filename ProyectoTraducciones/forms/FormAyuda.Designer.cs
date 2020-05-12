namespace ProyectoTraducciones
{
    partial class FormAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyuda));
            this.btnCerrarFormulario = new System.Windows.Forms.Button();
            this.tituloAyuda = new System.Windows.Forms.Label();
            this.labelContenidoAyuda = new System.Windows.Forms.Label();
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
            // tituloAyuda
            // 
            this.tituloAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tituloAyuda.AutoSize = true;
            this.tituloAyuda.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAyuda.Location = new System.Drawing.Point(259, 40);
            this.tituloAyuda.Name = "tituloAyuda";
            this.tituloAyuda.Size = new System.Drawing.Size(178, 61);
            this.tituloAyuda.TabIndex = 21;
            this.tituloAyuda.Text = "Ayuda";
            // 
            // labelContenidoAyuda
            // 
            this.labelContenidoAyuda.AutoSize = true;
            this.labelContenidoAyuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContenidoAyuda.Location = new System.Drawing.Point(70, 149);
            this.labelContenidoAyuda.Name = "labelContenidoAyuda";
            this.labelContenidoAyuda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelContenidoAyuda.Size = new System.Drawing.Size(649, 288);
            this.labelContenidoAyuda.TabIndex = 0;
            this.labelContenidoAyuda.Text = resources.GetString("labelContenidoAyuda.Text");
            this.labelContenidoAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 520);
            this.Controls.Add(this.labelContenidoAyuda);
            this.Controls.Add(this.tituloAyuda);
            this.Controls.Add(this.btnCerrarFormulario);
            this.Name = "FormAyuda";
            this.Text = "FormAyuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarFormulario;
        private System.Windows.Forms.Label tituloAyuda;
        private System.Windows.Forms.Label labelContenidoAyuda;
    }
}