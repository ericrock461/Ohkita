namespace Ohkita
{
    partial class Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ohkitaLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.instructButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ohkitaLabel
            // 
            this.ohkitaLabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohkitaLabel.Location = new System.Drawing.Point(272, 77);
            this.ohkitaLabel.Name = "ohkitaLabel";
            this.ohkitaLabel.Size = new System.Drawing.Size(264, 162);
            this.ohkitaLabel.TabIndex = 0;
            this.ohkitaLabel.Text = "Ōkita\r\n大北";
            this.ohkitaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playButton.Location = new System.Drawing.Point(313, 253);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(177, 47);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // instructButton
            // 
            this.instructButton.FlatAppearance.BorderSize = 0;
            this.instructButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.instructButton.Location = new System.Drawing.Point(313, 296);
            this.instructButton.Name = "instructButton";
            this.instructButton.Size = new System.Drawing.Size(177, 35);
            this.instructButton.TabIndex = 2;
            this.instructButton.Text = "Instructions";
            this.instructButton.UseVisualStyleBackColor = true;
            this.instructButton.Click += new System.EventHandler(this.instructButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.Location = new System.Drawing.Point(313, 337);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.instructButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.ohkitaLabel);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(799, 451);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ohkitaLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button instructButton;
        private System.Windows.Forms.Button exitButton;
    }
}
