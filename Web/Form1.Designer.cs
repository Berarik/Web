namespace Web
{
    partial class WebBrowserForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Adress = new System.Windows.Forms.TextBox();
            this.WeBrowser = new System.Windows.Forms.WebBrowser();
            this.AddressEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(1, 12);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(ClientSize.Width-AddressEnter.Width, 22);
            this.Adress.TabIndex = 0;
            this.Adress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Adress_KeyDown);
            // 
            // WeBrowser
            // 
            this.WeBrowser.Location = new System.Drawing.Point(1, 40);
            this.WeBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WeBrowser.Name = "WeBrowser";
            this.WeBrowser.Size = new System.Drawing.Size(WeBrowser.Width, WeBrowser.Height-50);
            this.WeBrowser.TabIndex = 1;
            this.WeBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.WeBrowser_NewWindow);
            // 
            // AddressEnter
            // 
            this.AddressEnter.Size = new System.Drawing.Size(75, 23);
            this.AddressEnter.Location = new System.Drawing.Point(ClientSize.Width-AddressEnter.Width, 10);
            this.AddressEnter.Name = "AddressEnter";
            this.AddressEnter.TabIndex = 2;
            this.AddressEnter.Text = "Перейти";
            this.AddressEnter.UseVisualStyleBackColor = true;
            this.AddressEnter.Click += new System.EventHandler(this.AddressEnter_Click);
            // 
            // WebBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.AddressEnter);
            this.Controls.Add(this.WeBrowser);
            this.Controls.Add(this.Adress);
            this.Name = "WebBrowserForm";
            this.Text = "WeBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.WebBrowserForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.WebBrowser WeBrowser;
        private System.Windows.Forms.Button AddressEnter;
    }
}

