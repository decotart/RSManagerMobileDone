using RSManagerMobile.Models;

namespace RSManagerMobile;

public partial class ViewPage : ContentPage
{
	public ViewPage()
	{
		InitializeComponent();
	}

    private void btnEdit_Clicked(object sender, EventArgs e)
    {
        UpdateItem();

        if (Data.item is Client client)
        {
            App._db.SaveItem(client);
        }
        if (Data.item is Car car)
        {
            App._db.SaveItem(car);
        }
        if (Data.item is Mechanic mechanic)
        {
            App._db.SaveItem(mechanic);
        }
        if (Data.item is RepairShop repairShop)
        {
            App._db.SaveItem(repairShop);
        }
        if (Data.item is Part part)
        {
            App._db.SaveItem(part);
        }
        if (Data.item is Work work)
        {
            App._db.SaveItem(work);
        }
    }

    private void btnRemove_Clicked(object sender, EventArgs e)
    {
        if (Data.item is Client client)
        {
            App._db.RemoveItem(client);
        }
        if (Data.item is Car car)
        {
            App._db.RemoveItem(car);
        }
        if (Data.item is Mechanic mechanic)
        {
            App._db.RemoveItem(mechanic);
        }
        if (Data.item is Part part)
        {
            App._db.RemoveItem(part);
        }
        if (Data.item is RepairShop shop)
        {
            App._db.RemoveItem(shop);
        }
        if (Data.item is Work work)
        {
            App._db.RemoveItem(work);
        }
    }

    private void btnBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        if (Data.isAdding == true)
        {
            gridAdd.IsVisible = true;
            gridView.IsVisible = !(gridAdd.IsVisible);
        }
        else
        {
            gridAdd.IsVisible = false;
            gridView.IsVisible = !(gridAdd.IsVisible);
        }

        if (Data.item is Client client)
        {
            stackClient.IsVisible = true;

            entryAdres.Text = client.Adres;
            entryName.Text = client.Name;
            entryPhone.Text = client.Phone;
        }
        if (Data.item is Car car)
        {
            stackCar.IsVisible = true;

            entryBrand.Text = car.Brand;
            entryPower.Text = car.Power;
            entryYear.Text = car.Year.ToString();
            entryColor.Text = car.Color;
        }
        if (Data.item is Mechanic mech)
        {
            stackMechanic.IsVisible = true;

            entryAdresM.Text = mech.Adres;
            entryNameM.Text = mech.Name;
            entryPhoneM.Text = mech.Phone;
            entryCategory.Text = mech.Category;
        }
        if (Data.item is Part part)
        {
            stackPart.IsVisible = true;

            entryCoast.Text = part.Coast.ToString();
            entryDateOfI.Text = part.DateOfIssue;
            entryCategoryPart.Text = part.Category;
            entryDateOfC.Text = part.CompletionDate;
        }
        if (Data.item is RepairShop shop)
        {
            stackShops.IsVisible = true;

            entryAdresS.Text = shop.Adres;
            entryNameS.Text = shop.Name;
            entryPhoneS.Text = shop.Phone;
        }
        if (Data.item is Work work)
        {
            stackWorks.IsVisible = true;

            entryClient.Text = work.ClientId.ToString();
            entryMechanic.Text = work.MechanicId.ToString();
            entryShop.Text = work.RepairShopId.ToString();
            entryCar.Text = work.CarId.ToString();
            entryPart.Text = work.PartId.ToString();
        }
    }

    private void UpdateItem()
    {
        if (Data.item is Client)
        {
            ((Client)Data.item).Name = entryName.Text;
            ((Client)Data.item).Adres = entryAdres.Text;
            ((Client)Data.item).Phone = entryPhone.Text;
        }
        if (Data.item is Car)
        {
            ((Car)Data.item).Brand = entryBrand.Text;
            ((Car)Data.item).Power = entryPower.Text;
            ((Car)Data.item).Year = Convert.ToInt32(entryYear.Text);
            ((Car)Data.item).Color = entryColor.Text;
        }
        if (Data.item is Mechanic)
        {
            ((Mechanic)Data.item).Adres = entryAdresM.Text;
            ((Mechanic)Data.item).Name = entryNameM.Text;
            ((Mechanic)Data.item).Phone = entryPhoneM.Text;
            ((Mechanic)Data.item).Category = entryCategory.Text;
        }
        if (Data.item is Part)
        {
            ((Part)Data.item).Coast = Convert.ToInt32(entryCoast.Text);
            ((Part)Data.item).DateOfIssue = entryDateOfI.Text;
            ((Part)Data.item).Category = entryCategoryPart.Text;
            ((Part)Data.item).CompletionDate = entryDateOfC.Text;
        }
        if (Data.item is RepairShop)
        {
            ((RepairShop)Data.item).Name = entryNameS.Text;
            ((RepairShop)Data.item).Adres = entryAdresS.Text;
            ((RepairShop)Data.item).Phone = entryPhoneS.Text;
        }
        if (Data.item is Work)
        {
            ((Work)Data.item).ClientId = Convert.ToInt32(entryClient.Text);
            ((Work)Data.item).MechanicId = Convert.ToInt32(entryMechanic.Text);
            ((Work)Data.item).RepairShopId = Convert.ToInt32(entryShop.Text);
            ((Work)Data.item).CarId = Convert.ToInt32(entryCar.Text);
            ((Work)Data.item).PartId = Convert.ToInt32(entryPart.Text);
        }
    }

}