namespace TreeniApp;

public partial class LisatietoPage : ContentPage
{
	public LisatietoPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}