namespace TP01PDMI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
        InitializeComponent();
	}

	private void OnOKClicked(object sender, EventArgs e)
	{
		if (IdEntry.Text == "ADMIN" && PassEntry.Text == "@admin")
		{
			labelValida.Text = "LOGOU COM SUCESSO!";
		}
		else
		{
            labelValida.Text = "Não autorizado.";
        }
	}

    private void OnCleanClicked(object sender, EventArgs e)
    {
		IdEntry.Text = null;
		PassEntry.Text = null;
    }

    private void OnCreditsClicked(object sender, EventArgs e)
    {
		CreditsLabel.Text = "Leandro Ribeiro, CB3015173";
    }
}

