using System.Windows.Input;
using WpfLib.Commands;
using WpfLib.Controls;
using WpfLib.ViewModels;

namespace WpfControlSlider.ViewModels
{
  public class MainViewModel : ViewModelBase
  {
    private ViewModelBase _currentViewModel = default!;
    private SlideType _slideType;

    private void BottomToTop(object _)
    {
      SlideType = SlideType.BottomToTop;
      CurrentViewModel = GetViewModel();
    }

    private void TopToBottom(object _)
    {
      SlideType = SlideType.TopToBottom;
      CurrentViewModel = GetViewModel();
    }

    private void RightToLeft(object _)
    {
      SlideType = SlideType.RightToLeft;
      CurrentViewModel = GetViewModel();
    }

    private void LeftToRight(object _)
    {
      SlideType = SlideType.LeftToRight;
      CurrentViewModel = GetViewModel();
    }

    private ViewModelBase GetViewModel()
    {
      if (_currentViewModel is FirstViewModel)
      {
        return new SecondViewModel();
      }
      else
      {
        return new FirstViewModel();
      }
    }

    public MainViewModel()
    {
      CurrentViewModel = new FirstViewModel();
      LeftToRightCommand = new RelayCommand<object>(LeftToRight);
      RightToLeftCommand = new RelayCommand<object>(RightToLeft);
      TopToBottomCommand = new RelayCommand<object>(TopToBottom);
      BottomToTopCommand = new RelayCommand<object>(BottomToTop);
    }

    public ViewModelBase CurrentViewModel
    {
      get
      {
        return _currentViewModel;
      }
      set
      {
        if (_currentViewModel != value)
        {
          _currentViewModel = value;
          OnPropertyChanged();
        }
      }
    }

    public SlideType SlideType
    {
      get { return _slideType; }
      set
      {
        if (_slideType != value)
        {
          _slideType = value;
          OnPropertyChanged();
        }
      }
    }

    public ICommand LeftToRightCommand { get; set; }
    public ICommand RightToLeftCommand { get; set; }
    public ICommand TopToBottomCommand { get; set; }
    public ICommand BottomToTopCommand { get; set; }
  }
}