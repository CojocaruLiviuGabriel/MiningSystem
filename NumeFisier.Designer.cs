
namespace MiningSystem
{
    partial class NumeFisier
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.btnCloseNume = new System.Windows.Forms.Button();
            this.lbNume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(27, 80);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(178, 23);
            this.tbNume.TabIndex = 0;
            // 
            // btnCloseNume
            // 
            this.btnCloseNume.Location = new System.Drawing.Point(27, 116);
            this.btnCloseNume.Name = "btnCloseNume";
            this.btnCloseNume.Size = new System.Drawing.Size(75, 23);
            this.btnCloseNume.TabIndex = 1;
            this.btnCloseNume.Text = "Close";
            this.btnCloseNume.UseVisualStyleBackColor = true;
            this.btnCloseNume.Click += new System.EventHandler(this.btnCloseNume_Click);
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(27, 40);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(66, 15);
            this.lbNume.TabIndex = 2;
            this.lbNume.Text = "nume fisier";
            // 
            // NumeFisier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 151);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.btnCloseNume);
            this.Controls.Add(this.tbNume);
            this.Name = "NumeFisier";
            this.Text = "NumeFisier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Button btnCloseNume;
        private System.Windows.Forms.Label lbNume;
    }
}