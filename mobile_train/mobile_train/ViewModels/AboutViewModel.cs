using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using mobile_train.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using mobile_train.Models;

namespace mobile_train.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string article;
        private bool isGettingInfo;
        private string GetResourseFit_png;
        private string thumbURL;
        private string image;
        private string price;
        private string price_sale;
        private string[] stocks;
        private string[] phones;
        private string allAbout;

        knocker knocker;
        
        public AboutViewModel()
        {
            knocker = new knocker();
            Title = "Проверка товара";
            Article = "";
            
            
            OpenWebCommand = new Command(
                
                async () =>
            
                {
                    //cначала установим пометку выполнения операции
                    await Task.Run(() =>
                    {
                        IsGettingInfo = true;
                        Task.Delay(20);
                    }
                    );

                        Stopwatch stopwatch = new Stopwatch();
                    //засекаем время начала операции
                    stopwatch.Start();

                    Console.WriteLine("Вот так");
                    Console.WriteLine("Вот rак");
                    
                    //Получение данных и запись в переменную

                    

                    GetResourse = await knocker.getResourseOutputAsync(Article);
                    AllAbout = await knocker.calculete(Article);
                    Console.WriteLine("Тадам");
                    
                    //Заполняем шаблон
                    GetResourseFit_png1 = GetResourse.@object.fit_png;
                    ThumbURL = @"https://fandeco.ru" + GetResourse.@object.thumb;
                    Image = @"https://fandeco.ru" + GetResourse.@object.image;
                    Price = string.Concat("Цена: ", GetResourse.@object.price.ToString());
                    Price_sale = string.Concat("Распродажная: ", GetResourse.@object.old_price.ToString());


                    var fff = GetResourse.@object.remains;
                    foreach (var item in GetResourse.@object.remains)
                    {
                        
                    }
                    string[] Stocks1 = new string[fff.Count];
                    for (int i = 0; i < fff.Count; i++) {

                        Stocks1[i] = string.Concat(fff[i].code.ToString(), " - ", fff[i].count, "шт. - ", fff[i].store_pagetitle) ;
                        Console.WriteLine(fff[i].code);
                    }

                    Stocks = Stocks1;

                    //Phones = new string[] { "iPhone 8", "Samsung Galaxy S9", "Huawei P10", "LG G6" };

                    



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
        public string ThumbURL { get => thumbURL; set => SetProperty(ref thumbURL, value); }
        public string Image { get => image; set => SetProperty(ref image, value); }
        public string Price { get => price; set => SetProperty(ref price, value); }
        public string[] Phones { get => phones; set => SetProperty(ref phones, value); }
        public string[] Stocks { get => stocks; set => SetProperty(ref stocks, value); }
        public string Price_sale { get => price_sale; set => SetProperty(ref price_sale, value); }
        public string AllAbout { get => allAbout; set => SetProperty(ref allAbout, value); }
    }
}