namespace lab2
{
	partial class Lab2Task1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculateFactorial = new Button();
            txtInput = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(75, 150);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(218, 40);
            btnCalculateFactorial.TabIndex = 0;
            btnCalculateFactorial.Text = "Solve";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(145, 68);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(72, 27);
            txtInput.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Silver;
            lblResult.Location = new Point(128, 254);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(57, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "Answer";
            // 
            // Lab2Task1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 450);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(btnCalculateFactorial);
            Name = "Lab2Task1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateFactorial;
        private TextBox txtInput;
        private Label lblResult;
    }
}
