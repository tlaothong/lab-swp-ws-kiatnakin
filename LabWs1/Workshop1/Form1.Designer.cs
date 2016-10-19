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
            this.NumToTextButton = new System.Windows.Forms.Button();
            this.Add100Button = new System.Windows.Forms.Button();
            this.NumWcfButton = new System.Windows.Forms.Button();
            this.Add200Button = new System.Windows.Forms.Button();
            this.FaultButton = new System.Windows.Forms.Button();
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
            // NumToTextButton
            // 
            this.NumToTextButton.AutoSize = true;
            this.NumToTextButton.Location = new System.Drawing.Point(171, 238);
            this.NumToTextButton.Name = "NumToTextButton";
            this.NumToTextButton.Size = new System.Drawing.Size(108, 30);
            this.NumToTextButton.TabIndex = 4;
            this.NumToTextButton.Text = "Num To Text";
            this.NumToTextButton.UseVisualStyleBackColor = true;
            this.NumToTextButton.Click += new System.EventHandler(this.NumToTextButton_Click);
            // 
            // Add100Button
            // 
            this.Add100Button.AutoSize = true;
            this.Add100Button.Location = new System.Drawing.Point(378, 102);
            this.Add100Button.Name = "Add100Button";
            this.Add100Button.Size = new System.Drawing.Size(75, 30);
            this.Add100Button.TabIndex = 5;
            this.Add100Button.Text = "Add100";
            this.Add100Button.UseVisualStyleBackColor = true;
            this.Add100Button.Click += new System.EventHandler(this.Add100Button_Click);
            // 
            // NumWcfButton
            // 
            this.NumWcfButton.AutoSize = true;
            this.NumWcfButton.Location = new System.Drawing.Point(378, 171);
            this.NumWcfButton.Name = "NumWcfButton";
            this.NumWcfButton.Size = new System.Drawing.Size(92, 30);
            this.NumWcfButton.TabIndex = 6;
            this.NumWcfButton.Text = "Num WCF";
            this.NumWcfButton.UseVisualStyleBackColor = true;
            this.NumWcfButton.Click += new System.EventHandler(this.NumWcfButton_Click);
            // 
            // Add200Button
            // 
            this.Add200Button.AutoSize = true;
            this.Add200Button.Location = new System.Drawing.Point(378, 238);
            this.Add200Button.Name = "Add200Button";
            this.Add200Button.Size = new System.Drawing.Size(75, 30);
            this.Add200Button.TabIndex = 7;
            this.Add200Button.Text = "Add200";
            this.Add200Button.UseVisualStyleBackColor = true;
            this.Add200Button.Click += new System.EventHandler(this.Add200Button_Click);
            // 
            // FaultButton
            // 
            this.FaultButton.AutoSize = true;
            this.FaultButton.Location = new System.Drawing.Point(28, 171);
            this.FaultButton.Name = "FaultButton";
            this.FaultButton.Size = new System.Drawing.Size(75, 30);
            this.FaultButton.TabIndex = 8;
            this.FaultButton.Text = "Fault";
            this.FaultButton.UseVisualStyleBackColor = true;
            this.FaultButton.Click += new System.EventHandler(this.FaultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 324);
            this.Controls.Add(this.FaultButton);
            this.Controls.Add(this.Add200Button);
            this.Controls.Add(this.NumWcfButton);
            this.Controls.Add(this.Add100Button);
            this.Controls.Add(this.NumToTextButton);
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
        private System.Windows.Forms.Button NumToTextButton;
        private System.Windows.Forms.Button Add100Button;
        private System.Windows.Forms.Button NumWcfButton;
        private System.Windows.Forms.Button Add200Button;
        private System.Windows.Forms.Button FaultButton;
    }
}

