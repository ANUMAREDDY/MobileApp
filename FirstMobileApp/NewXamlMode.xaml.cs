namespace FirstMobileApp;

public partial class NewXamlMode : ContentPage
{
    private int count;
	public NewXamlMode()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        count++;

        lblcounter.Text = $"Click count:{count}";
        SemanticScreenReader.Announce(lblcounter.Text);

    }
}