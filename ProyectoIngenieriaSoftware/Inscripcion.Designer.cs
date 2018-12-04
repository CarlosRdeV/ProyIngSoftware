namespace ProyectoIngenieriaSoftware
{
    partial class Inscripcion
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
            this.txtIDalumnoInsc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDcursonsc = new System.Windows.Forms.TextBox();
            this.btnInscrip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inscripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Alumno:";
            // 
            // txtIDalumnoInsc
            // 
            this.txtIDalumnoInsc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDalumnoInsc.Location = new System.Drawing.Point(219, 147);
            this.txtIDalumnoInsc.MaxLength = 10;
            this.txtIDalumnoInsc.Name = "txtIDalumnoInsc";
            this.txtIDalumnoInsc.Size = new System.Drawing.Size(253, 29);
            this.txtIDalumnoInsc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID Curso:";
            // 
            // txtIDcursonsc
            // 
            this.txtIDcursonsc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDcursonsc.Location = new System.Drawing.Point(219, 210);
            this.txtIDcursonsc.MaxLength = 10;
            this.txtIDcursonsc.Name = "txtIDcursonsc";
            this.txtIDcursonsc.Size = new System.Drawing.Size(253, 29);
            this.txtIDcursonsc.TabIndex = 7;
            // 
            // btnInscrip
            // 
            this.btnInscrip.BackColor = System.Drawing.Color.Blue;
            this.btnInscrip.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInscrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscrip.ForeColor = System.Drawing.Color.Transparent;
            this.btnInscrip.Location = new System.Drawing.Point(250, 302);
            this.btnInscrip.Name = "btnInscrip";
            this.btnInscrip.Size = new System.Drawing.Size(121, 40);
            this.btnInscrip.TabIndex = 9;
            this.btnInscrip.Text = "Inscribir";
            this.btnInscrip.UseVisualStyleBackColor = false;
            this.btnInscrip.Click += new System.EventHandler(this.btnInscrip_Click);
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoIngenieriaSoftware.Properties.Resources.fondo_azul_naranja_23_2147633368;
            this.ClientSize = new System.Drawing.Size(627, 414);
            this.Controls.Add(this.btnInscrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDcursonsc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDalumnoInsc);
            this.Controls.Add(this.label1);
            this.Name = "Inscripcion";
            this.Text = "Inscripcion";
            this.Load += new System.EventHandler(this.Inscripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDalumnoInsc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDcursonsc;
        private System.Windows.Forms.Button btnInscrip;
    }
}