namespace MeuConsultorio.Views;

public partial class AcessoPage : ContentPage
{
	public AcessoPage()
	{
		InitializeComponent();
	}

	public async void btnEntrarClick(object sender, EventArgs e)
	{
		await DisplayAlert("Atenção", "Você tem permissão para acessar esta página!!!","Ok");
	}

	public void btnRegistrarClick(object sender, EventArgs e)
	{

	}
}
