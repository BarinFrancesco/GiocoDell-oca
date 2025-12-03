namespace GiocoDell_oca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grd_Playground = new System.Windows.Forms.DataGridView();
            this.btn_Trow_Dices = new System.Windows.Forms.Button();
            this.Pct_Dice_1 = new System.Windows.Forms.PictureBox();
            this.Pct_Dice_2 = new System.Windows.Forms.PictureBox();
            this.lblTot = new System.Windows.Forms.Label();
            this.lbl_ActivePlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Playground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Dice_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Dice_2)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Playground
            // 
            this.grd_Playground.AllowUserToAddRows = false;
            this.grd_Playground.AllowUserToDeleteRows = false;
            this.grd_Playground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Playground.Location = new System.Drawing.Point(2, 2);
            this.grd_Playground.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grd_Playground.Name = "grd_Playground";
            this.grd_Playground.ReadOnly = true;
            this.grd_Playground.RowHeadersWidth = 51;
            this.grd_Playground.Size = new System.Drawing.Size(630, 490);
            this.grd_Playground.TabIndex = 0;
            // 
            // btn_Trow_Dices
            // 
            this.btn_Trow_Dices.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trow_Dices.Location = new System.Drawing.Point(739, 433);
            this.btn_Trow_Dices.Name = "btn_Trow_Dices";
            this.btn_Trow_Dices.Size = new System.Drawing.Size(246, 59);
            this.btn_Trow_Dices.TabIndex = 1;
            this.btn_Trow_Dices.Text = "Lancia Dadi";
            this.btn_Trow_Dices.UseVisualStyleBackColor = true;
            this.btn_Trow_Dices.Click += new System.EventHandler(this.btn_Trow_Dices_Click);
            // 
            // Pct_Dice_1
            // 
            this.Pct_Dice_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pct_Dice_1.BackgroundImage")));
            this.Pct_Dice_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pct_Dice_1.Location = new System.Drawing.Point(739, 282);
            this.Pct_Dice_1.Name = "Pct_Dice_1";
            this.Pct_Dice_1.Size = new System.Drawing.Size(120, 120);
            this.Pct_Dice_1.TabIndex = 2;
            this.Pct_Dice_1.TabStop = false;
            // 
            // Pct_Dice_2
            // 
            this.Pct_Dice_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pct_Dice_2.BackgroundImage")));
            this.Pct_Dice_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pct_Dice_2.Location = new System.Drawing.Point(865, 282);
            this.Pct_Dice_2.Name = "Pct_Dice_2";
            this.Pct_Dice_2.Size = new System.Drawing.Size(120, 120);
            this.Pct_Dice_2.TabIndex = 3;
            this.Pct_Dice_2.TabStop = false;
            // 
            // lblTot
            // 
            this.lblTot.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(735, 144);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(254, 26);
            this.lblTot.TabIndex = 4;
            this.lblTot.Text = "Nessun dado tirato";
            // 
            // lbl_ActivePlayer
            // 
            this.lbl_ActivePlayer.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ActivePlayer.Location = new System.Drawing.Point(731, 118);
            this.lbl_ActivePlayer.Name = "lbl_ActivePlayer";
            this.lbl_ActivePlayer.Size = new System.Drawing.Size(254, 26);
            this.lbl_ActivePlayer.TabIndex = 5;
            this.lbl_ActivePlayer.Text = "Turno di ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 666);
            this.Controls.Add(this.lbl_ActivePlayer);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.Pct_Dice_2);
            this.Controls.Add(this.Pct_Dice_1);
            this.Controls.Add(this.btn_Trow_Dices);
            this.Controls.Add(this.grd_Playground);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grd_Playground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Dice_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_Dice_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Playground;
        private System.Windows.Forms.Button btn_Trow_Dices;
        private System.Windows.Forms.PictureBox Pct_Dice_1;
        private System.Windows.Forms.PictureBox Pct_Dice_2;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lbl_ActivePlayer;
    }
}

