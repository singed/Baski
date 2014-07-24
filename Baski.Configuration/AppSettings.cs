using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baski.Configuration
{
    public class AppSettings : AppSettingsBase
    {
        public static string ArticlesImagesPath
        {
            get { return GetSettingValue("ArticlesImagesPath"); }
        }

        public static string PlayersImagesPath
        {
            get { return GetSettingValue("PlayersImagesPath"); }
        }

        public static string SidebarWidgetId
        {
            get { return GetSettingValue("SidebarWidgetId"); }
        }
    }
}
