namespace PlanetAppMAUI;
using PlanetAppMAUI.ViewModel;

public partial class App : Application
{
	public static MainPageViewModel MainPageViewModel { get; set; } = new MainPageViewModel();

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
