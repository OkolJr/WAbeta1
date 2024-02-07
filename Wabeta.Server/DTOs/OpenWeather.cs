﻿namespace WAbeta.Server.DTOs
{
    public class OpenWeather
    {
        public string Site { get; set; } = string.Empty;
        public string GeoVersion { get; set; } = string.Empty;
        public string WeatherVersion { get; set; } = string.Empty;
        public string GeoResponseType { get; set; } = string.Empty;
        public string WeatherResponseType { get; set; } = string.Empty;
        public string CurrentWeatherTemplate { get; set; } = string.Empty;
        public string FiveDaysForecastTemplate { get; set; } = string.Empty;
        public string GeolocationTemplate { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
    }
}
