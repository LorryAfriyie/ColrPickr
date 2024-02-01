namespace ColrPickr
{
    partial class frmApp
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.grpColorBox = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.grpColorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRed.Location = new System.Drawing.Point(6, 19);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(92, 38);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGreen.Location = new System.Drawing.Point(104, 19);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(93, 38);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBlue.Location = new System.Drawing.Point(203, 19);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(95, 38);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // grpColorBox
            // 
            this.grpColorBox.Controls.Add(this.btnYellow);
            this.grpColorBox.Controls.Add(this.btnPurple);
            this.grpColorBox.Controls.Add(this.btnRed);
            this.grpColorBox.Controls.Add(this.btnBlue);
            this.grpColorBox.Controls.Add(this.btnGreen);
            this.grpColorBox.Location = new System.Drawing.Point(12, 168);
            this.grpColorBox.Name = "grpColorBox";
            this.grpColorBox.Size = new System.Drawing.Size(304, 270);
            this.grpColorBox.TabIndex = 3;
            this.grpColorBox.TabStop = false;
            this.grpColorBox.Text = "Colors";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(61, 45);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(190, 73);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color";
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurple.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPurple.Location = new System.Drawing.Point(7, 64);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(91, 35);
            this.btnPurple.TabIndex = 3;
            this.btnPurple.Text = "Purple";
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(104, 64);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(93, 35);
            this.btnYellow.TabIndex = 4;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.grpColorBox);
            this.Name = "frmApp";
            this.Text = "ColrPickr";
            this.grpColorBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.GroupBox grpColorBox;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnYellow;
    }
}

