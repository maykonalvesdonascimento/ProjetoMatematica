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
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
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
			// button2
			// 
			this.button2.BackgroundImage = global::Projeto_Matematica.Properties.Resources.seta1;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(294, 221);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 91);
			this.button2.TabIndex = 8;
			this.button2.Text = "Antecessor";
			this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::Projeto_Matematica.Properties.Resources.seta2;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.Location = new System.Drawing.Point(403, 221);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 91);
			this.button3.TabIndex = 9;
			this.button3.Text = "Sucessor";
			this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.UseVisualStyleBackColor = true;
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
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AntecessorSucessor";
			this.Text = "AntecessorSucessor";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblantecessor;
        private System.Windows.Forms.Label lblsucessor;
        private System.Windows.Forms.Button btnApagar;
    }
}