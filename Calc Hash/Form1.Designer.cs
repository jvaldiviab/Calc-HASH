
namespace Calc_Hash
{
    partial class FormCalculate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_hmac = new System.Windows.Forms.RadioButton();
            this.rad_sha256 = new System.Windows.Forms.RadioButton();
            this.rad_sha1 = new System.Windows.Forms.RadioButton();
            this.rad_md5 = new System.Windows.Forms.RadioButton();
            this.rad_md4 = new System.Windows.Forms.RadioButton();
            this.text_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text_out = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.text_in);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENTRADA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "EJECUTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(219, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 93);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DESCRIPCIÓN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_hmac);
            this.groupBox3.Controls.Add(this.rad_sha256);
            this.groupBox3.Controls.Add(this.rad_sha1);
            this.groupBox3.Controls.Add(this.rad_md5);
            this.groupBox3.Controls.Add(this.rad_md4);
            this.groupBox3.Location = new System.Drawing.Point(41, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIPO";
            // 
            // rad_hmac
            // 
            this.rad_hmac.AutoSize = true;
            this.rad_hmac.Location = new System.Drawing.Point(18, 126);
            this.rad_hmac.Name = "rad_hmac";
            this.rad_hmac.Size = new System.Drawing.Size(61, 19);
            this.rad_hmac.TabIndex = 4;
            this.rad_hmac.TabStop = true;
            this.rad_hmac.Text = "HMAC";
            this.rad_hmac.UseVisualStyleBackColor = true;
            // 
            // rad_sha256
            // 
            this.rad_sha256.AutoSize = true;
            this.rad_sha256.Location = new System.Drawing.Point(18, 100);
            this.rad_sha256.Name = "rad_sha256";
            this.rad_sha256.Size = new System.Drawing.Size(66, 19);
            this.rad_sha256.TabIndex = 3;
            this.rad_sha256.TabStop = true;
            this.rad_sha256.Text = "SHA256";
            this.rad_sha256.UseVisualStyleBackColor = true;
            // 
            // rad_sha1
            // 
            this.rad_sha1.AutoSize = true;
            this.rad_sha1.Location = new System.Drawing.Point(18, 74);
            this.rad_sha1.Name = "rad_sha1";
            this.rad_sha1.Size = new System.Drawing.Size(54, 19);
            this.rad_sha1.TabIndex = 2;
            this.rad_sha1.TabStop = true;
            this.rad_sha1.Text = "SHA1";
            this.rad_sha1.UseVisualStyleBackColor = true;
            // 
            // rad_md5
            // 
            this.rad_md5.AutoSize = true;
            this.rad_md5.Location = new System.Drawing.Point(18, 48);
            this.rad_md5.Name = "rad_md5";
            this.rad_md5.Size = new System.Drawing.Size(50, 19);
            this.rad_md5.TabIndex = 1;
            this.rad_md5.TabStop = true;
            this.rad_md5.Text = "MD5";
            this.rad_md5.UseVisualStyleBackColor = true;
            // 
            // rad_md4
            // 
            this.rad_md4.AutoSize = true;
            this.rad_md4.Location = new System.Drawing.Point(18, 22);
            this.rad_md4.Name = "rad_md4";
            this.rad_md4.Size = new System.Drawing.Size(50, 19);
            this.rad_md4.TabIndex = 0;
            this.rad_md4.TabStop = true;
            this.rad_md4.Text = "MD4";
            this.rad_md4.UseVisualStyleBackColor = true;
            // 
            // text_in
            // 
            this.text_in.Location = new System.Drawing.Point(155, 25);
            this.text_in.Name = "text_in";
            this.text_in.Size = new System.Drawing.Size(488, 23);
            this.text_in.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto de entrada:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.text_out);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(43, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SALIDA";
            // 
            // text_out
            // 
            this.text_out.Location = new System.Drawing.Point(103, 44);
            this.text_out.Name = "text_out";
            this.text_out.Size = new System.Drawing.Size(540, 23);
            this.text_out.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLAVE:";
            // 
            // FormCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCalculate";
            this.Text = "CALCULADORA HASH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_hmac;
        private System.Windows.Forms.RadioButton rad_sha256;
        private System.Windows.Forms.RadioButton rad_sha1;
        private System.Windows.Forms.RadioButton rad_md5;
        private System.Windows.Forms.RadioButton rad_md4;
        private System.Windows.Forms.TextBox text_in;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_out;
        private System.Windows.Forms.Label label2;
    }
}

