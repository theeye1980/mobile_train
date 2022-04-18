using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using mobile_train.Models;

namespace mobile_train.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string article;
        private bool isGettingInfo;
        private getResourseOutput getResourseOutput;
        knocker knocker;
        
        public AboutViewModel()
        {
            knocker = new knocker();
            Title = "About";
            Article = "Установка";
            
            
            OpenWebCommand = new Command(
                
                async () =>
            //await Browser.OpenAsync("https://aka.ms/xamarin-quickstart")
                { 
                    Console.WriteLine("Вот так");
                    Console.WriteLine("Вот rак");
                    IsGettingInfo = true;
                    //Получение данных и запись в переменную
                    getResourseOutput = new getResourseOutput();

                    knocker.getResourseOutputAsync(Article, ref getResourseOutput);
                    Console.WriteLine("Тадам");
                    Console.WriteLine(getResourseOutput.@object.fit_png);
                    //await DisplayAlert("Alert", getResourseOutput.@object.fit_png, "OK");
                    IsGettingInfo = false;
                }
                
            );
        }
        
        public ICommand OpenWebCommand { get; }
        public string Article { get => article; set => SetProperty(ref article, value); }
        public getResourseOutput GetResourseOutput { get => getResourseOutput; set => SetProperty(ref getResourseOutput, value); }
        public bool IsGettingInfo { get => isGettingInfo; set => SetProperty(ref isGettingInfo, value); }
    }
}