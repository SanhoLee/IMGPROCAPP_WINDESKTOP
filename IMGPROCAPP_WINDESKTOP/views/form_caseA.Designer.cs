namespace IMGPROCAPP_WINDESKTOP
{
    partial class form_caseA
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.pic_org = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cutImg = new System.Windows.Forms.Button();
            this.btn_maskImg = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_org)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(532, 598);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(164, 39);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(532, 109);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(164, 40);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // pic_org
            // 
            this.pic_org.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_org.Location = new System.Drawing.Point(38, 65);
            this.pic_org.Name = "pic_org";
            this.pic_org.Size = new System.Drawing.Size(474, 271);
            this.pic_org.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_org.TabIndex = 7;
            this.pic_org.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(38, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "ORIGINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "RESULT";
            // 
            // btn_cutImg
            // 
            this.btn_cutImg.Location = new System.Drawing.Point(532, 249);
            this.btn_cutImg.Name = "btn_cutImg";
            this.btn_cutImg.Size = new System.Drawing.Size(164, 40);
            this.btn_cutImg.TabIndex = 11;
            this.btn_cutImg.Text = "Cut with 2P.";
            this.btn_cutImg.UseVisualStyleBackColor = true;
            this.btn_cutImg.Click += new System.EventHandler(this.btn_cutImg_Click);
            // 
            // btn_maskImg
            // 
            this.btn_maskImg.Location = new System.Drawing.Point(532, 295);
            this.btn_maskImg.Name = "btn_maskImg";
            this.btn_maskImg.Size = new System.Drawing.Size(164, 40);
            this.btn_maskImg.TabIndex = 12;
            this.btn_maskImg.Text = "Mask with 4P.";
            this.btn_maskImg.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(532, 65);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(164, 40);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(532, 554);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(164, 39);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save Pixels";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Set Parameters";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Run Processing";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 40);
            this.button3.TabIndex = 17;
            this.button3.Text = "Clear Processing";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // form_caseA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 675);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_maskImg);
            this.Controls.Add(this.btn_cutImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_org);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_close);
            this.Name = "form_caseA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_caseA";
            this.Load += new System.EventHandler(this.form_caseA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_org)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.PictureBox pic_org;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cutImg;
        private System.Windows.Forms.Button btn_maskImg;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}