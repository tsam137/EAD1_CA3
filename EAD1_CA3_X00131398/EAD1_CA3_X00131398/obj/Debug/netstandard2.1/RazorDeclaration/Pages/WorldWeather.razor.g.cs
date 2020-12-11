#pragma checksum "C:\Users\tobas\OneDrive\TUD T\EAD1\EAD1_CA3\EAD1_CA3_X00131398\EAD1_CA3_X00131398\Pages\WorldWeather.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6ec8bba4314d765c7bec991e5b8e3b29f0f0e4f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
