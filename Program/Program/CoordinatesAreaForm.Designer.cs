namespace Program
{
    partial class CoordinatesAreaForm
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
            this.TrackBarLeft = new System.Windows.Forms.TrackBar();
            this.ResultView = new System.Windows.Forms.PictureBox();
            this.TrackBarTop = new System.Windows.Forms.TrackBar();
            this.TrackBarRight = new System.Windows.Forms.TrackBar();
            this.CounterLeft = new System.Windows.Forms.NumericUpDown();
            this.CounterRight = new System.Windows.Forms.NumericUpDown();
            this.CounterTop = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CutView = new System.Windows.Forms.PictureBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutView)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackBarLeft
            // 
            this.TrackBarLeft.Location = new System.Drawing.Point(52, 100);
            this.TrackBarLeft.Name = "TrackBarLeft";
            this.TrackBarLeft.Size = new System.Drawing.Size(1787, 45);
            this.TrackBarLeft.TabIndex = 0;
            this.TrackBarLeft.TickFrequency = 0;
            this.TrackBarLeft.ValueChanged += new System.EventHandler(this.TrackBarLeft_ValueChanged);
            // 
            // ResultView
            // 
            this.ResultView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultView.Location = new System.Drawing.Point(52, 151);
            this.ResultView.Name = "ResultView";
            this.ResultView.Size = new System.Drawing.Size(1787, 438);
            this.ResultView.TabIndex = 1;
            this.ResultView.TabStop = false;
            // 
            // TrackBarTop
            // 
            this.TrackBarTop.Location = new System.Drawing.Point(1845, 151);
            this.TrackBarTop.Name = "TrackBarTop";
            this.TrackBarTop.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrackBarTop.Size = new System.Drawing.Size(45, 438);
            this.TrackBarTop.TabIndex = 2;
            this.TrackBarTop.TickFrequency = 0;
            this.TrackBarTop.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBarTop.ValueChanged += new System.EventHandler(this.TrackBarTop_ValueChanged);
            // 
            // TrackBarRight
            // 
            this.TrackBarRight.Location = new System.Drawing.Point(52, 595);
            this.TrackBarRight.Name = "TrackBarRight";
            this.TrackBarRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrackBarRight.Size = new System.Drawing.Size(1787, 45);
            this.TrackBarRight.TabIndex = 3;
            this.TrackBarRight.TickFrequency = 0;
            this.TrackBarRight.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBarRight.ValueChanged += new System.EventHandler(this.TrackBarRight_ValueChanged);
            // 
            // CounterLeft
            // 
            this.CounterLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterLeft.Location = new System.Drawing.Point(157, 28);
            this.CounterLeft.Name = "CounterLeft";
            this.CounterLeft.Size = new System.Drawing.Size(120, 26);
            this.CounterLeft.TabIndex = 5;
            this.CounterLeft.ValueChanged += new System.EventHandler(this.CounterLeft_ValueChanged);
            // 
            // CounterRight
            // 
            this.CounterRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterRight.Location = new System.Drawing.Point(542, 28);
            this.CounterRight.Name = "CounterRight";
            this.CounterRight.Size = new System.Drawing.Size(120, 26);
            this.CounterRight.TabIndex = 6;
            this.CounterRight.ValueChanged += new System.EventHandler(this.CounterRight_ValueChanged);
            // 
            // CounterTop
            // 
            this.CounterTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterTop.Location = new System.Drawing.Point(910, 28);
            this.CounterTop.Name = "CounterTop";
            this.CounterTop.Size = new System.Drawing.Size(120, 26);
            this.CounterTop.TabIndex = 7;
            this.CounterTop.ValueChanged += new System.EventHandler(this.CounterTop_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сдвиг слева";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(423, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Сдвиг справа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(795, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сдвиг сверху";
            // 
            // CutView
            // 
            this.CutView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CutView.Location = new System.Drawing.Point(49, 682);
            this.CutView.Name = "CutView";
            this.CutView.Size = new System.Drawing.Size(1790, 156);
            this.CutView.TabIndex = 11;
            this.CutView.TabStop = false;
            // 
            // OkBtn
            // 
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBtn.Location = new System.Drawing.Point(1408, 898);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(200, 40);
            this.OkBtn.TabIndex = 12;
            this.OkBtn.Text = "Принять";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(1639, 898);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(200, 40);
            this.BackBtn.TabIndex = 13;
            this.BackBtn.Text = "Отмена";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CoordinatesAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 981);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CutView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CounterTop);
            this.Controls.Add(this.CounterRight);
            this.Controls.Add(this.CounterLeft);
            this.Controls.Add(this.TrackBarRight);
            this.Controls.Add(this.TrackBarTop);
            this.Controls.Add(this.ResultView);
            this.Controls.Add(this.TrackBarLeft);
            this.Name = "CoordinatesAreaForm";
            this.Text = "CoordinatesAreaForm";
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrackBarLeft;
        private System.Windows.Forms.PictureBox ResultView;
        private System.Windows.Forms.TrackBar TrackBarTop;
        private System.Windows.Forms.TrackBar TrackBarRight;
        private System.Windows.Forms.NumericUpDown CounterLeft;
        private System.Windows.Forms.NumericUpDown CounterRight;
        private System.Windows.Forms.NumericUpDown CounterTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox CutView;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}