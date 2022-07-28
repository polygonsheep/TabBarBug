namespace TabBarBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnDetailsClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync(nameof(DetailsPage), true);
	}
}


