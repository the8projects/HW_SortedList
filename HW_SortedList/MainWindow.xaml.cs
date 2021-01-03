using System;
using System.Collections;
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

namespace HW_SortedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string strValue = "";
            if (int.TryParse(txtKey.Text.Trim(), out int i))
            {
                sortedList.Add(i, txtValue.Text.Trim());
                ICollection collection = sortedList.Keys;

                foreach (int key in collection)
                {
                    strValue += sortedList[key].ToString() + "@";
                }
                strValue = strValue.Replace("@", Environment.NewLine);
            }
            else
            {
                strValue = "Please enter key as number.";
            }
            
            MessageBox.Show(strValue);
            txtClear();
        }

        private void txtClear()
        {
            txtKey.Clear();
            txtValue.Clear();
        }
    }
}
