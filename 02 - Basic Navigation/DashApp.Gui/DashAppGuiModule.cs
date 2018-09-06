namespace DashApp.Gui
{
	using Prism.Ioc;
	using Prism.Modularity;
	using Prism.Regions;
	using Prism.Unity;
	using Unity;

	public class DashAppGuiModule : IModule
	{
		private readonly IUnityContainer container;

		public DashAppGuiModule(IUnityContainer container, IRegionManager regionManager)
		{
			this.container = container;
		}

		public void RegisterTypes(IContainerRegistry containerRegistry)
		{
		}

		public void OnInitialized(IContainerProvider containerProvider)
		{
			container.RegisterTypeForNavigation<ViewA.ViewA>();
			container.RegisterTypeForNavigation<ViewB.ViewB>();
		}
	}
}
