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
            // frmSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 254);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtTexto);
            this.Name = "frmSecundario";
            this.Text = "Secundario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button cmdAsignar;
    }
}