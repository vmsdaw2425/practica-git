namespace ejercicioTelegrama
{
    partial class Form1
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
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.radioOrdinario = new System.Windows.Forms.RadioButton();
            this.radioUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(34, 53);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(283, 99);
            this.txtTelegrama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coste";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(71, 210);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(228, 210);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(89, 20);
            this.btnCalcularPrecio.TabIndex = 5;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // radioOrdinario
            // 
            this.radioOrdinario.AutoSize = true;
            this.radioOrdinario.Checked = true;
            this.radioOrdinario.Location = new System.Drawing.Point(34, 167);
            this.radioOrdinario.Name = "radioOrdinario";
            this.radioOrdinario.Size = new System.Drawing.Size(67, 17);
            this.radioOrdinario.TabIndex = 6;
            this.radioOrdinario.TabStop = true;
            this.radioOrdinario.Text = "Ordinario";
            this.radioOrdinario.UseVisualStyleBackColor = true;
            // 
            // radioUrgente
            // 
            this.radioUrgente.AutoSize = true;
            this.radioUrgente.Location = new System.Drawing.Point(108, 167);
            this.radioUrgente.Name = "radioUrgente";
            this.radioUrgente.Size = new System.Drawing.Size(63, 17);
            this.radioUrgente.TabIndex = 7;
            this.radioUrgente.TabStop = true;
            this.radioUrgente.Text = "Urgente";
            this.radioUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 307);
            this.Controls.Add(this.radioUrgente);
            this.Controls.Add(this.radioOrdinario);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FormTelegrama VMSDAW2425";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.RadioButton radioOrdinario;
        private System.Windows.Forms.RadioButton radioUrgente;
    }
}

