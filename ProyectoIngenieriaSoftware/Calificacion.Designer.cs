namespace ProyectoIngenieriaSoftware
{
    partial class Calificacion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtIDcurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCalificacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblIDcurso = new System.Windows.Forms.Label();
            this.lblIDalumno = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdMostrar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtUpdateCalificacion = new System.Windows.Forms.TextBox();
            this.txtUpdateIDcurso = new System.Windows.Forms.TextBox();
            this.txtUpdateIDalumno = new System.Windows.Forms.TextBox();
            this.btnModificarUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnBuscarUpdate = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-6, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 341);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::ProyectoIngenieriaSoftware.Properties.Resources.fondo_azul_naranja_23_2147633368;
            this.tabPage1.Controls.Add(this.txtIDcurso);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbCalificacion);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtIDnombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCrear);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtIDcurso
            // 
            this.txtIDcurso.Location = new System.Drawing.Point(134, 90);
            this.txtIDcurso.Name = "txtIDcurso";
            this.txtIDcurso.Size = new System.Drawing.Size(149, 26);
            this.txtIDcurso.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Redondeado";
            // 
            // cmbCalificacion
            // 
            this.cmbCalificacion.FormattingEnabled = true;
            this.cmbCalificacion.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.cmbCalificacion.Location = new System.Drawing.Point(134, 132);
            this.cmbCalificacion.Name = "cmbCalificacion";
            this.cmbCalificacion.Size = new System.Drawing.Size(84, 26);
            this.cmbCalificacion.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Curso";
            // 
            // txtIDnombre
            // 
            this.txtIDnombre.Location = new System.Drawing.Point(134, 47);
            this.txtIDnombre.Name = "txtIDnombre";
            this.txtIDnombre.Size = new System.Drawing.Size(149, 26);
            this.txtIDnombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Alumno";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Blue;
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(147, 208);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(84, 36);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::ProyectoIngenieriaSoftware.Properties.Resources.fondo_azul_naranja_23_2147633368;
            this.tabPage2.Controls.Add(this.lblCalificacion);
            this.tabPage2.Controls.Add(this.lblIDcurso);
            this.tabPage2.Controls.Add(this.lblIDalumno);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtIdMostrar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mostrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.ForeColor = System.Drawing.Color.White;
            this.lblCalificacion.Location = new System.Drawing.Point(154, 168);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(53, 18);
            this.lblCalificacion.TabIndex = 23;
            this.lblCalificacion.Text = "---------";
            // 
            // lblIDcurso
            // 
            this.lblIDcurso.AutoSize = true;
            this.lblIDcurso.ForeColor = System.Drawing.Color.White;
            this.lblIDcurso.Location = new System.Drawing.Point(133, 130);
            this.lblIDcurso.Name = "lblIDcurso";
            this.lblIDcurso.Size = new System.Drawing.Size(53, 18);
            this.lblIDcurso.TabIndex = 22;
            this.lblIDcurso.Text = "---------";
            // 
            // lblIDalumno
            // 
            this.lblIDalumno.AutoSize = true;
            this.lblIDalumno.ForeColor = System.Drawing.Color.White;
            this.lblIDalumno.Location = new System.Drawing.Point(142, 95);
            this.lblIDalumno.Name = "lblIDalumno";
            this.lblIDalumno.Size = new System.Drawing.Size(53, 18);
            this.lblIDalumno.TabIndex = 21;
            this.lblIDalumno.Text = "---------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Inserte un Id a buscar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(58, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Calificacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID Curso";
            // 
            // txtIdMostrar
            // 
            this.txtIdMostrar.Location = new System.Drawing.Point(189, 46);
            this.txtIdMostrar.Name = "txtIdMostrar";
            this.txtIdMostrar.Size = new System.Drawing.Size(75, 26);
            this.txtIdMostrar.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(58, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID Alumno";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(282, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::ProyectoIngenieriaSoftware.Properties.Resources.fondo_azul_naranja_23_2147633368;
            this.tabPage3.Controls.Add(this.txtUpdateCalificacion);
            this.tabPage3.Controls.Add(this.txtUpdateIDcurso);
            this.tabPage3.Controls.Add(this.txtUpdateIDalumno);
            this.tabPage3.Controls.Add(this.btnModificarUpdate);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txtUpdateId);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.btnBuscarUpdate);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(408, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtUpdateCalificacion
            // 
            this.txtUpdateCalificacion.Location = new System.Drawing.Point(149, 189);
            this.txtUpdateCalificacion.Name = "txtUpdateCalificacion";
            this.txtUpdateCalificacion.Size = new System.Drawing.Size(153, 26);
            this.txtUpdateCalificacion.TabIndex = 39;
            // 
            // txtUpdateIDcurso
            // 
            this.txtUpdateIDcurso.Location = new System.Drawing.Point(149, 139);
            this.txtUpdateIDcurso.Name = "txtUpdateIDcurso";
            this.txtUpdateIDcurso.Size = new System.Drawing.Size(153, 26);
            this.txtUpdateIDcurso.TabIndex = 38;
            // 
            // txtUpdateIDalumno
            // 
            this.txtUpdateIDalumno.Location = new System.Drawing.Point(149, 90);
            this.txtUpdateIDalumno.Name = "txtUpdateIDalumno";
            this.txtUpdateIDalumno.Size = new System.Drawing.Size(153, 26);
            this.txtUpdateIDalumno.TabIndex = 37;
            this.txtUpdateIDalumno.Text = " ";
            // 
            // btnModificarUpdate
            // 
            this.btnModificarUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnModificarUpdate.ForeColor = System.Drawing.Color.White;
            this.btnModificarUpdate.Location = new System.Drawing.Point(149, 252);
            this.btnModificarUpdate.Name = "btnModificarUpdate";
            this.btnModificarUpdate.Size = new System.Drawing.Size(97, 35);
            this.btnModificarUpdate.TabIndex = 36;
            this.btnModificarUpdate.Text = "Modificar";
            this.btnModificarUpdate.UseVisualStyleBackColor = false;
            this.btnModificarUpdate.Click += new System.EventHandler(this.btnModificarUpdate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(16, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "Inserte un Id a buscar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(49, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 18);
            this.label16.TabIndex = 30;
            this.label16.Text = "Calificacion";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(49, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 18);
            this.label17.TabIndex = 29;
            this.label17.Text = "ID Curso";
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Location = new System.Drawing.Point(176, 37);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.Size = new System.Drawing.Size(59, 26);
            this.txtUpdateId.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(49, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 18);
            this.label18.TabIndex = 26;
            this.label18.Text = "ID Alumno";
            // 
            // btnBuscarUpdate
            // 
            this.btnBuscarUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnBuscarUpdate.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUpdate.Location = new System.Drawing.Point(255, 32);
            this.btnBuscarUpdate.Name = "btnBuscarUpdate";
            this.btnBuscarUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnBuscarUpdate.TabIndex = 27;
            this.btnBuscarUpdate.Text = "Buscar";
            this.btnBuscarUpdate.UseVisualStyleBackColor = false;
            this.btnBuscarUpdate.Click += new System.EventHandler(this.btnBuscarUpdate_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::ProyectoIngenieriaSoftware.Properties.Resources.fondo_azul_naranja_23_2147633368;
            this.tabPage4.Controls.Add(this.btnDelete);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtDeleteId);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(408, 310);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Borrar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(150, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(309, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Ingrese el Id de la calificacion a ser borrada";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(36, 88);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(75, 26);
            this.txtDeleteId.TabIndex = 31;
            // 
            // Calificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 333);
            this.Controls.Add(this.tabControl1);
            this.Name = "Calificacion";
            this.Text = "Calificacion";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCalificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblIDcurso;
        private System.Windows.Forms.Label lblIDalumno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdMostrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtUpdateCalificacion;
        private System.Windows.Forms.TextBox txtUpdateIDcurso;
        private System.Windows.Forms.TextBox txtUpdateIDalumno;
        private System.Windows.Forms.Button btnModificarUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUpdateId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBuscarUpdate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.TextBox txtIDcurso;
    }
}