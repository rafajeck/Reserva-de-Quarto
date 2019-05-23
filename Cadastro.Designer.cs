namespace WindowsFormsApplication3
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.NomeText = new ZBobb.AlphaBlendTextBox();
            this.CpfText = new ZBobb.AlphaBlendTextBox();
            this.TelText = new ZBobb.AlphaBlendTextBox();
            this.EndText = new ZBobb.AlphaBlendTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EmailText = new ZBobb.AlphaBlendTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomeText
            // 
            this.NomeText.BackAlpha = 255;
            this.NomeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NomeText.Location = new System.Drawing.Point(193, 143);
            this.NomeText.Name = "NomeText";
            this.NomeText.Size = new System.Drawing.Size(438, 29);
            this.NomeText.TabIndex = 0;
            this.NomeText.Text = "Nome";
            this.NomeText.TextChanged += new System.EventHandler(this.NomeText_TextChanged);
            this.NomeText.Enter += new System.EventHandler(this.NomeText_Enter);
            this.NomeText.Leave += new System.EventHandler(this.NomeText_Leave);
            // 
            // CpfText
            // 
            this.CpfText.BackAlpha = 255;
            this.CpfText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CpfText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpfText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CpfText.Location = new System.Drawing.Point(193, 201);
            this.CpfText.Name = "CpfText";
            this.CpfText.Size = new System.Drawing.Size(438, 29);
            this.CpfText.TabIndex = 1;
            this.CpfText.Text = "CPF";
            this.CpfText.TextChanged += new System.EventHandler(this.CpfText_TextChanged);
            this.CpfText.Enter += new System.EventHandler(this.CpfText_Enter);
            this.CpfText.Leave += new System.EventHandler(this.CpfText_Leave);
            // 
            // TelText
            // 
            this.TelText.BackAlpha = 255;
            this.TelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TelText.Location = new System.Drawing.Point(193, 260);
            this.TelText.Name = "TelText";
            this.TelText.Size = new System.Drawing.Size(438, 29);
            this.TelText.TabIndex = 2;
            this.TelText.Text = "Telefone";
            this.TelText.TextChanged += new System.EventHandler(this.TelText_TextChanged);
            this.TelText.Enter += new System.EventHandler(this.TelText_Enter);
            this.TelText.Leave += new System.EventHandler(this.TelText_Leave);
            // 
            // EndText
            // 
            this.EndText.BackAlpha = 255;
            this.EndText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EndText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EndText.Location = new System.Drawing.Point(195, 311);
            this.EndText.Name = "EndText";
            this.EndText.Size = new System.Drawing.Size(438, 29);
            this.EndText.TabIndex = 3;
            this.EndText.Text = "Endereço";
            this.EndText.TextChanged += new System.EventHandler(this.EndText_TextChanged);
            this.EndText.Enter += new System.EventHandler(this.EndText_Enter);
            this.EndText.Leave += new System.EventHandler(this.EndText_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(195, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(438, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailText
            // 
            this.EmailText.BackAlpha = 255;
            this.EmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EmailText.Location = new System.Drawing.Point(195, 366);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(438, 29);
            this.EmailText.TabIndex = 5;
            this.EmailText.Text = "E-mail";
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            this.EmailText.Enter += new System.EventHandler(this.EmailText_Enter);
            this.EmailText.Leave += new System.EventHandler(this.EmailText_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 79);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "EASYROOM";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EndText);
            this.Controls.Add(this.TelText);
            this.Controls.Add(this.CpfText);
            this.Controls.Add(this.NomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZBobb.AlphaBlendTextBox NomeText;
        private ZBobb.AlphaBlendTextBox CpfText;
        private ZBobb.AlphaBlendTextBox TelText;
        private ZBobb.AlphaBlendTextBox EndText;
        private System.Windows.Forms.Button button1;
        private ZBobb.AlphaBlendTextBox EmailText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

