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
using System.Windows.Threading;

namespace Containers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer Timer { get; set; }=new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            Timer.Interval = TimeSpan.FromMilliseconds(1);
            Timer.Tick += Timer_Tick;
            //Timer.Start();


            //stack panel
            //wrap panel
            //canvas 
            //dock panel
            //uniform grid arashdirma
            //grid
        }
        public int Degree { get; set; } = -90;
        private void Timer_Tick(object sender, EventArgs e)
        {
            Degree += 1;
            //myLbl.RenderTransform = new RotateTransform
            //{
            //    Angle = Degree
            //};
        }
    }
}
