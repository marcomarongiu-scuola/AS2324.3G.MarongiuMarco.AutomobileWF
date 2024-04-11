namespace AS2324._3G.Prof.AutomobileWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            prbVelocita = new ProgressBar();
            lblVelocita = new Label();
            btnAccellera = new Button();
            btnFrena = new Button();
            chkAccensione = new CheckBox();
            label1 = new Label();
            chkCinture = new CheckBox();
            btnClacson = new Button();
            lstMonitor = new ListBox();
            grbComandi = new GroupBox();
            label2 = new Label();
            cmbStrada = new ComboBox();
            grbComandi.SuspendLayout();
            SuspendLayout();
            // 
            // prbVelocita
            // 
            prbVelocita.Location = new Point(28, 341);
            prbVelocita.Name = "prbVelocita";
            prbVelocita.Size = new Size(598, 25);
            prbVelocita.TabIndex = 0;
            // 
            // lblVelocita
            // 
            lblVelocita.AutoSize = true;
            lblVelocita.Location = new Point(631, 341);
            lblVelocita.Name = "lblVelocita";
            lblVelocita.Size = new Size(48, 17);
            lblVelocita.TabIndex = 1;
            lblVelocita.Text = "0 km/h";
            // 
            // btnAccellera
            // 
            btnAccellera.Location = new Point(102, 22);
            btnAccellera.Name = "btnAccellera";
            btnAccellera.Size = new Size(82, 25);
            btnAccellera.TabIndex = 2;
            btnAccellera.Text = "Accellera";
            btnAccellera.UseVisualStyleBackColor = true;
            btnAccellera.Click += btnAccellera_Click;
            // 
            // btnFrena
            // 
            btnFrena.Location = new Point(8, 22);
            btnFrena.Name = "btnFrena";
            btnFrena.Size = new Size(88, 25);
            btnFrena.TabIndex = 3;
            btnFrena.Text = "Frena";
            btnFrena.UseVisualStyleBackColor = true;
            btnFrena.Click += btnFrena_Click;
            // 
            // chkAccensione
            // 
            chkAccensione.AutoSize = true;
            chkAccensione.Location = new Point(51, 108);
            chkAccensione.Name = "chkAccensione";
            chkAccensione.Size = new Size(129, 21);
            chkAccensione.TabIndex = 4;
            chkAccensione.Text = "Accendi il motore";
            chkAccensione.UseVisualStyleBackColor = true;
            chkAccensione.CheckedChanged += chkAccensione_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 11);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 5;
            label1.Text = "Vento 10 km/h";
            // 
            // chkCinture
            // 
            chkCinture.AutoSize = true;
            chkCinture.Location = new Point(51, 83);
            chkCinture.Name = "chkCinture";
            chkCinture.Size = new Size(68, 21);
            chkCinture.TabIndex = 6;
            chkCinture.Text = "Cinture";
            chkCinture.UseVisualStyleBackColor = true;
            // 
            // btnClacson
            // 
            btnClacson.Location = new Point(519, 133);
            btnClacson.Name = "btnClacson";
            btnClacson.Size = new Size(107, 40);
            btnClacson.TabIndex = 7;
            btnClacson.Text = "Clacson";
            btnClacson.UseVisualStyleBackColor = true;
            btnClacson.Click += btnClacson_Click;
            // 
            // lstMonitor
            // 
            lstMonitor.FormattingEnabled = true;
            lstMonitor.ItemHeight = 17;
            lstMonitor.Location = new Point(26, 235);
            lstMonitor.Name = "lstMonitor";
            lstMonitor.Size = new Size(664, 89);
            lstMonitor.TabIndex = 8;
            // 
            // grbComandi
            // 
            grbComandi.Controls.Add(btnAccellera);
            grbComandi.Controls.Add(btnFrena);
            grbComandi.Location = new Point(460, 54);
            grbComandi.Name = "grbComandi";
            grbComandi.Size = new Size(189, 58);
            grbComandi.TabIndex = 9;
            grbComandi.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 139);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 10;
            label2.Text = "Strada";
            // 
            // cmbStrada
            // 
            cmbStrada.FormattingEnabled = true;
            cmbStrada.Items.AddRange(new object[] { "Autostrada (130 km/h)", "Extraurbana (90 km/h)", "Urbana (50 km/h)" });
            cmbStrada.Location = new Point(99, 133);
            cmbStrada.Name = "cmbStrada";
            cmbStrada.Size = new Size(147, 25);
            cmbStrada.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 382);
            Controls.Add(cmbStrada);
            Controls.Add(label2);
            Controls.Add(grbComandi);
            Controls.Add(lstMonitor);
            Controls.Add(btnClacson);
            Controls.Add(chkCinture);
            Controls.Add(label1);
            Controls.Add(chkAccensione);
            Controls.Add(lblVelocita);
            Controls.Add(prbVelocita);
            Name = "Form1";
            Text = "Prof;AS 23/24 3G Lab 2.2;04/04/24; simulatore di un automobile";
            grbComandi.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar prbVelocita;
        private Label lblVelocita;
        private Button btnAccellera;
        private Button btnFrena;
        private CheckBox chkAccensione;
        private Label label1;
        private CheckBox chkCinture;
        private Button btnClacson;
        private ListBox lstMonitor;
        private GroupBox grbComandi;
        private Label label2;
        private ComboBox cmbStrada;
    }
}
