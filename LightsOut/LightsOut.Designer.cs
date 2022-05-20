
namespace LightsOut
{
    partial class LightsOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightsOut));
            this.cmbGridSize = new System.Windows.Forms.ComboBox();
            this.lblGridSize = new MaterialSkin.Controls.MaterialLabel();
            this.lblMoveCount = new MaterialSkin.Controls.MaterialLabel();
            this.lblRules = new MaterialSkin.Controls.MaterialLabel();
            this.btnReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGridSize
            // 
            this.cmbGridSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGridSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGridSize.FormattingEnabled = true;
            this.cmbGridSize.Items.AddRange(new object[] {
            "5 x 5",
            "6 x 6",
            "7 x 7",
            "8 x 8",
            "9 x 9",
            "10 x 10"});
            this.cmbGridSize.Location = new System.Drawing.Point(597, 508);
            this.cmbGridSize.Name = "cmbGridSize";
            this.cmbGridSize.Size = new System.Drawing.Size(241, 23);
            this.cmbGridSize.TabIndex = 2;
            // 
            // lblGridSize
            // 
            this.lblGridSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGridSize.AutoSize = true;
            this.lblGridSize.Depth = 0;
            this.lblGridSize.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGridSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGridSize.Location = new System.Drawing.Point(519, 508);
            this.lblGridSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(72, 19);
            this.lblGridSize.TabIndex = 3;
            this.lblGridSize.Text = "Grid Size:";
            // 
            // lblMoveCount
            // 
            this.lblMoveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoveCount.AutoSize = true;
            this.lblMoveCount.Depth = 0;
            this.lblMoveCount.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMoveCount.Location = new System.Drawing.Point(693, 486);
            this.lblMoveCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMoveCount.Name = "lblMoveCount";
            this.lblMoveCount.Size = new System.Drawing.Size(145, 19);
            this.lblMoveCount.TabIndex = 5;
            this.lblMoveCount.Text = "Number of Moves: 0";
            // 
            // lblRules
            // 
            this.lblRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRules.Depth = 0;
            this.lblRules.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRules.Location = new System.Drawing.Point(519, 242);
            this.lblRules.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(319, 163);
            this.lblRules.TabIndex = 7;
            this.lblRules.Text = "Welcome to Light\'s Out!\r\nThe goal of the game is to turn off all of the lights. \r" +
    "\nWhen a light is pressed, this light and the four adjacent lights are toggled. \r" +
    "\nGood luck!";
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Depth = 0;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReset.Icon = null;
            this.btnReset.Location = new System.Drawing.Point(0, 564);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = true;
            this.btnReset.Size = new System.Drawing.Size(850, 36);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LightsOut.Properties.Resources.light;
            this.pictureBox1.Location = new System.Drawing.Point(519, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LightsOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblMoveCount);
            this.Controls.Add(this.lblGridSize);
            this.Controls.Add(this.cmbGridSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LightsOut";
            this.Text = "Lights Out";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbGridSize;
        private MaterialSkin.Controls.MaterialLabel lblGridSize;
        private MaterialSkin.Controls.MaterialLabel lblMoveCount;
        private MaterialSkin.Controls.MaterialLabel lblRules;
        private MaterialSkin.Controls.MaterialRaisedButton btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

