namespace Csharp_GuessWordGame
{
    partial class Form1
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
            this.label_word = new System.Windows.Forms.Label();
            this.textBox_guess = new System.Windows.Forms.TextBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_word
            // 
            this.label_word.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_word.ForeColor = System.Drawing.Color.White;
            this.label_word.Location = new System.Drawing.Point(30, 22);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(388, 63);
            this.label_word.TabIndex = 0;
            this.label_word.Text = "Word";
            this.label_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_guess
            // 
            this.textBox_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_guess.Location = new System.Drawing.Point(30, 104);
            this.textBox_guess.Name = "textBox_guess";
            this.textBox_guess.Size = new System.Drawing.Size(388, 45);
            this.textBox_guess.TabIndex = 1;
            this.textBox_guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_next.Enabled = false;
            this.button_next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_next.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next.Location = new System.Drawing.Point(30, 174);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(388, 68);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_start.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(30, 264);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(388, 68);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.Color.Peru;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.ForeColor = System.Drawing.Color.White;
            this.label_result.Location = new System.Drawing.Point(30, 362);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(388, 63);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "Result";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_score.Location = new System.Drawing.Point(202, 455);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(39, 29);
            this.label_score.TabIndex = 5;
            this.label_score.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zhumaev Baizak COM 21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.textBox_guess);
            this.Controls.Add(this.label_word);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.TextBox textBox_guess;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label1;
    }
}

