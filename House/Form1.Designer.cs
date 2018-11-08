namespace House
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
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.doorButton = new System.Windows.Forms.Button();
            this.locationSelectionBox = new System.Windows.Forms.ComboBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(552, 314);
            this.descriptionBox.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(12, 332);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go here:";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // doorButton
            // 
            this.doorButton.Location = new System.Drawing.Point(12, 415);
            this.doorButton.Name = "doorButton";
            this.doorButton.Size = new System.Drawing.Size(552, 23);
            this.doorButton.TabIndex = 2;
            this.doorButton.Text = "Go through the door";
            this.doorButton.UseVisualStyleBackColor = true;
            this.doorButton.Click += new System.EventHandler(this.doorButton_Click);
            // 
            // locationSelectionBox
            // 
            this.locationSelectionBox.FormattingEnabled = true;
            this.locationSelectionBox.Location = new System.Drawing.Point(122, 332);
            this.locationSelectionBox.Name = "locationSelectionBox";
            this.locationSelectionBox.Size = new System.Drawing.Size(442, 21);
            this.locationSelectionBox.TabIndex = 3;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(12, 361);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(552, 23);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(12, 390);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(552, 23);
            this.hideButton.TabIndex = 5;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.locationSelectionBox);
            this.Controls.Add(this.doorButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.descriptionBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button doorButton;
        private System.Windows.Forms.ComboBox locationSelectionBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button hideButton;
    }
}

