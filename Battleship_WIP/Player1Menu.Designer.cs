using System.Windows.Forms;

namespace Battleship_WIP
{
    partial class Player1Menu
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
            this.doneBtn = new System.Windows.Forms.Button();
            this.rotateBtn = new System.Windows.Forms.Button();
            this.btnCarrier = new System.Windows.Forms.Button();
            this.btnBattleship = new System.Windows.Forms.Button();
            this.btnCruiser = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDestroyer = new System.Windows.Forms.Button();
            this.p1ShipPanel = new System.Windows.Forms.Panel();
            this.ShipBoard1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveCruiser = new System.Windows.Forms.Button();
            this.btnRemoveCarrier = new System.Windows.Forms.Button();
            this.btnRemoveBattleship = new System.Windows.Forms.Button();
            this.btnRemoveDestroyer = new System.Windows.Forms.Button();
            this.btnRemoveSub = new System.Windows.Forms.Button();
            this.p1ShipPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.Black;
            this.doneBtn.BackgroundImage = global::Battleship_WIP.Properties.Resources.done;
            this.doneBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doneBtn.Enabled = false;
            this.doneBtn.Location = new System.Drawing.Point(110, 405);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(73, 73);
            this.doneBtn.TabIndex = 10;
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // rotateBtn
            // 
            this.rotateBtn.BackColor = System.Drawing.Color.Black;
            this.rotateBtn.BackgroundImage = global::Battleship_WIP.Properties.Resources.rotate;
            this.rotateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateBtn.Location = new System.Drawing.Point(27, 405);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Size = new System.Drawing.Size(73, 73);
            this.rotateBtn.TabIndex = 9;
            this.rotateBtn.UseVisualStyleBackColor = false;
            this.rotateBtn.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // btnCarrier
            // 
            this.btnCarrier.BackColor = System.Drawing.Color.Black;
            this.btnCarrier.BackgroundImage = global::Battleship_WIP.Properties.Resources.carrier;
            this.btnCarrier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarrier.Location = new System.Drawing.Point(27, 334);
            this.btnCarrier.Name = "btnCarrier";
            this.btnCarrier.Size = new System.Drawing.Size(141, 40);
            this.btnCarrier.TabIndex = 8;
            this.btnCarrier.UseVisualStyleBackColor = false;
            this.btnCarrier.Click += new System.EventHandler(this.btnCarrier_Click);
            // 
            // btnBattleship
            // 
            this.btnBattleship.BackColor = System.Drawing.Color.Black;
            this.btnBattleship.BackgroundImage = global::Battleship_WIP.Properties.Resources.battle;
            this.btnBattleship.Location = new System.Drawing.Point(27, 282);
            this.btnBattleship.Name = "btnBattleship";
            this.btnBattleship.Size = new System.Drawing.Size(141, 35);
            this.btnBattleship.TabIndex = 7;
            this.btnBattleship.UseVisualStyleBackColor = false;
            this.btnBattleship.Click += new System.EventHandler(this.btnBattleship_Click);
            // 
            // btnCruiser
            // 
            this.btnCruiser.BackColor = System.Drawing.Color.Black;
            this.btnCruiser.BackgroundImage = global::Battleship_WIP.Properties.Resources.cruiser;
            this.btnCruiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCruiser.Location = new System.Drawing.Point(27, 217);
            this.btnCruiser.Name = "btnCruiser";
            this.btnCruiser.Size = new System.Drawing.Size(141, 35);
            this.btnCruiser.TabIndex = 6;
            this.btnCruiser.UseVisualStyleBackColor = false;
            this.btnCruiser.Click += new System.EventHandler(this.btnCruiser_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Black;
            this.btnSub.BackgroundImage = global::Battleship_WIP.Properties.Resources.submarine;
            this.btnSub.Location = new System.Drawing.Point(27, 154);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(141, 35);
            this.btnSub.TabIndex = 5;
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDestroyer
            // 
            this.btnDestroyer.BackColor = System.Drawing.Color.Black;
            this.btnDestroyer.BackgroundImage = global::Battleship_WIP.Properties.Resources.destroyer;
            this.btnDestroyer.Location = new System.Drawing.Point(27, 96);
            this.btnDestroyer.Name = "btnDestroyer";
            this.btnDestroyer.Size = new System.Drawing.Size(141, 36);
            this.btnDestroyer.TabIndex = 4;
            this.btnDestroyer.UseVisualStyleBackColor = false;
            this.btnDestroyer.Click += new System.EventHandler(this.btnDestroyer_Click);
            // 
            // p1ShipPanel
            // 
            this.p1ShipPanel.BackgroundImage = global::Battleship_WIP.Properties.Resources.emptyOcean1;
            this.p1ShipPanel.Controls.Add(this.ShipBoard1);
            this.p1ShipPanel.Location = new System.Drawing.Point(282, 96);
            this.p1ShipPanel.Name = "p1ShipPanel";
            this.p1ShipPanel.Size = new System.Drawing.Size(373, 364);
            this.p1ShipPanel.TabIndex = 3;
            // 
            // ShipBoard1
            // 
            this.ShipBoard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShipBoard1.BackColor = System.Drawing.Color.Transparent;
            this.ShipBoard1.ColumnCount = 10;
            this.ShipBoard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.ShipBoard1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ShipBoard1.Location = new System.Drawing.Point(31, 32);
            this.ShipBoard1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShipBoard1.Name = "ShipBoard1";
            this.ShipBoard1.RowCount = 10;
            this.ShipBoard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ShipBoard1.Size = new System.Drawing.Size(310, 310);
            this.ShipBoard1.TabIndex = 1;
            // 
            // btnRemoveCruiser
            // 
            this.btnRemoveCruiser.BackColor = System.Drawing.Color.Black;
            this.btnRemoveCruiser.BackgroundImage = global::Battleship_WIP.Properties.Resources.remove;
            this.btnRemoveCruiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveCruiser.Enabled = false;
            this.btnRemoveCruiser.Location = new System.Drawing.Point(196, 216);
            this.btnRemoveCruiser.Name = "btnRemoveCruiser";
            this.btnRemoveCruiser.Size = new System.Drawing.Size(38, 36);
            this.btnRemoveCruiser.TabIndex = 11;
            this.btnRemoveCruiser.UseVisualStyleBackColor = false;
            this.btnRemoveCruiser.Click += new System.EventHandler(this.btnRemoveCruiser_Click);
            // 
            // btnRemoveCarrier
            // 
            this.btnRemoveCarrier.BackColor = System.Drawing.Color.Black;
            this.btnRemoveCarrier.BackgroundImage = global::Battleship_WIP.Properties.Resources.remove;
            this.btnRemoveCarrier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveCarrier.Enabled = false;
            this.btnRemoveCarrier.Location = new System.Drawing.Point(196, 336);
            this.btnRemoveCarrier.Name = "btnRemoveCarrier";
            this.btnRemoveCarrier.Size = new System.Drawing.Size(38, 36);
            this.btnRemoveCarrier.TabIndex = 12;
            this.btnRemoveCarrier.UseVisualStyleBackColor = false;
            this.btnRemoveCarrier.Click += new System.EventHandler(this.btnRemoveCarrier_Click);
            // 
            // btnRemoveBattleship
            // 
            this.btnRemoveBattleship.BackColor = System.Drawing.Color.Black;
            this.btnRemoveBattleship.BackgroundImage = global::Battleship_WIP.Properties.Resources.remove;
            this.btnRemoveBattleship.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveBattleship.Enabled = false;
            this.btnRemoveBattleship.Location = new System.Drawing.Point(196, 273);
            this.btnRemoveBattleship.Name = "btnRemoveBattleship";
            this.btnRemoveBattleship.Size = new System.Drawing.Size(38, 36);
            this.btnRemoveBattleship.TabIndex = 13;
            this.btnRemoveBattleship.UseVisualStyleBackColor = false;
            this.btnRemoveBattleship.Click += new System.EventHandler(this.btnRemoveBattleship_Click);
            // 
            // btnRemoveDestroyer
            // 
            this.btnRemoveDestroyer.BackColor = System.Drawing.Color.Black;
            this.btnRemoveDestroyer.BackgroundImage = global::Battleship_WIP.Properties.Resources.remove;
            this.btnRemoveDestroyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveDestroyer.Enabled = false;
            this.btnRemoveDestroyer.Location = new System.Drawing.Point(196, 96);
            this.btnRemoveDestroyer.Name = "btnRemoveDestroyer";
            this.btnRemoveDestroyer.Size = new System.Drawing.Size(38, 36);
            this.btnRemoveDestroyer.TabIndex = 14;
            this.btnRemoveDestroyer.UseVisualStyleBackColor = false;
            this.btnRemoveDestroyer.Click += new System.EventHandler(this.btnRemoveDestroyer_Click);
            // 
            // btnRemoveSub
            // 
            this.btnRemoveSub.BackColor = System.Drawing.Color.Black;
            this.btnRemoveSub.BackgroundImage = global::Battleship_WIP.Properties.Resources.remove;
            this.btnRemoveSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveSub.Enabled = false;
            this.btnRemoveSub.Location = new System.Drawing.Point(196, 153);
            this.btnRemoveSub.Name = "btnRemoveSub";
            this.btnRemoveSub.Size = new System.Drawing.Size(38, 36);
            this.btnRemoveSub.TabIndex = 15;
            this.btnRemoveSub.UseVisualStyleBackColor = false;
            this.btnRemoveSub.Click += new System.EventHandler(this.btnRemoveSub_Click);
            // 
            // Player1Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Battleship_WIP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(727, 582);
            this.Controls.Add(this.btnRemoveSub);
            this.Controls.Add(this.btnRemoveDestroyer);
            this.Controls.Add(this.btnRemoveBattleship);
            this.Controls.Add(this.btnRemoveCarrier);
            this.Controls.Add(this.btnRemoveCruiser);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.rotateBtn);
            this.Controls.Add(this.btnCarrier);
            this.Controls.Add(this.btnBattleship);
            this.Controls.Add(this.btnCruiser);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnDestroyer);
            this.Controls.Add(this.p1ShipPanel);
            this.Name = "Player1Menu";
            this.Text = "Player1Menu";
            this.p1ShipPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public void AddButtonsPlayer1()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    RadioButton b = new RadioButton();
                    b.Appearance = System.Windows.Forms.Appearance.Button;
                    b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    b.Size = new System.Drawing.Size(28, 28);
                    b.MouseHover += new System.EventHandler(HoverHighlight);
                    b.MouseLeave += new System.EventHandler(UndoHighlight);
                    b.CheckedChanged += new System.EventHandler(PositionShip);
                    ShipBoard1.Controls.Add(b, i, j);


                    p1Buttons[i, j] = b;
                }
            }
        }

        #endregion

        private System.Windows.Forms.Panel p1ShipPanel;
        private System.Windows.Forms.TableLayoutPanel ShipBoard1;
        private Button btnDestroyer;
        private Button btnSub;
        private Button btnCruiser;
        private Button btnBattleship;
        private Button btnCarrier;
        private Button rotateBtn;
        private Button doneBtn;
        private Button btnRemoveCruiser;
        private Button btnRemoveCarrier;
        private Button btnRemoveBattleship;
        private Button btnRemoveDestroyer;
        private Button btnRemoveSub;
    }
}