namespace ProyectoIngenieriaSoftware
{
    partial class Curso
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.cmbDuracion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdMostrar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtUpdateProfesor = new System.Windows.Forms.TextBox();
            this.txtUpdateHorario = new System.Windows.Forms.TextBox();
            this.txtUpdateDuracion = new System.Windows.Forms.TextBox();
            this.txtUpdateNombre = new System.Windows.Forms.TextBox();
            this.btnModificarUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 364);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::ProyectoIngenieriaSoftware.Properties.Resources.fondo_azul_naranja_23_2147633368;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtProfesor);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cmbHorario);
            this.tabPage1.Controls.Add(this.cmbDuracion);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(506, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Semanas";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(104, 182);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(342, 26);
            this.txtProfesor.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Profesor";
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "08:00am - 10:00am ",
            "10:00am - 12:00pm",
            "12:00pm - 02:00pm",
            "02:00pm - 04:00pm"});
            this.cmbHorario.Location = new System.Drawing.Point(104, 131);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(149, 26);
            this.cmbHorario.TabIndex = 15;
            // 
            // cmbDuracion
            // 
            this.cmbDuracion.FormattingEnabled = true;
            this.cmbDuracion.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.cmbDuracion.Location = new System.Drawing.Point(104, 79);
            this.cmbDuracion.Name = "cmbDuracion";
            this.cmbDuracion.Size = new System.Drawing.Size(149, 26);
            this.cmbDuracion.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duracion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(342, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(209, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::ProyectoIngenieriaSoftware.Properties.Resources.fondo_azul_naranja_23_2147633368;
            this.tabPage2.Controls.Add(this.lblProfesor);
            this.tabPage2.Controls.Add(this.lblHorario);
            this.tabPage2.Controls.Add(this.lblDuracion);
            this.tabPage2.Controls.Add(this.lblNombre);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtIdMostrar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mostrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.ForeColor = System.Drawing.Color.White;
            this.lblProfesor.Location = new System.Drawing.Point(146, 200);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(53, 18);
            this.lblProfesor.TabIndex = 24;
            this.lblProfesor.Text = "---------";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(146, 159);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(53, 18);
            this.lblHorario.TabIndex = 23;
            this.lblHorario.Text = "---------";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ForeColor = System.Drawing.Color.White;
            this.lblDuracion.Location = new System.Drawing.Point(153, 122);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(53, 18);
            this.lblDuracion.TabIndex = 22;
            this.lblDuracion.Text = "---------";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(146, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 18);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "---------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Inserte un Id a buscar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(76, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Profesor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Horario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(76, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Duracion";
            // 
            // txtIdMostrar
            // 
            this.txtIdMostrar.Location = new System.Drawing.Point(188, 36);
            this.txtIdMostrar.Name = "txtIdMostrar";
            this.txtIdMostrar.Size = new System.Drawing.Size(56, 26);
            this.txtIdMostrar.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(76, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(264, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::ProyectoIngenieriaSoftware.Properties.Resources.fondo_azul_naranja_23_2147633368;
            this.tabPage3.Controls.Add(this.txtUpdateProfesor);
            this.tabPage3.Controls.Add(this.txtUpdateHorario);
            this.tabPage3.Controls.Add(this.txtUpdateDuracion);
            this.tabPage3.Controls.Add(this.txtUpdateNombre);
            this.tabPage3.Controls.Add(this.btnModificarUpdate);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txtUpdateId);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.btnBuscarUpdate);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(506, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtUpdateProfesor
            // 
            this.txtUpdateProfesor.Location = new System.Drawing.Point(149, 203);
            this.txtUpdateProfesor.Name = "txtUpdateProfesor";
            this.txtUpdateProfesor.Size = new System.Drawing.Size(274, 26);
            this.txtUpdateProfesor.TabIndex = 40;
            // 
            // txtUpdateHorario
            // 
            this.txtUpdateHorario.Location = new System.Drawing.Point(145, 151);
            this.txtUpdateHorario.Name = "txtUpdateHorario";
            this.txtUpdateHorario.Size = new System.Drawing.Size(183, 26);
            this.txtUpdateHorario.TabIndex = 39;
            // 
            // txtUpdateDuracion
            // 
            this.txtUpdateDuracion.Location = new System.Drawing.Point(152, 113);
            this.txtUpdateDuracion.Name = "txtUpdateDuracion";
            this.txtUpdateDuracion.Size = new System.Drawing.Size(176, 26);
            this.txtUpdateDuracion.TabIndex = 38;
            // 
            // txtUpdateNombre
            // 
            this.txtUpdateNombre.Location = new System.Drawing.Point(145, 72);
            this.txtUpdateNombre.Name = "txtUpdateNombre";
            this.txtUpdateNombre.Size = new System.Drawing.Size(278, 26);
            this.txtUpdateNombre.TabIndex = 37;
            this.txtUpdateNombre.Text = " ";
            // 
            // btnModificarUpdate
            // 
            this.btnModificarUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnModificarUpdate.ForeColor = System.Drawing.Color.White;
            this.btnModificarUpdate.Location = new System.Drawing.Point(199, 250);
            this.btnModificarUpdate.Name = "btnModificarUpdate";
            this.btnModificarUpdate.Size = new System.Drawing.Size(94, 33);
            this.btnModificarUpdate.TabIndex = 36;
            this.btnModificarUpdate.Text = "Modificar";
            this.btnModificarUpdate.UseVisualStyleBackColor = false;
            this.btnModificarUpdate.Click += new System.EventHandler(this.btnModificarUpdate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(30, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "Inserte un Id a buscar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(75, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 18);
            this.label15.TabIndex = 31;
            this.label15.Text = "Profesor";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(75, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 18);
            this.label16.TabIndex = 30;
            this.label16.Text = "Horario";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(75, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 18);
            this.label17.TabIndex = 29;
            this.label17.Text = "Duracion";
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Location = new System.Drawing.Point(199, 33);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.Size = new System.Drawing.Size(70, 26);
            this.txtUpdateId.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(75, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 18);
            this.label18.TabIndex = 26;
            this.label18.Text = "Nombre";
            // 
            // btnBuscarUpdate
            // 
            this.btnBuscarUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnBuscarUpdate.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUpdate.Location = new System.Drawing.Point(291, 28);
            this.btnBuscarUpdate.Name = "btnBuscarUpdate";
            this.btnBuscarUpdate.Size = new System.Drawing.Size(75, 35);
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
            this.tabPage4.Size = new System.Drawing.Size(506, 333);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Borrar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(204, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 34);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Ingrese el Id del curso a ser borrado";
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(295, 51);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(64, 26);
            this.txtDeleteId.TabIndex = 31;
            // 
            // Curso
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "Curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Curso_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdMostrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtUpdateProfesor;
        private System.Windows.Forms.TextBox txtUpdateHorario;
        private System.Windows.Forms.TextBox txtUpdateDuracion;
        private System.Windows.Forms.TextBox txtUpdateNombre;
        private System.Windows.Forms.Button btnModificarUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUpdateId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBuscarUpdate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.ComboBox cmbDuracion;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Label label2;
    }
}