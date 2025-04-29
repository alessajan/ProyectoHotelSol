namespace ProyectoHotelSol
{
    partial class FrmMunu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnHabitacion = new System.Windows.Forms.Button();
            this.btnReservaciones = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "HABITACIONES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RESERVACIONES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "FACTURA";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(140, 26);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(90, 23);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "ACEPTAR";
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnHabitacion
            // 
            this.btnHabitacion.Location = new System.Drawing.Point(158, 92);
            this.btnHabitacion.Name = "btnHabitacion";
            this.btnHabitacion.Size = new System.Drawing.Size(89, 23);
            this.btnHabitacion.TabIndex = 5;
            this.btnHabitacion.Text = "ACEPTAR";
            this.btnHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.Location = new System.Drawing.Point(167, 193);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Size = new System.Drawing.Size(85, 23);
            this.btnReservaciones.TabIndex = 6;
            this.btnReservaciones.Text = "ACEPTAR";
            this.btnReservaciones.UseVisualStyleBackColor = true;
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(174, 267);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(87, 23);
            this.btnFactura.TabIndex = 7;
            this.btnFactura.Text = "ACEPTAR";
            this.btnFactura.UseVisualStyleBackColor = true;
            // 
            // FrmMunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 366);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnReservaciones);
            this.Controls.Add(this.btnHabitacion);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMunu";
            this.Text = "Menu principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnHabitacion;
        private System.Windows.Forms.Button btnReservaciones;
        private System.Windows.Forms.Button btnFactura;
    }
}