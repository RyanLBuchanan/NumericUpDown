
namespace NumericUpDownTest
{
    partial class InterestCalculatorForm
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
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.principalLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.yearlyAccountBalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // principalTextBox
            // 
            this.principalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalTextBox.Location = new System.Drawing.Point(232, 45);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(264, 26);
            this.principalTextBox.TabIndex = 0;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestTextBox.Location = new System.Drawing.Point(232, 77);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(264, 26);
            this.interestTextBox.TabIndex = 1;
            // 
            // yearUpDown
            // 
            this.yearUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearUpDown.Location = new System.Drawing.Point(232, 110);
            this.yearUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yearUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.ReadOnly = true;
            this.yearUpDown.Size = new System.Drawing.Size(264, 26);
            this.yearUpDown.TabIndex = 2;
            this.yearUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.Location = new System.Drawing.Point(141, 219);
            this.displayTextBox.MaximumSize = new System.Drawing.Size(500, 500);
            this.displayTextBox.MinimumSize = new System.Drawing.Size(264, 200);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(500, 200);
            this.displayTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(555, 45);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(163, 26);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalLabel.Location = new System.Drawing.Point(137, 45);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(72, 20);
            this.principalLabel.TabIndex = 5;
            this.principalLabel.Text = "Principal:";
            this.principalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestLabel.Location = new System.Drawing.Point(141, 80);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(68, 20);
            this.interestLabel.TabIndex = 6;
            this.interestLabel.Text = "Interest:";
            this.interestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsLabel.Location = new System.Drawing.Point(154, 112);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(55, 20);
            this.yearsLabel.TabIndex = 7;
            this.yearsLabel.Text = "Years:";
            this.yearsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearlyAccountBalanceLabel
            // 
            this.yearlyAccountBalanceLabel.AutoSize = true;
            this.yearlyAccountBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyAccountBalanceLabel.Location = new System.Drawing.Point(137, 196);
            this.yearlyAccountBalanceLabel.Name = "yearlyAccountBalanceLabel";
            this.yearlyAccountBalanceLabel.Size = new System.Drawing.Size(178, 20);
            this.yearlyAccountBalanceLabel.TabIndex = 8;
            this.yearlyAccountBalanceLabel.Text = "Yearly account balance:";
            this.yearlyAccountBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InterestCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearlyAccountBalanceLabel);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.principalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.principalTextBox);
            this.Name = "InterestCalculatorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label yearlyAccountBalanceLabel;
    }
}

