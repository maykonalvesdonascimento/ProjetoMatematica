namespace Projeto_Matematica
{
    partial class Area
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
            this.GRBFormas = new System.Windows.Forms.GroupBox();
            this.radForma6 = new System.Windows.Forms.RadioButton();
            this.radForma5 = new System.Windows.Forms.RadioButton();
            this.radForma4 = new System.Windows.Forms.RadioButton();
            this.radForma3 = new System.Windows.Forms.RadioButton();
            this.radForma2 = new System.Windows.Forms.RadioButton();
            this.radForma1 = new System.Windows.Forms.RadioButton();
            this.picFormas = new System.Windows.Forms.PictureBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.GRBFormas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFormas)).BeginInit();
            this.SuspendLayout();
            // 
            // GRBFormas
            // 
            this.GRBFormas.BackColor = System.Drawing.Color.Transparent;
            this.GRBFormas.Controls.Add(this.radForma6);
            this.GRBFormas.Controls.Add(this.radForma5);
            this.GRBFormas.Controls.Add(this.radForma4);
            this.GRBFormas.Controls.Add(this.radForma3);
            this.GRBFormas.Controls.Add(this.radForma2);
            this.GRBFormas.Controls.Add(this.radForma1);
            this.GRBFormas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRBFormas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GRBFormas.Location = new System.Drawing.Point(12, 12);
            this.GRBFormas.Name = "GRBFormas";
            this.GRBFormas.Size = new System.Drawing.Size(214, 218);
            this.GRBFormas.TabIndex = 0;
            this.GRBFormas.TabStop = false;
            this.GRBFormas.Text = "Selecione uma Forma Geométrica";
            // 
            // radForma6
            // 
            this.radForma6.AutoSize = true;
            this.radForma6.Location = new System.Drawing.Point(31, 144);
            this.radForma6.Name = "radForma6";
            this.radForma6.Size = new System.Drawing.Size(66, 17);
            this.radForma6.TabIndex = 5;
            this.radForma6.Text = "Círculo";
            this.radForma6.UseVisualStyleBackColor = true;
            this.radForma6.CheckedChanged += new System.EventHandler(this.radForma6_CheckedChanged);
            // 
            // radForma5
            // 
            this.radForma5.AutoSize = true;
            this.radForma5.Location = new System.Drawing.Point(31, 121);
            this.radForma5.Name = "radForma5";
            this.radForma5.Size = new System.Drawing.Size(83, 17);
            this.radForma5.TabIndex = 4;
            this.radForma5.Text = "Losângulo";
            this.radForma5.UseVisualStyleBackColor = true;
            this.radForma5.CheckedChanged += new System.EventHandler(this.radForma5_CheckedChanged);
            // 
            // radForma4
            // 
            this.radForma4.AutoSize = true;
            this.radForma4.Location = new System.Drawing.Point(31, 98);
            this.radForma4.Name = "radForma4";
            this.radForma4.Size = new System.Drawing.Size(74, 17);
            this.radForma4.TabIndex = 3;
            this.radForma4.Text = "Trapézio";
            this.radForma4.UseVisualStyleBackColor = true;
            this.radForma4.CheckedChanged += new System.EventHandler(this.radForma4_CheckedChanged);
            // 
            // radForma3
            // 
            this.radForma3.AutoSize = true;
            this.radForma3.Location = new System.Drawing.Point(31, 75);
            this.radForma3.Name = "radForma3";
            this.radForma3.Size = new System.Drawing.Size(83, 17);
            this.radForma3.TabIndex = 2;
            this.radForma3.Text = "Retângulo";
            this.radForma3.UseVisualStyleBackColor = true;
            this.radForma3.CheckedChanged += new System.EventHandler(this.radForma3_CheckedChanged);
            // 
            // radForma2
            // 
            this.radForma2.AutoSize = true;
            this.radForma2.Location = new System.Drawing.Point(31, 52);
            this.radForma2.Name = "radForma2";
            this.radForma2.Size = new System.Drawing.Size(78, 17);
            this.radForma2.TabIndex = 1;
            this.radForma2.Text = "Triangulo";
            this.radForma2.UseVisualStyleBackColor = true;
            this.radForma2.CheckedChanged += new System.EventHandler(this.radForma2_CheckedChanged);
            // 
            // radForma1
            // 
            this.radForma1.AutoSize = true;
            this.radForma1.Location = new System.Drawing.Point(31, 29);
            this.radForma1.Name = "radForma1";
            this.radForma1.Size = new System.Drawing.Size(80, 17);
            this.radForma1.TabIndex = 0;
            this.radForma1.Text = "Quadrado";
            this.radForma1.UseVisualStyleBackColor = true;
            this.radForma1.CheckedChanged += new System.EventHandler(this.radForma1_CheckedChanged);
            // 
            // picFormas
            // 
            this.picFormas.BackColor = System.Drawing.Color.Transparent;
            this.picFormas.Location = new System.Drawing.Point(232, 12);
            this.picFormas.Name = "picFormas";
            this.picFormas.Size = new System.Drawing.Size(485, 240);
            this.picFormas.TabIndex = 1;
            this.picFormas.TabStop = false;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.BackColor = System.Drawing.Color.Transparent;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.Location = new System.Drawing.Point(230, 340);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(0, 16);
            this.lblValor1.TabIndex = 2;
            this.lblValor1.Visible = false;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.BackColor = System.Drawing.Color.Transparent;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.Location = new System.Drawing.Point(230, 373);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(0, 16);
            this.lblValor2.TabIndex = 3;
            this.lblValor2.Visible = false;
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(396, 337);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(118, 22);
            this.txtValor1.TabIndex = 4;
            this.txtValor1.Visible = false;
            this.txtValor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor1_KeyPress);
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(396, 370);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(118, 22);
            this.txtValor2.TabIndex = 5;
            this.txtValor2.Visible = false;
            this.txtValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor2_KeyPress);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(539, 343);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(44, 16);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Área:";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(723, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtValor3
            // 
            this.txtValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor3.Location = new System.Drawing.Point(396, 402);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(118, 22);
            this.txtValor3.TabIndex = 13;
            this.txtValor3.Visible = false;
            this.txtValor3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor3_KeyPress);
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.BackColor = System.Drawing.Color.Transparent;
            this.lblValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor3.Location = new System.Drawing.Point(230, 405);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(0, 16);
            this.lblValor3.TabIndex = 12;
            this.lblValor3.Visible = false;
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Matematica.Properties.Resources.backgroundTema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.picFormas);
            this.Controls.Add(this.GRBFormas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Area";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area";
            this.GRBFormas.ResumeLayout(false);
            this.GRBFormas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFormas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRBFormas;
        private System.Windows.Forms.RadioButton radForma6;
        private System.Windows.Forms.RadioButton radForma5;
        private System.Windows.Forms.RadioButton radForma4;
        private System.Windows.Forms.RadioButton radForma3;
        private System.Windows.Forms.RadioButton radForma2;
        private System.Windows.Forms.RadioButton radForma1;
        private System.Windows.Forms.PictureBox picFormas;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Label lblValor3;
    }
}