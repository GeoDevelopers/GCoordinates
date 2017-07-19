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
            this.ChooseImageFolderBtn = new System.Windows.Forms.Button();
            this.ImageFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.LabelImagePath = new System.Windows.Forms.Label();
            this.CounterThickness = new System.Windows.Forms.NumericUpDown();
            this.ClearImageFolderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CounterThickness)).BeginInit();
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
            this.GetAreaBtn.Location = new System.Drawing.Point(22, 168);
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
            this.StartMoveBtn.Location = new System.Drawing.Point(22, 216);
            this.StartMoveBtn.Name = "StartMoveBtn";
            this.StartMoveBtn.Size = new System.Drawing.Size(219, 42);
            this.StartMoveBtn.TabIndex = 2;
            this.StartMoveBtn.Text = "Начать захват";
            this.StartMoveBtn.UseVisualStyleBackColor = true;
            this.StartMoveBtn.Click += new System.EventHandler(this.StartMoveBtn_Click);
            this.StartMoveBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowKey_Down);
            // 
            // ChooseImageFolderBtn
            // 
            this.ChooseImageFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseImageFolderBtn.Location = new System.Drawing.Point(22, 265);
            this.ChooseImageFolderBtn.Name = "ChooseImageFolderBtn";
            this.ChooseImageFolderBtn.Size = new System.Drawing.Size(219, 63);
            this.ChooseImageFolderBtn.TabIndex = 3;
            this.ChooseImageFolderBtn.Text = "Выбрать папку для сохранения изображений";
            this.ChooseImageFolderBtn.UseVisualStyleBackColor = true;
            this.ChooseImageFolderBtn.Click += new System.EventHandler(this.ChooseImageFolderBtn_Click);
            // 
            // LabelImagePath
            // 
            this.LabelImagePath.AutoSize = true;
            this.LabelImagePath.Location = new System.Drawing.Point(265, 291);
            this.LabelImagePath.Name = "LabelImagePath";
            this.LabelImagePath.Size = new System.Drawing.Size(242, 13);
            this.LabelImagePath.TabIndex = 4;
            this.LabelImagePath.Text = "Текущая папка для сохранения изображений:";
            // 
            // CounterThickness
            // 
            this.CounterThickness.Location = new System.Drawing.Point(371, 206);
            this.CounterThickness.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CounterThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CounterThickness.Name = "CounterThickness";
            this.CounterThickness.Size = new System.Drawing.Size(120, 20);
            this.CounterThickness.TabIndex = 6;
            this.CounterThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ClearImageFolderBtn
            // 
            this.ClearImageFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearImageFolderBtn.Location = new System.Drawing.Point(22, 335);
            this.ClearImageFolderBtn.Name = "ClearImageFolderBtn";
            this.ClearImageFolderBtn.Size = new System.Drawing.Size(219, 42);
            this.ClearImageFolderBtn.TabIndex = 7;
            this.ClearImageFolderBtn.Text = "Очистить папку";
            this.ClearImageFolderBtn.UseVisualStyleBackColor = true;
            this.ClearImageFolderBtn.Click += new System.EventHandler(this.ClearImageFolderBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 413);
            this.Controls.Add(this.ClearImageFolderBtn);
            this.Controls.Add(this.CounterThickness);
            this.Controls.Add(this.LabelImagePath);
            this.Controls.Add(this.ChooseImageFolderBtn);
            this.Controls.Add(this.StartMoveBtn);
            this.Controls.Add(this.GetAreaBtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "GCoordinates";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowKey_Down);
            ((System.ComponentModel.ISupportInitialize)(this.CounterThickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button GetAreaBtn;
        private System.Windows.Forms.Button StartMoveBtn;
        private System.Windows.Forms.Button ChooseImageFolderBtn;
        private System.Windows.Forms.FolderBrowserDialog ImageFolderBrowser;
        private System.Windows.Forms.Label LabelImagePath;
        private System.Windows.Forms.NumericUpDown CounterThickness;
        private System.Windows.Forms.Button ClearImageFolderBtn;
    }
}

