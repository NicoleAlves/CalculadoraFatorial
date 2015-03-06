namespace WindowsFormsApplication1
{
    partial class Fatorial
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
            this.MI = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MI
            // 
            this.MI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MI.Location = new System.Drawing.Point(15, 72);
            this.MI.Name = "MI";
            this.MI.Size = new System.Drawing.Size(95, 23);
            this.MI.TabIndex = 0;
            this.MI.Text = "Iterativa";
            this.MI.UseVisualStyleBackColor = true;
            this.MI.Click += new System.EventHandler(this.ClickI);
            // 
            // MR
            // 
            this.MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MR.Location = new System.Drawing.Point(167, 72);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(95, 23);
            this.MR.TabIndex = 1;
            this.MR.Text = "Recursiva";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.ClickR);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(49, 109);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(175, 30);
            this.label.TabIndex = 2;
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(15, 26);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(247, 26);
            this.txt.TabIndex = 3;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // Fatorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 148);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MI);
            this.Name = "Fatorial";
            this.Text = "Fatorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MI;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt;
    }
}

