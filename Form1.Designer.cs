using System;

namespace puzzle
{
    partial class frmPuzzleGame
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuzzleGame));
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.gbPuzzleBox = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbOriginal.BackgroundImage")));
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.Location = new System.Drawing.Point(552, 84);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(377, 282);
            this.gbOriginal.TabIndex = 2;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Original Image";
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.White;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShuffle.Location = new System.Drawing.Point(552, 501);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(105, 62);
            this.btnShuffle.TabIndex = 3;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(700, 501);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(98, 62);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.White;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQuit.Location = new System.Drawing.Point(843, 501);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 62);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(619, 398);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(264, 80);
            this.lblTimeElapsed.TabIndex = 8;
            this.lblTimeElapsed.Text = "00:00:00";
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMovesMade.Location = new System.Drawing.Point(188, 522);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(118, 19);
            this.lblMovesMade.TabIndex = 9;
            this.lblMovesMade.Text = "Moves Made : ";
            // 
            // gbPuzzleBox
            // 
            this.gbPuzzleBox.Controls.Add(this.pbx1);
            this.gbPuzzleBox.Controls.Add(this.pbx2);
            this.gbPuzzleBox.Controls.Add(this.pbx3);
            this.gbPuzzleBox.Controls.Add(this.pbx4);
            this.gbPuzzleBox.Controls.Add(this.pbx5);
            this.gbPuzzleBox.Controls.Add(this.pbx6);
            this.gbPuzzleBox.Controls.Add(this.pbx7);
            this.gbPuzzleBox.Controls.Add(this.pbx8);
            this.gbPuzzleBox.Controls.Add(this.pbx9);
            this.gbPuzzleBox.Location = new System.Drawing.Point(58, 45);
            this.gbPuzzleBox.Name = "gbPuzzleBox";
            this.gbPuzzleBox.Size = new System.Drawing.Size(427, 433);
            this.gbPuzzleBox.TabIndex = 10;
            this.gbPuzzleBox.TabStop = false;
            this.gbPuzzleBox.Text = "PuzzleBox";
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(17, 23);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(130, 130);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(149, 23);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(130, 130);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(281, 23);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(130, 130);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(17, 155);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(130, 130);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(149, 155);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(130, 130);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(281, 155);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(130, 130);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(17, 287);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(130, 130);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(149, 287);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(130, 130);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(281, 287);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(130, 130);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            // 
            // frmPuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 593);
            this.Controls.Add(this.gbPuzzleBox);
            this.Controls.Add(this.lblMovesMade);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.gbOriginal);
            this.Name = "frmPuzzleGame";
            this.Text = "Puzzle Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pbx6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.GroupBox gbPuzzleBox;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx9;
    }
}

