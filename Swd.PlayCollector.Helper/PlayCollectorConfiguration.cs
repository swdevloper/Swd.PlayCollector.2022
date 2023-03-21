using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.PlayCollector.Helper
{
    public class PlayCollectorConfiguration
    {
        public string PathToMediaFiles { get; set; }
        public string PathToRessourceFiles { get; set; }
        public string PathToPlaceholderImage { get; set; }


        public PlayCollectorConfiguration()
        {

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json",optional: true, reloadOnChange: true)
                //.AddEnvironmentVariables()
                .Build();

            PathToMediaFiles = configuration.GetValue<string>("PathSettings:PATH_RootMediafiles").ToString();
            PathToRessourceFiles = 
                string.Format("{0}\\{1}",Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), 
                configuration.GetValue<string>("PathSettings:PATH_RootRessourceImages").ToString());
            PathToPlaceholderImage = 
                string.Format("{0}\\{1}", PathToRessourceFiles,
                configuration.GetValue<string>("PathSettings:FILE_PlaceholderImage").ToString());

        }

    }
}
