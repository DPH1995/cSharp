namespace WWTBAM
{
    partial class GameStartedForm
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
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.answerA = new System.Windows.Forms.Button();
            this.answerB = new System.Windows.Forms.Button();
            this.answerC = new System.Windows.Forms.Button();
            this.answerD = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answersLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLabel.Location = new System.Drawing.Point(25, 9);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(203, 29);
            this.questionNumberLabel.TabIndex = 0;
            this.questionNumberLabel.Text = "Question Number";
            // 
            // answerA
            // 
            this.answerA.Location = new System.Drawing.Point(47, 28);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(75, 23);
            this.answerA.TabIndex = 1;
            this.answerA.Text = "A";
            this.answerA.UseVisualStyleBackColor = true;
            // 
            // answerB
            // 
            this.answerB.Location = new System.Drawing.Point(160, 28);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(75, 23);
            this.answerB.TabIndex = 2;
            this.answerB.Text = "B";
            this.answerB.UseVisualStyleBackColor = true;
            this.answerB.Click += new System.EventHandler(this.button2_Click);
            // 
            // answerC
            // 
            this.answerC.Location = new System.Drawing.Point(47, 80);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(75, 23);
            this.answerC.TabIndex = 3;
            this.answerC.Text = "C";
            this.answerC.UseVisualStyleBackColor = true;
            // 
            // answerD
            // 
            this.answerD.Location = new System.Drawing.Point(160, 80);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(75, 23);
            this.answerD.TabIndex = 4;
            this.answerD.Text = "D";
            this.answerD.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(25, 55);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(110, 29);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "Question";
            // 
            // answersLabel
            // 
            this.answersLabel.AutoSize = true;
            this.answersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answersLabel.Location = new System.Drawing.Point(25, 129);
            this.answersLabel.Name = "answersLabel";
            this.answersLabel.Size = new System.Drawing.Size(105, 29);
            this.answersLabel.TabIndex = 6;
            this.answersLabel.Text = "Answers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.answerA);
            this.groupBox1.Controls.Add(this.answerB);
            this.groupBox1.Controls.Add(this.answerD);
            this.groupBox1.Controls.Add(this.answerC);
            this.groupBox1.Location = new System.Drawing.Point(87, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GameStartedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.answersLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Name = "GameStartedForm";
            this.Text = "GameStartedForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Button answerA;
        private System.Windows.Forms.Button answerB;
        private System.Windows.Forms.Button answerC;
        private System.Windows.Forms.Button answerD;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answersLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}