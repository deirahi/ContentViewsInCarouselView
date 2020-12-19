using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContentViewsInCarouselView.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        //CarouselView用のViewを保持
        private List<ContentView> _contentViews;
        public List<ContentView> ContentViews
        {
            get { return _contentViews; }
            set { SetValue(ref _contentViews, value); }
        }

        public MainViewModel()
        {
            //CarouselView用のViewを用意
            ContentViews = new List<ContentView>
            {
                new View1(),
                new View2(),
                new View3()
            };
        }

        // ボタン押してViewを切り替える
        public ICommand SelectTabCommand { get => new Command<string>((param) => PositionSelected = int.Parse(param)); }

        // 何番目のViewかを保持
        private int _positionSelected = 0;
        public int PositionSelected
        {
            set
            {
                if (_positionSelected != value)
                {
                    _positionSelected = value;

                    OnPropertyChanged(nameof(PositionSelected));
                }
            }
            get => _positionSelected;
        }
    }
}
