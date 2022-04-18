using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace mobile_train.Models
{
    public class knocker // задаем класс, который будет отвечать за соединение с REST сервером
    {
        //Метод постановки асинхноррной задачи, работает только с нашим REST сервисом
        public static async Task<string> GetData(string json, string url)
        {

            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var userName = "VXDTB9lg4Uz4vkKsASAx2";


            using var client = new HttpClient();
            var authToken = Encoding.ASCII.GetBytes($"{userName}:{userName}");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(authToken));

            var response = await client.PostAsync(url, data);
            string result = response.Content.ReadAsStringAsync().Result;
            //await Task.Delay(2000);
            return result;

        }

        public void getResourseOutputAsync(string article, ref getResourseOutput getResourseOutput) {

            string url = "https://fandeco.ru/rest/product/resource";
            getResourseInput articleInput = new getResourseInput
            {
                article = article
            };
            string articleInputJson = JsonSerializer.Serialize<getResourseInput>(articleInput);

            Console.WriteLine(articleInputJson);

            var t = Task.Run(() => knocker.GetData(articleInputJson, url));
            t.Wait();
            string result = t.Result.ToString();

            // пытаемся десереализовать нормальным методом
            getResourseOutput = JsonSerializer.Deserialize<getResourseOutput>(result);
            //Console.WriteLine(getResourseOutput.success);
        }

    }
}
