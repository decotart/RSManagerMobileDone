using RSManagerMobile.Models;

namespace RSManagerMobile;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private async void btnReg_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (entryPassword.Text == entryPassword2.Text)
            {
                Autorization user = new();

                user.Password = entryPassword.Text;

                user.Login = entryLogin.Text;

                user.AccessLevel = 0;

                App._db.SaveItem(user);

                await Navigation.PushModalAsync(new GeneralPage());
            }
            else await DisplayAlert("Ошибка!", "Пароли не совпадают!", "Ok");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ошибка!", ex.Message, "Ok");
        }
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}