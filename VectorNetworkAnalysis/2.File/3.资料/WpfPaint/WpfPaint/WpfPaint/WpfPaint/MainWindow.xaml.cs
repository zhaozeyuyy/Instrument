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

namespace WpfPaint
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private MinuteQuoteViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bitmap_MouseMove(object sender, MouseEventArgs e)
        {
            vm = new MinuteQuoteViewModel();
            int tmp = random.Next(600);
            vm.LastPx = tmp;
            this.bitmap.LatestQuote = vm;
        }
    }
}
