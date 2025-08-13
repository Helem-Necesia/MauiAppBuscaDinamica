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
				Descrição = txt_descricao.Text,
                Preço = Convert.ToDouble(txt_preço.Text),
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