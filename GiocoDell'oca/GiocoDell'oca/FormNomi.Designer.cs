namespace GiocoDell_oca
{
    partial class FormNomi
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
            this.txtbx_1 = new System.Windows.Forms.TextBox();
            this.txtbx_2 = new System.Windows.Forms.TextBox();
            this.lbl_FirstPlayer = new System.Windows.Forms.Label();
            this.lbl_SecondPlayer = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_1
            // 
            this.txtbx_1.Location = new System.Drawing.Point(63, 83);
            this.txtbx_1.Name = "txtbx_1";
            this.txtbx_1.Size = new System.Drawing.Size(216, 22);
            this.txtbx_1.TabIndex = 0;
            // 
            // txtbx_2
            // 
            this.txtbx_2.Location = new System.Drawing.Point(319, 83);
            this.txtbx_2.Name = "txtbx_2";
            this.txtbx_2.Size = new System.Drawing.Size(216, 22);
            this.txtbx_2.TabIndex = 1;
            // 
            // lbl_FirstPlayer
            // 
            this.lbl_FirstPlayer.Location = new System.Drawing.Point(60, 58);
            this.lbl_FirstPlayer.Name = "lbl_FirstPlayer";
            this.lbl_FirstPlayer.Size = new System.Drawing.Size(219, 22);
            this.lbl_FirstPlayer.TabIndex = 2;
            this.lbl_FirstPlayer.Text = "Nome Primo Giocatore:";
            // 
            // lbl_SecondPlayer
            // 
            this.lbl_SecondPlayer.Location = new System.Drawing.Point(316, 58);
            this.lbl_SecondPlayer.Name = "lbl_SecondPlayer";
            this.lbl_SecondPlayer.Size = new System.Drawing.Size(219, 22);
            this.lbl_SecondPlayer.TabIndex = 3;
            this.lbl_SecondPlayer.Text = "Nome Secondo Giocatore:";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(204, 162);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(175, 25);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Comincia a Giocare";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // FormNomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 262);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_SecondPlayer);
            this.Controls.Add(this.lbl_FirstPlayer);
            this.Controls.Add(this.txtbx_2);
            this.Controls.Add(this.txtbx_1);
            this.Name = "FormNomi";
            this.Text = "FormNomi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_1;
        private System.Windows.Forms.TextBox txtbx_2;
        private System.Windows.Forms.Label lbl_FirstPlayer;
        private System.Windows.Forms.Label lbl_SecondPlayer;
        private System.Windows.Forms.Button btn_Start;
    }
}