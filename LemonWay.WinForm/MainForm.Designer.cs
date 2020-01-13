namespace LemonWay.WinForm
{
    partial class MainForm
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
            this.ComputeFibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComputeFibonacci
            // 
            this.ComputeFibonacci.Location = new System.Drawing.Point(158, 115);
            this.ComputeFibonacci.Name = "ComputeFibonacci";
            this.ComputeFibonacci.Size = new System.Drawing.Size(152, 31);
            this.ComputeFibonacci.TabIndex = 0;
            this.ComputeFibonacci.Text = "Compute Fibonacci(10)";
            this.ComputeFibonacci.UseVisualStyleBackColor = true;
            this.ComputeFibonacci.Click += new System.EventHandler(this.ComputeFibonacci_ClickAsync);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 253);
            this.Controls.Add(this.ComputeFibonacci);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComputeFibonacci;
    }
}

