using EnigmaManipulator;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace EnigmaTrial1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static OpenFileDialog ofd = new OpenFileDialog();
        public static Settings Sett = new Settings();
        SolidColorBrush keyOrigColor = new SolidColorBrush();
        SolidColorBrush keyOutputColor = new SolidColorBrush();
        LinearGradientBrush labelOrigColor = new LinearGradientBrush();
        SolidColorBrush labelOutputColor = new SolidColorBrush();
        Ellipse[] column0 = new Ellipse[91];
        Label[] keyLabels = new Label[91];

        public MainWindow()
        {
            InitializeComponent();
            keyOrigColor.Color = Color.FromRgb(244, 244, 255);
            keyOutputColor.Color = Color.FromRgb(97, 0, 0);
            labelOrigColor.StartPoint = new Point(0.5, 0);
            labelOrigColor.EndPoint = new Point(0.5, 1);
            labelOrigColor.GradientStops.Add(new GradientStop(Color.FromRgb(121, 133, 249), 0));
            labelOrigColor.GradientStops.Add(new GradientStop(Colors.Black, 1));
            labelOutputColor.Color = Colors.White;

            column0[0] = _E1;
            column0[1] = _E2;
            column0[2] = _E3;
            column0[3] = _E4;
            column0[4] = _E5;
            column0[5] = _E6;
            column0[6] = _E7;
            column0[7] = _E8;
            column0[8] = _E9;
            column0[9] = _E10;
            column0[10] = _E11;
            column0[11] = _E12;
            column0[12] = _E13;
            column0[13] = _E14;
            column0[14] = _E15;
            column0[15] = _E16;
            column0[16] = _E17;
            column0[17] = _E18;
            column0[18] = _E19;
            column0[19] = _E20;
            column0[20] = _E21;
            column0[21] = _E22;
            column0[22] = _E23;
            column0[23] = _E24;
            column0[24] = _E25;
            column0[25] = _E26;
            column0[26] = _E27;
            column0[27] = _E28;
            column0[28] = _E29;
            column0[29] = _E30;
            column0[30] = _E31;
            column0[31] = _E32;
            column0[32] = _E33;
            column0[33] = _E34;
            column0[34] = _E35;
            column0[35] = _E36;
            column0[36] = _E37;
            column0[37] = _E38;
            column0[38] = _E39;
            column0[39] = _E40;
            column0[40] = _E41;
            column0[41] = _E42;
            column0[42] = _E43;
            column0[43] = _E44;
            column0[44] = _E45;
            column0[45] = _E46;
            column0[46] = _E47;
            column0[47] = _E48;
            column0[48] = _E49;
            column0[49] = _E50;
            column0[50] = _E51;
            column0[51] = _E52;
            column0[52] = _E53;
            column0[53] = _E54;
            column0[54] = _E55;
            column0[55] = _E56;
            column0[56] = _E57;
            column0[57] = _E58;
            column0[58] = _E59;
            column0[59] = _E60;
            column0[60] = _E61;
            column0[61] = _E62;
            column0[62] = _E63;
            column0[63] = _E64;
            column0[64] = _E65;
            column0[65] = _E66;
            column0[66] = _E67;
            column0[67] = _E68;
            column0[68] = _E69;
            column0[69] = _E70;
            column0[70] = _E71;
            column0[71] = _E72;
            column0[72] = _E73;
            column0[73] = _E74;
            column0[74] = _E75;
            column0[75] = _E76;
            column0[76] = _E77;
            column0[77] = _E78;
            column0[78] = _E79;
            column0[79] = _E80;
            column0[80] = _E81;
            column0[81] = _E82;
            column0[82] = _E83;
            column0[83] = _E84;
            column0[84] = _E85;
            column0[85] = _E86;
            column0[86] = _E87;
            column0[87] = _E88;
            column0[88] = _E89;
            column0[89] = _E90;
            column0[90] = _E91;

            keyLabels[0] = _label1;
            keyLabels[1] = _label2;
            keyLabels[2] = _label3;
            keyLabels[3] = _label4;
            keyLabels[4] = _label5;
            keyLabels[5] = _label6;
            keyLabels[6] = _label7;
            keyLabels[7] = _label8;
            keyLabels[8] = _label9;
            keyLabels[9] = _label10;
            keyLabels[10] = _label11;
            keyLabels[11] = _label12;
            keyLabels[12] = _label13;
            keyLabels[13] = _label14;
            keyLabels[14] = _label15;
            keyLabels[15] = _label16;
            keyLabels[16] = _label17;
            keyLabels[17] = _label18;
            keyLabels[18] = _label19;
            keyLabels[19] = _label20;
            keyLabels[20] = _label21;
            keyLabels[21] = _label22;
            keyLabels[22] = _label23;
            keyLabels[23] = _label24;
            keyLabels[24] = _label25;
            keyLabels[25] = _label26;
            keyLabels[26] = _label27;
            keyLabels[27] = _label28;
            keyLabels[28] = _label29;
            keyLabels[29] = _label30;
            keyLabels[30] = _label31;
            keyLabels[31] = _label32;
            keyLabels[32] = _label33;
            keyLabels[33] = _label34;
            keyLabels[34] = _label35;
            keyLabels[35] = _label36;
            keyLabels[36] = _label37;
            keyLabels[37] = _label38;
            keyLabels[38] = _label39;
            keyLabels[39] = _label40;
            keyLabels[40] = _label41;
            keyLabels[41] = _label42;
            keyLabels[42] = _label43;
            keyLabels[43] = _label44;
            keyLabels[44] = _label45;
            keyLabels[45] = _label46;
            keyLabels[46] = _label47;
            keyLabels[47] = _label48;
            keyLabels[48] = _label49;
            keyLabels[49] = _label50;
            keyLabels[50] = _label51;
            keyLabels[51] = _label52;
            keyLabels[52] = _label53;
            keyLabels[53] = _label54;
            keyLabels[54] = _label55;
            keyLabels[55] = _label56;
            keyLabels[56] = _label57;
            keyLabels[57] = _label58;
            keyLabels[58] = _label59;
            keyLabels[59] = _label60;
            keyLabels[60] = _label61;
            keyLabels[61] = _label62;
            keyLabels[62] = _label63;
            keyLabels[63] = _label64;
            keyLabels[64] = _label65;
            keyLabels[65] = _label66;
            keyLabels[66] = _label67;
            keyLabels[67] = _label68;
            keyLabels[68] = _label69;
            keyLabels[69] = _label70;
            keyLabels[70] = _label71;
            keyLabels[71] = _label72;
            keyLabels[72] = _label73;
            keyLabels[73] = _label74;
            keyLabels[74] = _label75;
            keyLabels[75] = _label76;
            keyLabels[76] = _label77;
            keyLabels[77] = _label78;
            keyLabels[78] = _label79;
            keyLabels[79] = _label80;
            keyLabels[80] = _label81;
            keyLabels[81] = _label82;
            keyLabels[82] = _label83;
            keyLabels[83] = _label84;
            keyLabels[84] = _label85;
            keyLabels[85] = _label86;
            keyLabels[86] = _label87;
            keyLabels[87] = _label88;
            keyLabels[88] = _label89;
            keyLabels[89] = _label90;
            keyLabels[90] = _label91;
        }

        void color()
        {
            for (int x = 0; x < column0.Length; x++)
            {
                string output = outputTbx.Text.Last().ToString();
                string label = (string)keyLabels[x].Content;

                if (output == label)
                {
                    column0[x].Fill = keyOutputColor;
                    keyLabels[x].Foreground = labelOutputColor;
                }
                else if (output == " ")
                {
                    for (int y = 0; y < keyLabels.Length; y++)
                    {
                        if (y == 89)
                        {
                            column0[89].Fill = keyOutputColor;
                            keyLabels[89].Foreground = labelOutputColor;
                        }
                        else
                        {
                            column0[x].Fill = keyOrigColor;
                            keyLabels[x].Foreground = labelOrigColor;
                        }
                    }
                }
                else if (output != label)
                {
                    column0[x].Fill = keyOrigColor;
                    keyLabels[x].Foreground = labelOrigColor;
                }
            }
        }

        public void loadBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Comma Separated Values (*.csv;)|*.csv;";
            if (ofd.ShowDialog() == true)
            {
                fileDirectoryTbx.Text = ofd.FileName;

                if (fileDirectoryTbx.Text.Length > 0)
                {
                    Manipulator.ringSelection = new int[3] { 0, 0, 0 };
                    Manipulator.ringSettings = new int[3] { 0, 0, 0 };
                    Sett.update();
                    Manipulator.MyReader(fileDirectoryTbx.Text);
                    Manipulator.rotorSeparator();
                    changeSettingsBtn.IsEnabled = true;
                    MessageBox.Show("Rings File has been Read and Formatted successfully! Please Proceed with the setup.", "Enigma", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        public void changeSettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            userTbx.Focus();
            changeSettingsBtn.IsEnabled = false;
            loadBtn.IsEnabled = false;
            Sett.windowSettings.Topmost = true;
            Sett.windowSettings.Show();
            Sett.ringCount.Content = Manipulator.rotorCount();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void printBtn_Click(object sender, RoutedEventArgs e)
        {
            printBtn.IsEnabled = true;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, outputTbx.Text);
            MessageBox.Show("Encrypted Data Downloaded! >>> " + saveFileDialog.FileName);
        }

        public void userTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (Sett.setBtnIsClicked)
            {
                if (e.KeyboardDevice.Modifiers != ModifierKeys.Shift)
                {
                    switch (e.Key)
                    {
                        //SMALL - LETTERS....
                        case Key.A:
                            userTbx.Text += "a";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.B:
                            userTbx.Text += "b";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.C:
                            userTbx.Text += "c";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D:
                            userTbx.Text += "d";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.E:
                            userTbx.Text += "e";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.F:
                            userTbx.Text += "f";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.G:
                            userTbx.Text += "g";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.H:
                            userTbx.Text += "h";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.I:
                            userTbx.Text += "i";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.J:
                            userTbx.Text += "j";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.K:
                            userTbx.Text += "k";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.L:
                            userTbx.Text += "l";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.M:
                            userTbx.Text += "m";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.N:
                            userTbx.Text += "n";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.O:
                            userTbx.Text += "o";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.P:
                            userTbx.Text += "p";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Q:
                            userTbx.Text += "q";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.R:
                            userTbx.Text += "r";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.S:
                            userTbx.Text += "s";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.T:
                            userTbx.Text += "t";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.U:
                            userTbx.Text += "u";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.V:
                            userTbx.Text += "v";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.W:
                            userTbx.Text += "w";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.X:
                            userTbx.Text += "x";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Y:
                            userTbx.Text += "y";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Z:
                            userTbx.Text += "z";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;

                        //NUMBERS...
                        case Key.D1:
                            userTbx.Text += "1";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D2:
                            userTbx.Text += "2";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D3:
                            userTbx.Text += "3";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D4:
                            userTbx.Text += "4";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D5:
                            userTbx.Text += "5";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D6:
                            userTbx.Text += "6";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D7:
                            userTbx.Text += "7";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D8:
                            userTbx.Text += "8";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D9:
                            userTbx.Text += "9";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D0:
                            userTbx.Text += "0";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;

                        //OTHER CHARACTERS...
                        case Key.OemPlus:
                            userTbx.Text += "=";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.OemMinus:
                            userTbx.Text += "-";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.OemComma:
                            userTbx.Text += ",";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.OemPeriod:
                            userTbx.Text += ".";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Oem1:
                            userTbx.Text += ";";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Oem2:
                            userTbx.Text += "/";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Oem4:
                            userTbx.Text += "[";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Oem5:
                            userTbx.Text += "\\";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Oem6:
                            userTbx.Text += "]";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                    }
                }
                else
                {
                    switch (e.Key)
                    {
                        //BIG - LETTERS...
                        case Key.A:
                            userTbx.Text += "A";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.B:
                            userTbx.Text += "B";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.C:
                            userTbx.Text += "C";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D:
                            userTbx.Text += "D";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.E:
                            userTbx.Text += "E";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.F:
                            userTbx.Text += "F";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.G:
                            userTbx.Text += "G";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.H:
                            userTbx.Text += "H";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.I:
                            userTbx.Text += "I";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.J:
                            userTbx.Text += "J";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.K:
                            userTbx.Text += "K";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.L:
                            userTbx.Text += "L";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.M:
                            userTbx.Text += "M";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.N:
                            userTbx.Text += "N";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.O:
                            userTbx.Text += "O";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.P:
                            userTbx.Text += "P";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Q:
                            userTbx.Text += "Q";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.R:
                            userTbx.Text += "R";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.S:
                            userTbx.Text += "S";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.T:
                            userTbx.Text += "T";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.U:
                            userTbx.Text += "U";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.V:
                            userTbx.Text += "V";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.W:
                            userTbx.Text += "W";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.X:
                            userTbx.Text += "X";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Y:
                            userTbx.Text += "Y";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Z:
                            userTbx.Text += "Z";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;

                        //SYMBOLS...
                        case Key.D1:
                            userTbx.Text += "!";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D2:
                            userTbx.Text += "@";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D3:
                            userTbx.Text += "#";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D4:
                            userTbx.Text += "$";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D5:
                            userTbx.Text += "%";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D6:
                            userTbx.Text += "^";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D7:
                            userTbx.Text += "&";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D8:
                            userTbx.Text += "*";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D9:
                            userTbx.Text += "(";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.D0:
                            userTbx.Text += ")";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;

                        //OTHER CHARACTERS...
                        case Key.OemPlus:
                            userTbx.Text += "+";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.OemMinus:
                            userTbx.Text += "_";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.OemComma:
                            userTbx.Text += "<";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.OemPeriod:
                            userTbx.Text += ">";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Oem1:
                            userTbx.Text += ":";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Oem2:
                            userTbx.Text += "?";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Oem4:
                            userTbx.Text += "{";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Oem5:
                            userTbx.Text += "|";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                        case Key.Oem6:
                            userTbx.Text += "}";
                            outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                            color();
                            break;
                    }
                }
            }
        }

        private void userTbx_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Sett.setBtnIsClicked)
            {
                switch (e.Key)
                {
                    case Key.Space:
                        userTbx.Text += " ";
                        outputTbx.Text += Manipulator.encryptedOutput(userTbx.Text.Last());
                        break;
                    case Key.Enter:
                        userTbx.Text += "\n";
                        outputTbx.Text += "\n";
                        break;
                }
            }
        }

        private void outputTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (outputTbx.Text != " ")
            {
                printBtn.IsEnabled = true;
            }
        }
    }
}
