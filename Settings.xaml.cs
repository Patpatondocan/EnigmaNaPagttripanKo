using EnigmaManipulator;
using System;
using System.Collections.Generic;
using System.Activities.Presentation.View;
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
using System.Windows.Shapes;
using System.IO;

namespace EnigmaTrial1
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        MainWindow mn = new MainWindow();
        public bool setBtnIsClicked = false;
        public Settings()
        {
            InitializeComponent();
        }

        public void update()
        {
            txtNum1.Text = Manipulator.ringSelection[0].ToString();
            txtNum2.Text = Manipulator.ringSelection[1].ToString();
            txtNum3.Text = Manipulator.ringSelection[2].ToString();
            txtNum4.Text = Manipulator.ringSettings[0].ToString();
            txtNum5.Text = Manipulator.ringSettings[1].ToString();
            txtNum6.Text = Manipulator.ringSettings[2].ToString();
        }

        public void checkDuplicates()
        {
            if (Manipulator.ringSelection[0] == Manipulator.ringSelection[1] || Manipulator.ringSelection[1] == Manipulator.ringSelection[2] || Manipulator.ringSelection[0] == Manipulator.ringSelection[2])
            {
                saveBtn.IsEnabled = false;
            }
            else
            {
                saveBtn.IsEnabled = true;
            }
        }

        public void add1_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSelectionCounter(0, '+');
            update();
            checkDuplicates();
        }

        public void minus1_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSelectionCounter(0, '-');
            update();
            checkDuplicates();
        }

        public void add2_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSelectionCounter(1, '+');
            update();
            checkDuplicates();
        }

        public void add3_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSelectionCounter(2, '+');
            update();
            checkDuplicates();
        }

        public void minus2_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSelectionCounter(1, '-');
            update();
            checkDuplicates();
        }

        public void minus3_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSelectionCounter(2, '-');
            update();
            checkDuplicates();
        }

        public void add4_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSettingsCounter(0, '+');
            update();
        }

        public void add5_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSettingsCounter(1, '+');
            update();
        }

        public void add6_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSettingsCounter(2, '+');
            update();
        }

        public void minus4_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSettingsCounter(0, '-');
            update();
        }

        public void minus5_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSettingsCounter(1, '-');
            update();
        }

        public void minus6_Click(object sender, RoutedEventArgs e)
        {
            Manipulator.ringSettingsCounter(2, '-');
            update();
        }

        public void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            setBtnIsClicked = true;
            if (MessageBox.Show("Are you sure you want to LOCK THE SELECTION?", "Enigma", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Enigma will hide the setup.\nPlease TAKE NOTE of the setup of your Enigma Machine", "Enigma", MessageBoxButton.OK, MessageBoxImage.Information);
                Manipulator.rotorOffset();
                mn.exitBtn.IsEnabled = true;
                windowSettings.Hide();
                mn.fileDirectoryTbx.IsEnabled = false;
                mn.userTbx.Focus();
            }
        }
    }
}
