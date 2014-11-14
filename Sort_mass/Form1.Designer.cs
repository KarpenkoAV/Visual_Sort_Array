namespace Sort_mass
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
            this.buttonRandom = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxIndicator = new System.Windows.Forms.GroupBox();
            this.groupBoxRandom = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFinish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.comboBoxMetod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxRandom.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(392, 21);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(71, 22);
            this.buttonRandom.TabIndex = 0;
            this.buttonRandom.Text = "Generate";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(215, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxIndicator
            // 
            this.groupBoxIndicator.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxIndicator.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIndicator.Name = "groupBoxIndicator";
            this.groupBoxIndicator.Size = new System.Drawing.Size(666, 135);
            this.groupBoxIndicator.TabIndex = 2;
            this.groupBoxIndicator.TabStop = false;
            this.groupBoxIndicator.Text = "Diagramm";
            // 
            // groupBoxRandom
            // 
            this.groupBoxRandom.Controls.Add(this.label4);
            this.groupBoxRandom.Controls.Add(this.textBoxDelay);
            this.groupBoxRandom.Controls.Add(this.label3);
            this.groupBoxRandom.Controls.Add(this.textBoxSize);
            this.groupBoxRandom.Controls.Add(this.label2);
            this.groupBoxRandom.Controls.Add(this.buttonRandom);
            this.groupBoxRandom.Controls.Add(this.textBoxFinish);
            this.groupBoxRandom.Controls.Add(this.label1);
            this.groupBoxRandom.Controls.Add(this.textBoxStart);
            this.groupBoxRandom.Location = new System.Drawing.Point(13, 154);
            this.groupBoxRandom.Name = "groupBoxRandom";
            this.groupBoxRandom.Size = new System.Drawing.Size(665, 57);
            this.groupBoxRandom.TabIndex = 3;
            this.groupBoxRandom.TabStop = false;
            this.groupBoxRandom.Text = "Random";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delay:";
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(593, 22);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(47, 20);
            this.textBoxDelay.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Size mass:";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(328, 22);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(47, 20);
            this.textBoxSize.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Finish Value:";
            // 
            // textBoxFinish
            // 
            this.textBoxFinish.Location = new System.Drawing.Point(202, 22);
            this.textBoxFinish.Name = "textBoxFinish";
            this.textBoxFinish.Size = new System.Drawing.Size(47, 20);
            this.textBoxFinish.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Value:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(72, 22);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(45, 20);
            this.textBoxStart.TabIndex = 0;
            // 
            // comboBoxMetod
            // 
            this.comboBoxMetod.FormattingEnabled = true;
            this.comboBoxMetod.Items.AddRange(new object[] {
            "Bubble",
            "QuickSort",
            "InsertSort"});
            this.comboBoxMetod.Location = new System.Drawing.Point(65, 216);
            this.comboBoxMetod.Name = "comboBoxMetod";
            this.comboBoxMetod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMetod.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Metod:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 312);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMetod);
            this.Controls.Add(this.groupBoxRandom);
            this.Controls.Add(this.groupBoxIndicator);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxRandom.ResumeLayout(false);
            this.groupBoxRandom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxIndicator;
        private System.Windows.Forms.GroupBox groupBoxRandom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.ComboBox comboBoxMetod;
        private System.Windows.Forms.Label label5;

    }
}

