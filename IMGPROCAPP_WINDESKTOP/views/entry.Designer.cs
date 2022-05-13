namespace IMGPROCAPP_WINDESKTOP
{
    partial class frm_entry
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
            this.btn_CASE_A = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_CASE_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CASE_A
            // 
            this.btn_CASE_A.Location = new System.Drawing.Point(82, 35);
            this.btn_CASE_A.Name = "btn_CASE_A";
            this.btn_CASE_A.Size = new System.Drawing.Size(75, 23);
            this.btn_CASE_A.TabIndex = 0;
            this.btn_CASE_A.Text = "CASE A";
            this.btn_CASE_A.UseVisualStyleBackColor = true;
            this.btn_CASE_A.Click += new System.EventHandler(this.btn_CASE_A_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(121, 88);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_CASE_B
            // 
            this.btn_CASE_B.Location = new System.Drawing.Point(163, 35);
            this.btn_CASE_B.Name = "btn_CASE_B";
            this.btn_CASE_B.Size = new System.Drawing.Size(75, 23);
            this.btn_CASE_B.TabIndex = 3;
            this.btn_CASE_B.Text = "CASE B";
            this.btn_CASE_B.UseVisualStyleBackColor = true;
            this.btn_CASE_B.Click += new System.EventHandler(this.btn_CASE_B_Click);
            // 
            // frm_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 144);
            this.Controls.Add(this.btn_CASE_B);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_CASE_A);
            this.Name = "frm_entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "entry";
            this.Load += new System.EventHandler(this.frm_entry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CASE_A;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_CASE_B;
    }
}

