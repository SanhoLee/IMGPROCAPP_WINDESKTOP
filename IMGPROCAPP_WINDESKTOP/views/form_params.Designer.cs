namespace IMGPROCAPP_WINDESKTOP
{
    partial class form_params
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
            this.num_ksize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_pxHighThres = new System.Windows.Forms.NumericUpDown();
            this.num_pxLowThres = new System.Windows.Forms.NumericUpDown();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_ksize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pxHighThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pxLowThres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blur Process : k-Size";
            // 
            // num_ksize
            // 
            this.num_ksize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_ksize.Location = new System.Drawing.Point(185, 20);
            this.num_ksize.Margin = new System.Windows.Forms.Padding(2);
            this.num_ksize.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.num_ksize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_ksize.Name = "num_ksize";
            this.num_ksize.Size = new System.Drawing.Size(84, 21);
            this.num_ksize.TabIndex = 1;
            this.num_ksize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_ksize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_ksize.ValueChanged += new System.EventHandler(this.num_ksize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pixel Thresholds : low";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pixel Thresholds : high";
            // 
            // num_pxHighThres
            // 
            this.num_pxHighThres.Location = new System.Drawing.Point(185, 106);
            this.num_pxHighThres.Margin = new System.Windows.Forms.Padding(2);
            this.num_pxHighThres.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_pxHighThres.Name = "num_pxHighThres";
            this.num_pxHighThres.Size = new System.Drawing.Size(84, 21);
            this.num_pxHighThres.TabIndex = 4;
            this.num_pxHighThres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_pxLowThres
            // 
            this.num_pxLowThres.Location = new System.Drawing.Point(185, 63);
            this.num_pxLowThres.Margin = new System.Windows.Forms.Padding(2);
            this.num_pxLowThres.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_pxLowThres.Name = "num_pxLowThres";
            this.num_pxLowThres.Size = new System.Drawing.Size(84, 21);
            this.num_pxLowThres.TabIndex = 5;
            this.num_pxLowThres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(35, 147);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(2);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(111, 28);
            this.btn_apply.TabIndex = 6;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(164, 147);
            this.btn_cls.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(105, 28);
            this.btn_cls.TabIndex = 7;
            this.btn_cls.Text = "Close";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // form_params
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 200);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.num_pxLowThres);
            this.Controls.Add(this.num_pxHighThres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_ksize);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_params";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "form_params";
            this.Load += new System.EventHandler(this.form_params_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_ksize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pxHighThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pxLowThres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_ksize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_pxHighThres;
        private System.Windows.Forms.NumericUpDown num_pxLowThres;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cls;
    }
}