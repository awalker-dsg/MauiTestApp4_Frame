namespace MauiTestApp4_Frame;

public partial class MainPage : ContentPage
{
	public List<SimpleItem> ItemsSource { get; } = new List<SimpleItem>();

    public SimpleItem StandAloneItem { get; set; }


    public MainPage()
	{
		InitializeComponent();

        StandAloneItem = new SimpleItem("Clickable stand-alone item", new Command(() => ClickedStandAloneButton()));

        ItemsSource.Add(new SimpleItem("Clickable list item 1", new Command(() => ClickedListButton(1))));
        ItemsSource.Add(new SimpleItem("Clickable list item 2", new Command(() => ClickedListButton(2))));

        BindingContext = this;
        StandAloneFrame.BindingContext = StandAloneItem;
    }

    public void ClickedListButton(int ival)
    {
        ReportClick($"Clicked list button {ival}");
    }

    public void ClickedStandAloneButton()
    {
        ReportClick($"Clicked stand-alone button");
    }

    private void ReportClick(string msg)
    {
        Console.WriteLine(msg);
        DisplayAlert("Alert", msg, "OK");
    }
}

