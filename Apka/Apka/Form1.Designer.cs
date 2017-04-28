namespace Apka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.obrazek = new System.Windows.Forms.PictureBox();
            this.graj = new System.Windows.Forms.Button();
            this.Pytanie = new System.Windows.Forms.TextBox();
            this.tak = new System.Windows.Forms.Button();
            this.NIE = new System.Windows.Forms.Button();
            this.odpowiedz = new System.Windows.Forms.Button();
            this.pytanie1 = new System.Windows.Forms.Button();
            this.pytanie2 = new System.Windows.Forms.Button();
            this.pytanie3 = new System.Windows.Forms.Button();
            this.pytanie4 = new System.Windows.Forms.Button();
            this.ZASADY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // obrazek
            // 
            this.obrazek.Location = new System.Drawing.Point(281, 25);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(100, 163);
            this.obrazek.TabIndex = 0;
            this.obrazek.TabStop = false;
            this.obrazek.Click += new System.EventHandler(this.obrazek_Click);
            // 
            // graj
            // 
            this.graj.BackColor = System.Drawing.Color.Salmon;
            this.graj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.graj.Location = new System.Drawing.Point(281, 196);
            this.graj.Name = "graj";
            this.graj.Size = new System.Drawing.Size(100, 39);
            this.graj.TabIndex = 1;
            this.graj.Text = "zagraj";
            this.graj.UseVisualStyleBackColor = false;
            this.graj.Click += new System.EventHandler(this.graj_Click);
            // 
            // Pytanie
            // 
            this.Pytanie.Enabled = false;
            this.Pytanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pytanie.Location = new System.Drawing.Point(22, 75);
            this.Pytanie.Name = "Pytanie";
            this.Pytanie.Size = new System.Drawing.Size(241, 26);
            this.Pytanie.TabIndex = 2;
            this.Pytanie.TextChanged += new System.EventHandler(this.Pytanie_TextChanged);
            // 
            // tak
            // 
            this.tak.BackColor = System.Drawing.Color.Crimson;
            this.tak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tak.Location = new System.Drawing.Point(22, 192);
            this.tak.Name = "tak";
            this.tak.Size = new System.Drawing.Size(75, 31);
            this.tak.TabIndex = 3;
            this.tak.Text = "TAK";
            this.tak.UseVisualStyleBackColor = false;
            this.tak.Visible = false;
            this.tak.Click += new System.EventHandler(this.button1_Click);
            // 
            // NIE
            // 
            this.NIE.BackColor = System.Drawing.Color.Crimson;
            this.NIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NIE.Location = new System.Drawing.Point(158, 192);
            this.NIE.Name = "NIE";
            this.NIE.Size = new System.Drawing.Size(75, 31);
            this.NIE.TabIndex = 4;
            this.NIE.Text = "NIE";
            this.NIE.UseVisualStyleBackColor = false;
            this.NIE.Visible = false;
            this.NIE.Click += new System.EventHandler(this.NIE_Click);
            // 
            // odpowiedz
            // 
            this.odpowiedz.BackColor = System.Drawing.Color.Crimson;
            this.odpowiedz.CausesValidation = false;
            this.odpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odpowiedz.Location = new System.Drawing.Point(78, 128);
            this.odpowiedz.Name = "odpowiedz";
            this.odpowiedz.Size = new System.Drawing.Size(107, 41);
            this.odpowiedz.TabIndex = 9;
            this.odpowiedz.Text = "Odpowiedź";
            this.odpowiedz.UseVisualStyleBackColor = false;
            this.odpowiedz.Visible = false;
            this.odpowiedz.Click += new System.EventHandler(this.odpowiedz_Click);
            // 
            // pytanie1
            // 
            this.pytanie1.BackColor = System.Drawing.Color.DarkCyan;
            this.pytanie1.CausesValidation = false;
            this.pytanie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pytanie1.Location = new System.Drawing.Point(66, 129);
            this.pytanie1.Name = "pytanie1";
            this.pytanie1.Size = new System.Drawing.Size(129, 40);
            this.pytanie1.TabIndex = 10;
            this.pytanie1.Text = "kolejne pytanie";
            this.pytanie1.UseVisualStyleBackColor = false;
            this.pytanie1.Visible = false;
            this.pytanie1.Click += new System.EventHandler(this.pytanie1_Click);
            // 
            // pytanie2
            // 
            this.pytanie2.BackColor = System.Drawing.Color.DarkCyan;
            this.pytanie2.CausesValidation = false;
            this.pytanie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pytanie2.Location = new System.Drawing.Point(66, 128);
            this.pytanie2.Name = "pytanie2";
            this.pytanie2.Size = new System.Drawing.Size(129, 40);
            this.pytanie2.TabIndex = 11;
            this.pytanie2.Text = "kolejne pytanie";
            this.pytanie2.UseVisualStyleBackColor = false;
            this.pytanie2.Visible = false;
            this.pytanie2.Click += new System.EventHandler(this.pytanie2_Click);
            // 
            // pytanie3
            // 
            this.pytanie3.BackColor = System.Drawing.Color.DarkCyan;
            this.pytanie3.CausesValidation = false;
            this.pytanie3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pytanie3.Location = new System.Drawing.Point(66, 129);
            this.pytanie3.Name = "pytanie3";
            this.pytanie3.Size = new System.Drawing.Size(129, 40);
            this.pytanie3.TabIndex = 13;
            this.pytanie3.Text = "kolejne pytanie";
            this.pytanie3.UseVisualStyleBackColor = false;
            this.pytanie3.Visible = false;
            this.pytanie3.Click += new System.EventHandler(this.pytanie3_Click);
            // 
            // pytanie4
            // 
            this.pytanie4.BackColor = System.Drawing.Color.DarkCyan;
            this.pytanie4.CausesValidation = false;
            this.pytanie4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pytanie4.Location = new System.Drawing.Point(66, 129);
            this.pytanie4.Name = "pytanie4";
            this.pytanie4.Size = new System.Drawing.Size(129, 40);
            this.pytanie4.TabIndex = 14;
            this.pytanie4.Text = "kolejne pytanie";
            this.pytanie4.UseVisualStyleBackColor = false;
            this.pytanie4.Visible = false;
            this.pytanie4.Click += new System.EventHandler(this.pytanie4_Click);
            // 
            // ZASADY
            // 
            this.ZASADY.BackColor = System.Drawing.Color.DarkSalmon;
            this.ZASADY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZASADY.Location = new System.Drawing.Point(281, 245);
            this.ZASADY.Name = "ZASADY";
            this.ZASADY.Size = new System.Drawing.Size(100, 39);
            this.ZASADY.TabIndex = 15;
            this.ZASADY.Text = "zasady gry";
            this.ZASADY.UseVisualStyleBackColor = false;
            this.ZASADY.Click += new System.EventHandler(this.ZASADY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(410, 355);
            this.Controls.Add(this.ZASADY);
            this.Controls.Add(this.pytanie4);
            this.Controls.Add(this.pytanie3);
            this.Controls.Add(this.pytanie2);
            this.Controls.Add(this.pytanie1);
            this.Controls.Add(this.odpowiedz);
            this.Controls.Add(this.NIE);
            this.Controls.Add(this.tak);
            this.Controls.Add(this.Pytanie);
            this.Controls.Add(this.graj);
            this.Controls.Add(this.obrazek);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Zgadnij kto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox obrazek;
        private System.Windows.Forms.Button graj;
        private System.Windows.Forms.TextBox Pytanie;
        private System.Windows.Forms.Button tak;
        private System.Windows.Forms.Button NIE;
        private System.Windows.Forms.Button odpowiedz;
        private System.Windows.Forms.Button pytanie1;
        private System.Windows.Forms.Button pytanie2;
        private System.Windows.Forms.Button pytanie3;
        private System.Windows.Forms.Button pytanie4;
        private System.Windows.Forms.Button ZASADY;
    }
}

