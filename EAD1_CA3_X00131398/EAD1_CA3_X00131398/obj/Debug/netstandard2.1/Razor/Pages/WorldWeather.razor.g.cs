#pragma checksum "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27b2674e992a0c737714d5f68e0652efb46eda75"
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
            __builder.AddMarkupContent(4, "<p>This component demonstrates fetching data from a weather api and displaying information and pictures dynamically.</p>\r\n\r\n\r\n\r\n");
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
#line 19 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                            GetDataAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
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
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 26 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"

    //The temperature symbol can be changed in the dropdown menu and then it changes the degrees to either celsius or farenheit

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "mb-2 p-3 col-sm-5");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "select");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                   GetDataAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                            tempSymbol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tempSymbol = __value, tempSymbol));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "selected", true);
            __builder.AddAttribute(49, "disabled", true);
            __builder.AddAttribute(50, "value", "-1");
            __builder.AddContent(51, " Select Degrees");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "option");
            __builder.AddAttribute(54, "value", "F");
            __builder.AddContent(55, "Fahrenheit");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", "C");
            __builder.AddContent(59, "Celsius");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.AddMarkupContent(63, "    <br>\r\n");
#nullable restore
#line 37 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
    //I added an if statement that checks if the state of the weather is a certain state then adds the suitable image of that state to the forecast cards
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
     foreach (var weatherForecast in data.consolidated_weather)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "      ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "id", "container");
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-md-5 col-sm-12 col-lg-6 mt-2 mb-2");
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "card");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "card-body");
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "h5");
            __builder.AddAttribute(78, "class", "card-title");
            __builder.AddContent(79, "Date: ");
            __builder.AddContent(80, 
#nullable restore
#line 44 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                  weatherForecast.applicable_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.OpenElement(82, "h6");
            __builder.AddAttribute(83, "class", "card-subtitle mb-2 text");
            __builder.AddContent(84, "Weather State: ");
            __builder.AddContent(85, 
#nullable restore
#line 45 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                        weatherForecast.weather_state_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "h6");
            __builder.AddAttribute(88, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(89, " ");
            __builder.AddContent(90, 
#nullable restore
#line 46 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                weatherLocation

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(91, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.AddMarkupContent(93, "<p class=\"card-text\"> </p>\r\n");
#nullable restore
#line 48 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                     if (weatherForecast.weather_state_name == "Light Rain")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(94, "                        ");
            __builder.AddMarkupContent(95, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-3.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 51 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (weatherForecast.weather_state_name == "Heavy Cloud")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "                        ");
            __builder.AddMarkupContent(97, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-2.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 55 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (weatherForecast.weather_state_name == "Heavy Rain")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "                        ");
            __builder.AddMarkupContent(99, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-3.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 59 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (weatherForecast.weather_state_name == "Showers")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                        ");
            __builder.AddMarkupContent(101, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-3.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 63 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (weatherForecast.weather_state_name == "Light Cloud")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                        ");
            __builder.AddMarkupContent(103, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-2.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 67 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (weatherForecast.weather_state_name == "Clear")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "                        ");
            __builder.AddMarkupContent(105, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-4.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 71 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "                        ");
            __builder.AddMarkupContent(107, "<p> <img class=\"resize\" src=\"https://icon-library.com/images/weather-icon-gif/weather-icon-gif-2.jpg\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 75 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(108, "                    <p></p>\r\n");
#nullable restore
#line 77 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                     if (tempSymbol == 'F')
                    {
                        var farenheit = (weatherForecast.the_temp * 9 / 5) +32;
                        Math.Floor(farenheit);

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, "                        ");
            __builder.OpenElement(110, "h4");
            __builder.AddAttribute(111, "class", "card-subtitle mb-2 text");
            __builder.AddContent(112, "Temperature: ");
            __builder.AddContent(113, 
#nullable restore
#line 81 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                          Math.Ceiling(farenheit)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(114, "° ");
            __builder.AddContent(115, 
#nullable restore
#line 81 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                                                    tempSymbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n");
#nullable restore
#line 82 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (tempSymbol == 'C')
                    {
                        var celsius = weatherForecast.the_temp;

#line default
#line hidden
#nullable disable
            __builder.AddContent(117, "                        ");
            __builder.OpenElement(118, "h4");
            __builder.AddAttribute(119, "class", "card-subtitle mb-2 text");
            __builder.AddContent(120, "Temperature: ");
            __builder.AddContent(121, 
#nullable restore
#line 86 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                          Math.Ceiling(celsius)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(122, "° ");
            __builder.AddContent(123, 
#nullable restore
#line 86 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                                                  tempSymbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 87 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "                    ");
            __builder.OpenElement(126, "h6");
            __builder.AddAttribute(127, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(128, "Wind Speed: ");
            __builder.AddContent(129, 
#nullable restore
#line 88 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                           weatherForecast.wind_speed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                    ");
            __builder.OpenElement(131, "h6");
            __builder.AddAttribute(132, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(133, "Humidity: ");
            __builder.AddContent(134, 
#nullable restore
#line 89 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                         weatherForecast.humidity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
#nullable restore
#line 94 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
       

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
                weatherLocation = "Dublin";
            }

            else if (key == "1118370")
            {
                weatherLocation = "Tokyo";
            }

            else if (key == "44418")
            {
                weatherLocation = "London";
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
