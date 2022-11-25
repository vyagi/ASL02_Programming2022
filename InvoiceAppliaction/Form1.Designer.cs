namespace InvoiceAppliaction
{
    partial class InvoiceAppForm
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
            this.readButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.categoryButton = new System.Windows.Forms.Button();
            this.monthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(12, 41);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(79, 23);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 12);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(776, 23);
            this.pathTextBox.TabIndex = 3;
            this.pathTextBox.Text = "C:\\Users\\Marcin\\Desktop\\Invoices.txt";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 70);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(776, 368);
            this.outputTextBox.TabIndex = 4;
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(97, 41);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(75, 23);
            this.categoryButton.TabIndex = 5;
            this.categoryButton.Text = "Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(178, 41);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(75, 23);
            this.monthButton.TabIndex = 6;
            this.monthButton.Text = "Month";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            // 
            // InvoiceAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.readButton);
            this.Name = "InvoiceAppForm";
            this.Text = "Invoicing Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button readButton;
        private TextBox pathTextBox;
        private TextBox outputTextBox;
        private Button categoryButton;
        private Button monthButton;
    }
}