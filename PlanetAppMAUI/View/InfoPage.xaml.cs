namespace PlanetAppMAUI.View;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
        BindingContext = App.MainPageViewModel;
    }

    private async void OnBackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}