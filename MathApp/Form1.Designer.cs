
namespace MathApp
{
    partial class mathsApp
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
            this.firstNumberTextbox = new System.Windows.Forms.TextBox();
            this.secondNumberTextbox = new System.Windows.Forms.TextBox();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.firstNumberLable = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.secondNumberLable = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.subButton = new System.Windows.Forms.Button();
            this.diviteButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberTextbox
            // 
            this.firstNumberTextbox.Font = new System.Drawing.Font("Palatino Linotype", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberTextbox.Location = new System.Drawing.Point(320, 83);
            this.firstNumberTextbox.Multiline = true;
            this.firstNumberTextbox.Name = "firstNumberTextbox";
            this.firstNumberTextbox.Size = new System.Drawing.Size(513, 110);
            this.firstNumberTextbox.TabIndex = 0;
            this.firstNumberTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // secondNumberTextbox
            // 
            this.secondNumberTextbox.Font = new System.Drawing.Font("Palatino Linotype", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumberTextbox.Location = new System.Drawing.Point(320, 319);
            this.secondNumberTextbox.Multiline = true;
            this.secondNumberTextbox.Name = "secondNumberTextbox";
            this.secondNumberTextbox.Size = new System.Drawing.Size(513, 110);
            this.secondNumberTextbox.TabIndex = 1;
            this.secondNumberTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultTextbox
            // 
            this.resultTextbox.Font = new System.Drawing.Font("Palatino Linotype", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextbox.Location = new System.Drawing.Point(320, 536);
            this.resultTextbox.Multiline = true;
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.Size = new System.Drawing.Size(513, 110);
            this.resultTextbox.TabIndex = 2;
            this.resultTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // firstNumberLable
            // 
            this.firstNumberLable.AutoSize = true;
            this.firstNumberLable.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberLable.Location = new System.Drawing.Point(468, 31);
            this.firstNumberLable.Name = "firstNumberLable";
            this.firstNumberLable.Size = new System.Drawing.Size(185, 37);
            this.firstNumberLable.TabIndex = 3;
            this.firstNumberLable.Text = "First Number";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Black;
            this.addButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(1182, 83);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(336, 110);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // secondNumberLable
            // 
            this.secondNumberLable.AutoSize = true;
            this.secondNumberLable.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumberLable.Location = new System.Drawing.Point(468, 235);
            this.secondNumberLable.Name = "secondNumberLable";
            this.secondNumberLable.Size = new System.Drawing.Size(222, 37);
            this.secondNumberLable.TabIndex = 11;
            this.secondNumberLable.Text = "Second Number";
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLable.Location = new System.Drawing.Point(468, 464);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(97, 37);
            this.resultLable.TabIndex = 12;
            this.resultLable.Text = "Result";
            this.resultLable.Click += new System.EventHandler(this.label5_Click);
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.Color.DarkGreen;
            this.subButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subButton.Location = new System.Drawing.Point(1182, 319);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(336, 110);
            this.subButton.TabIndex = 13;
            this.subButton.Text = "Sub";
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // diviteButton
            // 
            this.diviteButton.BackColor = System.Drawing.Color.Fuchsia;
            this.diviteButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diviteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.diviteButton.Location = new System.Drawing.Point(1182, 536);
            this.diviteButton.Name = "diviteButton";
            this.diviteButton.Size = new System.Drawing.Size(336, 110);
            this.diviteButton.TabIndex = 14;
            this.diviteButton.Text = "Divide";
            this.diviteButton.UseVisualStyleBackColor = false;
            this.diviteButton.Click += new System.EventHandler(this.diviteButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.Teal;
            this.multiplyButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.multiplyButton.Location = new System.Drawing.Point(1182, 714);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(336, 110);
            this.multiplyButton.TabIndex = 15;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Red;
            this.clearButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.Location = new System.Drawing.Point(320, 714);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(336, 110);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // mathsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(2100, 837);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.diviteButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.secondNumberLable);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.firstNumberLable);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.secondNumberTextbox);
            this.Controls.Add(this.firstNumberTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "mathsApp";
            this.Text = "MathsApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumberTextbox;
        private System.Windows.Forms.TextBox secondNumberTextbox;
        private System.Windows.Forms.TextBox resultTextbox;
        private System.Windows.Forms.Label firstNumberLable;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label secondNumberLable;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button diviteButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button clearButton;
    }
}

