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
            polygon.Fill = Brushes.LightGreen;
            polygon.Points.Add(new Point(50, 0));
            polygon.Points.Add(new Point(20, 16));
            polygon.Points.Add(new Point(69, 48));
            Canvas.SetLeft(polygon, 0);
            Canvas.SetBottom(polygon, 0);
            CanvasScene.Children.Add(polygon);
        }

        private void DrawStar()
        {
           
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
