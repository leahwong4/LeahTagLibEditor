namespace LeahTagLibEditor
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textFileTB = new System.Windows.Forms.TextBox();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AlbumTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.songFormatTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.songFolderTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song Name Text File Path (.txt)*";
            // 
            // textFileTB
            // 
            this.textFileTB.Location = new System.Drawing.Point(189, 33);
            this.textFileTB.Name = "textFileTB";
            this.textFileTB.Size = new System.Drawing.Size(320, 20);
            this.textFileTB.TabIndex = 2;
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(189, 62);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(320, 20);
            this.authorTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // AlbumTB
            // 
            this.AlbumTB.Location = new System.Drawing.Point(189, 95);
            this.AlbumTB.Name = "AlbumTB";
            this.AlbumTB.Size = new System.Drawing.Size(320, 20);
            this.AlbumTB.TabIndex = 4;
            this.AlbumTB.TextChanged += new System.EventHandler(this.AlbumTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Album";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(477, 139);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // songFormatTB
            // 
            this.songFormatTB.Location = new System.Drawing.Point(189, 127);
            this.songFormatTB.Name = "songFormatTB";
            this.songFormatTB.Size = new System.Drawing.Size(320, 20);
            this.songFormatTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Song File Format*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit TagLib";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // songFolderTB
            // 
            this.songFolderTB.Location = new System.Drawing.Point(189, 5);
            this.songFolderTB.Name = "songFolderTB";
            this.songFolderTB.Size = new System.Drawing.Size(320, 20);
            this.songFolderTB.TabIndex = 1;
            this.songFolderTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Song Folder*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Preview Result";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 353);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.songFolderTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.songFormatTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AlbumTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFileTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LeahTagLibEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFileTB;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AlbumTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox songFormatTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox songFolderTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

