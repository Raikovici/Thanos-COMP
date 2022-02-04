using System;
using ThanosCOMP.NormalUserWindows.Core;
using ThanosCOMP.NormalUserWindows;
namespace ThanosCOMP.NormalUserWindows.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public static int categoryId;
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand LaptopsViewCommand { get; set; }
        public RelayCommand PCViewCommand { get; set; }
        public RelayCommand KeyboardsViewCommand { get; set; }
        public RelayCommand MonitorsViewCommand { get; set; }
        public RelayCommand MiceViewCommand { get; set; }
        public RelayCommand ExternalMemoryViewCommand { get; set; }
        public RelayCommand PCComponentsViewCommand { get; set; }
        public RelayCommand ProductViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public LaptopsViewModel LaptopsVM { get; set; }
        public PCViewModel PCVM { get; set; }
        public KeyboardsViewModel KeyboardsVM { get; set; }
        public MonitorsViewModel MonitorsVM { get; set; }
        public MiceVewModel MiceVM { get; set; }
        public ExternalMemoryViewModel ExternalMemoryVM { get; set; }
        public PCComponentsModelView PCComponentsVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set {_currentView= value;
                OnProprietyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            LaptopsVM = new LaptopsViewModel();
            PCVM = new PCViewModel();
            KeyboardsVM = new KeyboardsViewModel();
            MonitorsVM = new MonitorsViewModel();
            MiceVM = new MiceVewModel();
            ExternalMemoryVM = new ExternalMemoryViewModel();
            PCComponentsVM = new PCComponentsModelView();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            {
                categoryId = 0;
                CurrentView = HomeVM;
            });

            LaptopsViewCommand = new RelayCommand(o =>
            {
                categoryId = 1;
                CurrentView = LaptopsVM;
            });

            PCViewCommand = new RelayCommand(o =>
            {
                categoryId = 2;
                CurrentView = PCVM;
            });

            KeyboardsViewCommand = new RelayCommand(o =>
            {
                categoryId = 3;
                CurrentView = KeyboardsVM;
            });

            MonitorsViewCommand = new RelayCommand(o =>
            {
                categoryId = 4;
                CurrentView = MonitorsVM;
            });

            MiceViewCommand = new RelayCommand(o =>
            {
                categoryId = 5;
                CurrentView = MiceVM;
            });

            ExternalMemoryViewCommand = new RelayCommand(o =>
            {
                categoryId = 6;
                CurrentView = ExternalMemoryVM;
            });

            PCComponentsViewCommand = new RelayCommand(o =>
            {
                categoryId = 7;
                CurrentView = PCComponentsVM;
            });

        }
    }
}
