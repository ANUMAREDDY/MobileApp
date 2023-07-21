namespace FirstMobileApp;

public class TestPage : ContentPage
{
    int count = 0;
    Label lblcounter;

    public TestPage()
	{
		var ScrollView= new ScrollView();
		var StackLayout= new StackLayout();
		ScrollView.Content = StackLayout;
		lblcounter = new Label {
			Text = "Count=0",
		    FontSize=22,
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions=LayoutOptions.Center,
		};
		StackLayout.Children.Add(lblcounter);

		var BtnCounter = new Button { 
			Text="Click to Count",
            HorizontalOptions = LayoutOptions.Center
        };
        StackLayout.Children.Add(BtnCounter);
		BtnCounter.Clicked += OnClickedEvent;
		this.Content = ScrollView;

		void OnClickedEvent(object sender, EventArgs e )
		{
			count++;
			lblcounter.Text = $"Click count:{count}";
			SemanticScreenReader.Announce(lblcounter.Text);

		}


    }
}