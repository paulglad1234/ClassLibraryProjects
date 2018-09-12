namespace TimeApp
{
    partial class TimeAppForm
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
            this.savedTimeLabel = new System.Windows.Forms.Label();
            this.dayTimeLabel = new System.Windows.Forms.Label();
            this.savedTimeButton = new System.Windows.Forms.Button();
            this.dayTimeButton = new System.Windows.Forms.Button();
            this.inputButton = new System.Windows.Forms.Button();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minuteBox = new System.Windows.Forms.TextBox();
            this.saveCurrentTimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // savedTimeLabel
            // 
            this.savedTimeLabel.AutoSize = true;
            this.savedTimeLabel.Location = new System.Drawing.Point(43, 220);
            this.savedTimeLabel.Name = "savedTimeLabel";
            this.savedTimeLabel.Size = new System.Drawing.Size(97, 13);
            this.savedTimeLabel.TabIndex = 0;
            this.savedTimeLabel.Text = "Введенное время";
            // 
            // dayTimeLabel
            // 
            this.dayTimeLabel.AutoSize = true;
            this.dayTimeLabel.Location = new System.Drawing.Point(409, 220);
            this.dayTimeLabel.Name = "dayTimeLabel";
            this.dayTimeLabel.Size = new System.Drawing.Size(71, 13);
            this.dayTimeLabel.TabIndex = 1;
            this.dayTimeLabel.Text = "Время суток";
            // 
            // savedTimeButton
            // 
            this.savedTimeButton.Location = new System.Drawing.Point(13, 265);
            this.savedTimeButton.Name = "savedTimeButton";
            this.savedTimeButton.Size = new System.Drawing.Size(168, 23);
            this.savedTimeButton.TabIndex = 2;
            this.savedTimeButton.Text = "Показать введенное время";
            this.savedTimeButton.UseVisualStyleBackColor = true;
            this.savedTimeButton.Click += new System.EventHandler(this.savedTimeButton_Click);
            // 
            // dayTimeButton
            // 
            this.dayTimeButton.Location = new System.Drawing.Point(226, 265);
            this.dayTimeButton.Name = "dayTimeButton";
            this.dayTimeButton.Size = new System.Drawing.Size(276, 23);
            this.dayTimeButton.TabIndex = 3;
            this.dayTimeButton.Text = "Показать время суток для введенного времени";
            this.dayTimeButton.UseVisualStyleBackColor = true;
            this.dayTimeButton.Click += new System.EventHandler(this.dayTimeButton_Click);
            // 
            // inputButton
            // 
            this.inputButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputButton.Location = new System.Drawing.Point(179, 12);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(139, 23);
            this.inputButton.TabIndex = 4;
            this.inputButton.Text = "Ввести время из полей";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(207, 41);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(26, 20);
            this.hourBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(239, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // minuteBox
            // 
            this.minuteBox.Location = new System.Drawing.Point(258, 41);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(27, 20);
            this.minuteBox.TabIndex = 7;
            // 
            // saveCurrentTimeButton
            // 
            this.saveCurrentTimeButton.Location = new System.Drawing.Point(176, 67);
            this.saveCurrentTimeButton.Name = "saveCurrentTimeButton";
            this.saveCurrentTimeButton.Size = new System.Drawing.Size(142, 23);
            this.saveCurrentTimeButton.TabIndex = 8;
            this.saveCurrentTimeButton.Text = "Ввести текущее время";
            this.saveCurrentTimeButton.UseVisualStyleBackColor = true;
            this.saveCurrentTimeButton.Click += new System.EventHandler(this.saveCurrentTimeButton_Click);
            // 
            // TimeAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 300);
            this.Controls.Add(this.saveCurrentTimeButton);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.dayTimeButton);
            this.Controls.Add(this.savedTimeButton);
            this.Controls.Add(this.dayTimeLabel);
            this.Controls.Add(this.savedTimeLabel);
            this.Name = "TimeAppForm";
            this.Text = "Время";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label savedTimeLabel;
        private System.Windows.Forms.Label dayTimeLabel;
        private System.Windows.Forms.Button savedTimeButton;
        private System.Windows.Forms.Button dayTimeButton;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.Button saveCurrentTimeButton;
    }
}

