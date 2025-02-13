namespace lab2
{
    partial class Lab2Task31
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
            txtInput = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(76, 54);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(86, 133);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(101, 212);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(57, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "Answer";
            // 
            // Lab2Task31
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput);
            Name = "Lab2Task31";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCalculate;
        private Label lblResult;
    }
}