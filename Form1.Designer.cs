namespace bangcuuchuong1
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
            this.nbukq = new System.Windows.Forms.NumericUpDown();
            this.lbkq = new System.Windows.Forms.ListBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbukq)).BeginInit();
            this.SuspendLayout();
            // 
            // nbukq
            // 
            this.nbukq.Location = new System.Drawing.Point(233, 34);
            this.nbukq.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbukq.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nbukq.Name = "nbukq";
            this.nbukq.Size = new System.Drawing.Size(120, 20);
            this.nbukq.TabIndex = 0;
            this.nbukq.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbkq
            // 
            this.lbkq.FormattingEnabled = true;
            this.lbkq.Location = new System.Drawing.Point(235, 109);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(176, 316);
            this.lbkq.TabIndex = 1;
            this.lbkq.SelectedIndexChanged += new System.EventHandler(this.lbkq_SelectedIndexChanged);
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(33, 109);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(0, 13);
            this.lblkq.TabIndex = 2;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(380, 34);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "=";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.nbukq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbukq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nbukq;
        private System.Windows.Forms.ListBox lbkq;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Button btnTinh;
    }
}

