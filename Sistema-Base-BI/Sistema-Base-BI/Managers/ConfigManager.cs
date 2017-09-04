using System;
using System.Drawing;
using System.Resources;

namespace Sistema_Base_BI.Managers
{
    public class ConfigManager
    {
        // |---------------Atributos---------------|
        private static ConfigManager instance;
        public static ConfigManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConfigManager();

                return instance;
            }
        }
        private ResourceManager resourceManager;

        // |---------------Constructores---------------|
        private ConfigManager()
        {

        }

        // |---------------Métodos Públicos---------------|
        public Boolean Init()
        {
            resourceManager = new ResourceManager("Sistema_Base_BI.Properties.Resources", GetType().Assembly);
            return true;
        }

        public void SetColorPrimario(Color color)
        {
            Properties.Settings.Default["COLOR_PRIMARIO"] = color.Name;
            Properties.Settings.Default.Save();
        }

        public Color GetColorPrimario()
        {
            return Color.FromName(Properties.Settings.Default.COLOR_PRIMARIO);
        }

        public String GetApplicationVersion()
        {
            return resourceManager.GetString("VERSION");
            
        }



        // |---------------Métodos Privados---------------|

        // |-------------------Eventos--------------------|
    }
}
