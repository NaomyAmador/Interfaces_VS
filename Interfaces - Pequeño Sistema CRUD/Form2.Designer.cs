namespace Interfaces___Pequeño_Sistema_CRUD
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label10 = new System.Windows.Forms.Label();
            this.Mostrar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.DataGridView_TablaCliente = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBox_Correo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBox_Nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBox_ClienteID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_IrCProductoCRUD = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TablaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label10.Location = new System.Drawing.Point(197, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(496, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "✿ Operaciones CRUD para manipular datos en la Base de Datos ✿";
            // 
            // Mostrar
            // 
            this.Mostrar.BackColor = System.Drawing.Color.Goldenrod;
            this.Mostrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar.ForeColor = System.Drawing.Color.White;
            this.Mostrar.Location = new System.Drawing.Point(173, 316);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(133, 33);
            this.Mostrar.TabIndex = 38;
            this.Mostrar.Text = "Mostrar Todo";
            this.Mostrar.UseVisualStyleBackColor = false;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(173, 282);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(133, 31);
            this.Btn_Buscar.TabIndex = 37;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(173, 244);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(133, 33);
            this.Btn_Eliminar.TabIndex = 36;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.Location = new System.Drawing.Point(173, 210);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(133, 33);
            this.Btn_Actualizar.TabIndex = 35;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Location = new System.Drawing.Point(173, 177);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(133, 32);
            this.Btn_Guardar.TabIndex = 34;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // DataGridView_TablaCliente
            // 
            this.DataGridView_TablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_TablaCliente.Location = new System.Drawing.Point(314, 177);
            this.DataGridView_TablaCliente.Name = "DataGridView_TablaCliente";
            this.DataGridView_TablaCliente.RowHeadersWidth = 51;
            this.DataGridView_TablaCliente.RowTemplate.Height = 24;
            this.DataGridView_TablaCliente.Size = new System.Drawing.Size(399, 172);
            this.DataGridView_TablaCliente.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Peru;
            this.label9.Location = new System.Drawing.Point(12, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "❀ Correo ❀";
            // 
            // TxtBox_Correo
            // 
            this.TxtBox_Correo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Correo.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtBox_Correo.Location = new System.Drawing.Point(16, 324);
            this.TxtBox_Correo.Name = "TxtBox_Correo";
            this.TxtBox_Correo.Size = new System.Drawing.Size(139, 23);
            this.TxtBox_Correo.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Peru;
            this.label8.Location = new System.Drawing.Point(11, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "❀ Nombre ❀";
            // 
            // TxtBox_Nombre
            // 
            this.TxtBox_Nombre.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Nombre.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtBox_Nombre.Location = new System.Drawing.Point(15, 265);
            this.TxtBox_Nombre.Name = "TxtBox_Nombre";
            this.TxtBox_Nombre.Size = new System.Drawing.Size(140, 23);
            this.TxtBox_Nombre.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Peru;
            this.label7.Location = new System.Drawing.Point(11, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "❀ ClienteID ❀";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = " ❤ Datos a Utilizar ❤";
            // 
            // TxtBox_ClienteID
            // 
            this.TxtBox_ClienteID.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_ClienteID.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtBox_ClienteID.Location = new System.Drawing.Point(15, 209);
            this.TxtBox_ClienteID.Name = "TxtBox_ClienteID";
            this.TxtBox_ClienteID.Size = new System.Drawing.Size(140, 23);
            this.TxtBox_ClienteID.TabIndex = 26;
            this.TxtBox_ClienteID.Text = "Para crear → No Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 6F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label5.Location = new System.Drawing.Point(308, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 14);
            this.label5.TabIndex = 25;
            this.label5.Text = "Interfaces - Sistema CRUD #2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(274, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "¡Elige las flores que acompañarán tu hogar!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(183, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "∘₊✧─── Deja que la Naturaleza te sorprenda ───✧₊∘";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(305, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Floristería - Flores a tu Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(176, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "-ˋˏ ༻❁ Flowers Basquet ❀༺ ˎˊ-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_IrCProductoCRUD
            // 
            this.Btn_IrCProductoCRUD.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_IrCProductoCRUD.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IrCProductoCRUD.ForeColor = System.Drawing.Color.White;
            this.Btn_IrCProductoCRUD.Location = new System.Drawing.Point(611, 9);
            this.Btn_IrCProductoCRUD.Name = "Btn_IrCProductoCRUD";
            this.Btn_IrCProductoCRUD.Size = new System.Drawing.Size(102, 33);
            this.Btn_IrCProductoCRUD.TabIndex = 40;
            this.Btn_IrCProductoCRUD.Text = "Volver ↺";
            this.Btn_IrCProductoCRUD.UseVisualStyleBackColor = false;
            this.Btn_IrCProductoCRUD.Click += new System.EventHandler(this.Btn_IrCProductoCRUD_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Goldenrod;
            this.label11.Location = new System.Drawing.Point(573, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 27);
            this.label11.TabIndex = 41;
            this.label11.Text = "°❀🐞⋆.ೃ࿔*:･";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(597, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 40);
            this.label12.TabIndex = 42;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(725, 361);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Btn_IrCProductoCRUD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.DataGridView_TablaCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtBox_Correo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtBox_Nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBox_ClienteID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TablaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.DataGridView DataGridView_TablaCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBox_Correo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBox_Nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBox_ClienteID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_IrCProductoCRUD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}