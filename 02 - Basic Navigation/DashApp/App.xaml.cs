namespace DashApp
{
	using System.Windows;
	using CommonServiceLocator;
	using Gui;
	using Prism.Ioc;
	using Prism.Modularity;
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

		protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
		{
			base.ConfigureModuleCatalog(moduleCatalog);
			moduleCatalog.AddModule(typeof(DashAppGuiModule));
		}
	}
}
