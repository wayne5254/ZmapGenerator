namespace ZmapGenerator
{
    partial class ResolutionForm
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResZ = new System.Windows.Forms.TextBox();
            this.textBoxResY = new System.Windows.Forms.TextBox();
            this.textBoxResX = new System.Windows.Forms.TextBox();
            this.comboBoxDepth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(131, 125);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(84, 21);
            this.buttonLoad.TabIndex = 25;
            this.buttonLoad.Text = "Load ZMap";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "bits / pixel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "units / pixel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "units / pixel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "units / pixel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "ZMap depth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "Z Resolution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Y Resolution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "X Resolution";
            // 
            // textBoxResZ
            // 
            this.textBoxResZ.Location = new System.Drawing.Point(75, 51);
            this.textBoxResZ.Name = "textBoxResZ";
            this.textBoxResZ.Size = new System.Drawing.Size(70, 22);
            this.textBoxResZ.TabIndex = 16;
            // 
            // textBoxResY
            // 
            this.textBoxResY.Location = new System.Drawing.Point(75, 27);
            this.textBoxResY.Name = "textBoxResY";
            this.textBoxResY.Size = new System.Drawing.Size(71, 22);
            this.textBoxResY.TabIndex = 15;
            // 
            // textBoxResX
            // 
            this.textBoxResX.Location = new System.Drawing.Point(75, 3);
            this.textBoxResX.Name = "textBoxResX";
            this.textBoxResX.Size = new System.Drawing.Size(71, 22);
            this.textBoxResX.TabIndex = 14;
            // 
            // comboBoxDepth
            // 
            this.comboBoxDepth.FormattingEnabled = true;
            this.comboBoxDepth.Items.AddRange(new object[] {
            "8",
            "16"});
            this.comboBoxDepth.Location = new System.Drawing.Point(75, 94);
            this.comboBoxDepth.Name = "comboBoxDepth";
            this.comboBoxDepth.Size = new System.Drawing.Size(71, 20);
            this.comboBoxDepth.TabIndex = 13;
            // 
            // ResolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 151);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResZ);
            this.Controls.Add(this.textBoxResY);
            this.Controls.Add(this.textBoxResX);
            this.Controls.Add(this.comboBoxDepth);
            this.Name = "ResolutionForm";
            this.Text = "ZMap resolution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResZ;
        private System.Windows.Forms.TextBox textBoxResY;
        private System.Windows.Forms.TextBox textBoxResX;
        private System.Windows.Forms.ComboBox comboBoxDepth;
    }
}