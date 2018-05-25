namespace AutoDeployWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(30, 50);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(56, 13);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "user name";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(99, 50);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(139, 20);
            this.txtlogin.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtlogin;
    }
}

