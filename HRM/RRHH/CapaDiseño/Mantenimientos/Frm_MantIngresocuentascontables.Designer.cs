﻿namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantIngresocuentascontables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantIngresocuentascontables));
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Gpb_IngresoDatos = new System.Windows.Forms.GroupBox();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Txt_Cuenta = new System.Windows.Forms.TextBox();
            this.Txt_Codigocuenta = new System.Windows.Forms.TextBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_RazonSansion = new System.Windows.Forms.Label();
            this.Lbl_NombreEmpleado = new System.Windows.Forms.Label();
            this.Lbl_IngresoSansion = new System.Windows.Forms.Label();
            this.Pic_Barra = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Gpb_IngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = global::CapaDiseño.Properties.Resources.question__1_;
            this.btn_Ayuda.Location = new System.Drawing.Point(353, 5);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.btn_Ayuda.TabIndex = 45;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(316, 5);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 44;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Location = new System.Drawing.Point(231, 141);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(106, 30);
            this.Btn_Ingresar.TabIndex = 41;
            this.Btn_Ingresar.Text = "INGRESAR";
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_RealizarSansion_Click);
            // 
            // Gpb_IngresoDatos
            // 
            this.Gpb_IngresoDatos.Controls.Add(this.Txt_Monto);
            this.Gpb_IngresoDatos.Controls.Add(this.Txt_Cuenta);
            this.Gpb_IngresoDatos.Controls.Add(this.Txt_Codigocuenta);
            this.Gpb_IngresoDatos.Controls.Add(this.Btn_Ingresar);
            this.Gpb_IngresoDatos.Controls.Add(this.Lbl_Descripcion);
            this.Gpb_IngresoDatos.Controls.Add(this.Lbl_RazonSansion);
            this.Gpb_IngresoDatos.Controls.Add(this.Lbl_NombreEmpleado);
            this.Gpb_IngresoDatos.Location = new System.Drawing.Point(12, 68);
            this.Gpb_IngresoDatos.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_IngresoDatos.Name = "Gpb_IngresoDatos";
            this.Gpb_IngresoDatos.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_IngresoDatos.Size = new System.Drawing.Size(374, 192);
            this.Gpb_IngresoDatos.TabIndex = 43;
            this.Gpb_IngresoDatos.TabStop = false;
            this.Gpb_IngresoDatos.Text = "Ingreso de Datos";
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Location = new System.Drawing.Point(122, 88);
            this.Txt_Monto.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(210, 20);
            this.Txt_Monto.TabIndex = 19;
            this.Txt_Monto.TextChanged += new System.EventHandler(this.Txt_Monto_TextChanged);
            // 
            // Txt_Cuenta
            // 
            this.Txt_Cuenta.Location = new System.Drawing.Point(122, 55);
            this.Txt_Cuenta.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cuenta.Name = "Txt_Cuenta";
            this.Txt_Cuenta.Size = new System.Drawing.Size(210, 20);
            this.Txt_Cuenta.TabIndex = 18;
            // 
            // Txt_Codigocuenta
            // 
            this.Txt_Codigocuenta.Location = new System.Drawing.Point(188, 21);
            this.Txt_Codigocuenta.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Codigocuenta.Name = "Txt_Codigocuenta";
            this.Txt_Codigocuenta.Size = new System.Drawing.Size(88, 20);
            this.Txt_Codigocuenta.TabIndex = 17;
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(19, 88);
            this.Lbl_Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Descripcion.TabIndex = 15;
            this.Lbl_Descripcion.Text = "MONTO";
            // 
            // Lbl_RazonSansion
            // 
            this.Lbl_RazonSansion.AutoSize = true;
            this.Lbl_RazonSansion.Location = new System.Drawing.Point(19, 58);
            this.Lbl_RazonSansion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_RazonSansion.Name = "Lbl_RazonSansion";
            this.Lbl_RazonSansion.Size = new System.Drawing.Size(51, 13);
            this.Lbl_RazonSansion.TabIndex = 14;
            this.Lbl_RazonSansion.Text = "CUENTA";
            // 
            // Lbl_NombreEmpleado
            // 
            this.Lbl_NombreEmpleado.AutoSize = true;
            this.Lbl_NombreEmpleado.Location = new System.Drawing.Point(19, 24);
            this.Lbl_NombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NombreEmpleado.Name = "Lbl_NombreEmpleado";
            this.Lbl_NombreEmpleado.Size = new System.Drawing.Size(165, 13);
            this.Lbl_NombreEmpleado.TabIndex = 13;
            this.Lbl_NombreEmpleado.Text = "INGRESE CODIGO DE CUENTA";
            // 
            // Lbl_IngresoSansion
            // 
            this.Lbl_IngresoSansion.AutoSize = true;
            this.Lbl_IngresoSansion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Lbl_IngresoSansion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IngresoSansion.ForeColor = System.Drawing.Color.White;
            this.Lbl_IngresoSansion.Location = new System.Drawing.Point(22, 11);
            this.Lbl_IngresoSansion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_IngresoSansion.Name = "Lbl_IngresoSansion";
            this.Lbl_IngresoSansion.Size = new System.Drawing.Size(289, 20);
            this.Lbl_IngresoSansion.TabIndex = 40;
            this.Lbl_IngresoSansion.Text = "INGRESO CUENTAS CONTABLES";
            // 
            // Pic_Barra
            // 
            this.Pic_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Barra.Location = new System.Drawing.Point(1, 1);
            this.Pic_Barra.Margin = new System.Windows.Forms.Padding(2);
            this.Pic_Barra.Name = "Pic_Barra";
            this.Pic_Barra.Size = new System.Drawing.Size(433, 45);
            this.Pic_Barra.TabIndex = 39;
            this.Pic_Barra.TabStop = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(390, 5);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 46;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // Frm_MantIngresocuentascontables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 274);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.Gpb_IngresoDatos);
            this.Controls.Add(this.Lbl_IngresoSansion);
            this.Controls.Add(this.Pic_Barra);
            this.Name = "Frm_MantIngresocuentascontables";
            this.Text = "Frm_MantIngresocuentascontables";
            this.Gpb_IngresoDatos.ResumeLayout(false);
            this.Gpb_IngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.GroupBox Gpb_IngresoDatos;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.TextBox Txt_Cuenta;
        private System.Windows.Forms.TextBox Txt_Codigocuenta;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_RazonSansion;
        private System.Windows.Forms.Label Lbl_NombreEmpleado;
        private System.Windows.Forms.Label Lbl_IngresoSansion;
        private System.Windows.Forms.PictureBox Pic_Barra;
        private System.Windows.Forms.Button btn_cerrar;
    }
}