using System;
using System.Configuration;
using System.Web.UI;

namespace CF.Presentation.Web
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string configName = ConfigurationManager.AppSettings["configName"];
            lblConfig.Text = "Config: " + configName;
        }
    }
}