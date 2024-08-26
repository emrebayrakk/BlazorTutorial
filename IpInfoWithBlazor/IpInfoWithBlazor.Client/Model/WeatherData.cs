namespace IpInfoWithBlazor.Client.Model
{
    using Newtonsoft.Json;

    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("tz_id")]
        public string TzId { get; set; }

        [JsonProperty("localtime_epoch")]
        public long LocaltimeEpoch { get; set; }

        [JsonProperty("localtime")]
        public string Localtime { get; set; }
    }

    public class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class Current
    {
        [JsonProperty("last_updated_epoch")]
        public long LastUpdatedEpoch { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("temp_c")]
        public double TempC { get; set; }

        [JsonProperty("temp_f")]
        public double TempF { get; set; }

        [JsonProperty("is_day")]
        public int IsDay { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("wind_mph")]
        public double WindMph { get; set; }

        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }

        [JsonProperty("wind_degree")]
        public int WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mb")]
        public double PressureMb { get; set; }

        [JsonProperty("pressure_in")]
        public double PressureIn { get; set; }

        [JsonProperty("precip_mm")]
        public double PrecipMm { get; set; }

        [JsonProperty("precip_in")]
        public double PrecipIn { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("cloud")]
        public int Cloud { get; set; }

        [JsonProperty("feelslike_c")]
        public double FeelslikeC { get; set; }

        [JsonProperty("feelslike_f")]
        public double FeelslikeF { get; set; }

        [JsonProperty("windchill_c")]
        public double WindchillC { get; set; }

        [JsonProperty("windchill_f")]
        public double WindchillF { get; set; }

        [JsonProperty("heatindex_c")]
        public double HeatindexC { get; set; }

        [JsonProperty("heatindex_f")]
        public double HeatindexF { get; set; }

        [JsonProperty("dewpoint_c")]
        public double DewpointC { get; set; }

        [JsonProperty("dewpoint_f")]
        public double DewpointF { get; set; }

        [JsonProperty("vis_km")]
        public double VisKm { get; set; }

        [JsonProperty("vis_miles")]
        public double VisMiles { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }

        [JsonProperty("gust_mph")]
        public double GustMph { get; set; }

        [JsonProperty("gust_kph")]
        public double GustKph { get; set; }
    }

    public class WeatherData
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("current")]
        public Current Current { get; set; }
    }


    public static class WeatherConditions
    {
        public static List<WeatherCondition> Conditions { get; } = new List<WeatherCondition>
    {
        new WeatherCondition { Code = 1000, Day = "Sunny", Night = "Clear", Icon = 113 },
        new WeatherCondition { Code = 1003, Day = "Partly cloudy", Night = "Partly cloudy", Icon = 116 },
        new WeatherCondition { Code = 1006, Day = "Cloudy", Night = "Cloudy", Icon = 119 },
        new WeatherCondition { Code = 1009, Day = "Overcast", Night = "Overcast", Icon = 122 },
        new WeatherCondition { Code = 1030, Day = "Mist", Night = "Mist", Icon = 143 },
        new WeatherCondition { Code = 1063, Day = "Patchy rain possible", Night = "Patchy rain possible", Icon = 176 },
        new WeatherCondition { Code = 1066, Day = "Patchy snow possible", Night = "Patchy snow possible", Icon = 179 },
        new WeatherCondition { Code = 1069, Day = "Patchy sleet possible", Night = "Patchy sleet possible", Icon = 182 },
        new WeatherCondition { Code = 1072, Day = "Patchy freezing drizzle possible", Night = "Patchy freezing drizzle possible", Icon = 185 },
        new WeatherCondition { Code = 1087, Day = "Thundery outbreaks possible", Night = "Thundery outbreaks possible", Icon = 200 },
        new WeatherCondition { Code = 1114, Day = "Blowing snow", Night = "Blowing snow", Icon = 227 },
        new WeatherCondition { Code = 1117, Day = "Blizzard", Night = "Blizzard", Icon = 230 },
        new WeatherCondition { Code = 1135, Day = "Fog", Night = "Fog", Icon = 248 },
        new WeatherCondition { Code = 1147, Day = "Freezing fog", Night = "Freezing fog", Icon = 260 },
        new WeatherCondition { Code = 1150, Day = "Patchy light drizzle", Night = "Patchy light drizzle", Icon = 263 },
        new WeatherCondition { Code = 1153, Day = "Light drizzle", Night = "Light drizzle", Icon = 266 },
        new WeatherCondition { Code = 1168, Day = "Freezing drizzle", Night = "Freezing drizzle", Icon = 281 },
        new WeatherCondition { Code = 1171, Day = "Heavy freezing drizzle", Night = "Heavy freezing drizzle", Icon = 284 },
        new WeatherCondition { Code = 1180, Day = "Patchy light rain", Night = "Patchy light rain", Icon = 293 },
        new WeatherCondition { Code = 1183, Day = "Light rain", Night = "Light rain", Icon = 296 },
        new WeatherCondition { Code = 1186, Day = "Moderate rain at times", Night = "Moderate rain at times", Icon = 299 },
        new WeatherCondition { Code = 1189, Day = "Moderate rain", Night = "Moderate rain", Icon = 302 },
        new WeatherCondition { Code = 1192, Day = "Heavy rain at times", Night = "Heavy rain at times", Icon = 305 },
        new WeatherCondition { Code = 1195, Day = "Heavy rain", Night = "Heavy rain", Icon = 308 },
        new WeatherCondition { Code = 1198, Day = "Light freezing rain", Night = "Light freezing rain", Icon = 311 },
        new WeatherCondition { Code = 1201, Day = "Moderate or heavy freezing rain", Night = "Moderate or heavy freezing rain", Icon = 314 },
        new WeatherCondition { Code = 1204, Day = "Light sleet", Night = "Light sleet", Icon = 317 },
        new WeatherCondition { Code = 1207, Day = "Moderate or heavy sleet", Night = "Moderate or heavy sleet", Icon = 320 },
        new WeatherCondition { Code = 1210, Day = "Patchy light snow", Night = "Patchy light snow", Icon = 323 },
        new WeatherCondition { Code = 1213, Day = "Light snow", Night = "Light snow", Icon = 326 },
        new WeatherCondition { Code = 1216, Day = "Patchy moderate snow", Night = "Patchy moderate snow", Icon = 329 },
        new WeatherCondition { Code = 1219, Day = "Moderate snow", Night = "Moderate snow", Icon = 332 },
        new WeatherCondition { Code = 1222, Day = "Patchy heavy snow", Night = "Patchy heavy snow", Icon = 335 },
        new WeatherCondition { Code = 1225, Day = "Heavy snow", Night = "Heavy snow", Icon = 338 },
        new WeatherCondition { Code = 1237, Day = "Ice pellets", Night = "Ice pellets", Icon = 350 },
        new WeatherCondition { Code = 1240, Day = "Light rain shower", Night = "Light rain shower", Icon = 353 },
        new WeatherCondition { Code = 1243, Day = "Moderate or heavy rain shower", Night = "Moderate or heavy rain shower", Icon = 356 },
        new WeatherCondition { Code = 1246, Day = "Torrential rain shower", Night = "Torrential rain shower", Icon = 359 },
        new WeatherCondition { Code = 1249, Day = "Light sleet showers", Night = "Light sleet showers", Icon = 362 },
        new WeatherCondition { Code = 1252, Day = "Moderate or heavy sleet showers", Night = "Moderate or heavy sleet showers", Icon = 365 },
        new WeatherCondition { Code = 1255, Day = "Light snow showers", Night = "Light snow showers", Icon = 368 },
        new WeatherCondition { Code = 1258, Day = "Moderate or heavy snow showers", Night = "Moderate or heavy snow showers", Icon = 371 },
        new WeatherCondition { Code = 1261, Day = "Light showers of ice pellets", Night = "Light showers of ice pellets", Icon = 374 },
        new WeatherCondition { Code = 1264, Day = "Moderate or heavy showers of ice pellets", Night = "Moderate or heavy showers of ice pellets", Icon = 377 },
        new WeatherCondition { Code = 1273, Day = "Patchy light rain with thunder", Night = "Patchy light rain with thunder", Icon = 386 },
        new WeatherCondition { Code = 1276, Day = "Moderate or heavy rain with thunder", Night = "Moderate or heavy rain with thunder", Icon = 389 },
        new WeatherCondition { Code = 1279, Day = "Patchy light snow with thunder", Night = "Patchy light snow with thunder", Icon = 392 },
        new WeatherCondition { Code = 1282, Day = "Moderate or heavy snow with thunder", Night = "Moderate or heavy snow with thunder", Icon = 395 }
    };
    }

    public class WeatherCondition
    {
        public int Code { get; set; }
        public string Day { get; set; }
        public string Night { get; set; }
        public int Icon { get; set; }
    }
}
