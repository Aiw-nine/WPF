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

namespace WpfApp_Adorner
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // 获取装饰层,如果未发现装饰层，该方法将返回 null
            var layer = AdornerLayer.GetAdornerLayer(myBox);
            // 添加装饰器
            layer.Add(new OneAdorner(myBox));
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            // 获取装饰层
            var layer = AdornerLayer.GetAdornerLayer(myBox);
            var arr = layer.GetAdorners(myBox);
            if (arr != null)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    layer.Remove(arr[i]);
                }
            }
        }
    }
}
