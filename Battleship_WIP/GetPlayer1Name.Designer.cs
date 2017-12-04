namespace Battleship_WIP
{
    partial class GetPlayer1Name
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
            this.lblP1Name = new System.Windows.Forms.Label();
            this.txtP1Name = new System.Windows.Forms.TextBox();
            this.btnSubmitP1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Name.Location = new System.Drawing.Point(103, 53);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(358, 31);
            this.lblP1Name.TabIndex = 0;
            this.lblP1Name.Text = "Player 1, enter your name:";
            // 
            // txtP1Name
            // 
            this.txtP1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP1Name.Location = new System.Drawing.Point(109, 120);
            this.txtP1Name.Name = "txtP1Name";
            this.txtP1Name.Size = new System.Drawing.Size(352, 31);
            this.txtP1Name.TabIndex = 1;
            // 
            // btnSubmitP1
            // 
            this.btnSubmitP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitP1.Location = new System.Drawing.Point(229, 177);
            this.btnSubmitP1.Name = "btnSubmitP1";
            this.btnSubmitP1.Size = new System.Drawing.Size(103, 45);
            this.btnSubmitP1.TabIndex = 2;
            this.btnSubmitP1.Text = "Submit";
            this.btnSubmitP1.UseVisualStyleBackColor = true;
            this.btnSubmitP1.Click += new System.EventHandler(this.btnSubmitP1_Click);
            // 
            // GetPlayer1Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 306);
            this.Controls.Add(this.btnSubmitP1);
            this.Controls.Add(this.txtP1Name);
            this.Controls.Add(this.lblP1Name);
            this.Name = "GetPlayer1Name";
            this.Text = "GetPlayer1Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblP1Name;
        private System.Windows.Forms.TextBox txtP1Name;
        private System.Windows.Forms.Button btnSubmitP1;
    }
}