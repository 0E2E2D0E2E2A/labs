namespace lab_OOP_2_3
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox_ChangeSort = new System.Windows.Forms.TextBox();
            this.textBox_ChoiceSort = new System.Windows.Forms.TextBox();
            this.textBox_InsertSort = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox_Random = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Generation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // textBox_ChangeSort
            // 
            this.textBox_ChangeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ChangeSort.Location = new System.Drawing.Point(16, 114);
            this.textBox_ChangeSort.Multiline = true;
            this.textBox_ChangeSort.Name = "textBox_ChangeSort";
            this.textBox_ChangeSort.Size = new System.Drawing.Size(365, 93);
            this.textBox_ChangeSort.TabIndex = 0;
            // 
            // textBox_ChoiceSort
            // 
            this.textBox_ChoiceSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ChoiceSort.Location = new System.Drawing.Point(387, 114);
            this.textBox_ChoiceSort.Multiline = true;
            this.textBox_ChoiceSort.Name = "textBox_ChoiceSort";
            this.textBox_ChoiceSort.Size = new System.Drawing.Size(365, 93);
            this.textBox_ChoiceSort.TabIndex = 1;
            // 
            // textBox_InsertSort
            // 
            this.textBox_InsertSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_InsertSort.Location = new System.Drawing.Point(761, 114);
            this.textBox_InsertSort.Multiline = true;
            this.textBox_InsertSort.Name = "textBox_InsertSort";
            this.textBox_InsertSort.Size = new System.Drawing.Size(365, 93);
            this.textBox_InsertSort.TabIndex = 2;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Start.Location = new System.Drawing.Point(1132, 112);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(149, 40);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Начать";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Pause.Location = new System.Drawing.Point(1132, 160);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(149, 40);
            this.btn_Pause.TabIndex = 5;
            this.btn_Pause.Text = "Пауза";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Stop.Location = new System.Drawing.Point(1132, 206);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(149, 40);
            this.btn_Stop.TabIndex = 6;
            this.btn_Stop.Text = "Стоп";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 213);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1112, 33);
            this.progressBar1.TabIndex = 7;
            // 
            // textBox_Random
            // 
            this.textBox_Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Random.Location = new System.Drawing.Point(430, 30);
            this.textBox_Random.Multiline = true;
            this.textBox_Random.Name = "textBox_Random";
            this.textBox_Random.Size = new System.Drawing.Size(122, 40);
            this.textBox_Random.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите количество случайных чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Метод обмена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(386, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Метод выбора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(757, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Метод вставок";
            // 
            // btn_Generation
            // 
            this.btn_Generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Generation.Location = new System.Drawing.Point(558, 30);
            this.btn_Generation.Name = "btn_Generation";
            this.btn_Generation.Size = new System.Drawing.Size(149, 40);
            this.btn_Generation.TabIndex = 13;
            this.btn_Generation.Text = "Создать";
            this.btn_Generation.UseVisualStyleBackColor = true;
            this.btn_Generation.Click += new System.EventHandler(this.btn_Generation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(756, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Полученный массив";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Result.Location = new System.Drawing.Point(963, 32);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(318, 40);
            this.textBox_Result.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.btn_Generation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Random);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.textBox_InsertSort);
            this.Controls.Add(this.textBox_ChoiceSort);
            this.Controls.Add(this.textBox_ChangeSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox_ChangeSort;
        private System.Windows.Forms.TextBox textBox_ChoiceSort;
        private System.Windows.Forms.TextBox textBox_InsertSort;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox_Random;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Generation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Result;
    }
}

