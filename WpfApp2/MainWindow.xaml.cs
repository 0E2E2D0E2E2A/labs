using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    class electronicKettle
    {
        public string Name { get; set; }
        public string Power { get; set; }
        public string Volume { get; set; }
        public string Color { get; set; }
        

        public electronicKettle(string name, string power, string volume, string color)
        {
            this.Name = name;
            this.Power = power;
            this.Volume = volume;
            this.Color = color;
        }
    }

    public partial class MainWindow : Window
    {
        ObservableCollection<electronicKettle> items;

        public MainWindow()
        {
            InitializeComponent();

            items = new ObservableCollection<electronicKettle>();

            dataGrid.ItemsSource = items;
        }

        private void Add_btn_Click_1_Click(object sender, RoutedEventArgs e)
        {
            string name = textBox_Name.Text;
            string power = textBox_Power.Text;
            string volume = textBox_Volume.Text;
            string color = textBox_Color.Text;

            items.Add(new electronicKettle(name, power, volume, color));


            textBox_Name.Text = null; 
            textBox_Power.Text = null; 
            textBox_Volume.Text = null; 
            textBox_Color.Text = null;

            //foreach (Control c in Controls)
            //{
            //    if (c is TextBox)
            //    {
            //        ((TextBox)c).Text = null;
            //    }
            //}
        }

        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                var index = dataGrid.SelectedIndex;

                dataGrid.Items.RemoveAt(index);
            }
        }

        private void delete_btn_Click_1_Click(object sender, RoutedEventArgs e)
        {
            var index = dataGrid.SelectedIndex;

            try
            {
                //dataGrid.Items.RemoveAt(index);
                //dataGrid.Items[index] = null;
                items.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("Ошибка! Вы не выбрали элемент, который нужно удалить");
            }
        }
    }
}
