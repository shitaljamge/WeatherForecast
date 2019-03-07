using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WeatherWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string FetchWeatherInfo()
        {
            string json = string.Empty;            
            //string key = string.Format("http://dataservice.accuweather.com/locations/v1/adminareas/{countryCode}", "IN");
            //string bycityname = "http://dataservice.accuweather.com/locations/v1/cities/search/q=mumbai?apikey=XiKvqHdri5kdbZ2Z73ZRtK9fuO1o4jyD";
            //string accuUrl = "http://dataservice.accuweather.com/locations/v1/adminareas/in?apikey=XiKvqHdri5kdbZ2Z73ZRtK9fuO1o4jyD";

            string accuUrl = "http://dataservice.accuweather.com/forecasts/v1/daily/1day/49785?apikey=XiKvqHdri5kdbZ2Z73ZRtK9fuO1o4jyD";
            
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(accuUrl);


                //json = Encoding.UTF8.GetString(bycityname);
            }

            return json;

        }
       
    }
}
