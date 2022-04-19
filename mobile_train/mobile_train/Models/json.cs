using System;
using System.Collections.Generic;
using System.Text;

namespace mobile_train.Models
{
    public class json
    {
    }

    public class getResourseInput
    {
        public string article { get; set; }
    }
    public class getResourseOutput
    {
        public bool success { get; set; }
        public string message { get; set; }
        public SearchArticles @object { get; set; }
        public int code { get; set; }
    }
        public class SearchArticle
    {
        public string artikul_1c { get; set; }
    }


    public class SearchArticles
    {
        public List<SearchArticle> search_articles { get; set; }
        public string artikul_1c { get; set; }
        public int price { get; set; }
        public int old_price { get; set; }
        public double weight { get; set; }
        public string image { get; set; }
        public string thumb { get; set; }
        public bool published { get; set; }
        public bool deleted { get; set; }
        public string fit_png { get; set; }
        public List<Remain> remains { get; set; }
        public List<Analog> analogs { get; set; }
        public List<string> images { get; set; }
    }
    public class Remain
    {
        public string code { get; set; }
        public string count { get; set; }
        public string store_id { get; set; }
        public string region_name { get; set; }
        public string store_pagetitle { get; set; }
        public string store_resource_id { get; set; }
        public string shop_address { get; set; }
        public string shop_phone { get; set; }
    }

    public class Analog
    {
        public int id { get; set; }
        public double score { get; set; }
    }
}
