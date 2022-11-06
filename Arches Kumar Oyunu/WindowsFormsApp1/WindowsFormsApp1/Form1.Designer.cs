
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.bakiyeTextBox = new System.Windows.Forms.TextBox();
            this.oynaBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oynananMiktarTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bakiyeTextBox
            // 
            this.bakiyeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyeTextBox.Location = new System.Drawing.Point(142, 6);
            this.bakiyeTextBox.Name = "bakiyeTextBox";
            this.bakiyeTextBox.Size = new System.Drawing.Size(93, 26);
            this.bakiyeTextBox.TabIndex = 0;
            // 
            // oynaBTN
            // 
            this.oynaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oynaBTN.Location = new System.Drawing.Point(160, 101);
            this.oynaBTN.Name = "oynaBTN";
            this.oynaBTN.Size = new System.Drawing.Size(75, 38);
            this.oynaBTN.TabIndex = 1;
            this.oynaBTN.Text = "Oyna";
            this.oynaBTN.UseVisualStyleBackColor = true;
            this.oynaBTN.Click += new System.EventHandler(this.oynaBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mevcut Bakiye =";
            // 
            // oynananMiktarTextBox
            // 
            this.oynananMiktarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oynananMiktarTextBox.Location = new System.Drawing.Point(160, 61);
            this.oynananMiktarTextBox.Name = "oynananMiktarTextBox";
            this.oynananMiktarTextBox.Size = new System.Drawing.Size(75, 26);
            this.oynananMiktarTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oynadığnız Miktar =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(419, 155);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oynananMiktarTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oynaBTN);
            this.Controls.Add(this.bakiyeTextBox);
            this.Name = "Form1";
            this.Text = "Arches Kumar Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bakiyeTextBox;
        private System.Windows.Forms.Button oynaBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oynananMiktarTextBox;
        private System.Windows.Forms.Label label2;
    }
}

