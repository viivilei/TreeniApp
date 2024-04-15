using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Newtonsoft.Json;
using TreeniApp.Models;



namespace TreeniApp
    {
    public partial class GoalsPage : ContentPage
    {
        private int userId;

        public GoalsPage(int id)
        {
            InitializeComponent();
            userId = id;
            LoadAllGoalsFromRestAPI();
        }

        // Oletuskonstruktori ilman parametreja
        public GoalsPage()
        {
            InitializeComponent();
            
            LoadAllGoalsFromRestAPI();

        }

        //protected override void OnNavigatedTo(INavigationParameters parameters)
        //{
        //    base.OnNavigatedTo(parameters);

        //    if (parameters.TryGetValue("userId", out int userId))
        //    {
        //        // K‰sittele userId t‰‰ll‰ tarvittaessa
        //    }
        //}

        async void LoadAllGoalsFromRestAPI()
        {

            await DisplayAlert("Moi", $"P‰‰sit t‰nne asti. K‰ytt‰j‰ ID: {userId}", "Ok");
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://treenidbbackend20240415080224.azurewebsites.net");
                string json = await client.GetStringAsync($"/api/goals/{userId}");

                await DisplayAlert("JSON Response", json, "OK");

                IEnumerable<Goal> goals = JsonConvert.DeserializeObject<IEnumerable<Goal>>(json);
                goalsList.ItemsSource = new ObservableCollection<Goal>(goals);


                // P‰ivit‰ goalsList kutsuvalla OnPropertyChanged-metodia
                //OnPropertyChanged(nameof(goalsList));
            }
            catch (Exception e)
            {
                await DisplayAlert("Virhe", e.Message.ToString(), "OK");
            }
        }

        async void AddButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("AddGoal");
        }
    }
    }