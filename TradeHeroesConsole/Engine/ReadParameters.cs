using System;
using System.Reflection;
using System.Resources;

namespace TradeHeroesConsole.Engine
{
    public class ReadParameters
    {
        private String _langage = "";

        #region Accesseur
        public String Language
        {
            get => _langage;
            set => _langage = value;
        }
        #endregion

        public ReadParameters()
        {
        }

        internal String LoadLanguage()
        {
            // Create a resource manager to retrieve resources.
            ResourceManager rm = new ResourceManager("items", Assembly.GetExecutingAssembly());

            // Retrieve the value of the string resource named "welcome".
            // The resource manager will retrieve the value of the  
            // localized resource using the caller's current culture setting.
            String str = rm.GetString("version");

            Console.WriteLine(str);

            return Language;
        }
    }
}
