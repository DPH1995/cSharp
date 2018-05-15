namespace ProjectSimulator
{
    partial class MainMenu
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
            this.randomBattleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomBattleButton
            // 
            this.randomBattleButton.Location = new System.Drawing.Point(12, 12);
            this.randomBattleButton.Name = "randomBattleButton";
            this.randomBattleButton.Size = new System.Drawing.Size(214, 23);
            this.randomBattleButton.TabIndex = 0;
            this.randomBattleButton.Text = "Random battle";
            this.randomBattleButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 427);
            this.Controls.Add(this.randomBattleButton);
            this.Name = "MainMenu";
            this.RightToLeftLayout = true;
            this.Text = "Pokemon Simulator V1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randomBattleButton;
    }
}