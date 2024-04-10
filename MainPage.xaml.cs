using System.Collections.ObjectModel;
using TreeniApp.Models;
using Newtonsoft;
using Newtonsoft.Json;


namespace TreeniApp
{
    public partial class MainPage : ContentPage
    {
        
        // Muuttujan alustaminen
        ObservableCollection<User> dataa = new ObservableCollection<User>();

        public MainPage()
        {
            InitializeComponent();
            LoadDataFromRestAPI();
        }

        async void LoadDataFromRestAPI()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://treeniappbackend.azurewebsites.net");

                string json = await client.GetStringAsync("/api/users");
                var users = JsonConvert.DeserializeObject<User[]>(json);

                dataa = new ObservableCollection<User>(users);
                userList.ItemsSource = dataa;
            }
            catch (Exception e)
            {
                await DisplayAlert("Virhe", e.Message.ToString(), "SELVÄ!");
            }
        }









        private void Lisatieto_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Moi ", "Hei", "Okei");
        }
    }

}
