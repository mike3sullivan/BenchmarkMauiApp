namespace PerformanceBenchmarkMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        DateTime now = DateTime.Now;
        for (int r = 0; r < 500000; r++)
        {
            for (int c = 0; c < 20; c++)
            {
                string cs = string.Empty;
                decimal c2 = c + 1;
                while (c2 > 0)
                {
                    decimal l = (c2 - 1) % 26;
                    char cl = (char)(l + 65);
                    cs = cl + cs;
                    c2 = (c2 - (l + 1)) / 26;
                }
            }
        }

        TimeSpan ts = DateTime.Now - now;
        CounterBtn.Text = ts.TotalSeconds.ToString();

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

