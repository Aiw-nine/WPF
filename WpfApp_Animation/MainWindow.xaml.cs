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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Animation
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = new Storyboard();  // 故事板
            sb.Children.Add(CreateDoubleAnimation(b1, false, new RepeatBehavior(1), "Width", 30));
            sb.Children.Add(CreateDoubleAnimation(b2, false, new RepeatBehavior(5), "Width", 30));
            sb.Children.Add(CreateDoubleAnimation(b3, true, new RepeatBehavior(999), "Height", 30));
            sb.Children.Add(CreateDoubleAnimation(b4, true, RepeatBehavior.Forever, "Height", 30));

            sb.Begin();  // 启动动画
        }

        private Timeline CreateDoubleAnimation(UIElement element,bool autoReverse,RepeatBehavior repeat,string prop,double by)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;  // 动画的起始值
            //da.To = 100;  // 动画的结束值
            da.By = by;  // 在原有的基础上加这个值
            da.Duration = TimeSpan.FromSeconds(2);  // 动画时间
            da.RepeatBehavior = repeat;   // 播放次数
            da.AutoReverse = autoReverse;  // 每次迭代结束时是否按相反的顺序播放

            Storyboard.SetTarget(da, element);  // 绑定元素
            Storyboard.SetTargetProperty(da, new PropertyPath(prop));  // 绑定到依赖属性

            return da;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = new Storyboard();

            bb1.RenderTransform = new TranslateTransform(0, 0);  // 支持位移
            bb2.RenderTransform = new RotateTransform(0, 0, 0);  // 支持旋转

            //DoubleAnimation da = new DoubleAnimation();
            //da.By = 50;
            //da.Duration = TimeSpan.FromSeconds(2);

            //DoubleAnimation da2 = new DoubleAnimation();
            //da2.By = 360;
            //da2.Duration = TimeSpan.FromSeconds(2);

            //Storyboard.SetTarget(da, bb1);
            //Storyboard.SetTargetProperty(da, new PropertyPath("(UIElement.RenderTransform).(TranslateTransform.X)"));

            //Storyboard.SetTarget(da2, bb2);
            //Storyboard.SetTargetProperty(da, new PropertyPath("(UIElement.RenderTransform).(TranslateTransform.X)"));

            sb.Children.Add(CreateDoubleAnimation(bb1, false, new RepeatBehavior(1), "(UIElement.RenderTransform).(TranslateTransform.X)", 30));
            sb.Children.Add(CreateDoubleAnimation(bb2, false, new RepeatBehavior(1), "(UIElement.RenderTransform).(TranslateTransform.Y)", 30));
            sb.Children.Add(CreateDoubleAnimation(bb3, true, new RepeatBehavior(3), "(UIElement.RenderTransform).(RotateTransform.Angle)", 90));
            sb.Children.Add(CreateDoubleAnimation(bb4, true, RepeatBehavior.Forever, "(UIElement.RenderTransform).(RotateTransform.Angle)", 360));
            sb.Begin();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = new Storyboard();  // 故事板
            sb.Children.Add(CreateDoubleAnimation(bbb1, false, new RepeatBehavior(1), "Opacity", 1));
            sb.Children.Add(CreateDoubleAnimation(bbb2, false, new RepeatBehavior(5), "Opacity", 1));
            sb.Children.Add(CreateDoubleAnimation(bbb3, true, new RepeatBehavior(999), "Opacity", 1));
            sb.Children.Add(CreateDoubleAnimation(bbb4, true, RepeatBehavior.Forever, "Opacity", 1));
            sb.Begin();  // 启动动画
        }
    }
}
