using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace lab_OOP_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        static object locker = new object(); //заглушка
        static void Print()
        {
            lock (locker)
            {
                Thread.Sleep(100);
            }
        }

        static void Print1()
        {
            ChangeSort(array1);

            for (int i = 0; i < array1.Length; i++)
            {
                str1 += array1[i];
                Print();
            }
        }

        static void Print2()
        {
            ChoiceSort(array1);

            for (int i = 0; i < array1.Length; i++)
            {
                str2 += array1[i];
                Print();
            }
        }

        static void Print3()
        {
            InsertSort(array1);

            for (int i = 0; i < array1.Length; i++)
            {
                str3 += array1[i];
                Print();
            }
        }

        Thread thread = new Thread(Print);
        Thread thread1 = new Thread(Print1);
        Thread thread2 = new Thread(Print2);
        Thread thread3 = new Thread(Print3);

        static int[] array1;
        //static int[] array2;
        //static int[] array3;

        static string str1 = "";
        static string str2= "";
        static string str3 = "";

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            textBox_ChangeSort.Text = str1;
            textBox_ChoiceSort.Text = str2;
            textBox_InsertSort.Text = str3;

            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += 1;
                backgroundWorker1.ReportProgress(i);

                Print();
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    //thread.Abort();
                    //thread1.Abort();
                    //thread2.Abort();
                    //thread3.Abort();
                    break;
                }
            }
            e.Result = sum;
        }

        static void ChangeSort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - 1 - i; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
        }

        static void ChoiceSort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                int indMin = i;
                int min = A[indMin];

                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < min)
                    {
                        indMin = j;
                        min = A[j];
                    }
                    A[indMin] = A[i];
                    A[i] = min;
                }
            }
        }

        static void InsertSort(int[] A) 
        {
            for (int i = 1; i < A.Length; i++)
            {
                int elem = A[i];
                int pos = 0;

                while (elem > A[pos]) pos++;

                for (int j = i - 1; j >= pos; j--) A[j + 1] = A[j];
                A[pos] = elem;
            }
        }

        [Obsolete]
        private void btn_Start_Click(object sender, EventArgs e)
        {
            thread.Start();
            thread1.Start();
            thread2.Start();
            thread3.Start();
            //thread.Start();
            if (!backgroundWorker1.IsBusy || thread.ThreadState == ThreadState.Unstarted)
            {
                backgroundWorker1.RunWorkerAsync();
                
            }

            //if (thread.ThreadState == ThreadState.Unstarted)
            //{
            //    MessageBox.Show("поток не запущен");
            //}
            //else if(thread.ThreadState == ThreadState.Stopped)
            //{
            //    thread.Resume();
            //}
        }

        //bool flag = true;

        [Obsolete]
        private void btn_Pause_Click(object sender, EventArgs e)
        {
            //thread.Suspend();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
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
                    MessageBox.Show("Промежуток цифр от 1 до 7");
                }
                else 
                {
                    array1 = new int[n];

                    for (int i = 0; i < array1.Length; i++)
                    {
                        array1[i] = random.Next(0, 50);
                    }
                    for (int i = 0; i < array1.Length; i++)
                    {
                        textBox_Result.Text += array1[i].ToString() + "  ";
                    }

                    //for (int i = 0; i < array1.Length; i++)
                    //{
                    //    array2[i] = array1[i];
                    //    array3[i] = array1[i];
                    //}
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled /*|| thread.ThreadState == ThreadState.Stopped*/)
            {
                MessageBox.Show("Отмена");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                MessageBox.Show("Выполненно");
            }
        }
    }
}