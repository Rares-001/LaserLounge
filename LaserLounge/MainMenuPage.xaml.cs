using System;
using Xamarin.Forms;

namespace LaserLounge
{
    public partial class MainMenuPage : ContentPage
    {
        public MainMenuPage()
        {
            InitializeComponent();

            StartButton.Clicked += OnStartButtonClicked;
            ExitButton.Clicked += OnExitButtonClicked;
        }

        private void OnStartButtonClicked(object sender, EventArgs e)
        {
            // TODO: Add code to start the game here.
        }

        private void OnExitButtonClicked(object sender, EventArgs e)
        {
            // TODO: Add code to exit the game here.
            System.Environment.Exit(0);
        }
    }
}