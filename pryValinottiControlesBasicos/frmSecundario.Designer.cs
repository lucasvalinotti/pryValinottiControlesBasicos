namespace pryValinottiControlesBasicos
{
    partial class frmSecundario
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkLucas = new System.Windows.Forms.CheckBox();
            this.chkSebastian = new System.Windows.Forms.CheckBox();
            this.chkValinotti = new System.Windows.Forms.CheckBox();
            this.cmdEscribir = new System.Windows.Forms.Button();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(191, 53);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(383, 20);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(249, 181);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(259, 25);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Su texto aparecera aqui...";
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Checked = true;
            this.optRojo.Location = new System.Drawing.Point(303, 96);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 2;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(424, 96);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 3;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(316, 132);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(136, 24);
            this.cmdAsignar.TabIndex = 4;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.chkValinotti);
            this.gbOpciones.Controls.Add(this.chkSebastian);
            this.gbOpciones.Controls.Add(this.chkLucas);
            this.gbOpciones.Location = new System.Drawing.Point(296, 225);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(173, 100);
            this.gbOpciones.TabIndex = 5;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // chkLucas
            // 
            this.chkLucas.AutoSize = true;
            this.chkLucas.Location = new System.Drawing.Point(52, 19);
            this.chkLucas.Name = "chkLucas";
            this.chkLucas.Size = new System.Drawing.Size(55, 17);
            this.chkLucas.TabIndex = 0;
            this.chkLucas.Text = "Lucas";
            this.chkLucas.UseVisualStyleBackColor = true;
            // 
            // chkSebastian
            // 
            this.chkSebastian.AutoSize = true;
            this.chkSebastian.Location = new System.Drawing.Point(52, 42);
            this.chkSebastian.Name = "chkSebastian";
            this.chkSebastian.Size = new System.Drawing.Size(73, 17);
            this.chkSebastian.TabIndex = 1;
            this.chkSebastian.Text = "Sebastian";
            this.chkSebastian.UseVisualStyleBackColor = true;
            // 
            // chkValinotti
            // 
            this.chkValinotti.AutoSize = true;
            this.chkValinotti.Location = new System.Drawing.Point(52, 65);
            this.chkValinotti.Name = "chkValinotti";
            this.chkValinotti.Size = new System.Drawing.Size(63, 17);
            this.chkValinotti.TabIndex = 2;
            this.chkValinotti.Text = "Valinotti";
            this.chkValinotti.UseVisualStyleBackColor = true;
            // 
            // cmdEscribir
            // 
            this.cmdEscribir.Location = new System.Drawing.Point(316, 331);
            this.cmdEscribir.Name = "cmdEscribir";
            this.cmdEscribir.Size = new System.Drawing.Size(136, 24);
            this.cmdEscribir.TabIndex = 6;
            this.cmdEscribir.Text = "Escribir";
            this.cmdEscribir.UseVisualStyleBackColor = true;
            this.cmdEscribir.Click += new System.EventHandler(this.cmdEscribir_Click);
            // 
            // frmSecundario
            // 
            this.AcceptButton = this.cmdAsignar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.cmdEscribir);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtTexto);
            this.MaximizeBox = false;
            this.Name = "frmSecundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secundario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.CheckBox chkValinotti;
        private System.Windows.Forms.CheckBox chkSebastian;
        private System.Windows.Forms.CheckBox chkLucas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cmdEscribir;
    }
}