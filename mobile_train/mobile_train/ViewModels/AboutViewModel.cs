using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using mobile_train.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace mobile_train.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string article;
        private bool isGettingInfo;
        private string GetResourseFit_png;

        knocker knocker;
        
        public AboutViewModel()
        {
            knocker = new knocker();
            Title = "About";
            Article = "Установка";
            
            
            OpenWebCommand = new Command(
                
                async () =>
            
                {
                    //cначала установим пометку выполнения операции
                    await Task.Run(() =>
                    {
                        IsGettingInfo = true;

                    }
                    );

                        Stopwatch stopwatch = new Stopwatch();
                    //засекаем время начала операции
                    stopwatch.Start();

                    Console.WriteLine("Вот так");
                    Console.WriteLine("Вот rак");
                    
                    //Получение данных и запись в переменную

                    

                    GetResourse = await knocker.getResourseOutputAsync(Article);
                    Console.WriteLine("Тадам");
                    GetResourseFit_png1 = GetResourse.@object.fit_png;

                    Console.WriteLine(GetResourseFit_png1);
                    //await DisplayAlert("Alert", getResourseOutput.@object.fit_png, "OK");
                    stopwatch.Stop();
                    //смотрим сколько миллисекунд было затрачено на выполнение
                    Console.WriteLine(stopwatch.ElapsedMilliseconds);


                    IsGettingInfo = false;
                }
                
            );
        }

        

        
        public ICommand OpenWebCommand { get; }
        public string Article { get => article; set => SetProperty(ref article, value); }
        public bool IsGettingInfo { get => isGettingInfo; set => SetProperty(ref isGettingInfo, value); }
        public string GetResourseFit_png1 { get => GetResourseFit_png; set => SetProperty(ref GetResourseFit_png, value); }
    }
}