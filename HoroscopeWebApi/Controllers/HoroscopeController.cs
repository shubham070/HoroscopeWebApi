using HoroscopeWebAPi.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HoroscopeWebAPi.Controllers
{
    
        
    public class HoroscopeController : Controller
    {
        public async Task<JsonResult> GetMonthlyPredictions(string id)
        {
            MonthlyHoroscope monthlyHoroscope = new MonthlyHoroscope();

            string Baseurl = "http://horoscope-api.herokuapp.com";
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("horoscope/month/" + id);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var temp = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    monthlyHoroscope = JsonConvert.DeserializeObject<MonthlyHoroscope>(temp);

                }

                //               return monthlyHoroscope;
                return Json(monthlyHoroscope, JsonRequestBehavior.AllowGet);

            }
        }

        public async Task<JsonResult> GetDailyPredictions(string id)
        {
            DailyHoroscope dailyHoroscope = new DailyHoroscope();

            string Baseurl = "http://horoscope-api.herokuapp.com";
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("horoscope/today/" + id);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var temp = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    dailyHoroscope = JsonConvert.DeserializeObject<DailyHoroscope>(temp);

                }

                return Json(dailyHoroscope, JsonRequestBehavior.AllowGet);

                

            }
        }

        public async Task<JsonResult> GetWeeklyPredictions(string id)
        {
            WeeklyHoroscope weeklyHoroscope = new WeeklyHoroscope();

            string Baseurl = "http://horoscope-api.herokuapp.com";
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("horoscope/week/" + id);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var temp = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    weeklyHoroscope = JsonConvert.DeserializeObject<WeeklyHoroscope>(temp);

                }

                return Json(weeklyHoroscope, JsonRequestBehavior.AllowGet);

                

            }
        }
    }

}

