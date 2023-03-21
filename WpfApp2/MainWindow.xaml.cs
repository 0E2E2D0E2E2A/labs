using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Xml.Linq;

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
        

        public electronicKettle(string Name, string Power, string Volume, string Color)
        {
            this.Name = Name;
            this.Power = Power;
            this.Volume = Volume;
            this.Color = Color;
        }
    }

    public partial class MainWindow : Window
    {
        ObservableCollection<electronicKettle> items;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            items = new ObservableCollection<electronicKettle>(); 
            dataGrid.ItemsSource = items;

            items.Add(new electronicKettle("name1", "power1", "volume1", "color1"));
            items.Add(new electronicKettle("name2", "power2", "volume2", "color2"));
            items.Add(new electronicKettle("name3", "power3", "volume3", "color3"));
            items.Add(new electronicKettle("name4", "power4", "volume4", "color4"));
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

        private void dataGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var items = dataGrid.SelectedItem as electronicKettle;

            //DataRowView data = (DataRowView)dataGrid.SelectedItems[0];
            //textBox_Name.Text = data.ToString();

            try
            {
                textBox_Name.Text = items.Name;
                textBox_Power.Text = items.Power;
                textBox_Volume.Text = items.Volume;
                textBox_Color.Text = items.Color;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Null");
            }
        }

    }
}