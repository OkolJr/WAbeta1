﻿using System.Text;
using WAbeta.Server.DTOs;
using WAbeta.Server.Interfaces;

namespace WAbeta.Server.Services
{
    public class UrlBuilderService : IUrlBuilderInterface
    {
        public string GetGeocodeUrl(OpenWeather openWeather, string city, int? stateCode, int? countryCode)
        {
            // Use stringbuilder to build url for geocode
            StringBuilder geocode = new StringBuilder();
            string geocodeUrl = geocode.Append(openWeather.Site + openWeather.GeoResponseType + openWeather.GeoVersion)
                              .Append(openWeather.GeolocationTemplate.Replace("cityname", city)
                              .Replace(",statecode", stateCode.HasValue ? stateCode.Value.ToString() : "")
                              .Replace(",countrycode", countryCode.HasValue ? countryCode.Value.ToString() : "")
                              .Replace("APIKey", openWeather.Key)).ToString();
            return geocodeUrl;
        }

        public string GetWeatherUrl(string template, GeoCodeDto geoCode, OpenWeather openWeather)
        {
            StringBuilder weatherUrl = new StringBuilder();
            string currentUrl = weatherUrl.Append(openWeather.Site + openWeather.WeatherResponseType + openWeather.WeatherVersion)
                             .Append(template.Replace("=lat", "=" + geoCode.Lat)
                             .Replace("=lon", "=" + geoCode.Lon).Replace("APIKey", openWeather.Key)).ToString();
            return currentUrl;
        }
    }
}
