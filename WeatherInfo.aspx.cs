using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeatherForecastApplication
{
    public partial class WeatherInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetWeatherInfo(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client();
            string json = svc.FetchWeatherInfo();
            lblDescription.Text = json;           
            tblWeather.Visible = true;
        }
    }
}