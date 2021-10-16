namespace Jalousie
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
            this.closeButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.plasticRadioButton = new System.Windows.Forms.RadioButton();
            this.aluminumRadioButton = new System.Windows.Forms.RadioButton();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(144, 152);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(90, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(12, 190);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(222, 58);
            this.resultLabel.TabIndex = 17;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(15, 152);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(90, 23);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // plasticRadioButton
            // 
            this.plasticRadioButton.AutoSize = true;
            this.plasticRadioButton.Location = new System.Drawing.Point(15, 112);
            this.plasticRadioButton.Name = "plasticRadioButton";
            this.plasticRadioButton.Size = new System.Drawing.Size(55, 17);
            this.plasticRadioButton.TabIndex = 15;
            this.plasticRadioButton.TabStop = true;
            this.plasticRadioButton.Text = "plastic";
            this.plasticRadioButton.UseVisualStyleBackColor = true;
            // 
            // aluminumRadioButton
            // 
            this.aluminumRadioButton.AutoSize = true;
            this.aluminumRadioButton.Location = new System.Drawing.Point(15, 89);
            this.aluminumRadioButton.Name = "aluminumRadioButton";
            this.aluminumRadioButton.Size = new System.Drawing.Size(69, 17);
            this.aluminumRadioButton.TabIndex = 14;
            this.aluminumRadioButton.TabStop = true;
            this.aluminumRadioButton.Text = "aluminum";
            this.aluminumRadioButton.UseVisualStyleBackColor = true;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(91, 47);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(143, 20);
            this.heightTextBox.TabIndex = 13;
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(91, 14);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(143, 20);
            this.widthTextBox.TabIndex = 12;
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            this.widthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Height (sm):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Width (sm): ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 267);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.plasticRadioButton);
            this.Controls.Add(this.aluminumRadioButton);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Jalousie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RadioButton plasticRadioButton;
        private System.Windows.Forms.RadioButton aluminumRadioButton;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

