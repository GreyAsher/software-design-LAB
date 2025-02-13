namespace lab2
{
    partial class Lab2Task2
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
            lblResult = new Label();
            txtInput = new TextBox();
            btnCalculateFactorial = new Button();
            btnCalculateSum = new Button();
            txtArrayInput = new TextBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Silver;
            lblResult.Location = new Point(236, 310);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(57, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "Answer";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(78, 114);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(145, 27);
            txtInput.TabIndex = 4;
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(77, 203);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(146, 40);
            btnCalculateFactorial.TabIndex = 3;
            btnCalculateFactorial.Text = "Calculate Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(295, 203);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(146, 40);
            btnCalculateSum.TabIndex = 6;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(295, 114);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(146, 27);
            txtArrayInput.TabIndex = 7;
            // 
            // Lab2Task2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(btnCalculateFactorial);
            Name = "Lab2Task2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtInput;
        private Button btnCalculateFactorial;
        private Button btnCalculateSum;
        private TextBox txtArrayInput;
    }
}