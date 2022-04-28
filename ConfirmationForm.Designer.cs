namespace Princess_Connect_Unit_Viewer
{
    partial class confirmationForm
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.txtLabel = new System.Windows.Forms.Label();
            this.sapwTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(69, 51);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "Log In";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Location = new System.Drawing.Point(10, 9);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(198, 13);
            this.txtLabel.TabIndex = 1;
            this.txtLabel.Text = "Please enter the SA Database password";
            // 
            // sapwTB
            // 
            this.sapwTB.Location = new System.Drawing.Point(12, 25);
            this.sapwTB.Name = "sapwTB";
            this.sapwTB.Size = new System.Drawing.Size(196, 20);
            this.sapwTB.TabIndex = 2;
            this.sapwTB.UseSystemPasswordChar = true;
            // 
            // confirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 78);
            this.Controls.Add(this.sapwTB);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.btn_Confirm);
            this.Name = "confirmationForm";
            this.Text = "Database Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.TextBox sapwTB;
    }
}