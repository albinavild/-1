namespace лабараторная1
{
    partial class Form2
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
            this.txtRub = new System.Windows.Forms.TextBox();
            this.txtEur = new System.Windows.Forms.TextBox();
            this.txtUsd = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPreferential = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRub
            // 
            this.txtRub.Location = new System.Drawing.Point(12, 45);
            this.txtRub.Name = "txtRub";
            this.txtRub.Size = new System.Drawing.Size(100, 22);
            this.txtRub.TabIndex = 0;
            // 
            // txtEur
            // 
            this.txtEur.Location = new System.Drawing.Point(12, 99);
            this.txtEur.Name = "txtEur";
            this.txtEur.ReadOnly = true;
            this.txtEur.Size = new System.Drawing.Size(100, 22);
            this.txtEur.TabIndex = 1;
            // 
            // txtUsd
            // 
            this.txtUsd.AcceptsReturn = true;
            this.txtUsd.Location = new System.Drawing.Point(12, 152);
            this.txtUsd.Name = "txtUsd";
            this.txtUsd.ReadOnly = true;
            this.txtUsd.Size = new System.Drawing.Size(100, 22);
            this.txtUsd.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(170, 51);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "рубль";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(170, 105);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "евро";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(170, 155);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(55, 16);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "доллар";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPreferential);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Location = new System.Drawing.Point(312, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "курс";
            // 
            // rbPreferential
            // 
            this.rbPreferential.AutoSize = true;
            this.rbPreferential.Location = new System.Drawing.Point(3, 44);
            this.rbPreferential.Name = "rbPreferential";
            this.rbPreferential.Size = new System.Drawing.Size(89, 20);
            this.rbPreferential.TabIndex = 1;
            this.rbPreferential.Text = "льготный";
            this.rbPreferential.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(3, 18);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(86, 20);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "обычный";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtUsd);
            this.Controls.Add(this.txtEur);
            this.Controls.Add(this.txtRub);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRub;
        private System.Windows.Forms.TextBox txtEur;
        private System.Windows.Forms.TextBox txtUsd;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPreferential;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Button button1;
    }
}