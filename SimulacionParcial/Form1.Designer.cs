﻿namespace SimulacionParcial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroIde = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBotonIngresar = new System.Windows.Forms.Button();
            this.dataGridViewDepartamento = new System.Windows.Forms.DataGridView();
            this.btnIngresoTemperatura = new System.Windows.Forms.Button();
            this.DataGridViewTemperatura = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnOrdenarMayor = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nùmero de Identificaciòn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperatura Registrada:";
            // 
            // txtNumeroIde
            // 
            this.txtNumeroIde.Location = new System.Drawing.Point(224, 66);
            this.txtNumeroIde.Name = "txtNumeroIde";
            this.txtNumeroIde.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroIde.TabIndex = 3;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(224, 95);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(100, 22);
            this.txtDepartamento.TabIndex = 4;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(559, 66);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 22);
            this.txtTemperatura.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Información Departamentos";
            // 
            // btnBotonIngresar
            // 
            this.btnBotonIngresar.Location = new System.Drawing.Point(42, 170);
            this.btnBotonIngresar.Name = "btnBotonIngresar";
            this.btnBotonIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnBotonIngresar.TabIndex = 7;
            this.btnBotonIngresar.Text = "Ingresar";
            this.btnBotonIngresar.UseVisualStyleBackColor = true;
            this.btnBotonIngresar.Click += new System.EventHandler(this.btnBotonIngresar_Click);
            // 
            // dataGridViewDepartamento
            // 
            this.dataGridViewDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamento.Location = new System.Drawing.Point(39, 236);
            this.dataGridViewDepartamento.Name = "dataGridViewDepartamento";
            this.dataGridViewDepartamento.RowHeadersWidth = 51;
            this.dataGridViewDepartamento.RowTemplate.Height = 24;
            this.dataGridViewDepartamento.Size = new System.Drawing.Size(294, 219);
            this.dataGridViewDepartamento.TabIndex = 8;
            // 
            // btnIngresoTemperatura
            // 
            this.btnIngresoTemperatura.Location = new System.Drawing.Point(374, 170);
            this.btnIngresoTemperatura.Name = "btnIngresoTemperatura";
            this.btnIngresoTemperatura.Size = new System.Drawing.Size(103, 23);
            this.btnIngresoTemperatura.TabIndex = 9;
            this.btnIngresoTemperatura.Text = "Ingresar Datos";
            this.btnIngresoTemperatura.UseVisualStyleBackColor = true;
            this.btnIngresoTemperatura.Click += new System.EventHandler(this.btnIngresoTemperatura_Click);
            // 
            // DataGridViewTemperatura
            // 
            this.DataGridViewTemperatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTemperatura.Location = new System.Drawing.Point(374, 236);
            this.DataGridViewTemperatura.Name = "DataGridViewTemperatura";
            this.DataGridViewTemperatura.RowHeadersWidth = 51;
            this.DataGridViewTemperatura.RowTemplate.Height = 24;
            this.DataGridViewTemperatura.Size = new System.Drawing.Size(335, 219);
            this.DataGridViewTemperatura.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temperatura Registrada";
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.Location = new System.Drawing.Point(925, 138);
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.RowHeadersWidth = 51;
            this.dataGridViewDatos.RowTemplate.Height = 24;
            this.dataGridViewDatos.Size = new System.Drawing.Size(373, 178);
            this.dataGridViewDatos.TabIndex = 12;
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(925, 322);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(98, 42);
            this.btnMostrarDatos.TabIndex = 13;
            this.btnMostrarDatos.Text = "Mostrar";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnOrdenarMayor
            // 
            this.btnOrdenarMayor.Location = new System.Drawing.Point(1030, 323);
            this.btnOrdenarMayor.Name = "btnOrdenarMayor";
            this.btnOrdenarMayor.Size = new System.Drawing.Size(106, 41);
            this.btnOrdenarMayor.TabIndex = 14;
            this.btnOrdenarMayor.Text = "Ordenar Ascendente";
            this.btnOrdenarMayor.UseVisualStyleBackColor = true;
            this.btnOrdenarMayor.Click += new System.EventHandler(this.btnOrdenarMayor_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(928, 394);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(95, 42);
            this.btnPromedio.TabIndex = 15;
            this.btnPromedio.Text = "Mostrar Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1052, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 585);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnOrdenarMayor);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.dataGridViewDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataGridViewTemperatura);
            this.Controls.Add(this.btnIngresoTemperatura);
            this.Controls.Add(this.dataGridViewDepartamento);
            this.Controls.Add(this.btnBotonIngresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtNumeroIde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Departamentos de Guatemala";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroIde;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBotonIngresar;
        private System.Windows.Forms.DataGridView dataGridViewDepartamento;
        private System.Windows.Forms.Button btnIngresoTemperatura;
        private System.Windows.Forms.DataGridView DataGridViewTemperatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnOrdenarMayor;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label label6;
    }
}

