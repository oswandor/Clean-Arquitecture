using Microsoft.AspNetCore.Mvc;

namespace TesthibridConnetions.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        [HttpGet ("GetServicePublic")]
        public async Task<IEnumerable<string>> GetpublicAsync()
        {   
            //instanciar httpclient 
            HttpClient client = new HttpClient();
            // GetResponseMessage of API 
            HttpResponseMessage response = await client.GetAsync("https://api.coindesk.com/v1/bpi/currentprice.json");
            // resonseBody of Content 
            string responseBody = await response.Content.ReadAsStringAsync();
           
           
            return new String[] { responseBody };
        }

        [HttpGet("GetServicePrivate")]
        public async Task<IEnumerable<String>> Getprivate()
        {

            //instanciar httpclient 
            HttpClient client = new HttpClient();
            // GetResponseMessage of API 
            HttpResponseMessage response = await client.GetAsync("https://localhost:44306/WeatherForecast/ReturnJsonPrivateNetwork\r\n");
            // resonseBody of Content 
            string responseBody = await response.Content.ReadAsStringAsync();

            return new String[] { responseBody };
        }



        [HttpGet("ReturnJsonPrivateNetwork")]
        public IEnumerable<String> returnJsonPrivate()
        {
            

            return new String[] { "this is Local Private Networking" };

        }




    }
}