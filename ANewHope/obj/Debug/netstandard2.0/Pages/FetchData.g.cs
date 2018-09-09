#pragma checksum "C:\Projects\Blazor App\ANewHope\Pages\FetchData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed0073fdabfb5970342294d8d16959da577f0bc"
// <auto-generated/>
#pragma warning disable 1591
namespace ANewHope.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using ANewHope;
    using ANewHope.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
#line 4 "C:\Projects\Blazor App\ANewHope\Pages\FetchData.cshtml"
 if (weatherLoaded)
{

#line default
#line hidden
            builder.AddContent(0, "    ");
            builder.OpenElement(1, "h1");
            builder.AddContent(2, "\n        ");
            builder.AddContent(3, ziplookup.places[0].city);
            builder.AddContent(4, ", ");
            builder.AddContent(5, ziplookup.places[0].stateabbr);
            builder.OpenElement(6, "br");
            builder.CloseElement();
            builder.AddContent(7, "\n        ");
            builder.AddContent(8, ConvertKtoF(currentcondition.main.temp, 1));
            builder.AddContent(9, " °F\n    ");
            builder.CloseElement();
            builder.AddContent(10, "\n    ");
            builder.OpenElement(11, "h2");
            builder.AddContent(12, "\n        ");
            builder.AddContent(13, currentcondition.weather[0].main);
            builder.AddContent(14, " ");
            builder.OpenElement(15, "img");
            builder.AddAttribute(16, "style", "display:inline");
            builder.AddAttribute(17, "src", imgurl);
            builder.CloseElement();
            builder.AddContent(18, "\n    ");
            builder.CloseElement();
            builder.AddContent(19, "\n    ");
            builder.OpenElement(20, "h3");
            builder.AddContent(21, "\n        ");
            builder.OpenElement(22, "span");
            builder.AddAttribute(23, "style", "display:inline;color:red");
            builder.AddContent(24, "HI ");
            builder.AddContent(25, ConvertKtoF(currentcondition.main.temp_max, 0));
            builder.AddContent(26, "  °F");
            builder.CloseElement();
            builder.AddContent(27, " /\n        ");
            builder.OpenElement(28, "span");
            builder.AddAttribute(29, "style", "color:blue");
            builder.AddContent(30, "LO ");
            builder.AddContent(31, ConvertKtoF(currentcondition.main.temp_min, 0));
            builder.AddContent(32, "  °F");
            builder.CloseElement();
            builder.OpenElement(33, "br");
            builder.CloseElement();
            builder.AddContent(34, "\n    ");
            builder.CloseElement();
            builder.AddContent(35, "\n    ");
            builder.OpenElement(36, "br");
            builder.CloseElement();
            builder.AddContent(37, "\n");
#line 18 "C:\Projects\Blazor App\ANewHope\Pages\FetchData.cshtml"
     if (alerts.features.Length > 0)
    {

#line default
#line hidden
            builder.AddContent(38, "        ");
            builder.OpenElement(39, "h2");
            builder.AddContent(40, "Alerts");
            builder.CloseElement();
            builder.AddContent(41, "\n        ");
            builder.OpenElement(42, "table");
            builder.AddAttribute(43, "class", "table");
            builder.AddContent(44, "\n            ");
            builder.OpenElement(45, "thead");
            builder.AddContent(46, "\n                ");
            builder.OpenElement(47, "tr");
            builder.AddContent(48, "\n                    ");
            builder.OpenElement(49, "th");
            builder.AddContent(50, "Date");
            builder.CloseElement();
            builder.AddContent(51, "\n                    ");
            builder.OpenElement(52, "th");
            builder.AddContent(53, "Alert");
            builder.CloseElement();
            builder.AddContent(54, "\n                ");
            builder.CloseElement();
            builder.AddContent(55, "\n            ");
            builder.CloseElement();
            builder.AddContent(56, "\n            ");
            builder.OpenElement(57, "tbody");
            builder.AddContent(58, "\n");
#line 29 "C:\Projects\Blazor App\ANewHope\Pages\FetchData.cshtml"
                 foreach (var alert in alerts.features)
                {

#line default
#line hidden
            builder.AddContent(59, "                    ");
            builder.OpenElement(60, "tr");
            builder.AddContent(61, "\n                        ");
            builder.OpenElement(62, "td");
            builder.AddContent(63, alert.properties.effective.ToString("MM/dd/yyyy hh:mmt"));
            builder.CloseElement();
            builder.AddContent(64, "\n                        ");
            builder.OpenElement(65, "td");
            builder.AddContent(66, "\n                            ");
            builder.OpenElement(67, "span");
            builder.AddAttribute(68, "style", "font-weight:600");
            builder.AddContent(69, alert.properties.headline);
            builder.CloseElement();
            builder.OpenElement(70, "br");
            builder.CloseElement();
            builder.AddContent(71, "\n                            ");
            builder.OpenElement(72, "span");
            builder.AddContent(73, alert.properties.description);
            builder.CloseElement();
            builder.AddContent(74, "\n                        ");
            builder.CloseElement();
            builder.AddContent(75, "\n                    ");
            builder.CloseElement();
            builder.AddContent(76, "\n");
#line 38 "C:\Projects\Blazor App\ANewHope\Pages\FetchData.cshtml"
                }

#line default
#line hidden
            builder.AddContent(77, "            ");
            builder.CloseElement();
            builder.AddContent(78, "\n        ");
            builder.CloseElement();
            builder.AddContent(79, "\n");
#line 41 "C:\Projects\Blazor App\ANewHope\Pages\FetchData.cshtml"
    }

#line default
#line hidden
#line 41 "C:\Projects\Blazor App\ANewHope\Pages\FetchData.cshtml"
     
}
else
{

#line default
#line hidden
            builder.AddContent(80, "    ");
            builder.OpenElement(81, "h1");
            builder.AddContent(82, "Weather Forecast");
            builder.CloseElement();
            builder.AddContent(83, "\n    ");
            builder.OpenElement(84, "div");
            builder.AddAttribute(85, "class", "input-group col-md-3");
            builder.AddContent(86, "\n        ");
            builder.OpenElement(87, "input");
            builder.AddAttribute(88, "type", "text");
            builder.AddAttribute(89, "class", "form-control");
            builder.AddAttribute(90, "placeholder", "Zip code");
            builder.AddAttribute(91, "maxlength", "5");
            builder.AddAttribute(92, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(zip));
            builder.AddAttribute(93, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => zip = __value, zip));
            builder.CloseElement();
            builder.AddContent(94, "\n        ");
            builder.OpenElement(95, "div");
            builder.AddAttribute(96, "class", "input-group-append");
            builder.AddContent(97, "\n            ");
            builder.OpenElement(98, "button");
            builder.AddAttribute(99, "class", "btn btn-secondary");
            builder.AddAttribute(100, "type", "button");
            builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(GetWeather));
            builder.AddContent(102, "Get Weather");
            builder.CloseElement();
            builder.AddContent(103, "\n        ");
            builder.CloseElement();
            builder.AddContent(104, "\n    ");
            builder.CloseElement();
            builder.AddContent(105, "\n    ");
            builder.OpenElement(106, "br");
            builder.CloseElement();
            builder.OpenElement(107, "span");
            builder.AddAttribute(108, "style", "color:red");
            builder.AddContent(109, errorMessage);
            builder.CloseElement();
            builder.AddContent(110, "\n");
