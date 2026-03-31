namespace PraktikumADO
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(129, 220);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(272, 101);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "button1";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(453, 220);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(272, 101);
            this.btnHitungMhs.TabIndex = 1;
            this.btnHitungMhs.Text = "button2";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.Location = new System.Drawing.Point(772, 220);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(272, 101);
            this.btnHitungMK.TabIndex = 2;
            this.btnHitungMK.Text = "button3";
            this.btnHitungMK.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1105, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(272, 101);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "button4";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1151, 31);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1933, 1077);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

