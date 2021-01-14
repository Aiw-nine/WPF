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
using System.Windows.Shapes;

namespace WpfApp_Adorner
{
    /// <summary>
    /// TwoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TwoWindow : Window
    {
        public TwoWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // 遍历获取子级装饰层
            foreach (UIElement item in myPanel.Children)
            {
                // 获取装饰层,如果未发现装饰层，该方法将返回 null
                var layer = AdornerLayer.GetAdornerLayer(item);
                // 添加装饰器
                layer.Add(new TwoAdorner(item));
            }

                
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            // 遍历获取子级装饰层
            foreach (UIElement item in myPanel.Children)
            {
                var layer = AdornerLayer.GetAdornerLayer(item);
                var arr = layer.GetAdorners(item);
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
}
