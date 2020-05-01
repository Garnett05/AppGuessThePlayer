﻿using System;
using System.Collections.Generic;
using System.Text;
using AppGuessThePlayer.Model;
using System.ComponentModel;
using Xamarin.Forms;
using AppGuessThePlayer.Database;

namespace AppGuessThePlayer.ViewModel
{
    public class StartViewModel : INotifyPropertyChanged
    {
        public Game Game { get; set; }
        public Command StartCommand { get; set; }
        public StartViewModel()
        {
            StartCommand = new Command(StartGame);
            //Necessário instanciar para os objetos não ficarem como null nas telas seguintes
            Game = new Game();
            Game.Group1 = new Group();
            Game.Group2 = new Group();
        }
        private void StartGame()
        {            
            Storage.Game = this.Game;
            Storage.Currentround = 1;
            App.Current.MainPage = new View.GamePage(Game.Group1);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string nameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nameProperty));
            }
        }
    }
}
