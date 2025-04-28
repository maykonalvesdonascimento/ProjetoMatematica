namespace Projeto_Matematica
{
    partial class AntecessorSucessor
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
			this.button1 = new System.Windows.Forms.Button();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAntecessor = new System.Windows.Forms.Button();
			this.btnSucessor = new System.Windows.Forms.Button();
			this.lblantecessor = new System.Windows.Forms.Label();
			this.lblsucessor = new System.Windows.Forms.Label();
			this.btnApagar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(653, -1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(315, 156);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(163, 20);
			this.txtNumero.TabIndex = 6;
			this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(311, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Digite um número";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(68, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(660, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Antecessor e Sucessor";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAntecessor
			// 
			this.btnAntecessor.BackgroundImage = global::Projeto_Matematica.Properties.Resources.setaesquerda;
			this.btnAntecessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAntecessor.Location = new System.Drawing.Point(294, 221);
			this.btnAntecessor.Name = "btnAntecessor";
			this.btnAntecessor.Size = new System.Drawing.Size(75, 91);
			this.btnAntecessor.TabIndex = 8;
			this.btnAntecessor.Text = "Antecessor";
			this.btnAntecessor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAntecessor.UseVisualStyleBackColor = true;
			this.btnAntecessor.Click += new System.EventHandler(this.btnAntecessor_Click);
			// 
			// btnSucessor
			// 
			this.btnSucessor.BackgroundImage = global::Projeto_Matematica.Properties.Resources.setadireita;
			this.btnSucessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSucessor.Location = new System.Drawing.Point(403, 221);
			this.btnSucessor.Name = "btnSucessor";
			this.btnSucessor.Size = new System.Drawing.Size(75, 91);
			this.btnSucessor.TabIndex = 9;
			this.btnSucessor.Text = "Sucessor";
			this.btnSucessor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSucessor.UseVisualStyleBackColor = true;
			this.btnSucessor.Click += new System.EventHandler(this.btnSucessor_Click);
			// 
			// lblantecessor
			// 
			this.lblantecessor.AutoSize = true;
			this.lblantecessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblantecessor.Location = new System.Drawing.Point(311, 337);
			this.lblantecessor.Name = "lblantecessor";
			this.lblantecessor.Size = new System.Drawing.Size(19, 20);
			this.lblantecessor.TabIndex = 10;
			this.lblantecessor.Text = "?";
			// 
			// lblsucessor
			// 
			this.lblsucessor.AutoSize = true;
			this.lblsucessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsucessor.Location = new System.Drawing.Point(442, 337);
			this.lblsucessor.Name = "lblsucessor";
			this.lblsucessor.Size = new System.Drawing.Size(19, 20);
			this.lblsucessor.TabIndex = 11;
			this.lblsucessor.Text = "?";
			// 
			// btnApagar
			// 
			this.btnApagar.BackgroundImage = global::Projeto_Matematica.Properties.Resources.lixo;
			this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnApagar.Location = new System.Drawing.Point(551, 308);
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.Size = new System.Drawing.Size(67, 83);
			this.btnApagar.TabIndex = 12;
			this.btnApagar.UseVisualStyleBackColor = true;
			this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
			// 
			// AntecessorSucessor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Projeto_Matematica.Properties.Resources.chevron_stripes_geometric_lines_1409_8687;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnApagar);
			this.Controls.Add(this.lblsucessor);
			this.Controls.Add(this.lblantecessor);
			this.Controls.Add(this.btnSucessor);
			this.Controls.Add(this.btnAntecessor);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AntecessorSucessor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AntecessorSucessor";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAntecessor;
        private System.Windows.Forms.Button btnSucessor;
        private System.Windows.Forms.Label lblantecessor;
        private System.Windows.Forms.Label lblsucessor;
        private System.Windows.Forms.Button btnApagar;
    }
}