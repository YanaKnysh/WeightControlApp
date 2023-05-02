namespace WeightControlApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnEnterDataClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			EnterDataBtn.Text = $"Clicked {count} time";
		else
            EnterDataBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(EnterDataBtn.Text);
	}
}

