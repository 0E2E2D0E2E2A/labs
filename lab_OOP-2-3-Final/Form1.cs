using System;
using System.Diagnostics;
using System.Threading;

namespace lab_OOP_2_3_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        static object _lock = new object(); //заглушка

        static int[] array1;
        static int[] array2;
        static int[] array3;

        Thread _threadChange;
        Thread _threadChoice;
        Thread _threadInsert;
        ManualResetEvent _shutdownEvent = new ManualResetEvent(false);
        ManualResetEvent _pauseEvent = new ManualResetEvent(true);

        void ChangeSort()
        {
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array1.Length - 1 - i; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        int temp = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temp;
                    }
                    //Form.Invoke() - этот метод выполн€ет указанный делегат в том потоке, в котором была создана форма.
                    this.Invoke(new MethodInvoker(() =>
                    {
                        textBox_ChangeSort.Text = array1[i + 1].ToString();
                    }));
                    
                }
            }
        }

        void ChoiceSort()
        {
            for (int i = 0; i < array2.Length; i++)
            {
                int indMin = i;
                int min = array2[indMin];

                for (int j = i + 1; j < array2.Length; j++)
                {
                    if (array2[j] < min)
                    {
                        indMin = j;
                        min = array2[j];
                    }
                    array2[indMin] = array2[i];
                    array2[i] = min;

                    //Form.Invoke() - этот метод выполн€ет указанный делегат в том потоке, в котором была создана форма.
                    this.Invoke(new MethodInvoker(() =>
                    {
                        textBox_ChoiceSort.Text = array2[i].ToString();
                    }));

                    

                }
            }
        }

        void InsertSort()
        {
            for (int i = 1; i < array3.Length; i++)
            {
                int elem = array3[i];
                int pos = 0;

                while (elem > array3[pos]) pos++;

                for (int j = i - 1; j >= pos; j--) array3[j + 1] = array3[j];
                array3[pos] = elem;

                //Form.Invoke() - этот метод выполн€ет указанный делегат в том потоке, в котором была создана форма.
                this.Invoke(new MethodInvoker(() =>
                {
                    textBox_InsertSort.Text = array3[i].ToString();
                }));
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    break;
                }
                else
                {
                    backgroundWorker1.ReportProgress(i);
                    Thread.Sleep(10);

                    ChangeSort();
                    ChoiceSort();
                    InsertSort();

                    if (i == 100)
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            textBox_InsertSort.Clear();
                            textBox_ChangeSort.Clear();
                            textBox_ChoiceSort.Clear();
                        }));

                        for (int j = 0; j < array1.Length; j++)
                        {
                            this.Invoke(new MethodInvoker(() => {
                                textBox_ChangeSort.Text += array1[j] + " ";
                                textBox_ChoiceSort.Text += array2[j] + " ";
                                textBox_InsertSort.Text += array3[j] + " ";
                            }));
                            
                        }
                    }
                }
            }
        }

        

        private void btn_Generation_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();

            Random random = new Random();

            try
            {
                int n = int.Parse(textBox_Random.Text);

                if (n > 7)
                {
                    MessageBox.Show("ѕромежуток цифр от 1 до 7");
                }
                else
                {
                    array1 = new int[n];
                    array2 = new int[n];
                    array3 = new int[n];

                    for (int i = 0; i < array1.Length; i++)
                    {
                        array1[i] = random.Next(0, 50);
                    }
                    for (int i = 0; i < array1.Length; i++)
                    {
                        textBox_Result.Text += array1[i].ToString() + "  ";
                    }

                    for (int i = 0; i < array1.Length; i++)
                    {
                        array2[i] = array1[i];
                        array3[i] = array1[i];
                    }
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy /*|| thread.ThreadState == ThreadState.Unstarted*/)
            {
                backgroundWorker1.RunWorkerAsync();

                _threadChange = new Thread(ChangeSort);
                _threadChoice = new Thread(ChoiceSort);
                _threadInsert = new Thread(InsertSort);

                _threadChange.Start();
                _threadChoice.Start();
                _threadInsert.Start();
            }
        }

        bool PauseFlag = true;

        Thread threadPause;

        public void Pause()
        {
            while (PauseFlag == true)
            {
                _pauseEvent.WaitOne(Timeout.Infinite);
            }

            //_pauseEvent.Reset();
            
        }

        //public void Resume()
        //{
        //    _pauseEvent.Set();
        //    PauseFlag = false;
        //}

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            threadPause = new Thread(Pause);
            threadPause.Start();

            if (PauseFlag == true) 
            {  
                _pauseEvent.Reset();
                PauseFlag = false;
            }
            else if(PauseFlag == false) 
            {
                _pauseEvent.Set();
                PauseFlag = true;
            }

            _pauseEvent.Set();
            threadPause.Join();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();

                _shutdownEvent.Set();

                // Make sure to resume any paused threads
                _pauseEvent.Set();

                // Wait for the thread to exit
                _threadInsert.Join();
                _threadChange.Join();
                _threadChoice.Join();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) MessageBox.Show("ќтмена");

            else if (e.Error != null) MessageBox.Show("ќшибка");

            else MessageBox.Show("¬ыполненно");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}