namespace manavornek
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
            this.txtsepet = new System.Windows.Forms.TextBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lstManav = new System.Windows.Forms.ListBox();
            this.btnSepettenKaldır = new System.Windows.Forms.Button();
            this.btnSeçilenelemanisil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsepet
            // 
            this.txtsepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsepet.Location = new System.Drawing.Point(64, 27);
            this.txtsepet.Name = "txtsepet";
            this.txtsepet.Size = new System.Drawing.Size(139, 21);
            this.txtsepet.TabIndex = 0;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(64, 76);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(139, 23);
            this.btnSepeteEkle.TabIndex = 1;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lstManav
            // 
            this.lstManav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstManav.FormattingEnabled = true;
            this.lstManav.ItemHeight = 15;
            this.lstManav.Location = new System.Drawing.Point(232, 27);
            this.lstManav.Name = "lstManav";
            this.lstManav.Size = new System.Drawing.Size(150, 169);
            this.lstManav.TabIndex = 2;
            this.lstManav.Tag = "";
            this.lstManav.SelectedIndexChanged += new System.EventHandler(this.lstManav_SelectedIndexChanged);
            // 
            // btnSepettenKaldır
            // 
            this.btnSepettenKaldır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepettenKaldır.Location = new System.Drawing.Point(64, 124);
            this.btnSepettenKaldır.Name = "btnSepettenKaldır";
            this.btnSepettenKaldır.Size = new System.Drawing.Size(139, 23);
            this.btnSepettenKaldır.TabIndex = 3;
            this.btnSepettenKaldır.Text = "Sepetten Kaldır";
            this.btnSepettenKaldır.UseVisualStyleBackColor = true;
            this.btnSepettenKaldır.Click += new System.EventHandler(this.btnSepettenKaldır_Click);
            // 
            // btnSeçilenelemanisil
            // 
            this.btnSeçilenelemanisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeçilenelemanisil.Location = new System.Drawing.Point(64, 173);
            this.btnSeçilenelemanisil.Name = "btnSeçilenelemanisil";
            this.btnSeçilenelemanisil.Size = new System.Drawing.Size(139, 23);
            this.btnSeçilenelemanisil.TabIndex = 4;
            this.btnSeçilenelemanisil.Text = "seçilen elemani sil";
            this.btnSeçilenelemanisil.UseVisualStyleBackColor = true;
            this.btnSeçilenelemanisil.Click += new System.EventHandler(this.btnSeçilenelemanisil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 226);
            this.Controls.Add(this.btnSeçilenelemanisil);
            this.Controls.Add(this.btnSepettenKaldır);
            this.Controls.Add(this.lstManav);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtsepet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsepet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox lstManav;
        private System.Windows.Forms.Button btnSepettenKaldır;
        private System.Windows.Forms.Button btnSeçilenelemanisil;
    }
}

