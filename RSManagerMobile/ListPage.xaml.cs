using RSManagerMobile.Models;

namespace RSManagerMobile;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Data.isAdding = true;

        Navigation.PushModalAsync(new ViewPage());
    }

    private void lvClients_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Data.item = lvClients.SelectedItem;

        Navigation.PushModalAsync(new ViewPage());
    }

    private void lvCars_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Data.item = lvCars.SelectedItem;

        Navigation.PushModalAsync(new ViewPage());
    }

    private void lvMechanics_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Data.item = lvMechanics.SelectedItem;

        Navigation.PushModalAsync(new ViewPage());
    }

    private void lvParts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Data.item = lvParts.SelectedItem;

        Navigation.PushModalAsync(new ViewPage());
    }

    private void lvShops_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Data.item = lvShops.SelectedItem;

        Navigation.PushModalAsync(new ViewPage());
    }

    private void lvWorks_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Data.item = lvWorks.SelectedItem;

        Navigation.PushModalAsync(new ViewPage());
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        if (Data.item is Client)
        {
            lvClients.IsVisible = true;

            lvClients.ItemsSource = await App._db.GetClietns();
        }
        else if (Data.item is Car)
        {
            lvCars.IsVisible = true;

            lvCars.ItemsSource = await App._db.GetCars();
        }
        else if (Data.item is Mechanic)
        {
            lvMechanics.IsVisible = true;

            lvMechanics.ItemsSource = await App._db.GetMechanics();
        }
        else if (Data.item is Part)
        {
            lvParts.IsVisible = true;

            lvParts.ItemsSource = await App._db.GetParts();
        }
        else if (Data.item is RepairShop)
        {
            lvShops.IsVisible = true;

            lvShops.ItemsSource = await App._db.GetShops();
        }
        else if (Data.item is Work)
        {
            lvWorks.IsVisible = true;

            lvWorks.ItemsSource = await App._db.GetWorks();
        }
    }

    private void btnBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}