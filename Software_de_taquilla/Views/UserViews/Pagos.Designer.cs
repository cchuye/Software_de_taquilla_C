﻿namespace Software_de_taquilla.Views.UserViews
{
    partial class Pagos
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
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.txt_notarjeta = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fechav = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago";
            // 
            // txt_correo
            // 
            this.txt_correo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_correo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_correo.Location = new System.Drawing.Point(48, 93);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(331, 30);
            this.txt_correo.TabIndex = 1;
            this.txt_correo.Text = "ejemplo@gmail.com";
            this.txt_correo.Click += new System.EventHandler(this.txt_correo_Click);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_telefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_telefono.Location = new System.Drawing.Point(437, 97);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(276, 30);
            this.txt_telefono.TabIndex = 2;
            this.txt_telefono.Text = "Teléfono";
            this.txt_telefono.Click += new System.EventHandler(this.txt_telefono_Click);
            this.txt_telefono.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // txt_monto
            // 
            this.txt_monto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_monto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_monto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_monto.Location = new System.Drawing.Point(48, 159);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(331, 30);
            this.txt_monto.TabIndex = 3;
            this.txt_monto.Text = "Q.245.00 ";
            this.txt_monto.Click += new System.EventHandler(this.txt_monto_Click);
            this.txt_monto.Leave += new System.EventHandler(this.txt_monto_Leave);
            // 
            // txt_notarjeta
            // 
            this.txt_notarjeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_notarjeta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_notarjeta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_notarjeta.Location = new System.Drawing.Point(48, 219);
            this.txt_notarjeta.Name = "txt_notarjeta";
            this.txt_notarjeta.Size = new System.Drawing.Size(331, 30);
            this.txt_notarjeta.TabIndex = 4;
            this.txt_notarjeta.Text = "Número de Tarjeta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txt_cvv
            // 
            this.txt_cvv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cvv.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cvv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_cvv.Location = new System.Drawing.Point(48, 294);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(331, 30);
            this.txt_cvv.TabIndex = 6;
            this.txt_cvv.Text = "CVV";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "CVV";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(437, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de vencimiento";
            // 
            // txt_fechav
            // 
            this.txt_fechav.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fechav.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_fechav.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_fechav.Location = new System.Drawing.Point(437, 293);
            this.txt_fechav.Name = "txt_fechav";
            this.txt_fechav.Size = new System.Drawing.Size(276, 30);
            this.txt_fechav.TabIndex = 9;
            this.txt_fechav.Text = "dd/mm/yyyy";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(437, 160);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(278, 25);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pago con tarjeta de credito";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Software_de_taquilla.Properties.Resources.visa;
            this.button1.Location = new System.Drawing.Point(448, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 28);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Software_de_taquilla.Properties.Resources.card1;
            this.button2.Location = new System.Drawing.Point(532, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 33);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Software_de_taquilla.Properties.Resources.american_express1;
            this.button3.Location = new System.Drawing.Point(625, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 32);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Software_de_taquilla.Properties.Resources.american_express1;
            this.button4.Location = new System.Drawing.Point(220, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 32);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Software_de_taquilla.Properties.Resources.card1;
            this.button5.Location = new System.Drawing.Point(127, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 33);
            this.button5.TabIndex = 15;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Enabled = false;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Software_de_taquilla.Properties.Resources.visa;
            this.button6.Location = new System.Drawing.Point(43, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 28);
            this.button6.TabIndex = 14;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 417);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txt_fechav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_notarjeta);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label1);
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_correo;
        private TextBox txt_telefono;
        private TextBox txt_monto;
        private TextBox txt_notarjeta;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_cvv;
        private Label label2;
        private Label label3;
        private TextBox txt_fechav;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}