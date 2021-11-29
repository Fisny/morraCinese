namespace morraCinese
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btNew = new System.Windows.Forms.Button();
            this.imCarta = new System.Windows.Forms.PictureBox();
            this.imSasso = new System.Windows.Forms.PictureBox();
            this.imForbice = new System.Windows.Forms.PictureBox();
            this.imSceltaGiocatore = new System.Windows.Forms.PictureBox();
            this.imSceltaPc = new System.Windows.Forms.PictureBox();
            this.txGiocatore = new System.Windows.Forms.Label();
            this.txPc = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rsPc = new System.Windows.Forms.TextBox();
            this.rsGiocatore = new System.Windows.Forms.TextBox();
            this.giocatoreV = new System.Windows.Forms.Label();
            this.pcV = new System.Windows.Forms.Label();
            this.lbEsito = new System.Windows.Forms.Label();
            this.imPcV = new System.Windows.Forms.PictureBox();
            this.imGiocatoreV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imSasso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imForbice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imSceltaGiocatore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imSceltaPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imPcV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imGiocatoreV)).BeginInit();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNew.Location = new System.Drawing.Point(45, 209);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(116, 72);
            this.btNew.TabIndex = 0;
            this.btNew.Text = "Nuova partita";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // imCarta
            // 
            this.imCarta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imCarta.Image = global::morraCinese.Properties.Resources.carta;
            this.imCarta.InitialImage = ((System.Drawing.Image)(resources.GetObject("imCarta.InitialImage")));
            this.imCarta.Location = new System.Drawing.Point(350, 81);
            this.imCarta.Name = "imCarta";
            this.imCarta.Size = new System.Drawing.Size(57, 62);
            this.imCarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imCarta.TabIndex = 1;
            this.imCarta.TabStop = false;
            this.imCarta.Click += new System.EventHandler(this.imCarta_Click);
            // 
            // imSasso
            // 
            this.imSasso.Image = ((System.Drawing.Image)(resources.GetObject("imSasso.Image")));
            this.imSasso.InitialImage = ((System.Drawing.Image)(resources.GetObject("imSasso.InitialImage")));
            this.imSasso.Location = new System.Drawing.Point(585, 81);
            this.imSasso.Name = "imSasso";
            this.imSasso.Size = new System.Drawing.Size(57, 62);
            this.imSasso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imSasso.TabIndex = 2;
            this.imSasso.TabStop = false;
            this.imSasso.Click += new System.EventHandler(this.imSasso_Click);
            // 
            // imForbice
            // 
            this.imForbice.Image = ((System.Drawing.Image)(resources.GetObject("imForbice.Image")));
            this.imForbice.InitialImage = ((System.Drawing.Image)(resources.GetObject("imForbice.InitialImage")));
            this.imForbice.Location = new System.Drawing.Point(467, 81);
            this.imForbice.Name = "imForbice";
            this.imForbice.Size = new System.Drawing.Size(57, 62);
            this.imForbice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imForbice.TabIndex = 3;
            this.imForbice.TabStop = false;
            this.imForbice.Click += new System.EventHandler(this.imForbice_Click);
            // 
            // imSceltaGiocatore
            // 
            this.imSceltaGiocatore.InitialImage = null;
            this.imSceltaGiocatore.Location = new System.Drawing.Point(350, 219);
            this.imSceltaGiocatore.Name = "imSceltaGiocatore";
            this.imSceltaGiocatore.Size = new System.Drawing.Size(57, 62);
            this.imSceltaGiocatore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imSceltaGiocatore.TabIndex = 4;
            this.imSceltaGiocatore.TabStop = false;
            this.imSceltaGiocatore.Click += new System.EventHandler(this.imSceltaGiocatore_Click);
            // 
            // imSceltaPc
            // 
            this.imSceltaPc.ErrorImage = null;
            this.imSceltaPc.InitialImage = ((System.Drawing.Image)(resources.GetObject("imSceltaPc.InitialImage")));
            this.imSceltaPc.Location = new System.Drawing.Point(557, 219);
            this.imSceltaPc.Name = "imSceltaPc";
            this.imSceltaPc.Size = new System.Drawing.Size(57, 62);
            this.imSceltaPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imSceltaPc.TabIndex = 5;
            this.imSceltaPc.TabStop = false;
            // 
            // txGiocatore
            // 
            this.txGiocatore.AutoSize = true;
            this.txGiocatore.Location = new System.Drawing.Point(306, 193);
            this.txGiocatore.Name = "txGiocatore";
            this.txGiocatore.Size = new System.Drawing.Size(151, 20);
            this.txGiocatore.TabIndex = 6;
            this.txGiocatore.Text = "Il giocatore ha scelto:";
            // 
            // txPc
            // 
            this.txPc.AutoSize = true;
            this.txPc.Location = new System.Drawing.Point(514, 193);
            this.txPc.Name = "txPc";
            this.txPc.Size = new System.Drawing.Size(151, 20);
            this.txPc.TabIndex = 7;
            this.txPc.Text = "Il computer ha scelto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scegli la mossa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Risultato giocatore:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Risultato computer:";
            // 
            // rsPc
            // 
            this.rsPc.Enabled = false;
            this.rsPc.Location = new System.Drawing.Point(620, 407);
            this.rsPc.Name = "rsPc";
            this.rsPc.Size = new System.Drawing.Size(46, 27);
            this.rsPc.TabIndex = 11;
            // 
            // rsGiocatore
            // 
            this.rsGiocatore.Enabled = false;
            this.rsGiocatore.Location = new System.Drawing.Point(412, 407);
            this.rsGiocatore.Name = "rsGiocatore";
            this.rsGiocatore.Size = new System.Drawing.Size(46, 27);
            this.rsGiocatore.TabIndex = 12;
            // 
            // giocatoreV
            // 
            this.giocatoreV.AutoSize = true;
            this.giocatoreV.Location = new System.Drawing.Point(312, 444);
            this.giocatoreV.Name = "giocatoreV";
            this.giocatoreV.Size = new System.Drawing.Size(73, 20);
            this.giocatoreV.TabIndex = 13;
            this.giocatoreV.Text = "Hai vinto!";
            this.giocatoreV.Visible = false;
            // 
            // pcV
            // 
            this.pcV.AutoSize = true;
            this.pcV.Location = new System.Drawing.Point(519, 444);
            this.pcV.Name = "pcV";
            this.pcV.Size = new System.Drawing.Size(73, 20);
            this.pcV.TabIndex = 14;
            this.pcV.Text = "Hai vinto!";
            this.pcV.Visible = false;
            // 
            // lbEsito
            // 
            this.lbEsito.AutoSize = true;
            this.lbEsito.Location = new System.Drawing.Point(450, 322);
            this.lbEsito.Name = "lbEsito";
            this.lbEsito.Size = new System.Drawing.Size(0, 20);
            this.lbEsito.TabIndex = 15;
            // 
            // imPcV
            // 
            this.imPcV.Enabled = false;
            this.imPcV.ErrorImage = null;
            this.imPcV.Image = global::morraCinese.Properties.Resources.tromba;
            this.imPcV.InitialImage = ((System.Drawing.Image)(resources.GetObject("imPcV.InitialImage")));
            this.imPcV.Location = new System.Drawing.Point(514, 467);
            this.imPcV.Name = "imPcV";
            this.imPcV.Size = new System.Drawing.Size(107, 62);
            this.imPcV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imPcV.TabIndex = 16;
            this.imPcV.TabStop = false;
            this.imPcV.Visible = false;
            // 
            // imGiocatoreV
            // 
            this.imGiocatoreV.Enabled = false;
            this.imGiocatoreV.ErrorImage = null;
            this.imGiocatoreV.Image = global::morraCinese.Properties.Resources.tromba;
            this.imGiocatoreV.InitialImage = ((System.Drawing.Image)(resources.GetObject("imGiocatoreV.InitialImage")));
            this.imGiocatoreV.Location = new System.Drawing.Point(299, 467);
            this.imGiocatoreV.Name = "imGiocatoreV";
            this.imGiocatoreV.Size = new System.Drawing.Size(107, 62);
            this.imGiocatoreV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imGiocatoreV.TabIndex = 17;
            this.imGiocatoreV.TabStop = false;
            this.imGiocatoreV.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 580);
            this.Controls.Add(this.imGiocatoreV);
            this.Controls.Add(this.imPcV);
            this.Controls.Add(this.lbEsito);
            this.Controls.Add(this.pcV);
            this.Controls.Add(this.giocatoreV);
            this.Controls.Add(this.rsGiocatore);
            this.Controls.Add(this.rsPc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txPc);
            this.Controls.Add(this.txGiocatore);
            this.Controls.Add(this.imSceltaPc);
            this.Controls.Add(this.imSceltaGiocatore);
            this.Controls.Add(this.imForbice);
            this.Controls.Add(this.imSasso);
            this.Controls.Add(this.imCarta);
            this.Controls.Add(this.btNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imSasso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imForbice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imSceltaGiocatore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imSceltaPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imPcV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imGiocatoreV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.PictureBox imCarta;
        private System.Windows.Forms.PictureBox imSasso;
        private System.Windows.Forms.PictureBox imForbice;
        private System.Windows.Forms.PictureBox imSceltaGiocatore;
        private System.Windows.Forms.PictureBox imSceltaPc;
        private System.Windows.Forms.Label txGiocatore;
        private System.Windows.Forms.Label txPc;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rsPc;
        private System.Windows.Forms.TextBox rsGiocatore;
        private System.Windows.Forms.Label giocatoreV;
        private System.Windows.Forms.Label pcV;
        private System.Windows.Forms.Label lbEsito;
        private System.Windows.Forms.PictureBox imPcV;
        private System.Windows.Forms.PictureBox imGiocatoreV;
    }
}
