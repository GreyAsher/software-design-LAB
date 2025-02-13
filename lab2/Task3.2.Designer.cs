namespace lab2
{
    partial class Lab2Task32
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
            btnCalculate = new Button();
            txtExponent = new TextBox();
            txtBase = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(132, 182);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(116, 130);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(125, 27);
            txtExponent.TabIndex = 1;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(116, 76);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(125, 27);
            txtBase.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(144, 260);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result";
            // 
            // Lab2Task32
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 450);
            Controls.Add(lblResult);
            Controls.Add(txtBase);
            Controls.Add(txtExponent);
            Controls.Add(btnCalculate);
            Name = "Lab2Task32";
            Text = "Task3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtExponent;
        private TextBox txtBase;
        private Label lblResult;
    }
}