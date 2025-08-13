using MauiAppBuscaDinamica.Model;

namespace MauiAppBuscaDinamica.View;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto

			{
				Descri��o = txt_descricao.Text,
                Pre�o = Convert.ToDouble(txt_pre�o.Text),
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
				
			};

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Registro Inserido", "OK");

		}
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }
}