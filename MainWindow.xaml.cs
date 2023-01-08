using System.Windows;
using WpfControlSlider.ViewModels;
using WpfLib.ViewModels;

namespace WpfControlSlider
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private ViewModelBase _currentViewModel = default!;

    public ViewModelBase CurrentViewModel
    {
      get
      {
        if (_currentViewModel is FirstViewModel)
        {
          _currentViewModel = new SecondViewModel();
        }
        else
        {
          _currentViewModel = new FirstViewModel();
        }
        return _currentViewModel;
      }
    }


    public MainWindow()
    {
      InitializeComponent();
    }

    private void LeftToRight_Clicked(object sender, RoutedEventArgs e)
    {
      slider.SetAnimationSpeed(100);
      slider.Slide(CurrentViewModel, WpfLib.Controls.SlideType.LeftToRight);
    }

    private void RightToLeft_Clicked(object sender, RoutedEventArgs e)
    {
      slider.SetAnimationSpeed(300);
      slider.Slide(CurrentViewModel, WpfLib.Controls.SlideType.RightToLeft);
    }

    private void TopToBottom_Clicked(object sender, RoutedEventArgs e)
    {
      slider.SetAnimationSpeed(700);
      slider.Slide(CurrentViewModel, WpfLib.Controls.SlideType.TopToBottom);
    }

    private void BottomToTop_Clicked(object sender, RoutedEventArgs e)
    {
      slider.SetAnimationSpeed(1000);
      slider.Slide(CurrentViewModel, WpfLib.Controls.SlideType.BottomToTop);
    }
  }
}
