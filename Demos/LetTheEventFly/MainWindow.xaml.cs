using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace LetTheEventFly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Class1 class1;
        private Class2 class2;

        public MainWindow()
        {
            InitializeComponent();

            class1 = new Class1();
            class1.SomeEvent += OnSomeEvent;
        }

        private void OnSomeEvent(int a, int b, int c, string d)
        {
            Debug.WriteLine($"{a} ! {b} ! {c} ! {d}");
        }

        private void RaiseEvent_button_Click(object sender, RoutedEventArgs e)
        {
            class1.RaiseSomeEvent();
        }

        private void StartClass2Thread_button_Click(object sender, RoutedEventArgs e)
        {
            class2 = new Class2();
            class2.SomeEvent += OnSomeEvent;
        }
    }
}
