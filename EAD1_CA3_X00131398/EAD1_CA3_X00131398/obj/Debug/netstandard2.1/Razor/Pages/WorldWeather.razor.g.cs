#pragma checksum "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f911a58bde309ab3dc7693d0605ebf69e343a56"
// <auto-generated/>
#pragma warning disable 1591
namespace EAD1_CA3_X00131398.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\_Imports.razor"
using EAD1_CA3_X00131398;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\_Imports.razor"
using EAD1_CA3_X00131398.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/weather")]
    public partial class WorldWeather : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Weather in ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                weatherLocation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(4, "<p>This component demonstrates fetching data from a weather API and displaying information and pictures dynamically.</p>\r\n\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
 if (data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 14 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
}
else
{
    //User can select a Location from the dropdown menu and it sets the forecast location to the speicifed location through the key value
    //Had to Math.Celeing to show no decimal place for the degrees and for the wind speed.

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "mb-2 p-3 col-sm-5");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                            GetDataAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                            key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => key = __value, key));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "selected", true);
            __builder.AddAttribute(19, "disabled", true);
            __builder.AddAttribute(20, "value", "-1");
            __builder.AddContent(21, " Select Location");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", "560743");
            __builder.AddContent(25, " Dublin");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", "1118370");
            __builder.AddContent(29, " Tokyo");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", "44418");
            __builder.AddContent(33, " London");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "650272");
            __builder.AddContent(37, " Frankfurt");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 28 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"

    //The temperature symbol can be changed in the dropdown menu and then it changes the degrees to either celsius or farenheit

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "mb-2 p-3 col-sm-5");
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "select");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                   GetDataAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                            tempSymbol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tempSymbol = __value, tempSymbol));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "selected", true);
            __builder.AddAttribute(53, "disabled", true);
            __builder.AddAttribute(54, "value", "-1");
            __builder.AddContent(55, " Select Degrees");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", "F");
            __builder.AddContent(59, "Fahrenheit");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "option");
            __builder.AddAttribute(62, "value", "C");
            __builder.AddContent(63, "Celsius");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.AddMarkupContent(67, "    <br>\r\n");
