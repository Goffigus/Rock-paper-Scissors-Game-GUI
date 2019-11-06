namespace Rock_paper_Scissors_Game_GUI
{
    partial class Form1
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
            this.Round1 = new System.Windows.Forms.CheckBox();
            this.Round3 = new System.Windows.Forms.CheckBox();
            this.Round5 = new System.Windows.Forms.CheckBox();
            this.Round7 = new System.Windows.Forms.CheckBox();
            this.Round9 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Players1 = new System.Windows.Forms.CheckBox();
            this.Players2 = new System.Windows.Forms.CheckBox();
            this.Players3 = new System.Windows.Forms.CheckBox();
            this.Players4 = new System.Windows.Forms.CheckBox();
            this.Players5 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Round1
            // 
            this.Round1.AutoSize = true;
            this.Round1.Location = new System.Drawing.Point(12, 38);
            this.Round1.Name = "Round1";
            this.Round1.Size = new System.Drawing.Size(67, 17);
            this.Round1.TabIndex = 0;
            this.Round1.Text = "1 Round";
            this.Round1.UseVisualStyleBackColor = true;
            this.Round1.Click += new System.EventHandler(this.Round1_CheckedChanged);
            // 
            // Round3
            // 
            this.Round3.AutoSize = true;
            this.Round3.Location = new System.Drawing.Point(11, 61);
            this.Round3.Name = "Round3";
            this.Round3.Size = new System.Drawing.Size(68, 17);
            this.Round3.TabIndex = 1;
            this.Round3.Text = "Best of 3";
            this.Round3.UseVisualStyleBackColor = true;
            this.Round3.Click += new System.EventHandler(this.Round3_CheckedChanged);
            // 
            // Round5
            // 
            this.Round5.AutoSize = true;
            this.Round5.Location = new System.Drawing.Point(11, 84);
            this.Round5.Name = "Round5";
            this.Round5.Size = new System.Drawing.Size(68, 17);
            this.Round5.TabIndex = 2;
            this.Round5.Text = "Best of 5";
            this.Round5.UseVisualStyleBackColor = true;
            this.Round5.Click += new System.EventHandler(this.Round5_CheckedChanged);
            // 
            // Round7
            // 
            this.Round7.AutoSize = true;
            this.Round7.Location = new System.Drawing.Point(11, 107);
            this.Round7.Name = "Round7";
            this.Round7.Size = new System.Drawing.Size(68, 17);
            this.Round7.TabIndex = 3;
            this.Round7.Text = "Best of 7";
            this.Round7.UseVisualStyleBackColor = true;
            this.Round7.Click += new System.EventHandler(this.Round7_CheckedChanged);
            // 
            // Round9
            // 
            this.Round9.AutoSize = true;
            this.Round9.Location = new System.Drawing.Point(11, 130);
            this.Round9.Name = "Round9";
            this.Round9.Size = new System.Drawing.Size(68, 17);
            this.Round9.TabIndex = 4;
            this.Round9.Text = "Best of 9";
            this.Round9.UseVisualStyleBackColor = true;
            this.Round9.Click += new System.EventHandler(this.Round9_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Round Limit";
            // 
            // Players1
            // 
            this.Players1.AutoSize = true;
            this.Players1.Location = new System.Drawing.Point(196, 38);
            this.Players1.Name = "Players1";
            this.Players1.Size = new System.Drawing.Size(64, 17);
            this.Players1.TabIndex = 6;
            this.Players1.Text = "1 Player";
            this.Players1.UseVisualStyleBackColor = true;
            this.Players1.Click += new System.EventHandler(this.Players1_CheckedChanged);
            // 
            // Players2
            // 
            this.Players2.AutoSize = true;
            this.Players2.Location = new System.Drawing.Point(196, 61);
            this.Players2.Name = "Players2";
            this.Players2.Size = new System.Drawing.Size(69, 17);
            this.Players2.TabIndex = 7;
            this.Players2.Text = "2 Players";
            this.Players2.UseVisualStyleBackColor = true;
            this.Players2.Click += new System.EventHandler(this.Players2_CheckedChanged);
            // 
            // Players3
            // 
            this.Players3.AutoSize = true;
            this.Players3.Location = new System.Drawing.Point(196, 84);
            this.Players3.Name = "Players3";
            this.Players3.Size = new System.Drawing.Size(69, 17);
            this.Players3.TabIndex = 8;
            this.Players3.Text = "3 Players";
            this.Players3.UseVisualStyleBackColor = true;
            this.Players3.Click += new System.EventHandler(this.Players3_CheckedChanged);
            // 
            // Players4
            // 
            this.Players4.AutoSize = true;
            this.Players4.Location = new System.Drawing.Point(196, 107);
            this.Players4.Name = "Players4";
            this.Players4.Size = new System.Drawing.Size(69, 17);
            this.Players4.TabIndex = 9;
            this.Players4.Text = "4 Players";
            this.Players4.UseVisualStyleBackColor = true;
            this.Players4.Click += new System.EventHandler(this.Players4_CheckedChanged);
            // 
            // Players5
            // 
            this.Players5.AutoSize = true;
            this.Players5.Location = new System.Drawing.Point(196, 130);
            this.Players5.Name = "Players5";
            this.Players5.Size = new System.Drawing.Size(69, 17);
            this.Players5.TabIndex = 10;
            this.Players5.Text = "5 Players";
            this.Players5.UseVisualStyleBackColor = true;
            this.Players5.Click += new System.EventHandler(this.Players5_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Amount of Players";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 144);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.AutoSize = true;
            this.ErrorBox.Location = new System.Drawing.Point(470, 159);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(29, 13);
            this.ErrorBox.TabIndex = 13;
            this.ErrorBox.Text = "Error";
            this.ErrorBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 251);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Players5);
            this.Controls.Add(this.Players4);
            this.Controls.Add(this.Players3);
            this.Controls.Add(this.Players2);
            this.Controls.Add(this.Players1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Round9);
            this.Controls.Add(this.Round7);
            this.Controls.Add(this.Round5);
            this.Controls.Add(this.Round3);
            this.Controls.Add(this.Round1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Round1;
        private System.Windows.Forms.CheckBox Round3;
        private System.Windows.Forms.CheckBox Round5;
        private System.Windows.Forms.CheckBox Round7;
        private System.Windows.Forms.CheckBox Round9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Players1;
        private System.Windows.Forms.CheckBox Players2;
        private System.Windows.Forms.CheckBox Players3;
        private System.Windows.Forms.CheckBox Players4;
        private System.Windows.Forms.CheckBox Players5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ErrorBox;
    }
}

