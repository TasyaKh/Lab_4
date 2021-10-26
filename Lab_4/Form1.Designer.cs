
namespace Lab_4
{
    partial class Form1
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
            this.buttonGet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.Refill = new System.Windows.Forms.Button();
            this.seeElems = new System.Windows.Forms.RichTextBox();
            this.switchMode = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGet
            // 
            this.buttonGet.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonGet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGet.Location = new System.Drawing.Point(288, 205);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(103, 76);
            this.buttonGet.TabIndex = 0;
            this.buttonGet.Text = "Получить";
            this.buttonGet.UseVisualStyleBackColor = false;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.Color.White;
            this.txtOut.Location = new System.Drawing.Point(8, 120);
            this.txtOut.Name = "txtOut";
            this.txtOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOut.Size = new System.Drawing.Size(268, 163);
            this.txtOut.TabIndex = 2;
            this.txtOut.Text = "";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInfo.Location = new System.Drawing.Point(8, 73);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(268, 41);
            this.txtInfo.TabIndex = 3;
            this.txtInfo.Text = "";
            // 
            // Refill
            // 
            this.Refill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Refill.Location = new System.Drawing.Point(8, 38);
            this.Refill.Name = "Refill";
            this.Refill.Size = new System.Drawing.Size(268, 29);
            this.Refill.TabIndex = 4;
            this.Refill.Text = "Заполнить";
            this.Refill.UseVisualStyleBackColor = false;
            this.Refill.Click += new System.EventHandler(this.Refill_Click);
            // 
            // seeElems
            // 
            this.seeElems.BackColor = System.Drawing.Color.White;
            this.seeElems.Location = new System.Drawing.Point(282, 120);
            this.seeElems.Name = "seeElems";
            this.seeElems.ReadOnly = true;
            this.seeElems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.seeElems.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.seeElems.Size = new System.Drawing.Size(103, 81);
            this.seeElems.TabIndex = 6;
            this.seeElems.Text = "";
            // 
            // switchMode
            // 
            this.switchMode.AutoSize = true;
            this.switchMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.switchMode.Location = new System.Drawing.Point(283, 90);
            this.switchMode.Name = "switchMode";
            this.switchMode.Size = new System.Drawing.Size(89, 24);
            this.switchMode.TabIndex = 7;
            this.switchMode.Text = "вкл. мод";
            this.switchMode.UseVisualStyleBackColor = false;
            this.switchMode.CheckedChanged += new System.EventHandler(this.switchMode_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(197, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Lab_4.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(399, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.switchMode);
            this.Controls.Add(this.seeElems);
            this.Controls.Add(this.Refill);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonGet);
            this.Name = "Form1";
            this.Text = "Лабораторная №4(Устройства)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.Button Refill;
        private System.Windows.Forms.RichTextBox seeElems;
        private System.Windows.Forms.CheckBox switchMode;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

