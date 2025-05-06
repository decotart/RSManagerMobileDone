using RSManagerMobile.Models;

namespace RSManagerMobile;

public partial class GeneralPage : ContentPage
{
	public GeneralPage()
	{
		InitializeComponent();
	}

    private  void  btnClients_Clicked(object sender, EventArgs e)
    {
        Data.item = new Client();

        Navigation.PushModalAsync(new ListPage());
    }

    private void btnMechanics_Clicked(object sender, EventArgs e)
    {
        Data.item = new Mechanic();

        Navigation.PushModalAsync(new ListPage());
    }

    private void btnRepairShops_Clicked(object sender, EventArgs e)
    {
        Data.item = new RepairShop();

        Navigation.PushModalAsync(new ListPage());
    }

    private void btnParts_Clicked(object sender, EventArgs e)
    {
        Data.item = new Part();

        Navigation.PushModalAsync(new ListPage());
    }

    private void btnWorks_Clicked(object sender, EventArgs e)
    {
        Data.item = new Work();

        Navigation.PushModalAsync(new ListPage());
    }

    private void brnCars_Clicked(object sender, EventArgs e)
    {
        Data.item = new Car();

        Navigation.PushModalAsync(new ListPage());
    }

    private void btnChangeUser_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}