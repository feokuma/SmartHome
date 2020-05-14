using SmartHome.Enums;
using System.Collections.Generic;

namespace SmartHome.Models
{
    public class Ambient
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public string AmbientIcon { get; set; }

        public static Dictionary<AmbientIconsEnum, string> AmbientIconsDictionary = new Dictionary<AmbientIconsEnum, string>
        {
            {AmbientIconsEnum.MainBedroom, "bed_solid.png" },
            {AmbientIconsEnum.BathRoom, "bath.png" }
        };
    }
}