#nullable restore
#line 39 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
    //I added an if statement that checks if the state of the weather is a certain state then adds the suitable image of that state to the forecast cards
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
     foreach (var weatherForecast in data.consolidated_weather)
    {
      

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col-md-5 col-sm-12 col-lg-5 mt-2 mb-2");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "card");
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "id", "container");
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "card-body");
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.OpenElement(81, "h5");
            __builder.AddAttribute(82, "class", "card-title");
            __builder.AddContent(83, "Date: ");
            __builder.AddContent(84, 
#nullable restore
#line 47 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                      weatherForecast.applicable_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "h6");
            __builder.AddAttribute(87, "class", "card-subtitle mb-2 text");
            __builder.AddContent(88, "Weather State: ");
            __builder.AddContent(89, 
#nullable restore
#line 48 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                            weatherForecast.weather_state_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                        ");
            __builder.OpenElement(91, "h6");
            __builder.AddAttribute(92, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(93, " ");
            __builder.AddContent(94, 
#nullable restore
#line 49 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                    weatherLocation

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                        ");
            __builder.AddMarkupContent(97, "<p class=\"card-text\"> </p>\r\n");
#nullable restore
#line 51 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                         if (weatherForecast.weather_state_name == "Light Rain")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "                            ");
            __builder.AddMarkupContent(99, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-3.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 54 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                        }
                        else if (weatherForecast.weather_state_name == "Heavy Cloud")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                            ");
            __builder.AddMarkupContent(101, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-2.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 58 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                        }
                        else if (weatherForecast.weather_state_name == "Heavy Rain")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                            ");
            __builder.AddMarkupContent(103, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-3.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 62 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                        }
                        else if (weatherForecast.weather_state_name == "Showers")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "                            ");
            __builder.AddMarkupContent(105, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-3.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 66 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                        }
                        else if (weatherForecast.weather_state_name == "Light Cloud")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "                            ");
            __builder.AddMarkupContent(107, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-2.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 70 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                        }
                        else if (weatherForecast.weather_state_name == "Clear")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "                            ");
            __builder.AddMarkupContent(109, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-4.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 74 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                            ");
            __builder.AddMarkupContent(111, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-2.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 78 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(112, "                        <p></p>\r\n");
#nullable restore
#line 80 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                         if (tempSymbol == 'F')
                        {
                            var farenheit = (weatherForecast.the_temp * 9 / 5) + 32;
                            Math.Floor(farenheit);

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "                            ");
            __builder.OpenElement(114, "h4");
            __builder.AddAttribute(115, "class", "card-subtitle mb-2 text");
            __builder.AddContent(116, "Temperature: ");
            __builder.AddContent(117, 
#nullable restore
#line 84 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                              Math.Ceiling(farenheit)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(118, "° ");
            __builder.AddContent(119, 
#nullable restore
#line 84 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                                                        tempSymbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 85 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                        }
                        else if (tempSymbol == 'C')
                        {
                            var celsius = weatherForecast.the_temp;

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, "                            ");
            __builder.OpenElement(122, "h4");
            __builder.AddAttribute(123, "class", "card-subtitle mb-2 text");
            __builder.AddContent(124, "Temperature: ");
            __builder.AddContent(125, 
#nullable restore
#line 89 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                              Math.Ceiling(celsius)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(126, "° ");
            __builder.AddContent(127, 
#nullable restore
#line 89 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                                                      tempSymbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 90 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "                        ");
            __builder.OpenElement(130, "h6");
            __builder.AddAttribute(131, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(132, "Wind Speed: ");
            __builder.AddContent(133, 
#nullable restore
#line 91 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                               Math.Ceiling(weatherForecast.wind_speed)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(134, "mph");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                        ");
            __builder.OpenElement(136, "h6");
            __builder.AddAttribute(137, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(138, "Humidity: ");
            __builder.AddContent(139, 
#nullable restore
#line 92 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                             weatherForecast.humidity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n");
#nullable restore
#line 97 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
       

    //
    //Variables
    //

    private WeatherData data;
    private Consolidated_Weather conWeather;
    private string key = "560743";                                    //This is the key that is added to the uri to display the different forecasts for the different location. It is on Dublin by default
    string weatherLocation = "Dublin";                               //This stores the location of weatherforecast so that I can dynamically display it in the header and in the forecast cards
    public char tempSymbol = 'C';                                   //Symbol to identify which degrees is being displayed
    private string errormessage;
    string uri = "https://meta-weather.now.sh/api/location/";


    // https://meta-weather.now.sh/api/location/560743
    private async Task GetDataAsync()
    {

        try
        {
            //Checks the key and if the key matches the key from the dropdown above then it sets the forecast location to the speicifed location
            if (key == "560743")
            {
                weatherLocation = "Dublin, Ireland";
            }

            else if (key == "1118370")
            {
                weatherLocation = "Tokyo, Japan";
            }

            else if (key == "44418")
            {
                weatherLocation = "London, England";
            }
            else if(key == "650272")
            {
                weatherLocation = "Frankfurt, Germany";
            }

            data = await Http.GetJsonAsync<WeatherData>(uri + key + "/");



            errormessage = String.Empty;
        }
        catch (Exception e)
        {

            errormessage = e.Message;
        }

    }

    protected override async Task OnInitializedAsync()
    {
        await GetDataAsync();
    }


    //
    //Models
    //

    public class WeatherData
    {
        public Consolidated_Weather[] consolidated_weather { get; set; }
        public DateTime time { get; set; }
        public DateTime sun_rise { get; set; }
        public DateTime sun_set { get; set; }
        public string timezone_name { get; set; }
        public Parent parent { get; set; }
        public Source[] sources { get; set; }
        public string title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string latt_long { get; set; }
        public string timezone { get; set; }
    }

    public class Parent
    {
        public string title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string latt_long { get; set; }
    }

    public class Consolidated_Weather
    {
        public long id { get; set; }
        public string weather_state_name { get; set; }
        public string weather_state_abbr { get; set; }
        public string wind_direction_compass { get; set; }
        public DateTime created { get; set; }
        public string applicable_date { get; set; }
        public float min_temp { get; set; }
        public float max_temp { get; set; }
        public float the_temp { get; set; }
        public float wind_speed { get; set; }
        public float wind_direction { get; set; }
        public float air_pressure { get; set; }
        public int humidity { get; set; }
        public float visibility { get; set; }
        public int predictability { get; set; }




    }

    public class Source
    {
        public string title { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public int crawl_rate { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
