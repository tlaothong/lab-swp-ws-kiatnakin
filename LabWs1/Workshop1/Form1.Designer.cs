namespace Workshop1
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CallButton = new System.Windows.Forms.Button();
            this.CallSvcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(170, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(306, 26);
            this.NameTextBox.TabIndex = 1;
            // 
            // CallButton
            // 
            this.CallButton.AutoSize = true;
            this.CallButton.Location = new System.Drawing.Point(170, 102);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(75, 30);
            this.CallButton.TabIndex = 2;
            this.CallButton.Text = "Call WS";
            this.CallButton.UseVisualStyleBackColor = true;
            this.CallButton.Click += new System.EventHandler(this.CallButton_Click);
            // 
            // CallSvcButton
            // 
            this.CallSvcButton.AutoSize = true;
            this.CallSvcButton.Location = new System.Drawing.Point(170, 171);
            this.CallSvcButton.Name = "CallSvcButton";
            this.CallSvcButton.Size = new System.Drawing.Size(82, 30);
            this.CallSvcButton.TabIndex = 3;
            this.CallSvcButton.Text = "Call SVC";
            this.CallSvcButton.UseVisualStyleBackColor = true;
            this.CallSvcButton.Click += new System.EventHandler(this.CallSvcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 324);
            this.Controls.Add(this.CallSvcButton);
            this.Controls.Add(this.CallButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button CallButton;
        private System.Windows.Forms.Button CallSvcButton;
    }
}

