using Q42.HueApi;
using Q42.HueApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilipsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Bridge();
        }
        public static async Task<bool> Bridge()
        {
            IBridgeLocator locator = new HttpBridgeLocator();

            //var  bridgeIPs = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));

            ILocalHueClient client = new LocalHueClient("192.168.20.106");
            client.Initialize("001788fffe7b215e");
            var lights = client.GetLightsAsync();//://blog.falafel.com/winiot-philips-hue-touchscreen-app/();// ("1");
           // v
            
            return true;
        }
    }
}
