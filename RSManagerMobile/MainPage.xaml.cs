using RSManagerMobile.Models;

namespace RSManagerMobile
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void btnReg_Clicked(object sender, EventArgs e)
        {
            RegisterPage page = new();

            Navigation.PushModalAsync(page);
        }

        private async void btnEnter_Clicked(object sender, EventArgs e)
        {
            try
            {
                var gen = await App._db.GetUsers();

                var item = gen.Where(x => x.Login == entryLogin.Text).FirstOrDefault();

                if (item != null)
                {
                    if (item.Password == entryPassword.Text)
                    {
                        await Navigation.PushModalAsync(new GeneralPage());
                    }
                }
                else
                {
                    await DisplayAlert("Ошибка!",
                        "Такого пользователя не существует!",
                        "Ок");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка!", ex.Message, "Ох...");
            }
        }

    }
}
