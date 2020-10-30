namespace Novella
{
    partial class Form6
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.textZone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.textBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1262, 504);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Transparent;
            this.textBox.Controls.Add(this.nameBox);
            this.textBox.Controls.Add(this.nameText);
            this.textBox.Controls.Add(this.textZone);
            this.textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox.Location = new System.Drawing.Point(0, 504);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(1262, 169);
            this.textBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(18, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(0, 38);
            this.nameBox.TabIndex = 2;
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameText.ForeColor = System.Drawing.Color.White;
            this.nameText.Location = new System.Drawing.Point(12, 3);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(0, 38);
            this.nameText.TabIndex = 1;
            // 
            // textZone
            // 
            this.textZone.AutoSize = true;
            this.textZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textZone.ForeColor = System.Drawing.Color.White;
            this.textZone.Location = new System.Drawing.Point(12, 47);
            this.textZone.Name = "textZone";
            this.textZone.Size = new System.Drawing.Size(1167, 38);
            this.textZone.TabIndex = 0;
            this.textZone.Text = "И вот я уже прихожу домой, даже не догадываясь что меня ждет письмо...";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.textBox.ResumeLayout(false);
            this.textBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel textBox;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label textZone;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}