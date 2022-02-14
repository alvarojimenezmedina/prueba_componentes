
namespace Comp_Info_Boton
{
    partial class Control_conBoton
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton
            // 
            this.boton.BackgroundImage = global::Comp_Info_Boton.Properties.Resources.info_claro;
            this.boton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton.Location = new System.Drawing.Point(0, 0);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(400, 400);
            this.boton.TabIndex = 0;
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // Control_conBoton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boton);
            this.Name = "Control_conBoton";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton;
    }
}
