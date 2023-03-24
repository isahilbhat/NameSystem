using System;
using System.Collections.Generic;
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

namespace NewApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
        }

        private void ButtonDeleteName_Click(object sender, RoutedEventArgs e)
        {
            //if(lstNames.Items.Contains(txtName.Text))
            //{
            //    lstNames.Items.Remove(txtName.Text);
            //    txtName.Clear();
            //}
            if (lstNames.SelectedItem != null)
            {
                lstNames.Items.Remove(lstNames.SelectedItem);
            }
        }

        private void ButtonUpdateName_Click(object sender, RoutedEventArgs e)
        {
            if (lstNames.SelectedItem != null && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Remove(lstNames.SelectedItem);
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
        }
    }
}
