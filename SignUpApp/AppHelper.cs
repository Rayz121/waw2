using System.Configuration;

namespace SignUpApp
{
    public static class AppHelper
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["SignUpApp.Properties.Settings.DatabaseConnectionString"].ConnectionString;
    }
}
