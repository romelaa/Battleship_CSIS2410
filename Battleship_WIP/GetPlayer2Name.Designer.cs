namespace Battleship_WIP
{
    partial class GetPlayer2Name
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
            this.lblP2Name = new System.Windows.Forms.Label();
            this.txtP2Name = new System.Windows.Forms.TextBox();
            this.btnSubmitP2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblP2Name
            // 
            this.lblP2Name.AutoSize = true;
            this.lblP2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Name.Location = new System.Drawing.Point(103, 53);
            this.lblP2Name.Name = "lblP2Name";
            this.lblP2Name.Size = new System.Drawing.Size(358, 31);
            this.lblP2Name.TabIndex = 0;
            this.lblP2Name.Text = "Player 2, enter your name:";
            // 
            // txtP2Name
            // 
            this.txtP2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP2Name.Location = new System.Drawing.Point(109, 120);
            this.txtP2Name.Name = "txtP2Name";
            this.txtP2Name.Size = new System.Drawing.Size(352, 31);
            this.txtP2Name.TabIndex = 1;
            // 
            // btnSubmitP2
            // 
            this.btnSubmitP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitP2.Location = new System.Drawing.Point(229, 177);
            this.btnSubmitP2.Name = "btnSubmitP2";
            this.btnSubmitP2.Size = new System.Drawing.Size(103, 45);
            this.btnSubmitP2.TabIndex = 2;
            this.btnSubmitP2.Text = "Submit";
            this.btnSubmitP2.UseVisualStyleBackColor = true;
            this.btnSubmitP2.Click += new System.EventHandler(this.btnSubmitP2_Click);
            // 
            // GetPlayer2Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 306);
            this.Controls.Add(this.btnSubmitP2);
            this.Controls.Add(this.txtP2Name);
            this.Controls.Add(this.lblP2Name);
            this.Name = "GetPlayer2Name";
            this.Text = "GetPlayer1Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblP2Name;
        private System.Windows.Forms.TextBox txtP2Name;
        private System.Windows.Forms.Button btnSubmitP2;
    }
}