namespace CalculatorUI
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
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.MultButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.AccessibleDescription = "First Number";
            this.FirstNumber.AccessibleName = "FirstNumber";
            this.FirstNumber.Location = new System.Drawing.Point(147, 53);
            this.FirstNumber.Multiline = true;
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(97, 20);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.Text = "FirstNumber";
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(147, 93);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(97, 20);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.Text = "SecondNumber";
            // 
            // Result
            // 
            this.Result.AccessibleName = "ResultButton";
            this.Result.Location = new System.Drawing.Point(147, 131);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(97, 20);
            this.Result.TabIndex = 2;
            this.Result.Text = "Result";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(35, 53);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(51, 30);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.Location = new System.Drawing.Point(35, 89);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(51, 29);
            this.SubButton.TabIndex = 4;
            this.SubButton.Text = "Sub";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // MultButton
            // 
            this.MultButton.Location = new System.Drawing.Point(35, 124);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(51, 35);
            this.MultButton.TabIndex = 5;
            this.MultButton.Text = "Multiply";
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.Location = new System.Drawing.Point(35, 165);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(51, 35);
            this.DivButton.TabIndex = 6;
            this.DivButton.Text = "Div";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 264);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.MultButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button MultButton;
        private System.Windows.Forms.Button DivButton;
    }
}

