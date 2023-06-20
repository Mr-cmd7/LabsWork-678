using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Wpf.Ui.Controls;

namespace LabWork_678
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UiWindow
    {
        List<int> positiveNumbers = new();
        List<int> negativeNumbers = new();

        LinkedQueue<double> linkedQueue = new();

        TList<int> list = new TList<int>();
        


        public MainWindow()
        {
            InitializeComponent();
            listbx0.ItemsSource = positiveNumbers;
            listbx1.ItemsSource = negativeNumbers;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                list.InsertBefore(random.Next(0, 100));
            }
            foreach (var item in list)
            {
                Out.Items.Add(item);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var inputString = txtBox.Text;
            var inputArray = inputString.Split(' ');
            foreach (var el in inputArray)
            {
                int n;
                bool success = int.TryParse(el, out n);
                if (success)
                {
                    if (n >= 0) positiveNumbers.Add(n);
                    else negativeNumbers.Add(n);
                }
            }
            listbx0.Items.Refresh();
            listbx1.Items.Refresh();

            txtBlP.Text = positiveNumbers.Sum().ToString();
            txtBlM.Text = negativeNumbers.Sum().ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            var inputString = txtBox7.Text;
            var inputArray = inputString.Split(' ');
            foreach (var el in inputArray)
            {
                double n;
                bool success = double.TryParse(el, out n);
                if (success)
                {
                    linkedQueue.Enqueue(n);
                }
            }
            Refresh();
            txtBox7.Text = "";
        }
        private void Refresh()
        {
            lsBox7.Items.Clear();
            foreach (var item in linkedQueue)
            {
                lsBox7.Items.Add(item);
            }
            txt7.Text = linkedQueue.Sum().ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            linkedQueue.Dequeue();
            Refresh();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Out.Items.Clear();
            foreach (var item in list)
            {
                if (item % 2 == 1)
                {
                    list.InsertBefore(item);
                }
            }
            foreach(var item in list)
            {
                Out.Items.Add(item);
            }
        }
    }
}
