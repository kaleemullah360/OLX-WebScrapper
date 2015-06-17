namespace KU_MSCS14059_A1
{
    partial class olx_html_scrapper_chrome
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
            this.components = new System.ComponentModel.Container();
            this.btn_execute = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.input_pages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.url_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progress_text_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(186, 227);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(55, 33);
            this.btn_execute.TabIndex = 0;
            this.btn_execute.Text = "Execute";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(247, 227);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(34, 33);
            this.btn_quit.TabIndex = 1;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // input_pages
            // 
            this.input_pages.Location = new System.Drawing.Point(48, 238);
            this.input_pages.Name = "input_pages";
            this.input_pages.Size = new System.Drawing.Size(48, 20);
            this.input_pages.TabIndex = 3;
            this.input_pages.TextChanged += new System.EventHandler(this.input_pages_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pages ";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(121, 227);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(59, 33);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // url_text
            // 
            this.url_text.Location = new System.Drawing.Point(35, 205);
            this.url_text.Name = "url_text";
            this.url_text.Size = new System.Drawing.Size(246, 20);
            this.url_text.TabIndex = 7;
            this.url_text.Text = "http://olx.com.pk/lahore/cars/";
            this.url_text.TextChanged += new System.EventHandler(this.url_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "URL";
            // 
            // progress_text_box
            // 
            this.progress_text_box.Location = new System.Drawing.Point(3, 3);
            this.progress_text_box.Name = "progress_text_box";
            this.progress_text_box.Size = new System.Drawing.Size(278, 200);
            this.progress_text_box.TabIndex = 9;
            this.progress_text_box.Text = "Progress:";
            // 
            // olx_html_scrapper_chrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.progress_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.url_text);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_pages);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_execute);
            this.MaximizeBox = false;
            this.Name = "olx_html_scrapper_chrome";
            this.Text = "Olx.com.pk -Scrapper";
            this.Load += new System.EventHandler(this.olx_html_scrapper_chrome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.TextBox input_pages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox url_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox progress_text_box;
    }
}

