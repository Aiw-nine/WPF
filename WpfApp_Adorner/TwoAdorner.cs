using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace WpfApp_Adorner
{
    public class TwoAdorner:Adorner
    {
        //这里必须调用基类的构造函数
        public TwoAdorner(UIElement adornedElement) : base(adornedElement) { }
        //通过复写onRender, 实现装饰器的呈现行为
        protected override void OnRender(DrawingContext drawingContext)
        {
            Rect adornedElementRect = new Rect(this.AdornedElement.RenderSize);

            Pen renderPen = new Pen(new SolidColorBrush(Colors.Red), 1.0);

            // Draw a circle at each corner.
            drawingContext.DrawLine(renderPen, new Point(adornedElementRect.TopLeft.X - 3, adornedElementRect.TopLeft.Y - 3), new Point(adornedElementRect.TopLeft.X + 5, adornedElementRect.TopLeft.Y - 3));
            drawingContext.DrawLine(renderPen, new Point(adornedElementRect.TopLeft.X - 3, adornedElementRect.TopLeft.Y - 3), new Point(adornedElementRect.TopLeft.X - 3, adornedElementRect.TopLeft.Y + 5));

            drawingContext.DrawLine(renderPen, new Point(adornedElementRect.TopRight.X + 3, adornedElementRect.TopRight.Y - 3), new Point(adornedElementRect.TopRight.X - 5, adornedElementRect.TopRight.Y - 3));
            drawingContext.DrawLine(renderPen, new Point(adornedElementRect.TopRight.X + 3, adornedElementRect.TopRight.Y - 3), new Point(adornedElementRect.TopRight.X + 3, adornedElementRect.TopRight.Y + 5));

            drawingContext.DrawLine(renderPen, new Point(adornedElementRect.BottomLeft.X - 3, adornedElementRect.BottomLeft.Y + 3), new Point(adornedElementRect.BottomLeft.X + 5, adornedElementRect.BottomLeft.Y + 3));
            drawingContext.DrawLine(renderPen, new Point(adornedElementRect.BottomLeft.X - 3, adornedElementRect.BottomLeft.Y + 3), new Point(adornedElementRect.BottomLeft.X - 3, adornedElementRect.BottomLeft.Y - 5));

            drawingContext.DrawLine(renderPen, new Point(adornedElementRect.BottomRight.X + 3, adornedElementRect.BottomRight.Y + 3), new Point(adornedElementRect.BottomRight.X - 5, adornedElementRect.BottomRight.Y + 3));
            drawingContext.DrawLine(renderPen, new Point(adornedElementRect.BottomRight.X + 3, adornedElementRect.BottomRight.Y + 3), new Point(adornedElementRect.BottomRight.X + 3, adornedElementRect.BottomRight.Y - 5));
        }
    }
}
