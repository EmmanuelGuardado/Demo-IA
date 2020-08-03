namespace IA.Forms
{
    partial class PreguntasForm
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
            this.btnRecomendacion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radCalor = new System.Windows.Forms.RadioButton();
            this.radFrio = new System.Windows.Forms.RadioButton();
            this.chkAcampar = new System.Windows.Forms.CheckBox();
            this.chkAnimales = new System.Windows.Forms.CheckBox();
            this.chkMontañas = new System.Windows.Forms.CheckBox();
            this.chkBosque = new System.Windows.Forms.CheckBox();
            this.chkPlaya = new System.Windows.Forms.CheckBox();
            this.chkCultura = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Responde a las siguientes preguntas";
            // 
            // btnRecomendacion
            // 
            this.btnRecomendacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecomendacion.Location = new System.Drawing.Point(190, 398);
            this.btnRecomendacion.Name = "btnRecomendacion";
            this.btnRecomendacion.Size = new System.Drawing.Size(166, 42);
            this.btnRecomendacion.TabIndex = 3;
            this.btnRecomendacion.Text = "Recomendación";
            this.btnRecomendacion.UseVisualStyleBackColor = true;
            this.btnRecomendacion.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkAcampar);
            this.groupBox1.Controls.Add(this.chkAnimales);
            this.groupBox1.Controls.Add(this.chkMontañas);
            this.groupBox1.Controls.Add(this.chkBosque);
            this.groupBox1.Controls.Add(this.chkPlaya);
            this.groupBox1.Controls.Add(this.chkCultura);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(102, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Te gusta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radCalor);
            this.groupBox2.Controls.Add(this.radFrio);
            this.groupBox2.Location = new System.Drawing.Point(22, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clima";
            // 
            // radCalor
            // 
            this.radCalor.AutoSize = true;
            this.radCalor.Location = new System.Drawing.Point(175, 25);
            this.radCalor.Name = "radCalor";
            this.radCalor.Size = new System.Drawing.Size(69, 24);
            this.radCalor.TabIndex = 1;
            this.radCalor.TabStop = true;
            this.radCalor.Text = "Calor";
            this.radCalor.UseVisualStyleBackColor = true;
            // 
            // radFrio
            // 
            this.radFrio.AutoSize = true;
            this.radFrio.Location = new System.Drawing.Point(6, 25);
            this.radFrio.Name = "radFrio";
            this.radFrio.Size = new System.Drawing.Size(58, 24);
            this.radFrio.TabIndex = 1;
            this.radFrio.TabStop = true;
            this.radFrio.Text = "Frio";
            this.radFrio.UseVisualStyleBackColor = true;
            // 
            // chkAcampar
            // 
            this.chkAcampar.AutoSize = true;
            this.chkAcampar.Location = new System.Drawing.Point(228, 114);
            this.chkAcampar.Name = "chkAcampar";
            this.chkAcampar.Size = new System.Drawing.Size(99, 24);
            this.chkAcampar.TabIndex = 0;
            this.chkAcampar.Text = "Acampar";
            this.chkAcampar.UseVisualStyleBackColor = true;
            // 
            // chkAnimales
            // 
            this.chkAnimales.AutoSize = true;
            this.chkAnimales.Location = new System.Drawing.Point(228, 69);
            this.chkAnimales.Name = "chkAnimales";
            this.chkAnimales.Size = new System.Drawing.Size(101, 24);
            this.chkAnimales.TabIndex = 0;
            this.chkAnimales.Text = "Animales";
            this.chkAnimales.UseVisualStyleBackColor = true;
            // 
            // chkMontañas
            // 
            this.chkMontañas.AutoSize = true;
            this.chkMontañas.Location = new System.Drawing.Point(228, 26);
            this.chkMontañas.Name = "chkMontañas";
            this.chkMontañas.Size = new System.Drawing.Size(107, 24);
            this.chkMontañas.TabIndex = 0;
            this.chkMontañas.Text = "Montañas";
            this.chkMontañas.UseVisualStyleBackColor = true;
            // 
            // chkBosque
            // 
            this.chkBosque.AutoSize = true;
            this.chkBosque.Location = new System.Drawing.Point(22, 114);
            this.chkBosque.Name = "chkBosque";
            this.chkBosque.Size = new System.Drawing.Size(89, 24);
            this.chkBosque.TabIndex = 0;
            this.chkBosque.Text = "Bosque";
            this.chkBosque.UseVisualStyleBackColor = true;
            // 
            // chkPlaya
            // 
            this.chkPlaya.AutoSize = true;
            this.chkPlaya.Location = new System.Drawing.Point(22, 69);
            this.chkPlaya.Name = "chkPlaya";
            this.chkPlaya.Size = new System.Drawing.Size(71, 24);
            this.chkPlaya.TabIndex = 0;
            this.chkPlaya.Text = "Playa";
            this.chkPlaya.UseVisualStyleBackColor = true;
            // 
            // chkCultura
            // 
            this.chkCultura.AutoSize = true;
            this.chkCultura.Location = new System.Drawing.Point(22, 26);
            this.chkCultura.Name = "chkCultura";
            this.chkCultura.Size = new System.Drawing.Size(86, 24);
            this.chkCultura.TabIndex = 0;
            this.chkCultura.Text = "Cultura";
            this.chkCultura.UseVisualStyleBackColor = true;
            // 
            // PreguntasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRecomendacion);
            this.Controls.Add(this.label1);
            this.Name = "PreguntasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecomendacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radCalor;
        private System.Windows.Forms.RadioButton radFrio;
        private System.Windows.Forms.CheckBox chkAcampar;
        private System.Windows.Forms.CheckBox chkAnimales;
        private System.Windows.Forms.CheckBox chkMontañas;
        private System.Windows.Forms.CheckBox chkBosque;
        private System.Windows.Forms.CheckBox chkPlaya;
        private System.Windows.Forms.CheckBox chkCultura;
    }
}