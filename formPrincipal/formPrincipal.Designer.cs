namespace formPrincipal
{
    partial class formPrincipal
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
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInscribir
            // 
            this.btnInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.Location = new System.Drawing.Point(140, 45);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(166, 60);
            this.btnInscribir.TabIndex = 0;
            this.btnInscribir.Text = "Inscribir Estudiante";
            this.btnInscribir.UseVisualStyleBackColor = true;
            // 
            // btnComprobante
            // 
            this.btnComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobante.Location = new System.Drawing.Point(350, 165);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(166, 60);
            this.btnComprobante.TabIndex = 1;
            this.btnComprobante.Text = "Entregar Comprobante";
            this.btnComprobante.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(140, 165);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(166, 60);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar Inscripción";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(350, 45);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(166, 60);
            this.btnAsignar.TabIndex = 3;
            this.btnAsignar.Text = "Asignar Curso";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 288);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.btnInscribir);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPrincipal";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnAsignar;
    }
}