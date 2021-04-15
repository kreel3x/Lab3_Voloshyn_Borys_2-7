using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;


namespace zadanie_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
   
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event Action myStartEvent = null;
        public event Action myStopEvent = null;
        public event Action myResetEvent = null;
        

        private void button_Start_Click(object sender, RoutedEventArgs e)
        {
            myStartEvent.Invoke();
        }

        private void button_Stop_Click(object sender, RoutedEventArgs e)
        {
            myStopEvent.Invoke();
        }

        private void button_Reset_Click(object sender, RoutedEventArgs e)
        {
            myResetEvent.Invoke();
        }

       
    }
}