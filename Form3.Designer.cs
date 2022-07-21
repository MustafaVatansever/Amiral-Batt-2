
namespace Amiral_Battı_2
{
    partial class Form3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1001 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5*1 Kruvazor",
            "4*1 Savaş Gemisi",
            "3*1 Yük Gemisi",
            "2*1 Yolcu Gemisi",
            "2*1 Yolcu Gemisi"});
            this.comboBox1.Location = new System.Drawing.Point(543, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DİKEY",
            "YATAY"});
            this.comboBox2.Location = new System.Drawing.Point(543, 340);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(254, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // button1001
            // 
            this.button1001.Location = new System.Drawing.Point(566, 431);
            this.button1001.Name = "button1001";
            this.button1001.Size = new System.Drawing.Size(204, 45);
            this.button1001.TabIndex = 3;
            this.button1001.Text = "Devam Et";
            this.button1001.UseVisualStyleBackColor = true;
            this.button1001.Click += new System.EventHandler(this.button1001_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 539);
            this.Controls.Add(this.button1001);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1001;
    }
}