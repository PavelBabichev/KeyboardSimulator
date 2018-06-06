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

namespace KeyboardSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        int i = 0;
        int fails = 0;
        string str;
        DateTime start;
        DateTime stop;
        TimeSpan elapsed = new TimeSpan();
        int chars = 0;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            changeKeyboardLayout(Console.CapsLock);
            ResizeMode = ResizeMode.NoResize;
        }

        void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
                changeKeyboardLayout(true);
            foreach (Button item in buttonsArea.Children)
            {
                    item.Foreground = Brushes.Black;
            }
        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.CapsLock||e.Key==Key.LeftShift||e.Key==Key.RightShift)
                changeKeyboardLayout(true);
            else if (returnsChar(e) == str[i])
            {
                if (str[i] == ' ')
                {
                    btnSpace.Foreground = Brushes.White;
                    btnSpace1.Foreground = Brushes.White;
                }
                else
                {
                    foreach (Button item in buttonsArea.Children)
                    {
                        if (item.Content.ToString() == str[i].ToString())
                            item.Foreground = Brushes.White;
                    }
                }
                string temp = txtWrite.Text + str[i];
                txtWrite.Text = temp;
                i++;
                chars++;
            }
            else fails++;
            txtFails.Text = fails.ToString();
            if (chars > 0)
            {
                stop = DateTime.Now;
                elapsed = stop.Subtract(start);
                txtSpeed.Text = (chars * 60 / elapsed.Seconds).ToString();
            }
            if ((i+1) == str.Length)
            {
                MessageBox.Show("Fails - " + fails.ToString() + " Speed - " + txtSpeed.Text);
                Button_Click_Stop(null, null);
            }
        }
        char returnsChar(KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.A:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'A';
                    else return 'a';
                    break;
                case Key.B:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'B';
                    else return 'b';
                    break;
                case Key.C:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'C';
                    else return 'c';
                    break;
                case Key.D:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'D';
                    else return 'd';
                    break;
                case Key.D0:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ')';
                    else return '0';
                    break;
                case Key.D1:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '!';
                    else return '1';
                    break;
                case Key.D2:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '@';
                    else return '2';
                    break;
                case Key.D3:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '#';
                    else return '3';
                    break;
                case Key.D4:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '$';
                    else return '4';
                    break;
                case Key.D5:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '%';
                    else return '5';
                    break;
                case Key.D6:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '^';
                    else return '6';
                    break;
                case Key.D7:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '&';
                    else return '7';
                    break;
                case Key.Enter:
                    return '\n';
                case Key.D8:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '*';
                    else return '8';
                    break;
                case Key.D9:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '(';
                    else return '9';
                    break;
                case Key.E:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'E';
                    else return 'e';
                    break;
                case Key.F:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'F';
                    else return 'f';
                    break;
                case Key.G:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'G';
                    else return 'g';
                    break;
                case Key.H:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'H';
                    else return 'h';
                    break;
                case Key.I:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'I';
                    else return 'i';
                    break;
                case Key.J:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'J';
                    else return 'j';
                    break;
                case Key.K:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'K';
                    else return 'k';
                    break;
                case Key.L:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'L';
                    else return 'l';
                    break;
                case Key.M:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'M';
                    else return 'm';
                    break;
                case Key.N:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'N';
                    else return 'n';
                    break;
                case Key.O:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'O';
                    else return 'o';
                    break;
                case Key.Oem1:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ':';
                    else return ';';
                    break;
                case Key.Oem3:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '~';
                    else return '`';
                    break;
                case Key.Oem5:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '|';
                    else return '\\';
                    break;
                case Key.Oem6:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '}';
                    else return ']';
                    break;
                case Key.OemComma:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '<';
                    else return ',';
                    break;
                case Key.OemMinus:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '_';
                    else return '-';
                    break;
                case Key.OemOpenBrackets:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '{';
                    else return '[';
                    break;
                case Key.OemPeriod:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '>';
                    else return '.';
                    break;
                case Key.OemPlus:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '+';
                    else return '=';
                    break;
                case Key.OemQuestion:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '?';
                    else return '/';
                    break;
                case Key.OemQuotes:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return '"';
                    else return '\'';
                    break;
                case Key.P:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'P';
                    else return 'p';
                    break;
                case Key.Q:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'Q';
                    else return 'q';
                    break;
                case Key.R:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'R';
                    else return 'r';
                    break;
                case Key.S:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'S';
                    else return 's';
                    break;
                case Key.Space:
                    return ' ';
                    break;
                case Key.T:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'T';
                    else return 't';
                    break;
                case Key.U:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'U';
                    else return 'u';
                    break;
                case Key.V:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'V';
                    else return 'v';
                    break;
                case Key.W:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'W';
                    else return 'w';
                    break;
                case Key.X:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'X';
                    else return 'x';
                    break;
                case Key.Y:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'Y';
                    else return 'y';
                    break;
                case Key.Z:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return 'Z';
                    else return 'z';
                    break;
                default:
                    return (char)1;
                    break;
            }
        }

        private void Button_Click_Start(object sender, RoutedEventArgs e)
        {
            //TODO сделать генерацию строки
            //и настроить чекбокс и слайдер
            txtRead.Text = "lorem ipsum \ndolor sit amet.";
            str = txtRead.Text;
            start = DateTime.Now;
            this.KeyDown += MainWindow_KeyDown;
            this.KeyUp += MainWindow_KeyUp;
            btnStop.IsEnabled = true;
            btnStart.IsEnabled = false;

        }

        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            this.KeyDown -= MainWindow_KeyDown;
            this.KeyUp -= MainWindow_KeyUp;
            btnStop.IsEnabled = false;
            btnStart.IsEnabled = true;
            txtSpeed.Text = "0";
            txtFails.Text = "0";
            txtRead.Text = "";
            txtWrite.Text = "";
            i = 0;
            fails = 0;
            chars = 0;
        }
        void changeKeyboardLayout(bool up)
        {
            if (up)
            {
                foreach (Button item in buttonsArea.Children)
                {
                    if (item.Visibility == Visibility.Visible)
                        item.Visibility = Visibility.Hidden;
                    else
                        item.Visibility = Visibility.Visible;
                }
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtSlider.Text = (((int)e.NewValue/5)*5).ToString();
        }
    }
}
