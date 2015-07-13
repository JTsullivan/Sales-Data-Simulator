namespace AutoSalesDataSheetGeneratorCsharp
{
    partial class AutoSalesGeneratorForm
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
            this.PrimaryActionButton = new System.Windows.Forms.Button();
            this.UIfilenameBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrimaryActionButton
            // 
            this.PrimaryActionButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimaryActionButton.Location = new System.Drawing.Point(39, 50);
            this.PrimaryActionButton.Name = "PrimaryActionButton";
            this.PrimaryActionButton.Size = new System.Drawing.Size(203, 147);
            this.PrimaryActionButton.TabIndex = 0;
            this.PrimaryActionButton.Text = "Generate Sales Data";
            this.PrimaryActionButton.UseVisualStyleBackColor = true;
            this.PrimaryActionButton.Click += new System.EventHandler(this.PrimaryActionButton_Click);
            // 
            // UIfilenameBOX
            // 
            this.UIfilenameBOX.Location = new System.Drawing.Point(39, 229);
            this.UIfilenameBOX.Name = "UIfilenameBOX";
            this.UIfilenameBOX.Size = new System.Drawing.Size(203, 20);
            this.UIfilenameBOX.TabIndex = 1;
            this.UIfilenameBOX.TextChanged += new System.EventHandler(this.UIfilenameBOX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name";
            // 
            // AutoSalesGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UIfilenameBOX);
            this.Controls.Add(this.PrimaryActionButton);
            this.Name = "AutoSalesGeneratorForm";
            this.Text = "Auto Sales Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrimaryActionButton;
        private System.Windows.Forms.TextBox UIfilenameBOX;
        private System.Windows.Forms.Label label1;
    }
}

