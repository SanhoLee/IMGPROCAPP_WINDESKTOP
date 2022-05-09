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
            this.pic_rst = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cutImg = new System.Windows.Forms.Button();
            this.btn_maskImg = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_set_Params = new System.Windows.Forms.Button();
            this.btn_run_proc = new System.Windows.Forms.Button();
            this.btn_clr_proc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_org)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rst)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(760, 897);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(234, 58);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(760, 164);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(234, 60);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // pic_org
            // 
            this.pic_org.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_org.Location = new System.Drawing.Point(54, 98);
            this.pic_org.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_org.Name = "pic_org";
            this.pic_org.Size = new System.Drawing.Size(676, 406);
            this.pic_org.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_org.TabIndex = 7;
            this.pic_org.TabStop = false;
            // 
            // pic_rst
            // 
            this.pic_rst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_rst.Location = new System.Drawing.Point(54, 550);
            this.pic_rst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_rst.Name = "pic_rst";
            this.pic_rst.Size = new System.Drawing.Size(676, 406);
            this.pic_rst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rst.TabIndex = 8;
            this.pic_rst.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "ORIGINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "RESULT";
            // 
            // btn_cutImg
            // 
            this.btn_cutImg.Location = new System.Drawing.Point(760, 374);
            this.btn_cutImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cutImg.Name = "btn_cutImg";
            this.btn_cutImg.Size = new System.Drawing.Size(234, 60);
            this.btn_cutImg.TabIndex = 11;
            this.btn_cutImg.Text = "Cut with 2P.";
            this.btn_cutImg.UseVisualStyleBackColor = true;
            this.btn_cutImg.Click += new System.EventHandler(this.btn_cutImg_Click);
            // 
            // btn_maskImg
            // 
            this.btn_maskImg.Location = new System.Drawing.Point(760, 442);
            this.btn_maskImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_maskImg.Name = "btn_maskImg";
            this.btn_maskImg.Size = new System.Drawing.Size(234, 60);
            this.btn_maskImg.TabIndex = 12;
            this.btn_maskImg.Text = "Mask with 4P.";
            this.btn_maskImg.UseVisualStyleBackColor = true;
            this.btn_maskImg.Click += new System.EventHandler(this.btn_maskImg_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(760, 98);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(234, 60);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(760, 831);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(234, 58);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save Pixels";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_set_Params
            // 
            this.btn_set_Params.Location = new System.Drawing.Point(760, 620);
            this.btn_set_Params.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_set_Params.Name = "btn_set_Params";
            this.btn_set_Params.Size = new System.Drawing.Size(234, 60);
            this.btn_set_Params.TabIndex = 15;
            this.btn_set_Params.Text = "Set Parameters";
            this.btn_set_Params.UseVisualStyleBackColor = true;
            this.btn_set_Params.Click += new System.EventHandler(this.btn_set_Params_Click);
            // 
            // btn_run_proc
            // 
            this.btn_run_proc.Location = new System.Drawing.Point(760, 688);
            this.btn_run_proc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_run_proc.Name = "btn_run_proc";
            this.btn_run_proc.Size = new System.Drawing.Size(234, 60);
            this.btn_run_proc.TabIndex = 16;
            this.btn_run_proc.Text = "Run Processing";
            this.btn_run_proc.UseVisualStyleBackColor = true;
            this.btn_run_proc.Click += new System.EventHandler(this.btn_run_proc_Click);
            // 
            // btn_clr_proc
            // 
            this.btn_clr_proc.Location = new System.Drawing.Point(760, 550);
            this.btn_clr_proc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clr_proc.Name = "btn_clr_proc";
            this.btn_clr_proc.Size = new System.Drawing.Size(234, 60);
            this.btn_clr_proc.TabIndex = 17;
            this.btn_clr_proc.Text = "Clear Processing";
            this.btn_clr_proc.UseVisualStyleBackColor = true;
            this.btn_clr_proc.Click += new System.EventHandler(this.btn_clr_proc_Click);
            // 
            // form_caseA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 1012);
            this.Controls.Add(this.btn_clr_proc);
            this.Controls.Add(this.btn_run_proc);
            this.Controls.Add(this.btn_set_Params);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_maskImg);
            this.Controls.Add(this.btn_cutImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_rst);
            this.Controls.Add(this.pic_org);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_close);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_caseA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_caseA";
            this.Load += new System.EventHandler(this.form_caseA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_org)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.PictureBox pic_org;
        private System.Windows.Forms.PictureBox pic_rst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cutImg;
        private System.Windows.Forms.Button btn_maskImg;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_set_Params;
        private System.Windows.Forms.Button btn_run_proc;
        private System.Windows.Forms.Button btn_clr_proc;
    }
}