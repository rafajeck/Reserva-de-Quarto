namespace WindowsFormsApplication3
{
    partial class Recibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recibo));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_checkIn = new System.Windows.Forms.Label();
            this.lbl_checkOut = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CheckIn = new System.Windows.Forms.TextBox();
            this.txt_tipoQuarto = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.txt_CheckOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(261, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Concluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(549, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome.Location = new System.Drawing.Point(59, 144);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 15;
            this.lbl_nome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo de Quarto";
            // 
            // lbl_checkIn
            // 
            this.lbl_checkIn.AutoSize = true;
            this.lbl_checkIn.ForeColor = System.Drawing.Color.Black;
            this.lbl_checkIn.Location = new System.Drawing.Point(59, 248);
            this.lbl_checkIn.Name = "lbl_checkIn";
            this.lbl_checkIn.Size = new System.Drawing.Size(52, 13);
            this.lbl_checkIn.TabIndex = 17;
            this.lbl_checkIn.Text = "Check in ";
            // 
            // lbl_checkOut
            // 
            this.lbl_checkOut.AutoSize = true;
            this.lbl_checkOut.ForeColor = System.Drawing.Color.Black;
            this.lbl_checkOut.Location = new System.Drawing.Point(289, 248);
            this.lbl_checkOut.Name = "lbl_checkOut";
            this.lbl_checkOut.Size = new System.Drawing.Size(58, 13);
            this.lbl_checkOut.TabIndex = 18;
            this.lbl_checkOut.Text = "Check Out";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(36, 347);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(112, 13);
            this.lbl_total.TabIndex = 19;
            this.lbl_total.Text = "Valor da Reserva R$ :";
            this.lbl_total.Click += new System.EventHandler(this.lbl_total_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 76);
            this.panel1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(177, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 73);
            this.label6.TabIndex = 0;
            this.label6.Text = "EASYROOM";
            // 
            // txt_CheckIn
            // 
            this.txt_CheckIn.Enabled = false;
            this.txt_CheckIn.Location = new System.Drawing.Point(59, 264);
            this.txt_CheckIn.Name = "txt_CheckIn";
            this.txt_CheckIn.Size = new System.Drawing.Size(120, 20);
            this.txt_CheckIn.TabIndex = 21;
            // 
            // txt_tipoQuarto
            // 
            this.txt_tipoQuarto.Enabled = false;
            this.txt_tipoQuarto.Location = new System.Drawing.Point(59, 214);
            this.txt_tipoQuarto.Name = "txt_tipoQuarto";
            this.txt_tipoQuarto.Size = new System.Drawing.Size(120, 20);
            this.txt_tipoQuarto.TabIndex = 22;
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(62, 161);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(117, 20);
            this.txt_nome.TabIndex = 23;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Enabled = false;
            this.txt_Valor.Location = new System.Drawing.Point(154, 344);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(52, 20);
            this.txt_Valor.TabIndex = 24;
            // 
            // txt_CheckOut
            // 
            this.txt_CheckOut.Enabled = false;
            this.txt_CheckOut.Location = new System.Drawing.Point(292, 263);
            this.txt_CheckOut.Name = "txt_CheckOut";
            this.txt_CheckOut.Size = new System.Drawing.Size(123, 20);
            this.txt_CheckOut.TabIndex = 21;
            this.txt_CheckOut.TextChanged += new System.EventHandler(this.txt_CheckOut_TextChanged);
            // 
            // Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_CheckOut);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_tipoQuarto);
            this.Controls.Add(this.txt_CheckIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_checkOut);
            this.Controls.Add(this.lbl_checkIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Recibo";
            this.Text = "Formulario_Venda";
            this.Load += new System.EventHandler(this.Recibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_checkIn;
        private System.Windows.Forms.Label lbl_checkOut;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CheckIn;
        private System.Windows.Forms.TextBox txt_tipoQuarto;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.TextBox txt_CheckOut;
    }
}