#pragma checksum "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6ec8bba4314d765c7bec991e5b8e3b29f0f0e4f"
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
            __builder.AddMarkupContent(37, "    <br>\r\n");
#nullable restore
#line 31 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
     foreach (var weatherForecast in data.consolidated_weather)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-md-5 col-sm-12 col-lg-6 mt-2 mb-2 display:flex;");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "card");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "card-body");
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "h5");
            __builder.AddAttribute(49, "class", "card-title");
            __builder.AddContent(50, "Date: ");
            __builder.AddContent(51, 
#nullable restore
#line 36 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                  weatherForecast.applicable_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "h6");
            __builder.AddAttribute(54, "class", "card-subtitle mb-2 text");
            __builder.AddContent(55, "Weather State: ");
            __builder.AddContent(56, 
#nullable restore
#line 37 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                        weatherForecast.weather_state_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "h6");
            __builder.AddAttribute(59, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(60, " ");
            __builder.AddContent(61, 
#nullable restore
#line 38 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                weatherLocation

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.AddMarkupContent(64, "<p class=\"card-text\"> </p>\r\n");
#nullable restore
#line 40 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                     if (weatherForecast.weather_state_name == "Light Rain")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "                        ");
            __builder.AddMarkupContent(66, "<p> <img class=\"resize\" src=\"https://ssl.gstatic.com/onebox/weather/64/rain_s_cloudy.png\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 43 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (weatherForecast.weather_state_name == "Heavy Cloud")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                        ");
            __builder.AddMarkupContent(68, "<p> <img class=\"resize\" src=\"https://ssl.gstatic.com/onebox/weather/64/cloudy.png\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 47 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (weatherForecast.weather_state_name == "Heavy Rain")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                        ");
            __builder.AddMarkupContent(70, "<p> <img class=\"resize\" src=\"https://ssl.gstatic.com/onebox/weather/64/rain.png\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 51 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (weatherForecast.weather_state_name == "Showers")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "                        ");
            __builder.AddMarkupContent(72, "<p> <img class=\"resize\" src=\"https://ssl.gstatic.com/onebox/weather/64/rain_light.png\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 55 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (weatherForecast.weather_state_name == "Light Cloud")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                        ");
            __builder.AddMarkupContent(74, "<p> <img class=\"resize\" src=\"https://ssl.gstatic.com/onebox/weather/64/partly_cloudy.png\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 59 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else if (weatherForecast.weather_state_name == "Clear")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                        ");
            __builder.AddMarkupContent(76, "<p> <img class=\"resize\" src=\"https://ssl.gstatic.com/onebox/weather/64/sunny.png\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 63 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "                        ");
            __builder.AddMarkupContent(78, "<p> <img class=\"resize\" src=\"https://ssl.gstatic.com/onebox/weather/64/partly_cloudy.png\" style=\"width:175px; height:175px;\"> </p>\r\n");
#nullable restore
#line 67 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                    ");
            __builder.OpenElement(80, "h4");
            __builder.AddAttribute(81, "class", "card-subtitle mb-2 text");
            __builder.AddContent(82, "Temperature: ");
            __builder.AddContent(83, 
#nullable restore
#line 68 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                      weatherForecast.the_temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(84, "° ");
            __builder.AddContent(85, 
#nullable restore
#line 68 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                                                 weatherForecast.tempSymbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "h6");
            __builder.AddAttribute(88, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(89, "Wind Speed: ");
            __builder.AddContent(90, 
#nullable restore
#line 69 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                           weatherForecast.wind_speed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.OpenElement(92, "h6");
            __builder.AddAttribute(93, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(94, "Humidity: ");
            __builder.AddContent(95, 
#nullable restore
#line 70 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                                         weatherForecast.humidity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.OpenElement(97, "button");
            __builder.AddAttribute(98, "class", "btn btn-primary");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                              ConvertFahrenheit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, "Convert to Fahrenheit");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "class", "btn btn-primary");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
                                                              ConvertCelsius

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(105, "Convert to Celsius");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 76 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor"
       

    private WeatherData data;
    private Consolidated_Weather conWeather;
    private string key = "560743";
    string weatherLocation = "Dublin";
    private string errormessage;
    string uri = "https://meta-weather.now.sh/api/location/";


    private void ConvertFahrenheit()
    {
        conWeather.the_temp = ((conWeather.the_temp  * 9 / 5) + 32);
        conWeather.tempSymbol = 'F';
    }

    private void ConvertCelsius()
    {
        if (conWeather.tempSymbol == 'F')
        {
            conWeather.the_temp = ((conWeather.the_temp - 32) * 5 / 9);
            conWeather.tempSymbol = 'C';
        }
        else
        {
            conWeather.the_temp = conWeather.the_temp;
        }
    }

    // https://meta-weather.now.sh/api/location/560743
    private async Task GetDataAsync()
    {

        try
        {
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

        public char tempSymbol = 'C';

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
