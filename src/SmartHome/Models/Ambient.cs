using System.Collections.Generic;
using System.Net.NetworkInformation;
using SmartHome;
using Xamarin.Forms;

namespace SmartHome.Models
{
    public class Ambient
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public string AmbientIcon { get; set; }
        public string AmbientImage { get; set; }

        public static Dictionary<AmbientEnum, string> AmbientIconsDictionary = new Dictionary<AmbientEnum, string>
        {
            {AmbientEnum.MainBedroom, "bed_solid.png" },
            {AmbientEnum.BathRoom, "bath_solid.png" },
        };

        public static Dictionary<AmbientEnum, string> AmbientImageDictionary = new Dictionary<AmbientEnum, string>
        {
            {AmbientEnum.MainBedroom, "MainBedroom" },
            {AmbientEnum.BathRoom, "Bathroom" },
            {AmbientEnum.LivingRoom, "LivingRoom" },
            {AmbientEnum.Kitchen, "Kitchen" },
            {AmbientEnum.Garage, "Garage" }
        };
    }

    public enum AmbientEnum
    {
        MainBedroom,
        BathRoom,
        LivingRoom,
        Garage,
        Kitchen
    }
}
