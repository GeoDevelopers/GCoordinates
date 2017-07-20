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
            this.GetAutoAreaBtn = new System.Windows.Forms.Button();
            this.MapView = new System.Windows.Forms.PictureBox();
            this.CheckBoxMap = new System.Windows.Forms.CheckBox();
            this.CheckBoxGrid = new System.Windows.Forms.CheckBox();
            this.CheckBoxGridView = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CutView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CounterThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutView)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(22, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(416, 137);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // GetAreaBtn
            // 
            this.GetAreaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetAreaBtn.Location = new System.Drawing.Point(22, 410);
            this.GetAreaBtn.Name = "GetAreaBtn";
            this.GetAreaBtn.Size = new System.Drawing.Size(416, 42);
            this.GetAreaBtn.TabIndex = 1;
            this.GetAreaBtn.Text = "Выбрать точки";
            this.GetAreaBtn.UseVisualStyleBackColor = true;
            this.GetAreaBtn.Click += new System.EventHandler(this.GetPlaceBtn_Click);
            this.GetAreaBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowKey_Down);
            // 
            // StartMoveBtn
            // 
            this.StartMoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMoveBtn.Location = new System.Drawing.Point(22, 833);
            this.StartMoveBtn.Name = "StartMoveBtn";
            this.StartMoveBtn.Size = new System.Drawing.Size(416, 42);
            this.StartMoveBtn.TabIndex = 2;
            this.StartMoveBtn.Text = "Начать захват";
            this.StartMoveBtn.UseVisualStyleBackColor = true;
            this.StartMoveBtn.Click += new System.EventHandler(this.StartMoveBtn_Click);
            this.StartMoveBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowKey_Down);
            // 
            // ChooseImageFolderBtn
            // 
            this.ChooseImageFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseImageFolderBtn.Location = new System.Drawing.Point(22, 558);
            this.ChooseImageFolderBtn.Name = "ChooseImageFolderBtn";
            this.ChooseImageFolderBtn.Size = new System.Drawing.Size(416, 42);
            this.ChooseImageFolderBtn.TabIndex = 3;
            this.ChooseImageFolderBtn.Text = "Выбрать папку для сохранения изображений";
            this.ChooseImageFolderBtn.UseVisualStyleBackColor = true;
            this.ChooseImageFolderBtn.Click += new System.EventHandler(this.ChooseImageFolderBtn_Click);
            // 
            // LabelImagePath
            // 
            this.LabelImagePath.AutoSize = true;
            this.LabelImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelImagePath.Location = new System.Drawing.Point(19, 603);
            this.LabelImagePath.Name = "LabelImagePath";
            this.LabelImagePath.Size = new System.Drawing.Size(314, 17);
            this.LabelImagePath.TabIndex = 4;
            this.LabelImagePath.Text = "Текущая папка для сохранения изображений:";
            // 
            // CounterThickness
            // 
            this.CounterThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterThickness.Location = new System.Drawing.Point(185, 235);
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
            this.CounterThickness.Size = new System.Drawing.Size(120, 23);
            this.CounterThickness.TabIndex = 6;
            this.CounterThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CounterThickness.ValueChanged += new System.EventHandler(this.CounterThickness_ValueChanged);
            // 
            // ClearImageFolderBtn
            // 
            this.ClearImageFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearImageFolderBtn.Location = new System.Drawing.Point(219, 696);
            this.ClearImageFolderBtn.Name = "ClearImageFolderBtn";
            this.ClearImageFolderBtn.Size = new System.Drawing.Size(219, 42);
            this.ClearImageFolderBtn.TabIndex = 7;
            this.ClearImageFolderBtn.Text = "Очистить папку";
            this.ClearImageFolderBtn.UseVisualStyleBackColor = true;
            this.ClearImageFolderBtn.Click += new System.EventHandler(this.ClearImageFolderBtn_Click);
            // 
            // GetAutoAreaBtn
            // 
            this.GetAutoAreaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetAutoAreaBtn.Location = new System.Drawing.Point(22, 172);
            this.GetAutoAreaBtn.Name = "GetAutoAreaBtn";
            this.GetAutoAreaBtn.Size = new System.Drawing.Size(416, 42);
            this.GetAutoAreaBtn.TabIndex = 8;
            this.GetAutoAreaBtn.Text = "Автоматически захватить экран";
            this.GetAutoAreaBtn.UseVisualStyleBackColor = true;
            this.GetAutoAreaBtn.Click += new System.EventHandler(this.GetAutoAreaBtn_Click);
            // 
            // MapView
            // 
            this.MapView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MapView.Location = new System.Drawing.Point(460, 12);
            this.MapView.Name = "MapView";
            this.MapView.Size = new System.Drawing.Size(1432, 942);
            this.MapView.TabIndex = 9;
            this.MapView.TabStop = false;
            // 
            // CheckBoxMap
            // 
            this.CheckBoxMap.AutoSize = true;
            this.CheckBoxMap.Checked = true;
            this.CheckBoxMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxMap.Location = new System.Drawing.Point(22, 281);
            this.CheckBoxMap.Name = "CheckBoxMap";
            this.CheckBoxMap.Size = new System.Drawing.Size(130, 21);
            this.CheckBoxMap.TabIndex = 10;
            this.CheckBoxMap.Text = "Показать карту";
            this.CheckBoxMap.UseVisualStyleBackColor = true;
            this.CheckBoxMap.CheckedChanged += new System.EventHandler(this.CheckBoxMap_CheckedChanged);
            // 
            // CheckBoxGrid
            // 
            this.CheckBoxGrid.AutoSize = true;
            this.CheckBoxGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxGrid.Location = new System.Drawing.Point(22, 308);
            this.CheckBoxGrid.Name = "CheckBoxGrid";
            this.CheckBoxGrid.Size = new System.Drawing.Size(226, 21);
            this.CheckBoxGrid.TabIndex = 11;
            this.CheckBoxGrid.Text = "Показать сетку сканирования";
            this.CheckBoxGrid.UseVisualStyleBackColor = true;
            this.CheckBoxGrid.CheckedChanged += new System.EventHandler(this.CheckBoxGrid_CheckedChanged);
            // 
            // CheckBoxGridView
            // 
            this.CheckBoxGridView.AutoSize = true;
            this.CheckBoxGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxGridView.Location = new System.Drawing.Point(42, 335);
            this.CheckBoxGridView.Name = "CheckBoxGridView";
            this.CheckBoxGridView.Size = new System.Drawing.Size(199, 21);
            this.CheckBoxGridView.TabIndex = 12;
            this.CheckBoxGridView.Text = "Отображать только точки";
            this.CheckBoxGridView.UseVisualStyleBackColor = true;
            this.CheckBoxGridView.CheckedChanged += new System.EventHandler(this.CheckBoxGridView_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Частота сканирования";
            // 
            // CutView
            // 
            this.CutView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CutView.Location = new System.Drawing.Point(22, 458);
            this.CutView.Name = "CutView";
            this.CutView.Size = new System.Drawing.Size(416, 50);
            this.CutView.TabIndex = 14;
            this.CutView.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.CutView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxGridView);
            this.Controls.Add(this.CheckBoxGrid);
            this.Controls.Add(this.CheckBoxMap);
            this.Controls.Add(this.MapView);
            this.Controls.Add(this.GetAutoAreaBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.MapView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutView)).EndInit();
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
        private System.Windows.Forms.Button GetAutoAreaBtn;
        private System.Windows.Forms.PictureBox MapView;
        private System.Windows.Forms.CheckBox CheckBoxMap;
        private System.Windows.Forms.CheckBox CheckBoxGrid;
        private System.Windows.Forms.CheckBox CheckBoxGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CutView;
    }
}

