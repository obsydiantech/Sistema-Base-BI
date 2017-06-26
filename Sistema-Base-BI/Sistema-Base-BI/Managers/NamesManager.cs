using System;
using System.IO;

namespace Sistema_Base_BI.Managers
{
    public class NamesManager // Singleton
    {
        // |---------------Atributos---------------|
        private static NamesManager instance;
        public static NamesManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new NamesManager();

                return instance;
            }
        }

        public const String SYSTEM_NAME = "Sistema Base";
        public const String SYSTEM_ROOT_FOLDER = @"C:\Program Files (x86)\" + SYSTEM_NAME + @"\";
        public const String ERROR_LOGS_FILEPATH = SYSTEM_ROOT_FOLDER + "error_logs.txt";
        public const String CONFIG_FILEPATH = SYSTEM_ROOT_FOLDER + "config.txt";
        public String DESKTOP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // |---------------Constructores---------------|
        private NamesManager()
        {

        }

        // |---------------Métodos Públicos---------------|
        public void Init()
        {
            if (!Directory.Exists(SYSTEM_ROOT_FOLDER))
                CreateDirectoriesAndFiles();
        }

        // |---------------Métodos Privados---------------|
        private void CreateDirectoriesAndFiles()
        {
            CreateRootDirectory();

            CreateErrorLogsFile();

            CreateConfigFile();
        }

        private void CreateRootDirectory()
        {
            Directory.CreateDirectory(SYSTEM_ROOT_FOLDER);
        }

        private void CreateErrorLogsFile()
        {
            File.Create(ERROR_LOGS_FILEPATH);
        }

        private void CreateConfigFile()
        {
            File.Create(CONFIG_FILEPATH);
        }
    }
}