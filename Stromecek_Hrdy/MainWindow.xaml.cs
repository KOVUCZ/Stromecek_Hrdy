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

namespace Stromecek_Hrdy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawXmas()
        {
            
            DrawGround();
            DrawTree();
            DrawStar();
            DrawDecorations();
        }

        private void DrawGround()
        {
            CanvasScene.Children.Clear();
            Rectangle ground = new Rectangle();
            ground.Width = CanvasScene.ActualWidth;
            ground.Height = CanvasScene.ActualHeight * 0.2;
            ground.Fill = Brushes.White;
            Canvas.SetLeft(ground, 0);
            Canvas.SetBottom(ground, 0);
            CanvasScene.Children.Add(ground);
        }

        private void DrawTree()
        {
            
            Polygon polygon = new Polygon();
            var height = (CanvasScene.ActualHeight / 5) * 4;
            var width = height * 0.75;
            polygon.Fill = Brushes.LightGreen;
            polygon.Points.Add(new Point(0, height));
            polygon.Points.Add(new Point(width, height));
            polygon.Points.Add(new Point(width / 2, 0));
            Canvas.SetLeft(polygon, (CanvasScene.ActualWidth - width) / 2);
            Canvas.SetBottom(polygon, CanvasScene.ActualHeight / 10);
            CanvasScene.Children.Add(polygon);
        }

        private void DrawStar()
        {
            Polygon star = new Polygon();
            var size = CanvasScene.ActualHeight * 0.05;
            var count = 5;
            var angle = 2*Math.PI / count;
            for(int i = 0; i < count; i++)
            {
                star.Points.Add(new Point(Math.Cos(angle * i) * size, Math.Sin(angle * i) * size));
                star.Points.Add(new Point(Math.Cos(angle * i) + (angle * 0.5) * (size * 2), Math.Sin(angle * i) + angle * 0.5 * size));
            }
            star.Fill = Brushes.Yellow;
            Canvas.SetLeft(star, 0);
            Canvas.SetTop(star, 0);
           CanvasScene.Children.Add(star);
        }

        private void DrawDecorations()
        {

        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            DrawXmas();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DrawXmas();
        }
    }
}
