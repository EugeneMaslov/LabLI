namespace Module_Reading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.download = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Dothis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.SystemColors.Highlight;
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.download.Location = new System.Drawing.Point(513, 12);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(119, 37);
            this.download.TabIndex = 0;
            this.download.Text = "Загрузить";
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 346);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Dothis
            // 
            this.Dothis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dothis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dothis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dothis.Location = new System.Drawing.Point(638, 12);
            this.Dothis.Name = "Dothis";
            this.Dothis.Size = new System.Drawing.Size(117, 37);
            this.Dothis.TabIndex = 2;
            this.Dothis.Text = "Вычислить";
            this.Dothis.UseVisualStyleBackColor = false;
            this.Dothis.Click += new System.EventHandler(this.Dothis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(407, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите файл:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(-20, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(743, 346);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Поле для загрузки изображения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите файл для открытия и \r\nлабиринт появится на этом поле";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Справка";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(461, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 231);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dothis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.download);
            this.Name = "Form1";
            this.Text = "LabLi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button download;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Dothis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

