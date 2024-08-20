namespace Atividade_Prática
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
            this.lblpesoterra = new System.Windows.Forms.Label();
            this.lblplaneta = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.btnpeso = new System.Windows.Forms.Button();
            this.rbmercurio = new System.Windows.Forms.RadioButton();
            this.rbvenus = new System.Windows.Forms.RadioButton();
            this.rbmarte = new System.Windows.Forms.RadioButton();
            this.rbjupter = new System.Windows.Forms.RadioButton();
            this.rbsaturno = new System.Windows.Forms.RadioButton();
            this.rburano = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblpesoterra
            // 
            this.lblpesoterra.AutoSize = true;
            this.lblpesoterra.BackColor = System.Drawing.Color.SkyBlue;
            this.lblpesoterra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpesoterra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpesoterra.Location = new System.Drawing.Point(26, 27);
            this.lblpesoterra.Name = "lblpesoterra";
            this.lblpesoterra.Size = new System.Drawing.Size(111, 15);
            this.lblpesoterra.TabIndex = 0;
            this.lblpesoterra.Text = "Peso na Terra (kg):";
            // 
            // lblplaneta
            // 
            this.lblplaneta.AutoSize = true;
            this.lblplaneta.BackColor = System.Drawing.Color.SkyBlue;
            this.lblplaneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaneta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblplaneta.Location = new System.Drawing.Point(26, 119);
            this.lblplaneta.Name = "lblplaneta";
            this.lblplaneta.Size = new System.Drawing.Size(120, 15);
            this.lblplaneta.TabIndex = 1;
            this.lblplaneta.Text = "Selecione o Planeta:";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(24, 56);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(152, 20);
            this.txtpeso.TabIndex = 2;
            // 
            // btnpeso
            // 
            this.btnpeso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpeso.Location = new System.Drawing.Point(191, 54);
            this.btnpeso.Name = "btnpeso";
            this.btnpeso.Size = new System.Drawing.Size(106, 23);
            this.btnpeso.TabIndex = 3;
            this.btnpeso.Text = "Calcular Peso";
            this.btnpeso.UseVisualStyleBackColor = true;
            this.btnpeso.Click += new System.EventHandler(this.btnpeso_Click);
            // 
            // rbmercurio
            // 
            this.rbmercurio.AutoSize = true;
            this.rbmercurio.BackColor = System.Drawing.Color.RosyBrown;
            this.rbmercurio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbmercurio.Location = new System.Drawing.Point(43, 150);
            this.rbmercurio.Name = "rbmercurio";
            this.rbmercurio.Size = new System.Drawing.Size(66, 17);
            this.rbmercurio.TabIndex = 4;
            this.rbmercurio.TabStop = true;
            this.rbmercurio.Text = "Mercúrio";
            this.rbmercurio.UseVisualStyleBackColor = false;
            // 
            // rbvenus
            // 
            this.rbvenus.AutoSize = true;
            this.rbvenus.BackColor = System.Drawing.Color.RosyBrown;
            this.rbvenus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbvenus.Location = new System.Drawing.Point(43, 188);
            this.rbvenus.Name = "rbvenus";
            this.rbvenus.Size = new System.Drawing.Size(55, 17);
            this.rbvenus.TabIndex = 5;
            this.rbvenus.TabStop = true;
            this.rbvenus.Text = "Vênus";
            this.rbvenus.UseVisualStyleBackColor = false;
            // 
            // rbmarte
            // 
            this.rbmarte.AutoSize = true;
            this.rbmarte.BackColor = System.Drawing.Color.RosyBrown;
            this.rbmarte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbmarte.Location = new System.Drawing.Point(157, 150);
            this.rbmarte.Name = "rbmarte";
            this.rbmarte.Size = new System.Drawing.Size(52, 17);
            this.rbmarte.TabIndex = 6;
            this.rbmarte.TabStop = true;
            this.rbmarte.Text = "Marte";
            this.rbmarte.UseVisualStyleBackColor = false;
            // 
            // rbjupter
            // 
            this.rbjupter.AutoSize = true;
            this.rbjupter.BackColor = System.Drawing.Color.RosyBrown;
            this.rbjupter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbjupter.Location = new System.Drawing.Point(157, 188);
            this.rbjupter.Name = "rbjupter";
            this.rbjupter.Size = new System.Drawing.Size(54, 17);
            this.rbjupter.TabIndex = 7;
            this.rbjupter.TabStop = true;
            this.rbjupter.Text = "Júpter";
            this.rbjupter.UseVisualStyleBackColor = false;
            // 
            // rbsaturno
            // 
            this.rbsaturno.AutoSize = true;
            this.rbsaturno.BackColor = System.Drawing.Color.RosyBrown;
            this.rbsaturno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbsaturno.Location = new System.Drawing.Point(276, 150);
            this.rbsaturno.Name = "rbsaturno";
            this.rbsaturno.Size = new System.Drawing.Size(62, 17);
            this.rbsaturno.TabIndex = 8;
            this.rbsaturno.TabStop = true;
            this.rbsaturno.Text = "Saturno";
            this.rbsaturno.UseVisualStyleBackColor = false;
            // 
            // rburano
            // 
            this.rburano.AutoSize = true;
            this.rburano.BackColor = System.Drawing.Color.RosyBrown;
            this.rburano.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rburano.Location = new System.Drawing.Point(276, 188);
            this.rburano.Name = "rburano";
            this.rburano.Size = new System.Drawing.Size(54, 17);
            this.rburano.TabIndex = 9;
            this.rburano.TabStop = true;
            this.rburano.Text = "Urano";
            this.rburano.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::Atividade_Prática.Properties.Resources.planetas;
            this.ClientSize = new System.Drawing.Size(434, 256);
            this.Controls.Add(this.rburano);
            this.Controls.Add(this.rbsaturno);
            this.Controls.Add(this.rbjupter);
            this.Controls.Add(this.rbmarte);
            this.Controls.Add(this.rbvenus);
            this.Controls.Add(this.rbmercurio);
            this.Controls.Add(this.btnpeso);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblplaneta);
            this.Controls.Add(this.lblpesoterra);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpesoterra;
        private System.Windows.Forms.Label lblplaneta;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Button btnpeso;
        private System.Windows.Forms.RadioButton rbmercurio;
        private System.Windows.Forms.RadioButton rbvenus;
        private System.Windows.Forms.RadioButton rbmarte;
        private System.Windows.Forms.RadioButton rbjupter;
        private System.Windows.Forms.RadioButton rbsaturno;
        private System.Windows.Forms.RadioButton rburano;
    }
}