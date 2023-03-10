namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.Elimina = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Visualizza = new System.Windows.Forms.Button();
            this.Scrittaprodotto = new System.Windows.Forms.TextBox();
            this.Modificare = new System.Windows.Forms.TextBox();
            this.Modificato = new System.Windows.Forms.TextBox();
            this.Prodotto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MAX = new System.Windows.Forms.Button();
            this.MIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Elimina
            // 
            this.Elimina.Location = new System.Drawing.Point(12, 84);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(75, 23);
            this.Elimina.TabIndex = 1;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = true;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modifica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Visualizza
            // 
            this.Visualizza.Location = new System.Drawing.Point(15, 265);
            this.Visualizza.Name = "Visualizza";
            this.Visualizza.Size = new System.Drawing.Size(75, 23);
            this.Visualizza.TabIndex = 3;
            this.Visualizza.Text = "Visualizza";
            this.Visualizza.UseVisualStyleBackColor = true;
            this.Visualizza.Click += new System.EventHandler(this.Visualizza_Click);
            // 
            // Scrittaprodotto
            // 
            this.Scrittaprodotto.Location = new System.Drawing.Point(12, 25);
            this.Scrittaprodotto.Name = "Scrittaprodotto";
            this.Scrittaprodotto.Size = new System.Drawing.Size(100, 20);
            this.Scrittaprodotto.TabIndex = 4;
            this.Scrittaprodotto.TextChanged += new System.EventHandler(this.Scrittaprodotto_TextChanged);
            // 
            // Modificare
            // 
            this.Modificare.Location = new System.Drawing.Point(119, 124);
            this.Modificare.Name = "Modificare";
            this.Modificare.Size = new System.Drawing.Size(100, 20);
            this.Modificare.TabIndex = 8;
            // 
            // Modificato
            // 
            this.Modificato.Location = new System.Drawing.Point(252, 124);
            this.Modificato.Name = "Modificato";
            this.Modificato.Size = new System.Drawing.Size(100, 20);
            this.Modificato.TabIndex = 11;
            this.Modificato.TextChanged += new System.EventHandler(this.Modificato_TextChanged);
            // 
            // Prodotto
            // 
            this.Prodotto.AutoSize = true;
            this.Prodotto.Location = new System.Drawing.Point(12, 9);
            this.Prodotto.Name = "Prodotto";
            this.Prodotto.Size = new System.Drawing.Size(47, 13);
            this.Prodotto.TabIndex = 12;
            this.Prodotto.Text = "Prodotto";
            this.Prodotto.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Prezzo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "A prodotto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "A prezzo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(418, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(340, 409);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Totale prezzo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // MAX
            // 
            this.MAX.Location = new System.Drawing.Point(15, 194);
            this.MAX.Name = "MAX";
            this.MAX.Size = new System.Drawing.Size(106, 23);
            this.MAX.TabIndex = 27;
            this.MAX.Text = "Prezzo massimo";
            this.MAX.UseVisualStyleBackColor = true;
            this.MAX.Click += new System.EventHandler(this.MAX_Click);
            // 
            // MIN
            // 
            this.MIN.Location = new System.Drawing.Point(15, 223);
            this.MIN.Name = "MIN";
            this.MIN.Size = new System.Drawing.Size(106, 23);
            this.MIN.TabIndex = 28;
            this.MIN.Text = "Prezzo minimo";
            this.MIN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MIN);
            this.Controls.Add(this.MAX);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prodotto);
            this.Controls.Add(this.Modificato);
            this.Controls.Add(this.Modificare);
            this.Controls.Add(this.Scrittaprodotto);
            this.Controls.Add(this.Visualizza);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Visualizza;
        private System.Windows.Forms.TextBox Scrittaprodotto;
        private System.Windows.Forms.TextBox Modificare;
        private System.Windows.Forms.TextBox Modificato;
        private System.Windows.Forms.Label Prodotto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button MAX;
        private System.Windows.Forms.Button MIN;
    }
}

