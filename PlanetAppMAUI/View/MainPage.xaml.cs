using PlanetAppMAUI.View;

namespace PlanetAppMAUI;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        BindingContext = App.MainPageViewModel;
	}

    private async void OnInfoButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InfoPage());
    }


}

