namespace DashApp.Shell
{
	using System.Windows;
	using Prism.Commands;
	using Prism.Mvvm;
	using Prism.Regions;

	public class MainWindowViewModel : BindableBase
	{
		private readonly IRegionManager regionManager;
		private DelegateCommand exitCommand;

		public MainWindowViewModel(IRegionManager regionManager)
		{
			this.regionManager = regionManager;
			exitCommand = new DelegateCommand(() => Application.Current.Shutdown());
			NavigateCommand = new DelegateCommand<string>(Navigate);
		}

		public DelegateCommand ExitCommand
		{
			get => exitCommand;
			set => SetProperty(ref exitCommand, value);
		}

		public DelegateCommand<string> NavigateCommand { get; private set; }

		private void Navigate(string path)
		{
			if (path != null)
			{
				regionManager.RequestNavigate("ContentRegion", path);
			}
		}
	}
}