#line 53 "C:\Projects\Blazor App\ANewHope\Pages\FetchData.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 55 "C:\Projects\Blazor App\ANewHope\Pages\FetchData.cshtml"
            
    String zip = String.Empty;
    String errorMessage = String.Empty;
    Models.CurrentConditions currentcondition;
    Models.Alert alerts;
    Models.ZipLookup ziplookup;
    String imgurl = "";
    bool weatherLoaded = false;

    private async Task GetWeather()
    {
        Http.DefaultRequestHeaders.Add("Accept", "application/vnd.noaa.dwml+json;version=1");
        Http.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36");

        // get location info from zip
        try
        {
            errorMessage = "";
            var zipresultStr = await Http.GetStringAsync($"http://api.zippopotam.us/US/{zip}");
            zipresultStr = zipresultStr.Replace("place name", "city").Replace("state abbreviation", "stateabbr");
            ziplookup = JsonUtil.Deserialize<Models.ZipLookup>(zipresultStr);
        }
        catch
        {
            errorMessage = "Invalid zip code";
            return;
        }

        // get current condition by zip
        currentcondition = await Http.GetJsonAsync<Models.CurrentConditions>($"http://api.openweathermap.org/data/2.5/weather?zip={zip},us&appid=93f0b74104f16e4f15a144056218b830");
        imgurl = $"http://openweathermap.org/img/w/{currentcondition.weather[0].icon}.png";

        // retrieve nws alerts for state
        alerts = await Http.GetJsonAsync<Models.Alert>($"https://api.weather.gov/alerts/active/area/{ziplookup.places[0].stateabbr}");

        weatherLoaded = true;
    }

    private decimal ConvertKtoF(decimal kelvin, int decimals)
    {
        return Math.Round(kelvin * 9 / 5 - 459.67M, decimals);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
