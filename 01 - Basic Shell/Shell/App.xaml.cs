namespace BasicWpfApp
{
	using System.Windows;
	using CommonServiceLocator;
	using Prism.Ioc;
	using Prism.Unity;
	using Shell;

	public partial class App : PrismApplication
	{
		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
		}

		protected override Window CreateShell()
		{
			return ServiceLocator.Current.GetInstance<MainWindow>();
		}
	}
}
