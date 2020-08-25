namespace MVCFrog
{
    partial class FrogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrogView));
            this.txtFrogSize = new System.Windows.Forms.TextBox();
            this.lblFrogSize = new System.Windows.Forms.Label();
            this.btnGrowFrog = new System.Windows.Forms.Button();
            this.btnShrinkFrog = new System.Windows.Forms.Button();
            this.picFrog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFrog)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFrogSize
            // 
            this.txtFrogSize.Location = new System.Drawing.Point(127, 60);
            this.txtFrogSize.Name = "txtFrogSize";
            this.txtFrogSize.Size = new System.Drawing.Size(100, 22);
            this.txtFrogSize.TabIndex = 0;
            // 
            // lblFrogSize
            // 
            this.lblFrogSize.AutoSize = true;
            this.lblFrogSize.Location = new System.Drawing.Point(124, 40);
            this.lblFrogSize.Name = "lblFrogSize";
            this.lblFrogSize.Size = new System.Drawing.Size(68, 17);
            this.lblFrogSize.TabIndex = 1;
            this.lblFrogSize.Text = "Frog Size";
            // 
            // btnGrowFrog
            // 
            this.btnGrowFrog.Location = new System.Drawing.Point(386, 60);
            this.btnGrowFrog.Name = "btnGrowFrog";
            this.btnGrowFrog.Size = new System.Drawing.Size(75, 23);
            this.btnGrowFrog.TabIndex = 2;
            this.btnGrowFrog.Text = "Grow";
            this.btnGrowFrog.UseVisualStyleBackColor = true;
            this.btnGrowFrog.Click += new System.EventHandler(this.btnGrowFrog_Click);
            // 
            // btnShrinkFrog
            // 
            this.btnShrinkFrog.Location = new System.Drawing.Point(386, 106);
            this.btnShrinkFrog.Name = "btnShrinkFrog";
            this.btnShrinkFrog.Size = new System.Drawing.Size(75, 23);
            this.btnShrinkFrog.TabIndex = 3;
            this.btnShrinkFrog.Text = "Shrink";
            this.btnShrinkFrog.UseVisualStyleBackColor = true;
            this.btnShrinkFrog.Click += new System.EventHandler(this.btnShrinkFrog_Click);
            // 
            // picFrog
            // 
            this.picFrog.Image = ((System.Drawing.Image)(resources.GetObject("picFrog.Image")));
            this.picFrog.Location = new System.Drawing.Point(141, 214);
            this.picFrog.Name = "picFrog";
            this.picFrog.Size = new System.Drawing.Size(0, 0);
            this.picFrog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrog.TabIndex = 4;
            this.picFrog.TabStop = false;
            // 
            // FrogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picFrog);
            this.Controls.Add(this.btnShrinkFrog);
            this.Controls.Add(this.btnGrowFrog);
            this.Controls.Add(this.lblFrogSize);
            this.Controls.Add(this.txtFrogSize);
            this.Name = "FrogView";
            this.Text = "FrogView";
            ((System.ComponentModel.ISupportInitialize)(this.picFrog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrogSize;
        private System.Windows.Forms.Label lblFrogSize;
        private System.Windows.Forms.Button btnGrowFrog;
        private System.Windows.Forms.Button btnShrinkFrog;
        private System.Windows.Forms.PictureBox picFrog;
    }
}