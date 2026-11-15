using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace RegIN_Kazakov.Classes
{
    public class Animation
    {
        public static void ChangeImage(Image img, ImageSource newSource)
        {
            DoubleAnimation StartAnimation = new DoubleAnimation();
            StartAnimation.From = 1;
            StartAnimation.To = 0;
            StartAnimation.Duration = TimeSpan.FromSeconds(0.6);
            StartAnimation.Completed += delegate
            {
                img.Source = newSource;
                DoubleAnimation EndAnimation = new DoubleAnimation();
                EndAnimation.From = 0;
                EndAnimation.To = 1;
                EndAnimation.Duration = TimeSpan.FromSeconds(1.2);
                img.BeginAnimation(Image.OpacityProperty, EndAnimation);
            };
            img.BeginAnimation(Image.OpacityProperty, StartAnimation);
        }
    }
}
