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
        public GoalsPage()
        {
            InitializeComponent();
            LoadAllGoalsFromRestAPI();
        }

        async void LoadAllGoalsFromRestAPI()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://treenidbbackend20240415080224.azurewebsites.net/");
                string json = await client.GetStringAsync("/api/goals");
                IEnumerable<Goal> goals = JsonConvert.DeserializeObject<IEnumerable<Goal>>(json);
                goalsList.ItemsSource = new ObservableCollection<Goal>(goals);
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