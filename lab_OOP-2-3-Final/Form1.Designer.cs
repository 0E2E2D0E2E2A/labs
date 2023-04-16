namespace lab_OOP_2_3_Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_Random = new TextBox();
            textBox_Result = new TextBox();
            textBox_ChangeSort = new TextBox();
            textBox_ChoiceSort = new TextBox();
            textBox_InsertSort = new TextBox();
            btn_Generation = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            btn_Start = new Button();
            btn_Pause = new Button();
            btn_Stop = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(439, 31);
            label1.TabIndex = 0;
            label1.Text = "Введите количество случайных чисел";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 106);
            label2.Name = "label2";
            label2.Size = new Size(176, 31);
            label2.TabIndex = 1;
            label2.Text = "Метод обмена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(788, 34);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(398, 106);
            label4.Name = "label4";
            label4.Size = new Size(178, 31);
            label4.TabIndex = 3;
            label4.Text = "Метод выбора";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(736, 106);
            label5.Name = "label5";
            label5.Size = new Size(178, 31);
            label5.TabIndex = 4;
            label5.Text = "Метод вставок";
            // 
            // textBox_Random
            // 
            textBox_Random.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Random.Location = new Point(464, 34);
            textBox_Random.Multiline = true;
            textBox_Random.Name = "textBox_Random";
            textBox_Random.Size = new Size(121, 31);
            textBox_Random.TabIndex = 5;
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Result.Location = new Point(887, 34);
            textBox_Result.Multiline = true;
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(309, 31);
            textBox_Result.TabIndex = 6;
            // 
            // textBox_ChangeSort
            // 
            textBox_ChangeSort.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ChangeSort.Location = new Point(10, 140);
            textBox_ChangeSort.Multiline = true;
            textBox_ChangeSort.Name = "textBox_ChangeSort";
            textBox_ChangeSort.Size = new Size(382, 68);
            textBox_ChangeSort.TabIndex = 7;
            // 
            // textBox_ChoiceSort
            // 
            textBox_ChoiceSort.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ChoiceSort.Location = new Point(398, 140);
            textBox_ChoiceSort.Multiline = true;
            textBox_ChoiceSort.Name = "textBox_ChoiceSort";
            textBox_ChoiceSort.Size = new Size(332, 70);
            textBox_ChoiceSort.TabIndex = 8;
            // 
            // textBox_InsertSort
            // 
            textBox_InsertSort.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_InsertSort.Location = new Point(736, 140);
            textBox_InsertSort.Multiline = true;
            textBox_InsertSort.Name = "textBox_InsertSort";
            textBox_InsertSort.Size = new Size(332, 68);
            textBox_InsertSort.TabIndex = 9;
            // 
            // btn_Generation
            // 
            btn_Generation.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Generation.Location = new Point(591, 34);
            btn_Generation.Name = "btn_Generation";
            btn_Generation.Size = new Size(111, 31);
            btn_Generation.TabIndex = 10;
            btn_Generation.TabStop = false;
            btn_Generation.Text = "Создать";
            btn_Generation.UseVisualStyleBackColor = true;
            btn_Generation.Click += btn_Generation_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(10, 216);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1069, 29);
            progressBar1.TabIndex = 11;
            // 
            // btn_Start
            // 
            btn_Start.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Start.Location = new Point(1085, 140);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(111, 31);
            btn_Start.TabIndex = 12;
            btn_Start.TabStop = false;
            btn_Start.Text = "Старт";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_Pause
            // 
            btn_Pause.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Pause.Location = new Point(1085, 177);
            btn_Pause.Name = "btn_Pause";
            btn_Pause.Size = new Size(111, 31);
            btn_Pause.TabIndex = 13;
            btn_Pause.TabStop = false;
            btn_Pause.Text = "Пауза";
            btn_Pause.UseVisualStyleBackColor = true;
            btn_Pause.Click += btn_Pause_Click;
            // 
            // btn_Stop
            // 
            btn_Stop.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Stop.Location = new Point(1085, 214);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(111, 31);
            btn_Stop.TabIndex = 14;
            btn_Stop.TabStop = false;
            btn_Stop.Text = "Стоп";
            btn_Stop.UseVisualStyleBackColor = true;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 258);
            Controls.Add(btn_Stop);
            Controls.Add(btn_Pause);
            Controls.Add(btn_Start);
            Controls.Add(progressBar1);
            Controls.Add(btn_Generation);
            Controls.Add(textBox_InsertSort);
            Controls.Add(textBox_ChoiceSort);
            Controls.Add(textBox_ChangeSort);
            Controls.Add(textBox_Result);
            Controls.Add(textBox_Random);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_Random;
        private TextBox textBox_Result;
        private TextBox textBox_ChangeSort;
        private TextBox textBox_ChoiceSort;
        private TextBox textBox_InsertSort;
        private Button btn_Generation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private Button btn_Start;
        private Button btn_Pause;
        private Button btn_Stop;
    }
}