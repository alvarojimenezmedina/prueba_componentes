
namespace Prueba_de_componentes
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
            this.control_conBoton1 = new Comp_Info_Boton.Control_conBoton();
            this.control_conPicture1 = new Comp_Info_Picture.Control_conPicture();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_boton_ctrl = new System.Windows.Forms.Label();
            this.lb_picture_ctrl = new System.Windows.Forms.Label();
            this.lb_boton_default = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // control_conBoton1
            // 
            this.control_conBoton1.Location = new System.Drawing.Point(27, 12);
            this.control_conBoton1.Name = "control_conBoton1";
            this.control_conBoton1.Size = new System.Drawing.Size(400, 400);
            this.control_conBoton1.TabIndex = 0;
            this.control_conBoton1.Click += new System.EventHandler(this.control_conBoton1_Click);
            // 
            // control_conPicture1
            // 
            this.control_conPicture1.Location = new System.Drawing.Point(472, 12);
            this.control_conPicture1.Name = "control_conPicture1";
            this.control_conPicture1.Size = new System.Drawing.Size(400, 400);
            this.control_conPicture1.TabIndex = 1;
            this.control_conPicture1.Click += new System.EventHandler(this.control_conPicture1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // lb_boton_ctrl
            // 
            this.lb_boton_ctrl.AutoSize = true;
            this.lb_boton_ctrl.Location = new System.Drawing.Point(109, 442);
            this.lb_boton_ctrl.Name = "lb_boton_ctrl";
            this.lb_boton_ctrl.Size = new System.Drawing.Size(124, 13);
            this.lb_boton_ctrl.TabIndex = 5;
            this.lb_boton_ctrl.Text = "Cambia con este control:";
            // 
            // lb_picture_ctrl
            // 
            this.lb_picture_ctrl.AutoSize = true;
            this.lb_picture_ctrl.Location = new System.Drawing.Point(576, 442);
            this.lb_picture_ctrl.Name = "lb_picture_ctrl";
            this.lb_picture_ctrl.Size = new System.Drawing.Size(124, 13);
            this.lb_picture_ctrl.TabIndex = 6;
            this.lb_picture_ctrl.Text = "Cambia con este control:";
            // 
            // lb_boton_default
            // 
            this.lb_boton_default.AutoSize = true;
            this.lb_boton_default.Location = new System.Drawing.Point(109, 514);
            this.lb_boton_default.Name = "lb_boton_default";
            this.lb_boton_default.Size = new System.Drawing.Size(141, 13);
            this.lb_boton_default.TabIndex = 8;
            this.lb_boton_default.Text = "Cambia con el botón normal:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_boton_default);
            this.Controls.Add(this.lb_picture_ctrl);
            this.Controls.Add(this.lb_boton_ctrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.control_conPicture1);
            this.Controls.Add(this.control_conBoton1);
            this.Name = "Form1";
            this.Text = "PRUEBAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Comp_Info_Boton.Control_conBoton control_conBoton1;
        private Comp_Info_Picture.Control_conPicture control_conPicture1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_boton_ctrl;
        private System.Windows.Forms.Label lb_picture_ctrl;
        private System.Windows.Forms.Label lb_boton_default;
        private System.Windows.Forms.Button button1;
    }
}

