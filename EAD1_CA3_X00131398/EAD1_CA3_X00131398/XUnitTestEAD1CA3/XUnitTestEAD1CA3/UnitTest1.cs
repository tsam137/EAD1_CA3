using System;
using EAD1_CA3_X00131398;
using EAD1_CA3_X00131398.Shared;
//using EAD1_CA3_X00131398.Pages;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;


//Somehow at the last minute I was getting errors for random things so I had to comment those things out
namespace XUnitTestEAD1CA3
{
    public class UnitTest1
    {
        //Test to see if the tempSymbol that is initialized at the start of the API call is the same as the expected tempSymbol
        [Fact]
        public async Task TestTempSymbol()
        {
            string url = "https://meta-weather.now.sh/api/location/560743";
            char expected = 'C';

            WorldWeather worldWeather = new WorldWeather();
            char tempS = ' '; //worldWeather.tempSymbol;

            Assert.Equal(tempS, expected);
        }

        //Test to see if the inital location of the API is the same as the expected. On the first API call the key should be set to Dublin
        [Fact]
        public async Task LocationValueTest()
        {
            string url = "https://meta-weather.now.sh/api/location/560743";
            string expected = "Dublin";
            
            var Http = new HttpClient();
            WorldWeather.WeatherData get1, get2;

            get1 = await Http.GetJsonAsync<WorldWeather.WeatherData>(url);
            get2 = await Http.GetJsonAsync<WorldWeather.WeatherData>(url);
            WorldWeather.WeatherData weatherData = new WorldWeather.WeatherData();
            string weatherLoc = ""; //weatherData.title;
            
            Assert.Equal(expected, weatherLoc);
        }

        //Test to see if the key that is loaded at the start of the api call is the same key as is in the expected variable.
        //Also checks if the key that is stored first in the key variable in the WorldWeather.razor is the same as the expected.
        //This will let the user be able to change the key as the key is no longer attached to the database but is now a variable that can be used dynamically
        [Fact]
        public async Task KeyValueTest()
        {
            string url = "https://meta-weather.now.sh/api/location/560743";
            string expected = "560743";

            var Http = new HttpClient();
            WorldWeather.WeatherData get1;

           
            get1 = await Http.GetJsonAsync<WorldWeather.WeatherData>(url);
            WorldWeather worldWeather = new WorldWeather();
            string KeyTest = ""; //worldWeather.key;


            string weatherKey = "";//get1.woeid.ToString();

            Assert.Equal(expected, KeyTest);
            Assert.Equal(expected, weatherKey);
        }


    }
}
