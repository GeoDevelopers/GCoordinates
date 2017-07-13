namespace Program
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GetAreaBtn = new System.Windows.Forms.Button();
            this.StartMoveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ImageFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(22, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(596, 137);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // GetAreaBtn
            // 
            this.GetAreaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetAreaBtn.Location = new System.Drawing.Point(399, 200);
            this.GetAreaBtn.Name = "GetAreaBtn";
            this.GetAreaBtn.Size = new System.Drawing.Size(219, 42);
            this.GetAreaBtn.TabIndex = 1;
            this.GetAreaBtn.Text = "Выбрать точки";
            this.GetAreaBtn.UseVisualStyleBackColor = true;
            this.GetAreaBtn.Click += new System.EventHandler(this.GetPlaceBtn_Click);
            this.GetAreaBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowKey_Down);
            // 
            // StartMoveBtn
            // 
            this.StartMoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMoveBtn.Location = new System.Drawing.Point(399, 248);
            this.StartMoveBtn.Name = "StartMoveBtn";
            this.StartMoveBtn.Size = new System.Drawing.Size(219, 42);
            this.StartMoveBtn.TabIndex = 2;
            this.StartMoveBtn.Text = "Начать захват";
            this.StartMoveBtn.UseVisualStyleBackColor = true;
            this.StartMoveBtn.Click += new System.EventHandler(this.StartMoveBtn_Click);
            this.StartMoveBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowKey_Down);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(399, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выбрать папку для сохранения изображений";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartMoveBtn);
            this.Controls.Add(this.GetAreaBtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "GCoordinates";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowKey_Down);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button GetAreaBtn;
        private System.Windows.Forms.Button StartMoveBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog ImageFolderBrowser;
    }
}

